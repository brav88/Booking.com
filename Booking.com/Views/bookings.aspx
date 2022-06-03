<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bookings.aspx.cs" Inherits="Booking.com.Views.bookings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet"
        id="theme_link"
        href="https://cdnjs.cloudflare.com/ajax/libs/bootswatch/5.1.2/lux/bootstrap.min.css" />
    <title>My Bookings</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav class="navbar navbar-expand-lg navbar-dark bg-primary">
                <div class="container-fluid">
                    <a class="navbar-brand" href="#">Booking.com</a>
                    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarColor01" aria-controls="navbarColor01" aria-expanded="false" aria-label="Toggle navigation">
                        <span class="navbar-toggler-icon"></span>
                    </button>

                    <div class="collapse navbar-collapse" id="navbarColor01">
                        <ul class="navbar-nav me-auto">
                            <li class="nav-item">
                                <a class="nav-link" href="resorts.aspx">Resorts</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="#">Pricing</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" href="#">About</a>
                            </li>
                            <li class="nav-item dropdown">
                                <a class="nav-link dropdown-toggle" data-bs-toggle="dropdown" href="#" role="button" aria-haspopup="true" aria-expanded="false">Dropdown</a>
                                <div class="dropdown-menu">
                                    <a class="dropdown-item" href="#">Action</a>
                                    <a class="dropdown-item" href="#">Another action</a>
                                    <a class="dropdown-item" href="#">Something else here</a>
                                    <div class="dropdown-divider"></div>
                                    <a class="dropdown-item" href="#">Separated link</a>
                                </div>
                            </li>
                        </ul>
                        <form class="d-flex">
                            <input class="form-control me-sm-2" type="text" placeholder="Search">
                            <button class="btn btn-secondary my-2 my-sm-0" type="submit">Search</button>
                        </form>
                    </div>
                </div>
            </nav>
            <div class="container">
                <div class="row">
                    <asp:Repeater ID="repBooking" runat="server">
                        <ItemTemplate>
                            <div class="card m-2" style="width: 18rem;">
                                <img src="../<%# Eval("Photo")%>" class="card-img-top" style="width: 270px; height: 180px">
                                <div class="card-body">
                                    <h5 class="card-title"><%# Eval("Name")%></h5>
                                    <hr />
                                    <div class="row mb-3">
                                        <div class="col">
                                            Checkin: 
                                    <p class="card-text"><%# Eval("Checkin")%></p>
                                        </div>
                                        <div class="col">
                                            Checkout: 
                                    <p class="card-text"><%# Eval("Checkout")%></p>
                                        </div>
                                    </div>
                                    <div class="row mb-3">
                                        <div class="col">
                                            Adults: 
                                    <p class="card-text"><%# Eval("Adults")%></p>
                                        </div>
                                        <div class="col">
                                            Kids: 
                                    <p class="card-text"><%# Eval("Kids")%></p>
                                        </div>
                                    </div>
                                    <div class="row mb-3">
                                        <div class="col">
                                            Nights: 
                                    <p class="card-text"><%# Eval("Nights")%></p>
                                        </div>
                                        <div class="col">
                                            Total cost: 
                                    <p class="card-text">$<%# Eval("BookingTotalCost")%></p>
                                        </div>
                                    </div>
                                    <hr />
                                    <div class="row mb-3">
                                        <div class="col">
                                            <button class="btn btn-danger" style="float: left; width: 49%">Cancel</button>
                                            <button class="btn btn-info" style="float: right; width: 49%">Edit</button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
