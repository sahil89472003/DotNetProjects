using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clinic_Management_System.Views.Admin
{
    public partial class Receptionist : System.Web.UI.Page
    {
        Models.Function Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Function();
            ShowReceptionist();
        }

        public override void VerifyRenderingInServerForm(Control control)
        {
            
        }

        private void ShowReceptionist()
        {
            string query = "Select * from ReceptionistTbl";
            ReceptionistGV.DataSource = Con.GetDatas(query);
            ReceptionistGV.DataBind();
        }
        protected void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string RName = RecNameTb.Value;
                string REmail = RecEmailTb.Value;
                string RAdd = AddressTb.Value;
                string RPhone = PhoneTb.Value;
                string RPassword = PasswordTb.Value;
                string query = "insert into ReceptionistTbl values('{0}','{1}','{2}','{3}','{4}')";
                query = string.Format(query, RName, REmail, RAdd, RPhone, RPassword);
                Con.SetDatas(query);
                ErrMsg.InnerText = "Receptionist Added..!!!";

                ShowReceptionist();
                 RecNameTb.Value="";
                 RecEmailTb.Value = "";
                 AddressTb.Value = "";
                 PhoneTb.Value = "";
                 PasswordTb.Value = "";
            }
            catch (Exception ex) 
            {
                ErrMsg.InnerText = ex.Message;
            }
        }
        int key = 0;
        protected void ReceptionistGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecNameTb.Value = ReceptionistGV.SelectedRow.Cells[2].Text;
            RecEmailTb.Value= ReceptionistGV.SelectedRow.Cells[3].Text;
            AddressTb.Value = ReceptionistGV.SelectedRow.Cells[4].Text;
            PhoneTb.Value = ReceptionistGV.SelectedRow.Cells[5].Text;
            PasswordTb.Value = ReceptionistGV.SelectedRow.Cells[6].Text;

            if(RecNameTb.Value=="" )
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(ReceptionistGV.SelectedRow.Cells[1].Text);
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (RecNameTb.Value == "")
            {
                ErrMsg.InnerText = "Select a Receptionist..!!!";
            }
            else
            {
                string query = "Delete from ReceptionistTbl where RecId={0}";
                query = string.Format(query, ReceptionistGV.SelectedRow.Cells[1].Text);
                Con.SetDatas(query);
                ShowReceptionist();
                ErrMsg.InnerText = "Receptionist Deleted..!!!";
                key =0;
                RecNameTb.Value = "";
                RecEmailTb.Value = "";
                AddressTb.Value = "";
                PhoneTb.Value = "";
                PasswordTb.Value = "";
            }
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string RName = RecNameTb.Value;
                string REmail = RecEmailTb.Value;
                string RAdd = AddressTb.Value;
                string RPhone = PhoneTb.Value;
                string RPassword = PasswordTb.Value;
                string query = "update ReceptionistTbl set RecName='{0}',RecEmail='{1}',RecAdd='{2}',RecPhone='{3}',RecPassword='{4}' where RecId={5}";
                query = string.Format(query, RName, REmail, RAdd, RPhone, RPassword, ReceptionistGV.SelectedRow.Cells[1].Text);
                Con.SetDatas(query);
                ErrMsg.InnerText = "Receptionist Edited..!!!";

                ShowReceptionist();
                RecNameTb.Value = "";
                RecEmailTb.Value = "";
                AddressTb.Value = "";
                PhoneTb.Value = "";
                PasswordTb.Value = "";
            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }

        }
    }
}