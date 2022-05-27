<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="book.aspx.cs" Inherits="Booking.com.Views.book" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../Scripts/bootstrap.bundle.min.js"></script>
    <link rel="stylesheet" href="../Content/navbar-fixed-left.min.css" />
    <title>Book this resort</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav class="navbar navbar-expand-md navbar-dark bg-primary fixed-left">
                <a class="navbar-brand m-2" href="#"><h2>Booking.com</h2></a>
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarsExampleDefault"
                    aria-controls="navbarsExampleDefault" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarsExampleDefault">
                    <ul class="navbar-nav">                                                                 
                        <li class="nav-item">
                            <a href="resorts.aspx" class="nav-link"><h4>Resorts</h4></a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link"><h4>Contact us</h4></a>
                        </li>                       
                    </ul>
                </div>
            </nav>
            <div class="container">
                <asp:Repeater ID="repBookResort" runat="server">
                    <HeaderTemplate>
                        <div class="row">
                    </HeaderTemplate>
                    <ItemTemplate>
                        <div class="card m-2" style="width: 18rem;">
                            <img src="../<%# Eval("Photo")%>" class="card-img-top" style="width: 270px; height: 180px">
                            <div class="card-body">
                                <h5 class="card-title"><%# Eval("Name")%></h5>
                                <p class="card-text"><%# Eval("Description")%></p>
                                <p class="card-text">$<%# Eval("Price")%> per night</p>
                                <a href="resorts.aspx" class="btn btn-primary">Go back</a>
                            </div>
                        </div>
                    </ItemTemplate>
                    <FooterTemplate>
                        </div>
                    </FooterTemplate>
                </asp:Repeater>
            </div>
        </div>
    </form>
</body>
</html>
