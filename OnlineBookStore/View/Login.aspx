
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OnlineBookStore.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../Assets/Lib/css/bootstrap.min.css" />

</head>
<body>
    <div class ="container-fluid">
        <div class="row mt-5 mb-54">

        </div>

        <div class="row">
            <div class ="col-md-4">

            </div>
            <div class="col-md-4">
            <form id="form1" runat="server">
                <div>

                    <div class ="row">
                        <div class="col-md-4"></div>
                        <div class="col-md-8"></div>

                    </div>

                    <!--Login book image start-->

                   <img src="../Assets/images/bookicon.jpeg"  class="align-content-center"/>
                </div>

                <!--Login book image end-->

                <div class ="mt-3">
                    <label for="" class="form-label">UserName</label>
                 <input type="email" placeholder="Enter email here" runat="server" autocomplete="off" class="form-control" id="UnameTb" />
                </div>

                <div class ="mt-3">
                    <label for="" class="form-label">Password</label>
                 <input type="password" placeholder="Enter Password" runat="server"  autocomplete="off" class="form-control" id="PasswordTb" />
                </div>

                <div class ="mt-3 d-grid">
                   <asp:Button text="Login" runat="server"  Class="btn-success btn" ID="LoginBtn" OnClick="LoginBtn_Click"/>
                </div>

            </form>
        </div>

        <div class="col-md-4">

        </div>
    </div>
        </div>
    
</body>
</html>

