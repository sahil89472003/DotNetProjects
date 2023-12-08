<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="doctors.aspx.cs" Inherits="Clinic_Management_System.Views.Admin.doctors" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <h2>Doctors Detail</h2>
                <form>
                    <div class="mb-3">
                        <label for="exampleInputEmail1" runat="server" class="form-label">Name</label>
                        <input type="text" runat="server" class="form-control" id="DocNameTb" required="required"/>
                    </div>
                    <div class="mb-3">
                        <label for="DocPhoneTb" runat="server" class="form-label">Phone</label>
                        <input type="text" runat="server" class="form-control" id="DocPhoneTb" required="required"/>
                    </div>
                    <div class="mb-3">
                        <label for="DocPhoneTb" runat="server" class="form-label">Experience</label>
                        <input type="text" runat="server" class="form-control" id="DocExpTb" required="required"/>
                    </div>
                    <div class="mb-3">
                        <label for="SpecializationTb" runat="server" class="form-label">Specialization</label>
                        <input type="text" runat="server" class="form-control" id="SpecializationTb" required="required"/>
                    </div>
                    <div class="mb-3">
                        <label for="PasswordTb" runat="server" class="form-label">Password</label>
                        <input type="text" runat="server" class="form-control" id="PasswordTb" required="required"/>
                    </div>
                     <div class="mb-3">
                        <label for="GenderTb" runat="server" class="form-label">Gender</label>
                         <asp:DropDownList ID="GenderTb" runat="server" class="form-control">
                             <asp:ListItem>Male</asp:ListItem>
                             <asp:ListItem>Female</asp:ListItem>
                         </asp:DropDownList>
                    </div>
                    <div class="mb-3">
                        <label for="AddTb" runat="server" class="form-label">Address</label>
                        <input type="text" runat="server"  class="form-control" id="AddTb" required="required"/>
                    </div>
                    <div class="mb-3">
                        <label for="DOBTb" runat="server" class="form-label">Date of Birth</label>
                        <input type="date" runat="server" class="form-control" id="DOBTb" required="required"/>
                    </div>
                    <div class="mb-3">
                        <label for="EmailTb" runat="server" class="form-label">Email</label>
                        <input type="email" runat="server" class="form-control" id="EmailTb" required="required"/>
                    </div>
                    <label runat="server" id="ErrMsg" class="text-danger"></label><br />
                    <asp:Button ID="EditBtn" runat="server" Text="Edit" class="btn btn-warning" OnClick="EditBtn_Click" />
                    <asp:Button ID="AddBtn" runat="server" Text="Save" class="btn btn-danger" OnClick="AddBtn_Click"/>
                    <asp:Button ID="DeleteBtn" runat="server" Text="Delete" class="btn btn-primary" OnClick="DeleteBtn_Click" />

                </form>
            </div>
            <div class="col-md-8">
                <div class="row">
                    <div class="col">
                        <img src="../../Assets/Images/doctor.jpeg" height="350px" width="100%" class="rounded-3" />
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <h1>Doctor Details</h1>
                        <asp:GridView ID="DoctorGV" runat="server" class="table table-hover" AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="DocotrGV_SelectedIndexChanged">
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
