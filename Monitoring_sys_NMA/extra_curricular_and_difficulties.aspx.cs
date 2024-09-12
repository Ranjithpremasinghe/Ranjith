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
    public partial class extra_curricular_and_difficulties : System.Web.UI.Page
    {
        string connection = ConfigurationManager.ConnectionStrings["nma"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
              
            }
            TextBox1.Text = Convert.ToString(Session["school"]);
            TextBox9.Text = Convert.ToString(Session["course"]);
        }

       
        protected void extra_activities_Click(object sender, EventArgs e)
        {
           string school = TextBox1.Text; string course = TextBox9.Text, srno = TextBox2.Text, date = TextBox3.Text, activity = TextBox4.Text, instructor = TextBox5.Text, tranee = TextBox6.Text,description=TextBox7.Text;
            
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                SqlCommand duplicatecmd = new SqlCommand(" select * from [dbo].[extra_activity] where course='" + course + "' and date='" + date + "' and srno='"+srno+"'", conn);
                DataTable dupdt = new DataTable();
                SqlDataAdapter dupsda = new SqlDataAdapter(duplicatecmd);
                dupsda.Fill(dupdt);
                if (dupdt.Rows.Count >= 1)
                {

                    Response.Write("<script>alert('Records Already Inserted');</script>");
                    TextBox2.Text = "";
                   // TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox5.Text = "";
                    TextBox6.Text = "";
                    TextBox7.Text = "";
                    
                }

                else
                {


                    using (SqlConnection con = new SqlConnection(connection))
                    {
                        string query = "INSERT INTO [dbo].[extra_activity] VALUES (@school,@course,@srno,@date,@activity,@instructor,@tranee,@description,@po,@ci,@do,@oic,@tc,@comadant,@tc_remark,@c_remark)";
                        using (SqlCommand cmd = new SqlCommand(query))
                        {
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("@school", school);
                            cmd.Parameters.AddWithValue("@course", course);
                            cmd.Parameters.AddWithValue("@srno", srno);
                            cmd.Parameters.AddWithValue("@date", date);
                            cmd.Parameters.AddWithValue("@activity", activity);
                            cmd.Parameters.AddWithValue("@instructor", instructor);
                            cmd.Parameters.AddWithValue("@tranee", tranee);                           
                            cmd.Parameters.AddWithValue("@description", description);
                            cmd.Parameters.AddWithValue("@po", "0");
                            cmd.Parameters.AddWithValue("@ci", "0");
                            cmd.Parameters.AddWithValue("@do", "0");
                            cmd.Parameters.AddWithValue("@oic", "0");
                            cmd.Parameters.AddWithValue("@tc", "0");
                            cmd.Parameters.AddWithValue("@comadant", "0");
                            cmd.Parameters.AddWithValue("@tc_remark", "0");
                            cmd.Parameters.AddWithValue("@c_remark", "0");
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            Response.Write("<script>alert('Your File and Data Saved Sucessfully');</script>");
                        }

                        TextBox2.Text = "";
                       // TextBox3.Text = "";
                        TextBox4.Text = "";
                        TextBox5.Text = "";
                        TextBox6.Text = "";
                        TextBox7.Text = "";
                        grid_extra_activity();
                    }

                }
            }
        }


        private void grid_extra_activity()
        {
            string date =TextBox3.Text;
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from [dbo].[extra_activity] where date='"+date+"'", con);
                DataTable filedt = new DataTable();
                SqlDataAdapter filesda = new SqlDataAdapter(cmd);
                filesda.Fill(filedt);
                GridView1.DataSource = filedt;
                GridView1.DataBind();
                con.Close();
            }
        }

        protected void btn_default_Click(object sender, EventArgs e)
        {
            string school = TextBox1.Text; string course = TextBox9.Text, srno = TextBox10.Text, date = TextBox8.Text, rank_name = TextBox11.Text, reason = TextBox12.Text, action = TextBox13.Text;

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                SqlCommand duplicatecmd = new SqlCommand(" select * from [dbo].[defaulters_1] where course='" + course + "' and date='" + date + "'", conn);
                DataTable dupdt = new DataTable();
                SqlDataAdapter dupsda = new SqlDataAdapter(duplicatecmd);
                dupsda.Fill(dupdt);
                if (dupdt.Rows.Count >= 1)
                {

                    Response.Write("<script>alert('Records Already Inserted');</script>");
                    TextBox10.Text = "";
                   // TextBox8.Text = "";
                    TextBox11.Text = "";
                    TextBox12.Text = "";
                    TextBox13.Text = "";
                   

                }

                else
                {


                    using (SqlConnection con = new SqlConnection(connection))
                    {
                        string query = "INSERT INTO [dbo].[defaulters_1] VALUES (@sr_no,@school,@course,@date,@st_time,@end_time,@subject,@instructor,@activities,@rank,@reason,@action, @po,@ci,@do,@oic,@tc,@comadant,@tc_remark,@c_remark)";
                        using (SqlCommand cmd = new SqlCommand(query))
                        {
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("@sr_no", srno);
                            cmd.Parameters.AddWithValue("@school", school);
                            cmd.Parameters.AddWithValue("@course", course);                            
                            cmd.Parameters.AddWithValue("@date", date);
                            cmd.Parameters.AddWithValue("@st_time", "");
                            cmd.Parameters.AddWithValue("@end_time", "");
                            cmd.Parameters.AddWithValue("@subject", "");
                            cmd.Parameters.AddWithValue("@instructor", "");
                            cmd.Parameters.AddWithValue("@activities", "");
                            cmd.Parameters.AddWithValue("@rank", rank_name);
                            cmd.Parameters.AddWithValue("@reason", reason);
                            cmd.Parameters.AddWithValue("@action", action);                           
                            cmd.Parameters.AddWithValue("@po", "0");
                            cmd.Parameters.AddWithValue("@ci", "0");
                            cmd.Parameters.AddWithValue("@do", "0");
                            cmd.Parameters.AddWithValue("@oic", "0");
                            cmd.Parameters.AddWithValue("@tc", "0");
                            cmd.Parameters.AddWithValue("@comadant", "0");
                            cmd.Parameters.AddWithValue("@tc_remark", "0");
                            cmd.Parameters.AddWithValue("@c_remark", "0");
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            Response.Write("<script>alert('Your File and Data Saved Sucessfully');</script>");
                        }

                        TextBox10.Text = "";
                       // TextBox8.Text = "";
                        TextBox11.Text = "";
                        TextBox12.Text = "";
                        TextBox13.Text = "";
                        grid_default_1();       
                    }

                }
            }
        }
        private void grid_default_1()
        {
            string date = date = TextBox8.Text;
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from [dbo].[defaulters_1] where date='"+date+"'", con);
                DataTable filedt = new DataTable();
                SqlDataAdapter filesda = new SqlDataAdapter(cmd);
                filesda.Fill(filedt);
                GridView2.DataSource = filedt;
                GridView2.DataBind();
                con.Close();
            }
        }


        //NextPrevFormat part
        protected void defaulr_2_Click(object sender, EventArgs e)
        {
            string school = TextBox1.Text; string course = TextBox9.Text, srno = TextBox14.Text, date = TextBox15.Text, rank_name = TextBox16.Text, reason = TextBox17.Text, description = TextBox18.Text;

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                SqlCommand duplicatecmd = new SqlCommand(" select * from [dbo].[defaulters_2] where course='" + course + "' and date='" + date + "' and srno='"+srno+"'", conn);
                DataTable dupdt = new DataTable();
                SqlDataAdapter dupsda = new SqlDataAdapter(duplicatecmd);
                dupsda.Fill(dupdt);
                if (dupdt.Rows.Count >= 1)
                {

                    Response.Write("<script>alert('Records Already Inserted');</script>");
                    TextBox14.Text = "";
                    //TextBox15.Text = "";
                    TextBox16.Text = "";
                    TextBox17.Text = "";
                    TextBox18.Text = "";


                }

                else
                {


                    using (SqlConnection con = new SqlConnection(connection))
                    {
                        string query = "INSERT INTO [dbo].[defaulters_2] VALUES (@school,@course,@srno,@date,@rank,@reason,@description,@po,@ci,@do,@tc,@oic,@comadant,@tc_remark,@c_remark)";
                        using (SqlCommand cmd = new SqlCommand(query))
                        {
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("@school", school);
                            cmd.Parameters.AddWithValue("@course", course);
                            cmd.Parameters.AddWithValue("@srno", srno);
                            cmd.Parameters.AddWithValue("@date", date);
                            cmd.Parameters.AddWithValue("@rank", rank_name);
                            cmd.Parameters.AddWithValue("@reason", reason);
                            cmd.Parameters.AddWithValue("@description", description);
                            cmd.Parameters.AddWithValue("@po", "0");
                            cmd.Parameters.AddWithValue("@ci", "0");
                            cmd.Parameters.AddWithValue("@do", "0");
                            cmd.Parameters.AddWithValue("@oic", "0");
                            cmd.Parameters.AddWithValue("@tc", "0");
                            cmd.Parameters.AddWithValue("@comadant", "0");
                            cmd.Parameters.AddWithValue("@tc_remark", "0");
                            cmd.Parameters.AddWithValue("@c_remark", "0");
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            Response.Write("<script>alert('Your File and Data Saved Sucessfully');</script>");
                        }

                        TextBox14.Text = "";
                        //TextBox15.Text = "";
                        TextBox16.Text = "";
                        TextBox17.Text = "";
                        TextBox18.Text = "";
                        grid_default_2();
                    }
                }
            }
        }
        private void grid_default_2()
        {
            string date = date = TextBox15.Text;
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from [dbo].[defaulters_2] where date='"+date+"'", con);
                DataTable filedt = new DataTable();
                SqlDataAdapter filesda = new SqlDataAdapter(cmd);
                filesda.Fill(filedt);
                GridView3.DataSource = filedt;
                GridView3.DataBind();
                con.Close();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //Session["school"] = TextBox1.Text;
            //Session["course"] = TextBox9.Text;

            //Response.Redirect("working_party.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["school"] = TextBox1.Text;
            Session["course"] = TextBox9.Text;

            Response.Redirect("workingParty.aspx");
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            using (SqlConnection con = new SqlConnection(connection))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("delete [dbo].[extra_activity] where id='" + id + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                grid_extra_activity();
            }
        }

        protected void GridView3_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView3.DataKeys[e.RowIndex].Value);
            using (SqlConnection con = new SqlConnection(connection))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("delete [dbo].[defaulters_2] where id='" + id + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                grid_default_2();
            }
        }

        protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView2.DataKeys[e.RowIndex].Value);
            using (SqlConnection con = new SqlConnection(connection))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("delete [dbo].[defaulters_1] where id='" + id + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                grid_default_1();
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            grid_extra_activity();
        }

        protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView2.EditIndex = e.NewEditIndex;
            grid_default_1();
        }

        protected void GridView3_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView3.EditIndex = e.NewEditIndex;
            grid_default_2();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            grid_extra_activity();
        }

        protected void GridView2_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView2.EditIndex = -1;
            grid_default_1();
        }

        protected void GridView3_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView3.EditIndex = -1;
            grid_default_2();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            string SRNO = (GridView1.Rows[e.RowIndex].FindControl("txtsr") as TextBox).Text;
            string DATE = (GridView1.Rows[e.RowIndex].FindControl("txtdate") as TextBox).Text;
            string ACTIVITY = (GridView1.Rows[e.RowIndex].FindControl("txtact") as TextBox).Text;
            string INSTRUCTOR = (GridView1.Rows[e.RowIndex].FindControl("txINS") as TextBox).Text;
            string TRANEE = (GridView1.Rows[e.RowIndex].FindControl("txtTR") as TextBox).Text;
            string DESCRTPTION = (GridView1.Rows[e.RowIndex].FindControl("txtDIS") as TextBox).Text;
         

            using (SqlConnection con = new SqlConnection(connection))
            {

                con.Open();
                //SqlCommand cmd = new SqlCommand("login_gridview_update", con);
                SqlCommand cmd = new SqlCommand("update [dbo].[extra_activity] set srno=@sr,date=@date,activity=@ACT,instructor=@INS,tranee=@TR,description=@DES where id=@id", con);
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@sr", SRNO);
                cmd.Parameters.AddWithValue("@date", DATE);
                cmd.Parameters.AddWithValue("@ACT", ACTIVITY);
                cmd.Parameters.AddWithValue("@INS", INSTRUCTOR);
                cmd.Parameters.AddWithValue("@TR", TRANEE);
                cmd.Parameters.AddWithValue("@DES", DESCRTPTION);
            

                cmd.ExecuteNonQuery();

                con.Close();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Update Sucessfully');", true);
                GridView1.EditIndex = -1;

                grid_extra_activity();
            }
        }

        protected void GridView2_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView2.DataKeys[e.RowIndex].Value.ToString());
            string SRNO = (GridView2.Rows[e.RowIndex].FindControl("txtsr") as TextBox).Text;
            string RANK = (GridView2.Rows[e.RowIndex].FindControl("txtRNK") as TextBox).Text;
            string REASON = (GridView2.Rows[e.RowIndex].FindControl("txtRSN") as TextBox).Text;
            string ACTION = (GridView2.Rows[e.RowIndex].FindControl("txACT") as TextBox).Text;
          


            using (SqlConnection con = new SqlConnection(connection))
            {

                con.Open();
                //SqlCommand cmd = new SqlCommand("login_gridview_update", con);
                SqlCommand cmd = new SqlCommand("update [dbo].[defaulters_1] set sr_no=@sr_no,rank_name=@RANK,reason=@REA,action=@AC where id=@id", con);
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@sr_no", SRNO);
                cmd.Parameters.AddWithValue("@RANK", RANK);
                cmd.Parameters.AddWithValue("@REA", REASON);
                cmd.Parameters.AddWithValue("@AC", ACTION);
              


                cmd.ExecuteNonQuery();

                con.Close();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Update Sucessfully');", true);
                GridView2.EditIndex = -1;

                grid_default_1();
            }
        }

        protected void GridView3_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView3.DataKeys[e.RowIndex].Value.ToString());
            string SRNO = (GridView3.Rows[e.RowIndex].FindControl("txtsr") as TextBox).Text;
            string RANK = (GridView3.Rows[e.RowIndex].FindControl("txtRNK") as TextBox).Text;
            string REASON = (GridView3.Rows[e.RowIndex].FindControl("txtRSN") as TextBox).Text;
            string DESCRIPTION = (GridView3.Rows[e.RowIndex].FindControl("txDES") as TextBox).Text;



            using (SqlConnection con = new SqlConnection(connection))
            {

                con.Open();
                //SqlCommand cmd = new SqlCommand("login_gridview_update", con);
                SqlCommand cmd = new SqlCommand("update [dbo].[defaulters_2] set srno=@sr,rank_name=@RANK,reason=@REA,description=@DES where id=@id", con);
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@sr", SRNO);
                cmd.Parameters.AddWithValue("@RANK", RANK);
                cmd.Parameters.AddWithValue("@REA", REASON);
                cmd.Parameters.AddWithValue("@DES", DESCRIPTION);



                cmd.ExecuteNonQuery();

                con.Close();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Update Sucessfully');", true);
                GridView3.EditIndex = -1;

                grid_default_2();
            }
        }
    }

}