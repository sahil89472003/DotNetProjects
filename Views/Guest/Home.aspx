<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Clinic_Management_System.Views.Guest.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../../lib/font-awesome/css/all.css" rel="stylesheet" />
    <title></title>
</head>
<body>
   <%-- <form id="form1" runat="server">
        <div>
        </div>
    </form>--%>

    <div class="container-fluid">
        <nav class="navbar navbar-expand-lg navbar-light bg-light">
            <div class="container-fluid">
                <a class="navbar-brand" href="#">Clinic</a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>

                <div class="collapse navbar-collapse" id="navbarSupportedContent">
                    <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                        <li class="nav-item">
                            <a class="nav-link" href="../Admin/Login.aspx">Doctors</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="../Admin/Login.aspx">Laboratorian</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="../Admin/Login.aspx">Receptionist</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="../Admin/Login.aspx">Login</a>
                        </li>
                </div>
            </div>
        </nav>

        <div class="row" style="background-image: url(../../Assets/Images/Home.png); height: 800px; background-size: cover">
            <div class="col-1"></div>
            <div class="col-md-5">
                <div class="row" style="height: 100px"></div>
                <h1>Your Health is only our Priority</h1><br />
                <p class="h4">"He who has health has hope, and he who has hope has everything."</p>
                <p class="h3"> Welcome to Health care Clinic </p><br />
                <button class="btn btn-primary">Contact us</button>
                <button class="btn border-primary text-primary bg-transparent">Feedback</button>
            </div>
        </div>
        <div class="col-md-3">

        </div>
        <div class="row bg-primary">
            <div class="row" style="height: 20px"></div>
            <div class="row">
                <div class="col-md-2 bg-light offset-1 rounded-3">
                    <div class="row">
                        <div class="col-2">
                             <a href="../../lib/font-awesome/webfonts/fa-solid-900.woff2"><i class="fa-solid fa-scissors fa-xl"></i></a>
                        </div>
                        <div class="col-7">
                            <h5 class="text-center">Surgery</h5>
                            <p class="h6 text-center">Clinic has Surgery department with Highly Experienced Surgeons</p>
                        </div>
                    </div>
                </div>

                <div class="col-md-2 bg-light offset-1 rounded-3">
                    <div class="row">
                        <div class="col-2">
                            <a href="../../lib/font-awesome/webfonts/fa-solid-900.woff2"><i class="fa-solid fa-heart-pulse fa-xl"></i></a>                        
                        </div>
                        <div class="col-7">
                            <h5 class="text-center">Urology</h5>
                            <p class="h6 text-center">Clinic has Urology department with Highly Experienced Urologist</p>
                        </div>
                    </div>
                </div>

                <div class="col-md-2 bg-light offset-1 rounded-3">
                     <div class="row">
                        <div class="col-2">
                             <a href="../../lib/font-awesome/webfonts/fa-solid-900.woff2"><i class="fa-solid fa-eye fa-xl"></i></a>
                        </div>
                        <div class="col-7">
                            <h5 class="text-center">Ophtalmology</h5>
                            <p class="h6 text-center">Clinic has Ophtalmology department with Highly Experienced Ophtalmologist</p>
                        </div>
                    </div>
                </div>

                <div class="col-md-2 bg-light offset-1 rounded-3">
                     <div class="row">
                        <div class="col-2">
                             <a href="../../lib/font-awesome/webfonts/fa-solid-900.woff2"><i class="fa-solid fa-brain fa-xl"></i></a>
                        </div>
                        <div class="col-7">
                            <h5 class="text-center">Physcology</h5>
                            <p class="h6 text-center">Clinic has Physcology department with Highly Experienced Physcologist</p>
                        </div>
                    </div>
                </div>
                <div class="col-1"></div>
            </div>
            <div class="row" style="height: 48px"></div>
        </div>
    </div>  
</body>
</html>
