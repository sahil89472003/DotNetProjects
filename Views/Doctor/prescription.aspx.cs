using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clinic_Management_System.Views.Doctor
{
    public partial class Doc : System.Web.UI.Page
    {
        Models.Function Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Function();
            ShowPrescription();
            getTest();
            getPatient();
        }
        private void ShowPrescription()
        {
            string query = "Select * from PrescriptionTbl";
            prescriptionGV.DataSource = Con.GetDatas(query);
            prescriptionGV.DataBind();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        private void getTest()
        {
            string query = "select * from LabTestTbl";
            TestTb.DataTextField = Con.GetDatas(query).Columns["TestName"].ToString();
            TestTb.DataValueField = Con.GetDatas(query).Columns["TestId"].ToString();
            TestTb.DataSource = Con.GetDatas(query);
            TestTb.DataBind();
        }
        private void getPatient()
        {
            string query = "select * from PatientTbl";
            PatientTb.DataTextField = Con.GetDatas(query).Columns["PatName"].ToString();
            PatientTb.DataValueField = Con.GetDatas(query).Columns["PatId"].ToString();
            PatientTb.DataSource = Con.GetDatas(query);
            PatientTb.DataBind();
        }
        
        protected void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int Doctor = 301;
                string Patient = PatientTb.SelectedValue.ToString();
                string Medicines = MedicinesTb.Value;
                string Test = TestTb.SelectedValue.ToString();
                string Cost = CostTb.Value;
                
                string query = "insert into PrescriptionTbl values('{0}','{1}','{2}','{3}','{4}')";
                query = string.Format(query, Doctor,Patient, Medicines, Test, Cost);
                Con.SetDatas(query);
                ErrMsg.InnerText = "Patient Added..!!!";

                ShowPrescription();
                PatientTb.SelectedIndex = -1;
                MedicinesTb.Value = "";
                TestTb.SelectedIndex = -1;
                CostTb.Value = "";
                

            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }
        }
    }
}