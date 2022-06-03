﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="book.aspx.cs" Inherits="Booking.com.Views.book" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet"
        id="theme_link"
        href="https://cdnjs.cloudflare.com/ajax/libs/bootswatch/5.1.2/lux/bootstrap.min.css" />
    <title>Book this resort</title>
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
                    <asp:Repeater ID="repBookResort" runat="server">
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
                    </asp:Repeater>
                    <div class="card m-2" style="width: 30rem">
                        <div class="card-body">
                            <div class="row mb-2">
                                <div class="col">
                                    <h5 class="card-title">$ 125 per nigth</h5>
                                </div>
                                <div class="col">
                                    <h6 class="card-subtitle" style="float: right">4.95 * 97 reviews</h6>
                                </div>
                            </div>
                            <hr />
                            <div class="row mb-2">
                                <div class="col">
                                    Checkin
                                    <br />
                                    <input type="date" class="form-control" id="dtCheckin" />
                                </div>
                                <div class="col">
                                    Check out
                                    <br />
                                    <input type="date" class="form-control" id="dtCheckout" />
                                </div>
                            </div>
                            <div class="row mb-2">
                                <div class="col">
                                    Adults
                                    <br />
                                    <input type="number" class="form-control" id="intAdults" />
                                </div>
                                <div class="col">
                                    Kids
                                    <br />
                                    <input type="number" class="form-control" id="intKids" />
                                </div>
                            </div>
                            <div class="row mb-2">
                                <div class="col">
                                    <p style="text-align: center"><strong>No credit card needed.</strong></p>
                                </div>
                            </div>
                            <div class="row mb-2">
                                <div class="col">
                                    $125 per 5 nights
                                </div>
                                <div class="col">
                                    $1750
                                </div>
                            </div>
                            <div class="row mb-2">
                                <div class="col">
                                    Cleaning tax
                                </div>
                                <div class="col">
                                    $20
                                </div>
                            </div>
                            <div class="row mb-2">
                                <div class="col">
                                    Service tax
                                </div>
                                <div class="col">
                                    $10
                                </div>
                            </div>
                            <hr />
                            <div class="row mb-2">
                                <div class="col">
                                    <strong>Total</strong>
                                </div>
                                <div class="col">
                                    $1780
                                </div>
                            </div>
                            <hr />
                            <div class="row mb-2">
                                <div class="col">
                                    <button class="btn btn-primary" style="float: right">Book now!</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
