<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Clinic_Management_System.Views.Admin.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../Libs/Bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="../../CSS/login.css"/>
</head>
<body style="background-image: url(../../Assets/Images/login.jpg); background-size: cover">


    <div class="container-fluid">
        <div class="row" style="height:120px"></div>
        <div class="row">
            <div class="col-md-4"></div>
            <div class="col-md-5 bg-light shadow-lg opacity-75 rounded-3">
                <h1 class="T pl-3 text-primary text-center">Health Care Clinic</h1>
                <form id="form1" runat="server">

                    <div class="mb-3">
                        <label for="EmailTb" class="form-label text-primary">Email address</label>
                        <input type="email" class="form-control" id="EmailTb" aria-describedby="emailHelp" placeholder="Enter email" runat="server"/>
                    </div>

                    <div class="mb-3">
                        <label for="PasswordTb" class="form-label text-primary">Password</label>
                        <input type="password" class="form-control" id="PasswordTb" placeholder="Password" runat="server"/>
                    </div>
                    <div class="mb-3">
                         <asp:DropDownList ID="RoleTb" runat="server" class="form-control">
                             <asp:ListItem>--Select Role--</asp:ListItem>
                             <asp:ListItem>Admin</asp:ListItem>
                             <asp:ListItem>Doctor</asp:ListItem>
                             <asp:ListItem>Receptionist</asp:ListItem>
                             <asp:ListItem>Laboratorian</asp:ListItem>
                         </asp:DropDownList>
                    </div>
                    <div class="d-grid">
                         <label runat="server" id="ErrMsg" class="text-danger"></label>
                    <br />
                    <asp:Button ID="LoginBtn" runat="server" Text="Login" class="btn btn-primary btn-block" OnClick="LoginBtn_Click"/>
                    </div>

                </form>
                <div class="row" style="height:10px">

                </div>
            </div>
            <div class="col-md-3"></div>
        </div>
    </div>

</body>
</html>
