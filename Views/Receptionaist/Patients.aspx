<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Receptionaist/ReceptionistMaster.Master" AutoEventWireup="true" CodeBehind="Patients.aspx.cs" Inherits="Clinic_Management_System.Views.Receptionaist.Patients" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
            <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <h2>Patient Details</h2>
                <form>
                    <div class="mb-3">
                        <label for="NameTb" class="form-label" runat="server">Name</label>
                        <input type="text" class="form-control" id="NameTb" runat="server" />
                    </div>
                    <div class="mb-3">
                        <label for="PhoneTb" class="form-label" runat="server">Phone</label>
                        <input type="text" class="form-control" id="PhoneTb" runat="server" />  
                    </div>
                    <div class="mb-3">
                        <label for="DOBTb" class="form-label" runat="server">DOB</label>
                        <input type="date" class="form-control" id="DOBTb" runat="server" />
                    </div>
                    <div class="mb-3">
                        <label for="AddressTb" class="form-label" runat="server">Address</label>
                        <input type="text" class="form-control" id="AddressTb" runat="server" />
                    </div>
                    <div class="mb-3">
                        <label for="AllergyTb" class="form-label" runat="server">Allergies</label>
                        <input type="text" class="form-control" id="AllergyTb" runat="server" />
                    </div>
                    <label runat="server" id="ErrMsg" class="text-danger"></label>
                    <br />
                    <asp:Button ID="EditBtn" runat="server" Text="Edit" class="btn btn-warning" OnClick="EditBtn_Click"/>
                    <asp:Button ID="AddBtn" runat="server" Text="Save" class="btn btn-danger" OnClick="AddBtn_Click"/>
                    <asp:Button ID="DeleteBtn" runat="server" Text="Delete" class="btn btn-primary" OnClick="DeleteBtn_Click"/>
                </form>
            </div>
            <div class="col-md-8">
                <div class="row">
                    <div class="col">
                        <img src="../../Assets/Images/patient.png" height="350px" width="100%" class="rounded-3" />
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <h1>Patient Details</h1>
                        <asp:GridView ID="PatGV" runat="server" class="table table-hover" AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="PatGV_SelectedIndexChanged1">
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
