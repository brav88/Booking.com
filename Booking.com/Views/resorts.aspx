<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="resorts.aspx.cs" Inherits="Booking.com.Views.resorts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- JavaScript Bundle with Popper -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"
        integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
    <link rel="stylesheet"
        id="theme_link"
        href="https://cdnjs.cloudflare.com/ajax/libs/bootswatch/5.1.2/lux/bootstrap.min.css" />
    <title>Resorts</title>
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
                                <a class="nav-link" href="bookings.aspx">Bookings</a>
                            </li>
                            <li class="nav-item">
                                <a class="nav-link" data-bs-toggle="offcanvas" data-bs-target="#offcanvasRight" aria-controls="offcanvasRight">Login</a>
                            </li>
                        </ul>
                        <form class="d-flex">
                            <input class="form-control me-sm-2" type="text" placeholder="Search">
                            <button class="btn btn-secondary my-2 my-sm-0" type="submit">Search</button>
                        </form>
                    </div>
                </div>
            </nav>
            <div id="divAlert" runat="server" class="alert alert-dark" role="alert" hidden="hidden">
            </div>
            <div class="container">
                <asp:Repeater ID="repResort" runat="server">
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
                                <a href="book.aspx?resortId=<%# Eval("id")%>&BookingCode=0" class="btn btn-primary">Book this!</a>
                            </div>
                        </div>
                    </ItemTemplate>
                    <FooterTemplate>
                        </div>
                    </FooterTemplate>
                </asp:Repeater>
            </div>
            <div class="offcanvas offcanvas-end" tabindex="-1" id="offcanvasRight" aria-labelledby="offcanvasRightLabel">
                <div class="offcanvas-header">
                    <h5 id="offcanvasRightLabel">Log in</h5>
                    <button type="button" class="btn-close text-reset" data-bs-dismiss="offcanvas" aria-label="Close"></button>
                </div>
                <div class="offcanvas-body">
                    <div class="card" style="border-radius: 15px;">
                        <div runat="server" id="cardLogin" class="card-body">
                            <div class="form-floating mb-3">
                                <input runat="server" type="email" class="form-control" id="email" placeholder="name@example.com" value="brav850@gmail.com"/>
                                <label for="floatingInput">Email address</label>
                            </div>
                            <div class="form-floating">
                                <input runat="server" type="text" class="form-control" id="password" placeholder="Password" value="Abc123$" />
                                <label for="floatingPassword">Password</label>
                            </div>
                            <hr />
                            <button id="btnLogin" runat="server" class="btn btn-primary" style="float: right" onserverclick="Login_Click">Login</button>
                        </div>

                        <div runat="server" id="cardLogout" class="card-body" hidden="hidden">
                            <div class="form-floating">                                
                                <label runat="server" id="lblUser"></label>
                            </div>
                            <button id="btnLogout" runat="server" class="btn btn-primary" style="float: right" onserverclick="Logout_Click">LogOut</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
