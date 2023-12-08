using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clinic_Management_System.Views.Admin
{
    public partial class Login : System.Web.UI.Page
    {
        Models.Function Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Function();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            if (RoleTb.SelectedIndex == 0)
            {
                ErrMsg.InnerText = "Select a role..!";
            }
            else if (RoleTb.SelectedIndex == 1)
            {
                if (EmailTb.Value == "Admin@gmail.com" && PasswordTb.Value == "Admin")
                {
                    Response.Redirect("../Admin/doctors.aspx");
                }
                else
                {
                    ErrMsg.InnerText = "Invalid Admin";
                }
            }
            else if (RoleTb.SelectedIndex == 2)
            {
                //ErrMsg.InnerText = "Login in as Doctor..!";
                string query = "select * from DoctorTbl where DocEmail='{0}'and DocPass='{1}'";
                query = string.Format(query, EmailTb.Value, PasswordTb.Value);
                DataTable dt = Con.GetDatas(query);
                if (dt.Rows.Count == 0)
                {
                    ErrMsg.InnerText = "Invalid Doctor";
                }
                else
                {
                    string role = "Doctors";
                    Session["uid"] = dt.Rows[0][0].ToString();
                    Session["role"] = role;
                    Session.Timeout = 10;
                    string r_url = "../Doctor/prescription.aspx";
                    r_url = string.Format(r_url, role);
                    Response.Redirect(r_url);
                }
            }
            else if (RoleTb.SelectedIndex == 3)
            {
                string query = "select * from ReceptionistTbl where RecEmail='{0}'and RecPassword='{1}'";
                query = string.Format(query, EmailTb.Value, PasswordTb.Value);
                DataTable dt = Con.GetDatas(query);
                if (dt.Rows.Count == 0)
                {
                    ErrMsg.InnerText = "Invalid Receptionist";
                }
                else
                {
                    string role = "Receptionist";
                    Session["uid"] = dt.Rows[0][0].ToString();
                    Session["role"] = role;
                    Session.Timeout = 10;
                    string r_url = "../Receptionaist/Patients.aspx";
                    r_url = string.Format(r_url, role);
                    Response.Redirect(r_url);
                }
            }
            else if (RoleTb.SelectedIndex == 4)
            {
                string query = "select * from LaboratorianTbl where LabEmail='{0}'and LabPass='{1}'";
                query = string.Format(query, EmailTb.Value, PasswordTb.Value);
                DataTable dt = Con.GetDatas(query);
                if (dt.Rows.Count == 0)
                {
                    ErrMsg.InnerText = "Invalid Laboratorian";
                }
                else
                {
                    string role = "Laboratorian";
                    Session["uid"] = dt.Rows[0][0].ToString();
                    Session["role"] = role;
                    Session.Timeout = 10;
                    string r_url = "../Laboratrian/LabTest.aspx";
                    r_url = string.Format(r_url, role);
                    Response.Redirect(r_url);
                }
            }
        }
    }
}