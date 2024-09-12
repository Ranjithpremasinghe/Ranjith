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
    public partial class Daily_schedule : System.Web.UI.Page
    {
        string connection = ConfigurationManager.ConnectionStrings["nma"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox15.Text = Convert.ToString(Session["school"]);
           
            if (!IsPostBack)
            {
               
            }
        }

        //protected void get_school()
        //{
        //    using (SqlConnection con = new SqlConnection(connection))
        //    {
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand("select* from [dbo].[school]", con);
        //        DataTable dt = new DataTable();
        //        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //        sda.Fill(dt);
        //        DropDownList1.DataSource = dt;
        //        DropDownList1.DataTextField = "school_name";
        //        DropDownList1.DataValueField = "school_name";
        //        DropDownList1.DataBind();
        //        DropDownList1.Items.Insert(0, new ListItem("--Select--", "0"));
        //        DropDownList1.Items[0].Selected = true;
        //        DropDownList1.Items[0].Attributes["disabled"] = "Disabled";

        //    }
        //}

       
        protected void btn_daily_schedule_Click(object sender, EventArgs e)
        {

            string srno = TextBox2.Text; string date = TextBox3.Text, time_st = TextBox4.Text, time_end = TextBox5.Text, subject = TextBox6.Text, instructor = TextBox7.Text, activity = TextBox8.Text;
            string school = TextBox15.Text, course =txtCourse.Text;
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                SqlCommand duplicatecmd = new SqlCommand(" select * from [dbo].[daily_schedule] where course='" + course + "' and date='" + date + "' and sr_no='" + srno + "'", conn);
                DataTable dupdt = new DataTable();
                SqlDataAdapter dupsda = new SqlDataAdapter(duplicatecmd);
                dupsda.Fill(dupdt);
                if (dupdt.Rows.Count >= 1)
                {

                    Response.Write("<script>alert('Records Already Inserted');</script>");
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox5.Text = "";
                    TextBox6.Text = "";
                    TextBox7.Text = "";
                    TextBox8.Text = "";
                    //TextBox9.Text = "";
                }

                else
                {


                    using (SqlConnection con = new SqlConnection(connection))
                    {
                        string query = "INSERT INTO [dbo].[daily_schedule] VALUES (@serial,@school,@course,@date,@sttime,@endtime,@subject,@instructor,@activity,@po,@ci,@do,@oic,@tc,@comadant,@tc_remark,@c_remark)";
                        using (SqlCommand cmd = new SqlCommand(query))
                        {
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("@serial", srno);
                            cmd.Parameters.AddWithValue("@school", school);
                            cmd.Parameters.AddWithValue("@course", course);
                            cmd.Parameters.AddWithValue("@date", date);
                            cmd.Parameters.AddWithValue("@sttime", time_st);
                            cmd.Parameters.AddWithValue("@endtime", time_end);
                            cmd.Parameters.AddWithValue("@subject", subject);
                            cmd.Parameters.AddWithValue("@instructor", instructor);
                            cmd.Parameters.AddWithValue("@activity", activity);
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
                        //TextBox3.Text = "";
                        TextBox4.Text = "";
                        TextBox5.Text = "";
                        TextBox6.Text = "";
                        TextBox7.Text = "";
                        TextBox8.Text = "";
                       // TextBox9.Text = "";
                        griddata();


                    }

                }
            }

        }

        private void griddata()
        {
            string date=TextBox3.Text;
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from [dbo].[daily_schedule] where date='"+date+"'", con);
                DataTable filedt = new DataTable();
                SqlDataAdapter filesda = new SqlDataAdapter(cmd);
                filesda.Fill(filedt);
                GridView1.DataSource = filedt;
                GridView1.DataBind();
                con.Close();
            }
        }

        protected void btn_deviation_Click(object sender, EventArgs e)
        {
            string srno = TextBox10.Text, subject = TextBox11.Text, deviation = TextBox12.Text, instructor = TextBox13.Text, reason = TextBox14.Text;
            string school = TextBox15.Text, course = txtCourse.Text;
             string date = TextBox1.Text;
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                SqlCommand duplicatecmd = new SqlCommand(" select * from [dbo].[subject_deviation] where course='" + course + "' and dte='"+date+"' and srno='"+srno+"'", conn);
                DataTable dupdt = new DataTable();
                SqlDataAdapter dupsda = new SqlDataAdapter(duplicatecmd);
                dupsda.Fill(dupdt);
                if (dupdt.Rows.Count >= 1)
                {

                    Response.Write("<script>alert('Records Already Inserted');</script>");
                    TextBox10.Text = "";
                    TextBox11.Text = "";
                    TextBox12.Text = "";
                    TextBox12.Text = "";
                    TextBox14.Text = "";
                    TextBox13.Text = "";
                    
                }

                else
                {


                    using (SqlConnection con = new SqlConnection(connection))
                    {
                        string query = "INSERT INTO [dbo].[subject_deviation] VALUES (@school,@course,@srno,@subject,@deviation,@instructor,@instructor,@po,@ci,@do,@oic,@tc,@comadant,@date,@tc_remark,@c_remark)";
                        using (SqlCommand cmd = new SqlCommand(query))
                        {
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("@school", school);
                            cmd.Parameters.AddWithValue("@course",course );
                            cmd.Parameters.AddWithValue("@srno", srno);
                            cmd.Parameters.AddWithValue("@subject", subject);
                            cmd.Parameters.AddWithValue("@deviation", deviation);
                            cmd.Parameters.AddWithValue("@instructor", instructor);
                            cmd.Parameters.AddWithValue("@reason", reason);                           
                            cmd.Parameters.AddWithValue("@po", "0");
                            cmd.Parameters.AddWithValue("@ci", "0");
                            cmd.Parameters.AddWithValue("@do", "0");
                            cmd.Parameters.AddWithValue("@oic", "0");
                            cmd.Parameters.AddWithValue("@tc", "0");
                            cmd.Parameters.AddWithValue("@comadant", "0");
                            cmd.Parameters.AddWithValue("@date", date);
                            cmd.Parameters.AddWithValue("@tc_remark", "0");
                            cmd.Parameters.AddWithValue("@c_remark", "0");
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            Response.Write("<script>alert('Your File and Data Saved Sucessfully');</script>");
                        }

                        TextBox10.Text = "";
                        TextBox11.Text = "";
                        TextBox12.Text = "";
                        TextBox12.Text = "";
                        TextBox14.Text = "";
                        TextBox13.Text = "";
                        griddeviation();


                    }

                }
            }

        }

        private void griddeviation()
        {
            string date = TextBox1.Text;
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from [dbo].[subject_deviation] where dte='"+date+"'", con);
                DataTable filedt = new DataTable();
                SqlDataAdapter filesda = new SqlDataAdapter(cmd);
                filesda.Fill(filedt);
                GridView2.DataSource = filedt;
                GridView2.DataBind();
                con.Close();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Session["school"] = TextBox15.Text;
            Session["course"] = txtCourse.Text;
            
            Response.Redirect("extra_curricular_and_difficulties.aspx");
            
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            using (SqlConnection con = new SqlConnection(connection))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("delete [dbo].[daily_schedule] where id='" + id + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                griddata();
            }
        }

        protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView2.DataKeys[e.RowIndex].Value);
            using (SqlConnection con = new SqlConnection(connection))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("delete [dbo].[subject_deviation] where id='" + id + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                griddeviation();
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            griddata();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            griddata();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            string SRNO = (GridView1.Rows[e.RowIndex].FindControl("txtsr") as TextBox).Text;
            string DATE = (GridView1.Rows[e.RowIndex].FindControl("txtdate") as TextBox).Text;
            string STTIME = (GridView1.Rows[e.RowIndex].FindControl("txtst") as TextBox).Text;
            string ENDTIME = (GridView1.Rows[e.RowIndex].FindControl("txtet") as TextBox).Text;
            string SUBJCT = (GridView1.Rows[e.RowIndex].FindControl("txtsbjt") as TextBox).Text;
            string INSTRU = (GridView1.Rows[e.RowIndex].FindControl("txtins") as TextBox).Text;
            string ACTIVITY = (GridView1.Rows[e.RowIndex].FindControl("txtact") as TextBox).Text;


            using (SqlConnection con = new SqlConnection(connection))
            {

                con.Open();
                //SqlCommand cmd = new SqlCommand("login_gridview_update", con);
                SqlCommand cmd = new SqlCommand("update [dbo].[daily_schedule] set sr_no=@sr,date=@date,st_time=@st,end_time=@et,subject=@sub,instructor=@ins,activities=@activity where id=@id", con);
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@sr", SRNO);
                cmd.Parameters.AddWithValue("@date", DATE);
                cmd.Parameters.AddWithValue("@st", STTIME);
                cmd.Parameters.AddWithValue("@et", ENDTIME);
                cmd.Parameters.AddWithValue("@sub", SUBJCT);
                cmd.Parameters.AddWithValue("@ins", INSTRU);
                cmd.Parameters.AddWithValue("@activity", ACTIVITY);
               
                cmd.ExecuteNonQuery();

                con.Close();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Update Sucessfully');", true);
                GridView1.EditIndex = -1;

                griddata();
            }

        }

        protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView2.EditIndex = e.NewEditIndex;
            griddeviation();
        }

        protected void GridView2_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView2.DataKeys[e.RowIndex].Value.ToString());
            string SRNO = (GridView2.Rows[e.RowIndex].FindControl("txtsr") as TextBox).Text;
            string DATE = (GridView2.Rows[e.RowIndex].FindControl("txtdate") as TextBox).Text;
            string SUBJECT = (GridView2.Rows[e.RowIndex].FindControl("txtsub") as TextBox).Text;
            string DEVIATION = (GridView2.Rows[e.RowIndex].FindControl("txtdv") as TextBox).Text;
            string INSTRUCTOR = (GridView2.Rows[e.RowIndex].FindControl("txtins") as TextBox).Text;
            string REASONS = (GridView2.Rows[e.RowIndex].FindControl("txtact") as TextBox).Text;
           


            using (SqlConnection con = new SqlConnection(connection))
            {

                con.Open();
                //SqlCommand cmd = new SqlCommand("login_gridview_update", con);
                SqlCommand cmd = new SqlCommand("update [dbo].[subject_deviation] set srno=@sr,dte=@date,subject=@sub,deviation=@devi,instructor=@ins,reasons=@rea where id=@id", con);
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@sr", SRNO);
                cmd.Parameters.AddWithValue("@date", DATE);
                cmd.Parameters.AddWithValue("@sub", SUBJECT);
                cmd.Parameters.AddWithValue("@devi", DEVIATION);
                cmd.Parameters.AddWithValue("@ins", INSTRUCTOR);
                cmd.Parameters.AddWithValue("@rea", REASONS);
               
                cmd.ExecuteNonQuery();

                con.Close();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Update Sucessfully');", true);
                GridView2.EditIndex = -1;

                griddeviation();
            }
        }

        protected void GridView2_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView2.EditIndex = -1;
            griddeviation();
        }


        public object c_remark { get; set; }

        public object tc_remark { get; set; }
    }
}