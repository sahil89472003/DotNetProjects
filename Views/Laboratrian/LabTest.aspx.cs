using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clinic_Management_System.Views.Laboratrian
{
    public partial class LabTest : System.Web.UI.Page
    {
        Models.Function Con;
        protected void Page_Load(object sender, EventArgs e)
        {

            Con = new Models.Function();
            ShowLabTest();
        }
        private void ShowLabTest()
        {
            string query = "Select * from LabTestTbl";
            LabTestGV.DataSource = Con.GetDatas(query);
            LabTestGV.DataBind();
        }

        public override void VerifyRenderingInServerForm(Control control)
        {

        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string LabName = LabNameTb.Value;
                string TestCost = TestCostTb.Value;
                string query = "insert into LabTestTbl values('{0}','{1}','{2}')";
                query = string.Format(query, LabName, TestCost,1);
                Con.SetDatas(query);
                ErrMsg.InnerText = "Lab Test Added..!!!";

                ShowLabTest();
                LabNameTb.Value = "";
                TestCostTb.Value = "";

            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }
        }
        int key = 0;
        protected void LabTestGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabNameTb.Value = LabTestGV.SelectedRow.Cells[2].Text;
            TestCostTb.Value = LabTestGV.SelectedRow.Cells[3].Text;
            if (LabNameTb.Value == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(LabTestGV.SelectedRow.Cells[1].Text);
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (LabNameTb.Value == "")
            {
                ErrMsg.InnerText = "Select a Laboratorian..!!!";
            }
            else
            {
                string query = "Delete from LabTestTbl where TestId={0}";
                query = string.Format(query, LabTestGV.SelectedRow.Cells[1].Text);
                Con.SetDatas(query);
                ShowLabTest();
                ErrMsg.InnerText = "Lab Test Deleted..!!!";
                key = 0;
                LabNameTb.Value = "";
                TestCostTb.Value = "";
            }
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string LabName = LabNameTb.Value;
                string TestCost = TestCostTb.Value;
                string query = "update LabTestTbl set TestName='{0}',TestCost='{1}' where TestId='{2}'";
                query = string.Format(query, LabName, TestCost);
                Con.SetDatas(query);
                ErrMsg.InnerText = "Lab Test Edited..!!!";

                ShowLabTest();
                LabNameTb.Value = "";
                TestCostTb.Value = "";

            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }
        }
    }
}