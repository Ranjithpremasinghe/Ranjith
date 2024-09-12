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
    public partial class commandant_approval : System.Web.UI.Page
    {
        string connection = ConfigurationManager.ConnectionStrings["nma"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                school();
            }
        }
        private void school()
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select* from [dbo].[school]", con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                DropDownList1.DataSource = dt;
                DropDownList1.DataTextField = "school_name";
                DropDownList1.DataValueField = "school_name";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, new ListItem("--Select--", "0"));
                DropDownList1.Items[0].Selected = true;
                DropDownList1.Items[0].Attributes["disabled"] = "Disabled";

            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select* from [dbo].[daily_schedule] where school_id='" + DropDownList1.SelectedItem.Value.ToString() + "' ", con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                DropDownList2.DataSource = dt;
                DropDownList2.DataTextField = "course";
                DropDownList2.DataValueField = "course";
                DropDownList2.DataBind();
                DropDownList2.Items.Insert(0, new ListItem("--Select--", "0"));
                DropDownList2.Items[0].Selected = true;
                DropDownList2.Items[0].Attributes["disabled"] = "Disabled";

            }
            griddata();
            griddeviation();
            grid_extra_activity();
            grid_default_1();
            grid_default_2();
            grid_working_party1();
            grid_working_party2();
        }

        private void griddata()
        {

            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from [dbo].[daily_schedule] where tc='1' and  course='" + DropDownList2.SelectedItem.Value.ToString() + "'", con);
                DataTable filedt = new DataTable();
                SqlDataAdapter filesda = new SqlDataAdapter(cmd);
                filesda.Fill(filedt);
                GridView1.DataSource = filedt;
                GridView1.DataBind();
                con.Close();
            }
        }

        private void griddeviation()
        {

            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from [dbo].[subject_deviation] where tc='1' and  course='" + DropDownList2.SelectedItem.Value.ToString() + "'", con);
                DataTable filedt = new DataTable();
                SqlDataAdapter filesda = new SqlDataAdapter(cmd);
                filesda.Fill(filedt);
                GridView2.DataSource = filedt;
                GridView2.DataBind();
                con.Close();
            }
        }

        private void grid_extra_activity()
        {


            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from [dbo].[extra_activity] where tc='1' and course='" + DropDownList2.SelectedItem.Value.ToString() + "'", con);
                DataTable filedt = new DataTable();
                SqlDataAdapter filesda = new SqlDataAdapter(cmd);
                filesda.Fill(filedt);
                GridView3.DataSource = filedt;
                GridView3.DataBind();
                con.Close();
            }
        }

        private void grid_default_1()
        {

            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from [dbo].[defaulters_1] where tc='1' and course='" + DropDownList2.SelectedItem.Value.ToString() + "'", con);
                DataTable filedt = new DataTable();
                SqlDataAdapter filesda = new SqlDataAdapter(cmd);
                filesda.Fill(filedt);
                GridView4.DataSource = filedt;
                GridView4.DataBind();
                con.Close();
            }
        }

        private void grid_default_2()
        {


            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from [dbo].[defaulters_2] where tc='1' and course='" + DropDownList2.SelectedItem.Value.ToString() + "'", con);
                DataTable filedt = new DataTable();
                SqlDataAdapter filesda = new SqlDataAdapter(cmd);
                filesda.Fill(filedt);
                GridView5.DataSource = filedt;
                GridView5.DataBind();
                con.Close();
            }
        }

        private void grid_working_party1()
        {


            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from [dbo].[working_party_1] where tc='1' and course='" + DropDownList2.SelectedItem.Value.ToString() + "'", con);
                DataTable filedt = new DataTable();
                SqlDataAdapter filesda = new SqlDataAdapter(cmd);
                filesda.Fill(filedt);
                GridView6.DataSource = filedt;
                GridView6.DataBind();
                con.Close();
            }
        }

        private void grid_working_party2()
        {


            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from [dbo].[working_party_2] where tc='1' and course='" + DropDownList2.SelectedItem.Value.ToString() + "'", con);
                DataTable filedt = new DataTable();
                SqlDataAdapter filesda = new SqlDataAdapter(cmd);
                filesda.Fill(filedt);
                GridView7.DataSource = filedt;
                GridView7.DataBind();
                con.Close();
            }
        }

        private void update_daily_schedule()
        {

            using (SqlConnection con = new SqlConnection(connection))
            {
                string REMARK = TextBox1.Text.ToUpper().ToString();
                con.Open();
                SqlCommand cmd1 = new SqlCommand("select * from [dbo].[daily_schedule] where course='" + DropDownList2.SelectedItem.Value.ToString() + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string SRNO = dt.Rows[i][1].ToString();
                        SqlCommand cmd = new SqlCommand("update [dbo].[daily_schedule] set c_remark=@Co,commandant=@commandant where sr_no='" + SRNO + "' and course='" + DropDownList2.SelectedItem.Value.ToString() + "'", con);
                        cmd.Parameters.AddWithValue("@Co", REMARK);
                        cmd.Parameters.AddWithValue("@commandant", '1');
                        cmd.ExecuteNonQuery();

                    }
                }
                con.Close();
                //con.Open();
                ////SqlCommand cmd = new SqlCommand("login_gridview_update", con);
                //SqlCommand cmd = new SqlCommand("update [dbo].[daily_schedule] set commandant=@commandant where school_id='" + DropDownList2.SelectedItem.Value.ToString() + "'", con);
                ////cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.CommandType = CommandType.Text;
                //cmd.Parameters.AddWithValue("@commandant", "1");
                //cmd.ExecuteNonQuery();
                //con.Close();
                ////ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Update Sucessfully');", true);                             
            }
        }

        private void update_deviation()
        {

            using (SqlConnection con = new SqlConnection(connection))
            {
                string REMARK = TextBox1.Text.ToUpper().ToString();
                con.Open();
                SqlCommand cmd2 = new SqlCommand("select * from [dbo].[subject_deviation] where course='" + DropDownList2.SelectedItem.Value.ToString() + "'", con);
                SqlDataAdapter sda1 = new SqlDataAdapter(cmd2);
                DataTable dt39 = new DataTable();
                sda1.Fill(dt39);
                if (dt39.Rows.Count > 0)
                {
                    for (int i = 0; i < dt39.Rows.Count; i++)
                    {
                        string SRNO = dt39.Rows[i][1].ToString();
                        SqlCommand cmd9 = new SqlCommand("update [dbo].[subject_deviation] set c_remark=@Co ,comadant=@comadant where srno='" + SRNO + "' and course='" + DropDownList2.SelectedItem.Value.ToString() + "'", con);
                        cmd9.Parameters.AddWithValue("@Co", REMARK);
                        cmd9.Parameters.AddWithValue("@comadant", '1');
                        cmd9.ExecuteNonQuery();

                    }
                }
                con.Close();
                //con.Open();
                ////SqlCommand cmd = new SqlCommand("login_gridview_update", con);
                //SqlCommand cmd = new SqlCommand("update [dbo].[subject_deviation] set commandant=@commandant where school_id='" + DropDownList2.SelectedItem.Value.ToString() + "'", con);
                ////cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.CommandType = CommandType.Text;
                //cmd.Parameters.AddWithValue("@commandant", "1");
                //cmd.ExecuteNonQuery();
                //con.Close();
                ////ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Update Sucessfully');", true);                             
            }
        }

        private void update_extra_activity()
        {

            using (SqlConnection con = new SqlConnection(connection))
            {
                string REMARK = TextBox1.Text.ToUpper().ToString();
                con.Open();
                SqlCommand cmd1 = new SqlCommand("select * from [dbo].[extra_activity] where course='" + DropDownList2.SelectedItem.Value.ToString() + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string SRNO = dt.Rows[i][1].ToString();
                        SqlCommand cmd = new SqlCommand("update [dbo].[extra_activity] set c_remark=@Co,commadant=@commadant where srno='" + SRNO + "' and course='" + DropDownList2.SelectedItem.Value.ToString() + "'", con);
                        cmd.Parameters.AddWithValue("@Co", REMARK);
                        cmd.Parameters.AddWithValue("@commadant", '1');
                        cmd.ExecuteNonQuery();

                    }
                }
                con.Close();
                //con.Open();
                //////SqlCommand cmd = new SqlCommand("login_gridview_update", con);
                //SqlCommand cmd = new SqlCommand("update [dbo].[extra_activity] set commandant=@commandant where school='" + DropDownList2.SelectedItem.Value.ToString() + "'", con);
                ////cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.CommandType = CommandType.Text;
                //cmd.Parameters.AddWithValue("@commandant", "1");
                //cmd.ExecuteNonQuery();
                //con.Close();
                ////ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Update Sucessfully');", true);                             
            }
        }

        private void update_default_1()
        {

            using (SqlConnection con = new SqlConnection(connection))
            {
                string REMARK = TextBox1.Text.ToUpper().ToString();
                con.Open();
                SqlCommand cmd1 = new SqlCommand("select * from [dbo].[defaulters_1] where course='" + DropDownList2.SelectedItem.Value.ToString() + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string SRNO = dt.Rows[i][1].ToString();
                        SqlCommand cmd = new SqlCommand("update [dbo].[defaulters_1] set c_remark=@Co,comadant=@comadant where sr_no='" + SRNO + "' and course='" + DropDownList2.SelectedItem.Value.ToString() + "'", con);
                        cmd.Parameters.AddWithValue("@Co", REMARK);
                        cmd.Parameters.AddWithValue("@comadant", '1');
                        cmd.ExecuteNonQuery();

                    }
                }
                con.Close();
                //con.Open();
                ////SqlCommand cmd = new SqlCommand("login_gridview_update", con);
                //SqlCommand cmd = new SqlCommand("update [dbo].[defaulters_1] set commandant=@commandant where school_id='" + DropDownList2.SelectedItem.Value.ToString() + "'", con);
                ////cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.CommandType = CommandType.Text;
                //cmd.Parameters.AddWithValue("@commandant", "1");
                //cmd.ExecuteNonQuery();
                //con.Close();
                ////ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Update Sucessfully');", true);                             
            }
        }

        private void update_default_2()
        {

            using (SqlConnection con = new SqlConnection(connection))
            {
                string REMARK = TextBox1.Text.ToUpper().ToString();
                con.Open();
                SqlCommand cmd1 = new SqlCommand("select * from [dbo].[defaulters_2] where course='" + DropDownList2.SelectedItem.Value.ToString() + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string SRNO = dt.Rows[i][1].ToString();
                        SqlCommand cmd = new SqlCommand("update [dbo].[defaulters_2] set c_remark=@Co,commandant=@commandant where srno='" + SRNO + "' and course='" + DropDownList2.SelectedItem.Value.ToString() + "'", con);
                        cmd.Parameters.AddWithValue("@Co", REMARK);
                        cmd.Parameters.AddWithValue("@commandant", '1');
                        cmd.ExecuteNonQuery();

                    }
                }
                con.Close();
                //con.Open();
                ////SqlCommand cmd = new SqlCommand("login_gridview_update", con);
                //SqlCommand cmd = new SqlCommand("update [dbo].[defaulters_2] set commandant=@commandant where school='" + DropDownList2.SelectedItem.Value.ToString() + "'", con);
                ////cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.CommandType = CommandType.Text;
                //cmd.Parameters.AddWithValue("@commandant", "1");
                //cmd.ExecuteNonQuery();
                //con.Close();
                ////ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Update Sucessfully');", true);                             
            }
        }

        private void update_working_1()
        {

            using (SqlConnection con = new SqlConnection(connection))
            {
                string REMARK = TextBox1.Text.ToUpper().ToString();
                con.Open();
                SqlCommand cmd1 = new SqlCommand("select * from [dbo].[working_party_1] where course='" + DropDownList2.SelectedItem.Value.ToString() + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string SRNO = dt.Rows[i][1].ToString();
                        SqlCommand cmd = new SqlCommand("update [dbo].[working_party_1] set c_remark=@Co,commandant=@commandant where srno='" + SRNO + "' and course='" + DropDownList2.SelectedItem.Value.ToString() + "'", con);
                        cmd.Parameters.AddWithValue("@Co", REMARK);
                        cmd.Parameters.AddWithValue("@commandant", '1');
                        cmd.ExecuteNonQuery();

                    }
                }
                con.Close();
                //con.Open();
                ////SqlCommand cmd = new SqlCommand("login_gridview_update", con);
                //SqlCommand cmd = new SqlCommand("update [dbo].[working_party_1] set commandant=@commandant where school='" + DropDownList2.SelectedItem.Value.ToString() + "'", con);
                ////cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.CommandType = CommandType.Text;
                //cmd.Parameters.AddWithValue("@commandant", "1");
                //cmd.ExecuteNonQuery();
                //con.Close();
                ////ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Update Sucessfully');", true);                             
            }
        }

        private void update_working_2()
        {

            using (SqlConnection con = new SqlConnection(connection))
            {
                string REMARK = TextBox1.Text.ToUpper().ToString();
                con.Open();
                SqlCommand cmd1 = new SqlCommand("select * from [dbo].[working_party_2] where course='" + DropDownList2.SelectedItem.Value.ToString() + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string SRNO = dt.Rows[i][1].ToString();
                        SqlCommand cmd = new SqlCommand("update [dbo].[working_party_2] set c_remark=@Co,commandant=@commandant where srno='" + SRNO + "' and course='" + DropDownList2.SelectedItem.Value.ToString() + "'", con);
                        cmd.Parameters.AddWithValue("@Co", REMARK);
                        cmd.Parameters.AddWithValue("@commandant", '1');
                        cmd.ExecuteNonQuery();

                    }
                }
                con.Close();
                //con.Open();
                ////SqlCommand cmd = new SqlCommand("login_gridview_update", con);
                //SqlCommand cmd = new SqlCommand("update [dbo].[working_party_2] set commandant=@commandant where school='" + DropDownList2.SelectedItem.Value.ToString() + "'", con);
                ////cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.CommandType = CommandType.Text;
                //cmd.Parameters.AddWithValue("@commandant", "1");
                //cmd.ExecuteNonQuery();
                //con.Close();
                ////ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Update Sucessfully');", true);                             
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            update_daily_schedule();
            update_deviation();
            update_extra_activity();
            update_default_1();
            update_default_2();
            update_working_1();
            update_working_2();
            //Response.Redirect("User_login.aspx");
            GridView1.DataSource = null;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            griddata();
            griddeviation();
            grid_extra_activity();
            grid_default_1();
            grid_default_2();
            grid_working_party1();
            grid_working_party2();
        }


    }
}