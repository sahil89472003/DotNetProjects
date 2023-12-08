using Clinic_Management_System.Views.Admin;
using Clinic_Management_System.Views.Laboratrian;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clinic_Management_System.Views.Receptionaist
{
    public partial class Patients : System.Web.UI.Page
    {
        Models.Function Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Function();
            ShowPatient();
        }
        private void ShowPatient()
        {
            string query = "Select * from PatientTbl";
            PatGV.DataSource = Con.GetDatas(query);
            PatGV.DataBind();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
        protected void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
               
                string PatName = NameTb.Value;
                string PatPhone = PhoneTb.Value;
                string PatDOB = DOBTb.Value;
                string PatAdd = AddressTb.Value;
                string PatAllergy = AllergyTb.Value;
                string query = "insert into PatientTbl values('{0}','{1}',{2},'{3}','{4}','{5}')";
                query = string.Format(query, PatName, PatPhone,  PatDOB, PatAdd, PatAllergy,1);
                Con.SetDatas(query);
                ErrMsg.InnerText = "Patient Added..!!!";

                ShowPatient();
                NameTb.Value = "";
                PhoneTb.Value = "";
                DOBTb.Value = "";
                AddressTb.Value = "";
                AllergyTb.Value = "";
                
                
            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }
        }

        int key = 0;      
        protected void PatGV_SelectedIndexChanged1(object sender, EventArgs e)
        {
            NameTb.Value = PatGV.SelectedRow.Cells[2].Text;
            PhoneTb.Value = PatGV.SelectedRow.Cells[3].Text;
            DOBTb.Value = PatGV.SelectedRow.Cells[4].Text;
            AddressTb.Value = PatGV.SelectedRow.Cells[5].Text;
            AllergyTb.Value = PatGV.SelectedRow.Cells[6].Text;
            if (NameTb.Value == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(PatGV.SelectedRow.Cells[1].Text);
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Value == "")
            {
                ErrMsg.InnerText = "Select a Patient..!!!";
            }
            else
            {
                string query = "Delete from PatientTbl where PatId={0}";
                query = string.Format(query, PatGV.SelectedRow.Cells[1].Text);
                Con.SetDatas(query);
                ErrMsg.InnerText = "Patient Deleted..!!!";
                key = 0;
                ShowPatient();
                NameTb.Value = "";
                PhoneTb.Value = "";
                DOBTb.Value = "";
                AddressTb.Value = "";
                AllergyTb.Value = "";
            }

        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string PatName = NameTb.Value;
                string PatPhone = PhoneTb.Value;
                string PatDOB = DOBTb.Value;
                string PatAdd = AddressTb.Value;
                string PatAllergy = AllergyTb.Value;
                string query = "update PatientTbl set PatName='{0}',PatPhone='{1}',PatDOB='{2}',PatAdd='{3}',PatAllergies='{4}' where PatId='{5}'";
                query = string.Format(query, PatName, PatPhone, PatDOB, PatAdd, PatAllergy, PatGV.SelectedRow.Cells[1].Text);
                Con.SetDatas(query);
                ErrMsg.InnerText = "Patient Edited..!!!";

                ShowPatient();
                NameTb.Value = "";
                PhoneTb.Value = "";
                DOBTb.Value = "";
                AddressTb.Value = "";
                AllergyTb.Value = "";
            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }
        }
    }
}