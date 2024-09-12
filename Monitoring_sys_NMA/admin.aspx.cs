using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Monitoring_sys_NMA
{
    public partial class admin : System.Web.UI.Page
    {
        string connection = ConfigurationManager.ConnectionStrings["nma"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                get_school();
                roles();
                gridData();
            }
        }

        private void roles()
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select* from [dbo].[user_role]", con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                DropDownList1.DataSource = dt;
                DropDownList1.DataTextField = "role";
                DropDownList1.DataValueField = "role";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, new ListItem("--Select--", "0"));
                DropDownList1.Items[0].Selected = true;
                DropDownList1.Items[0].Attributes["disabled"] = "Disabled";

            }
        }

        protected void get_school()
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select* from [dbo].[school]", con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                DropDownList2.DataSource = dt;
                DropDownList2.DataTextField = "school_name";
                DropDownList2.DataValueField = "school_name";
                DropDownList2.DataBind();
                DropDownList2.Items.Insert(0, new ListItem("--Select--", "0"));
                DropDownList2.Items[0].Selected = true;
                DropDownList2.Items[0].Attributes["disabled"] = "Disabled";

            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {


        }

        private void saveloginData()
        {
            string role = DropDownList1.SelectedValue.ToString(), school = DropDownList2.SelectedValue.ToString();
            string email = TextBox1.Text, password = TextBox2.Text;
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {


                    con.Open();
                    SqlCommand cmd = new SqlCommand(" select * from [dbo].[Users] where email='" + email + "'", con);
                    DataTable users = new DataTable();
                    SqlDataAdapter sdausers = new SqlDataAdapter(cmd);
                    sdausers.Fill(users);
                    if (users.Rows.Count >= 1)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Already Exist');", true);
                        DropDownList1.SelectedValue = "0";
                        DropDownList2.SelectedValue = "0";
                        TextBox1.Text = "";
                        TextBox2.Text = "";
                    }
                    else
                    {
                        using (SqlConnection conn = new SqlConnection(connection))
                        {
                            string query = "INSERT INTO [dbo].[Users] VALUES (@school,@role,@email,@pass)";
                            using (SqlCommand cd = new SqlCommand(query))
                            {
                                cd.Connection = con;
                                cd.Parameters.AddWithValue("@school", school);
                                cd.Parameters.AddWithValue("@role", role);
                                cd.Parameters.AddWithValue("@email", email);
                                cd.Parameters.AddWithValue("@pass", password);

                                conn.Open();
                                cd.ExecuteNonQuery();
                                conn.Close();
                                Response.Write("<script>alert('Your File and Data Saved Sucessfully');</script>");
                            }

                            TextBox1.Text = "";
                            TextBox2.Text = "";
                            DropDownList1.SelectedValue = "0";
                            DropDownList2.SelectedValue = "0";
                            gridData();

                        }

                    }

                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }

        }

        private void gridData()
        {
            using (SqlConnection con = new SqlConnection(connection))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("select * from [dbo].[Users]", con);
                DataTable gridtabel = new DataTable();
                SqlDataAdapter gridgataadapter = new SqlDataAdapter(cmd);
                gridgataadapter.Fill(gridtabel);
                GridView1.DataSource = gridtabel;
                GridView1.DataBind();
                con.Close();


            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            using (SqlConnection con = new SqlConnection(connection))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("delete [dbo].[Users] where id='" + id + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                gridData();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                string search = TextBox3.Text;
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from [dbo].[Users] where userRole like '%'+@mail+'%' ", con);
                cmd.Parameters.AddWithValue("@mail", search);
                DataTable searchdt = new DataTable();
                SqlDataAdapter searchsda = new SqlDataAdapter(cmd);
                searchsda.Fill(searchdt);
                GridView1.DataSource = searchdt;
                GridView1.DataBind();
                con.Close();
                TextBox3.Text = "";

            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            saveloginData();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            save_school();
        }

        private void save_school()
        {
               string school = TextBox5.Text.ToUpper().Trim();
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(" select * from [dbo].[school] where school_name='" + school + "'", con);
                    DataTable users = new DataTable();
                    SqlDataAdapter sdausers = new SqlDataAdapter(cmd);
                    sdausers.Fill(users);
                    if (users.Rows.Count >= 1)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Already Exist');", true);
                        TextBox5.Text = "";
                    }
                    else
                    {
                        using (SqlConnection conn = new SqlConnection(connection))
                        {
                            string query = "INSERT INTO [dbo].[school] VALUES (@school)";
                            using (SqlCommand cds = new SqlCommand(query))
                            {
                                cds.Connection = con;
                                cds.Parameters.AddWithValue("@school", school);
                                conn.Open();
                                cds.ExecuteNonQuery();
                                conn.Close();
                                Response.Write("<script>alert('Data Saved Sucessfully');</script>");
                            }
                            TextBox5.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}