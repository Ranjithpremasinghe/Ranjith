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
    public partial class do_authorization : System.Web.UI.Page
    {
        string connection = ConfigurationManager.ConnectionStrings["nma"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox15.Text = Convert.ToString(Session["school"]);

            if (!IsPostBack)
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

        //private void grid_extra_activity()
        //{
        //    throw new NotImplementedException();
        //}

        private void griddata()
        {
            string school = TextBox15.Text;
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from [dbo].[daily_schedule] where po='1' and do='0' and school_id='" + school + "'", con);
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
            string school = TextBox15.Text;
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from [dbo].[subject_deviation] where po='1' and do='0' and school_id='" + school + "'", con);
                DataTable filedt = new DataTable();
                SqlDataAdapter filesda = new SqlDataAdapter(cmd);
                filesda.Fill(filedt);
                GridView2.DataSource = filedt;
                GridView2.DataBind();
                con.Close();
            }
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

        protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView2.EditIndex = e.NewEditIndex;
            griddeviation();
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

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            griddata();
        }

        protected void GridView2_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView2.EditIndex = -1;
            griddeviation();
        }

        private void grid_extra_activity()
        {
            string school = TextBox15.Text;

            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from [dbo].[extra_activity] where po='1' and do='0' and school='" + school + "'", con);
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
            string school = TextBox15.Text;
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from [dbo].[defaulters_1] where po='1' and do='0' and school_id='" + school + "'", con);
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
            string school = TextBox15.Text;

            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from [dbo].[defaulters_2] where po='1' and do='0' and school='" + school + "'", con);
                DataTable filedt = new DataTable();
                SqlDataAdapter filesda = new SqlDataAdapter(cmd);
                filesda.Fill(filedt);
                GridView5.DataSource = filedt;
                GridView5.DataBind();
                con.Close();
            }
        }

        protected void GridView3_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView3.DataKeys[e.RowIndex].Value);
            using (SqlConnection con = new SqlConnection(connection))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("delete [dbo].[extra_activity] where id='" + id + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                grid_extra_activity();
            }
        }

        protected void GridView4_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView4.DataKeys[e.RowIndex].Value);
            using (SqlConnection con = new SqlConnection(connection))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("delete [dbo].[defaulters_1] where id='" + id + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                grid_default_1();
            }
        }

        protected void GridView5_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView5.DataKeys[e.RowIndex].Value);
            using (SqlConnection con = new SqlConnection(connection))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("delete [dbo].[defaulters_2] where id='" + id + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                grid_default_2();
            }
        }

        protected void GridView3_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView3.EditIndex = e.NewEditIndex;
            grid_extra_activity();
        }

        protected void GridView4_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView4.EditIndex = e.NewEditIndex;
            grid_default_1();
        }

        protected void GridView5_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView5.EditIndex = e.NewEditIndex;
            grid_default_2();
        }

        protected void GridView3_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView3.EditIndex = -1;
            grid_extra_activity();
        }

        protected void GridView4_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView4.EditIndex = -1;
            grid_default_1();
        }

        protected void GridView5_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView5.EditIndex = -1;
            grid_default_2();
        }

        protected void GridView3_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView3.DataKeys[e.RowIndex].Value.ToString());
            string SRNO = (GridView3.Rows[e.RowIndex].FindControl("txtsr") as TextBox).Text;
            string DATE = (GridView3.Rows[e.RowIndex].FindControl("txtdate") as TextBox).Text;
            string ACTIVITY = (GridView3.Rows[e.RowIndex].FindControl("txtact") as TextBox).Text;
            string INSTRUCTOR = (GridView3.Rows[e.RowIndex].FindControl("txINS") as TextBox).Text;
            string TRANEE = (GridView3.Rows[e.RowIndex].FindControl("txtTR") as TextBox).Text;
            string DESCRTPTION = (GridView3.Rows[e.RowIndex].FindControl("txtDIS") as TextBox).Text;


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
                GridView3.EditIndex = -1;

                grid_extra_activity();
            }
        }

        protected void GridView4_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView4.DataKeys[e.RowIndex].Value.ToString());
            string SRNO = (GridView4.Rows[e.RowIndex].FindControl("txtsr") as TextBox).Text;
            string RANK = (GridView4.Rows[e.RowIndex].FindControl("txtRNK") as TextBox).Text;
            string REASON = (GridView4.Rows[e.RowIndex].FindControl("txtRSN") as TextBox).Text;
            string ACTION = (GridView4.Rows[e.RowIndex].FindControl("txACT") as TextBox).Text;



            using (SqlConnection con = new SqlConnection(connection))
            {

                con.Open();
                //SqlCommand cmd = new SqlCommand("login_gridview_update", con);
                SqlCommand cmd = new SqlCommand("update [dbo].[defaulters_1] set srno=@sr,rank_name=@RANK,reason=@REA,action=@AC where id=@id", con);
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@sr", SRNO);
                cmd.Parameters.AddWithValue("@RANK", RANK);
                cmd.Parameters.AddWithValue("@REA", REASON);
                cmd.Parameters.AddWithValue("@AC", ACTION);



                cmd.ExecuteNonQuery();

                con.Close();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Update Sucessfully');", true);
                GridView4.EditIndex = -1;

                grid_default_1();
            }
        }

        protected void GridView5_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView5.DataKeys[e.RowIndex].Value.ToString());
            string SRNO = (GridView5.Rows[e.RowIndex].FindControl("txtsr") as TextBox).Text;
            string RANK = (GridView5.Rows[e.RowIndex].FindControl("txtRNK") as TextBox).Text;
            string REASON = (GridView5.Rows[e.RowIndex].FindControl("txtRSN") as TextBox).Text;
            string DESCRIPTION = (GridView5.Rows[e.RowIndex].FindControl("txDES") as TextBox).Text;



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
                GridView5.EditIndex = -1;

                grid_default_2();
            }
        }

        private void grid_working_party1()
        {
            string school = TextBox15.Text;

            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from [dbo].[working_party_1] where po='1' and do='0' and school='" + school + "'", con);
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
            string school = TextBox15.Text;

            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from [dbo].[working_party_2] where po='1' and do='0' and school='" + school + "'", con);
                DataTable filedt = new DataTable();
                SqlDataAdapter filesda = new SqlDataAdapter(cmd);
                filesda.Fill(filedt);
                GridView7.DataSource = filedt;
                GridView7.DataBind();
                con.Close();
            }
        }

        protected void GridView6_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView6.DataKeys[e.RowIndex].Value);
            using (SqlConnection con = new SqlConnection(connection))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("delete [dbo].[working_party_1] where id='" + id + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                grid_working_party1();
            }
        }

        protected void GridView7_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView7.DataKeys[e.RowIndex].Value);
            using (SqlConnection con = new SqlConnection(connection))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("delete [dbo].[working_party_2] where id='" + id + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                grid_working_party2();
            }
        }

        protected void GridView6_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView6.EditIndex = e.NewEditIndex;
            grid_working_party1();
        }

        protected void GridView7_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView7.EditIndex = e.NewEditIndex;
            grid_working_party2();
        }

        protected void GridView6_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView6.EditIndex = -1;
            grid_working_party1();
        }

        protected void GridView7_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView7.EditIndex = -1;
            grid_working_party2();
        }

        protected void GridView6_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView6.DataKeys[e.RowIndex].Value.ToString());
            string SRNO = (GridView6.Rows[e.RowIndex].FindControl("txtsr") as TextBox).Text;
            string DATE = (GridView6.Rows[e.RowIndex].FindControl("txtDTEK") as TextBox).Text;
            string TIME_FROM = (GridView6.Rows[e.RowIndex].FindControl("txtTF") as TextBox).Text;
            string TIME_TO = (GridView6.Rows[e.RowIndex].FindControl("txTTO") as TextBox).Text;
            string TASK = (GridView6.Rows[e.RowIndex].FindControl("txTSK") as TextBox).Text;
            string STRENGTH = (GridView6.Rows[e.RowIndex].FindControl("txSTR") as TextBox).Text;
            string DESCRTPTION = (GridView6.Rows[e.RowIndex].FindControl("txDES") as TextBox).Text;

            using (SqlConnection con = new SqlConnection(connection))
            {

                con.Open();
                //SqlCommand cmd = new SqlCommand("login_gridview_update", con);
                SqlCommand cmd = new SqlCommand("update [dbo].[working_party_1] set srno=@sr,date=@date,time_from=@TF,time_to=@TT,task=@TAS,strength=@STR,description=@DES where id=@id", con);
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@sr", SRNO);
                cmd.Parameters.AddWithValue("@date", DATE);
                cmd.Parameters.AddWithValue("@TF", TIME_FROM);
                cmd.Parameters.AddWithValue("@TT", TIME_TO);
                cmd.Parameters.AddWithValue("@TAS", TASK);
                cmd.Parameters.AddWithValue("@STR", STRENGTH);
                cmd.Parameters.AddWithValue("@DES", DESCRTPTION);


                cmd.ExecuteNonQuery();

                con.Close();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Update Sucessfully');", true);
                GridView6.EditIndex = -1;

                grid_working_party1();
            }
        }

        protected void GridView7_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView7.DataKeys[e.RowIndex].Value.ToString());
            string SRNO = (GridView7.Rows[e.RowIndex].FindControl("txtsr") as TextBox).Text;
            string DATE = (GridView7.Rows[e.RowIndex].FindControl("txtDTE") as TextBox).Text;
            string TIME_FROM = (GridView7.Rows[e.RowIndex].FindControl("txtTF") as TextBox).Text;
            string TIME_TO = (GridView7.Rows[e.RowIndex].FindControl("txTTO") as TextBox).Text;
            string details = (GridView7.Rows[e.RowIndex].FindControl("txDTLS") as TextBox).Text;
            string remark = (GridView7.Rows[e.RowIndex].FindControl("txREMK") as TextBox).Text;


            using (SqlConnection con = new SqlConnection(connection))
            {

                con.Open();
                //SqlCommand cmd = new SqlCommand("login_gridview_update", con);
                SqlCommand cmd = new SqlCommand("update [dbo].[working_party_2] set srno=@sr,date=@date,timefrom=@TF,timeto=@TT,details=@det,remarks=@rem where id=@id", con);
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@sr", SRNO);
                cmd.Parameters.AddWithValue("@date", DATE);
                cmd.Parameters.AddWithValue("@TF", TIME_FROM);
                cmd.Parameters.AddWithValue("@TT", TIME_TO);
                cmd.Parameters.AddWithValue("@det", details);
                cmd.Parameters.AddWithValue("@rem", remark);



                cmd.ExecuteNonQuery();

                con.Close();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Update Sucessfully');", true);
                GridView7.EditIndex = -1;

                grid_working_party2();
            }
        }
        private void update_daily_schedule()
        {
            string school = TextBox15.Text;
            using (SqlConnection con = new SqlConnection(connection))
            {

                con.Open();
                //SqlCommand cmd = new SqlCommand("login_gridview_update", con);
                SqlCommand cmd = new SqlCommand("update [dbo].[daily_schedule] set do=@do where school_id='" + school + "'", con);
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@do", "1");
                cmd.ExecuteNonQuery();
                con.Close();
                //ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Update Sucessfully');", true);                             
            }
        }

        private void update_deviation()
        {
            string school = TextBox15.Text;
            using (SqlConnection con = new SqlConnection(connection))
            {

                con.Open();
                //SqlCommand cmd = new SqlCommand("login_gridview_update", con);
                SqlCommand cmd = new SqlCommand("update [dbo].[subject_deviation] set do=@do where school_id='" + school + "'", con);
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@do", "1");
                cmd.ExecuteNonQuery();
                con.Close();
                //ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Update Sucessfully');", true);                             
            }
        }

        private void update_extra_activity()
        {
            string school = TextBox15.Text;
            using (SqlConnection con = new SqlConnection(connection))
            {

                con.Open();
                //SqlCommand cmd = new SqlCommand("login_gridview_update", con);
                SqlCommand cmd = new SqlCommand("update [dbo].[extra_activity] set do=@do where school='" + school + "'", con);
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@do", "1");
                cmd.ExecuteNonQuery();
                con.Close();
                //ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Update Sucessfully');", true);                             
            }
        }

        private void update_default_1()
        {
            string school = TextBox15.Text;
            using (SqlConnection con = new SqlConnection(connection))
            {

                con.Open();
                //SqlCommand cmd = new SqlCommand("login_gridview_update", con);
                SqlCommand cmd = new SqlCommand("update [dbo].[defaulters_1] set do=@do where school_id='" + school + "'", con);
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@do", "1");
                cmd.ExecuteNonQuery();
                con.Close();
                //ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Update Sucessfully');", true);                             
            }
        }

        private void update_default_2()
        {
            string school = TextBox15.Text;
            using (SqlConnection con = new SqlConnection(connection))
            {

                con.Open();
                //SqlCommand cmd = new SqlCommand("login_gridview_update", con);
                SqlCommand cmd = new SqlCommand("update [dbo].[defaulters_2] set do=@do where school='" + school + "'", con);
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@do", "1");
                cmd.ExecuteNonQuery();
                con.Close();
                //ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Update Sucessfully');", true);                             
            }
        }

        private void update_working_1()
        {
            string school = TextBox15.Text;
            using (SqlConnection con = new SqlConnection(connection))
            {

                con.Open();
                //SqlCommand cmd = new SqlCommand("login_gridview_update", con);
                SqlCommand cmd = new SqlCommand("update [dbo].[working_party_1] set do=@do where school='" + school + "'", con);
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@do", "1");
                cmd.ExecuteNonQuery();
                con.Close();
                //ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Update Sucessfully');", true);                             
            }
        }

        private void update_working_2()
        {
            string school = TextBox15.Text;
            using (SqlConnection con = new SqlConnection(connection))
            {

                con.Open();
                //SqlCommand cmd = new SqlCommand("login_gridview_update", con);
                SqlCommand cmd = new SqlCommand("update [dbo].[working_party_2] set do=@do where school='" + school + "'", con);
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@do", "1");
                cmd.ExecuteNonQuery();
                con.Close();
                //ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Update Sucessfully');", true);                             
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
            Response.Redirect("User_login.aspx");
        }

    }

}

       