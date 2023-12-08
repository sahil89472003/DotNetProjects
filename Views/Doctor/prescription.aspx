<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Doctor/DoctorMaster.Master" AutoEventWireup="true" CodeBehind="prescription.aspx.cs" Inherits="Clinic_Management_System.Views.Doctor.Doc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
     <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <h2>Prescription Details</h2>
                <br />
                <br />
                <form>
                    <div class="mb-3">
                        <label for="PatientTb" class="form-label" runat="server">Patient</label>
                        <asp:DropDownList ID="PatientTb" runat="server" class="form-control">

                        </asp:DropDownList>
                    </div>
                    <div class="mb-3">
                        <label for="MedicinesTb" class="form-label" runat="server">Medicine</label>
                        <input type="text" class="form-control" id="MedicinesTb" runat="server" />  
                    </div>
                    <div class="mb-3">
                        <label for="TestTb" class="form-label" runat="server">LabTest</label>
                        <asp:DropDownList ID="TestTb" runat="server" class="form-control">

                        </asp:DropDownList>
                    </div>
                    <div class="mb-3">
                        <label for="CostTb" class="form-label" runat="server">Cost</label>
                        <input type="text" class="form-control" id="CostTb" runat="server" />
                    </div>
                    <div class="d-grid">
                        <label runat="server" id="ErrMsg" class="text-danger"></label>
                    <br />
                    <asp:Button ID="AddBtn" runat="server" Text="Save Prescription" class="btn btn-warning btn-block text-dark" OnClick="AddBtn_Click"/>
                    </div>
                    
                </form>
            </div>
            <div class="col-md-8">
                <div class="row">
                    <div class="col">
                        <img src="../../Assets/Images/prescription.jpg" height="350px" width="100%" class="rounded-3" />
                        
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <h1>Prescription Details</h1>
                        <asp:GridView ID="prescriptionGV" runat="server" class="table table-hover" AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" GridLines="None">
                            <AlternatingRowStyle BackColor="White" />
                            <EditRowStyle BackColor="#2461BF" />
                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EFF3FB" />
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                            <SortedDescendingHeaderStyle BackColor="#4870BE" />
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
