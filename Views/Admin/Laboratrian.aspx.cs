using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clinic_Management_System.Views.Admin
{
    public partial class Laboratrian : System.Web.UI.Page
    {
        Models.Function Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Function();
            ShowLab();
        }
        private void ShowLab()
        {
            string query = "Select * from LaboratorianTbl";
            LaboGV.DataSource = Con.GetDatas(query);
            LaboGV.DataBind();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
        protected void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string LabName = LabNameTb.Value;
                string LabEmail = LabEmailTb.Value;
                string LabPass = PasswordTb.Value;
                string LabPhone = PhoneTb.Value;
                string LabAdd = AddressTb.Value;
                string LabGen = GenderTb.SelectedItem.ToString();
                string query = "insert into LaboratorianTbl values('{0}','{1}',{2},'{3}','{4}','{5}')";
                query=string.Format(query, LabName, LabEmail, LabPass, LabPhone, LabAdd,LabGen);
                Con.SetDatas(query);
                ErrMsg.InnerText = "Laboratorian Added..!!!";

                ShowLab();
                LabNameTb.Value = "";
                LabEmailTb.Value = "";
                PasswordTb.Value = "";
                PhoneTb.Value = "";
                AddressTb.Value = "";
                GenderTb.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }
        }

        int key = 0;
        protected void LaboGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabNameTb.Value = LaboGV.SelectedRow.Cells[2].Text;
            LabEmailTb.Value = LaboGV.SelectedRow.Cells[3].Text;
            PasswordTb.Value = LaboGV.SelectedRow.Cells[4].Text;
            PhoneTb.Value = LaboGV.SelectedRow.Cells[5].Text;
            AddressTb.Value = LaboGV.SelectedRow.Cells[6].Text;
            GenderTb.SelectedItem.Value = LaboGV.SelectedRow.Cells[7].Text;
            if (LabNameTb.Value == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(LaboGV.SelectedRow.Cells[1].Text);
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
                string query = "Delete from LaboratorianTbl where LabId={0}";
                query = string.Format(query, LaboGV.SelectedRow.Cells[1].Text);
                Con.SetDatas(query);
                ShowLab();
                ErrMsg.InnerText = "Laboratorian Deleted..!!!";
                key = 0;
                LabNameTb.Value = "";
                LabEmailTb.Value = "";
                PasswordTb.Value = "";
                PhoneTb.Value = "";
                AddressTb.Value = "";
                GenderTb.SelectedIndex = -1;
            }
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string LabName = LabNameTb.Value;
                string LabEmail = LabEmailTb.Value;
                string LabPass = PasswordTb.Value;
                string LabPhone = PhoneTb.Value;
                string LabAdd = AddressTb.Value;
                string LabGen = GenderTb.SelectedItem.ToString();
                string query = "update LaboratorianTbl set LabName='{0}',LabEmail='{1}',LabPass={2},LabPhone='{3}',LabAdd='{4}',LabGen='{5}'";
                query = string.Format(query, LabName, LabEmail, LabPass, LabPhone, LabAdd, LabGen, LaboGV.SelectedRow.Cells[1].Text);
                Con.SetDatas(query);
                ErrMsg.InnerText = "Doctor Edited..!!!";

                ShowLab();
                LabNameTb.Value = "";
                LabEmailTb.Value = "";
                PasswordTb.Value = "";
                PhoneTb.Value = "";
                AddressTb.Value = "";
                GenderTb.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }
        }
    }
}