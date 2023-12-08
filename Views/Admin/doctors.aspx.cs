using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clinic_Management_System.Views.Admin
{
    public partial class doctors : System.Web.UI.Page
    {
        Models.Function Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Function();
            ShowDoctor();
        }

        private void ShowDoctor()
        {
            string query = "Select * from DoctorTbl";
            DoctorGV.DataSource = Con.GetDatas(query);
            DoctorGV.DataBind();
        }

        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                 string DocName = DocNameTb.Value;
                 string DocPhone = DocPhoneTb.Value;
                 string DocExp = DocExpTb.Value;
                 string DocSpe = SpecializationTb.Value;
                 string DocGen = GenderTb.SelectedItem.ToString();
                 string DocAdd = AddTb.Value;
                 string DocDOB = DOBTb.Value;
                 string DocPass = PasswordTb.Value;
                 string DocEmail= EmailTb.Value;
                 string query = "insert into DoctorTbl values('{0}','{1}',{2},'{3}','{4}','{5}','{6}','{7}','{8}')";
                query = string.Format(query, DocName, DocPhone, DocExp, DocSpe, DocGen, DocAdd, DocDOB, DocPass,DocEmail);
                Con.SetDatas(query);
                ErrMsg.InnerText = "Doctor Added..!!!";

                ShowDoctor();
                DocNameTb.Value = "";
                DocPhoneTb.Value = "";
                DocExpTb.Value = "";
                SpecializationTb.Value = "";
                GenderTb.SelectedIndex = -1;
                AddTb.Value = "";
                DOBTb.Value = "";
                PasswordTb.Value = "";
                EmailTb.Value = "";
            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }

        }
        int key = 0;
        protected void DocotrGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            DocNameTb.Value = DoctorGV.SelectedRow.Cells[2].Text;
            DocPhoneTb.Value = DoctorGV.SelectedRow.Cells[3].Text;
            DocExpTb.Value = DoctorGV.SelectedRow.Cells[4].Text;
            SpecializationTb.Value = DoctorGV.SelectedRow.Cells[5].Text;
            GenderTb.SelectedItem.Value = DoctorGV.SelectedRow.Cells[6].Text;
            AddTb.Value = DoctorGV.SelectedRow.Cells[7].Text;
            DOBTb.Value= DoctorGV.SelectedRow.Cells[8].Text;
            PasswordTb.Value = DoctorGV.SelectedRow.Cells[9].Text;
            EmailTb.Value = DoctorGV.SelectedRow.Cells[10].Text;

            if (DocNameTb.Value == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DoctorGV.SelectedRow.Cells[1].Text);
            }
        }
        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (DocNameTb.Value == "")
            {
                ErrMsg.InnerText = "Select a Doctor..!!!";
            }
            else
            {
                string query = "Delete from DoctorTbl where DocId={0}";
                query = string.Format(query, DoctorGV.SelectedRow.Cells[1].Text);
                Con.SetDatas(query);
                ShowDoctor();
                ErrMsg.InnerText = "Doctor Deleted..!!!";
                key = 0;
                DocNameTb.Value = "";
                DocPhoneTb.Value = "";
                DocExpTb.Value = "";
                SpecializationTb.Value = "";
                GenderTb.SelectedIndex = -1;
                AddTb.Value = "";
                DOBTb.Value = "";
                PasswordTb.Value = "";
                EmailTb.Value = "";
            }
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string DocName = DocNameTb.Value;
                string DocPhone = DocPhoneTb.Value;
                string DocExp = DocExpTb.Value;
                string DocSpe = SpecializationTb.Value;
                string DocGen = GenderTb.SelectedItem.ToString();
                string DocAdd = AddTb.Value;
                string DocDOB = DOBTb.Value;
                string DocPass = PasswordTb.Value;
                string DocEmail = EmailTb.Value;
                string query = "update DoctorTbl set DocName='{0}',DocPhone='{1}',DocExp={2},DocSpe='{3}',DocGen='{4}',DocAdd='{5}',DocDOB='{6}',DocPass='{7}',DocEmail='{8}'";
                query = string.Format(query, DocName, DocPhone, DocExp, DocSpe, DocGen, DocAdd, DocDOB, DocPass,DocEmail, DoctorGV.SelectedRow.Cells[1].Text);
                Con.SetDatas(query);
                ErrMsg.InnerText = "Doctor Edited..!!!";

                ShowDoctor();
                DocNameTb.Value = "";
                DocPhoneTb.Value = "";
                DocExpTb.Value = "";
                SpecializationTb.Value = "";
                GenderTb.SelectedIndex = -1;
                AddTb.Value = "";
                DOBTb.Value = "";
                PasswordTb.Value = "";
                EmailTb.Value = "";
            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }
        }
    }
}