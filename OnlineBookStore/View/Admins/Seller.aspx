<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admins/Admin.Master" AutoEventWireup="true" CodeBehind="Seller.aspx.cs" Inherits="OnlineBookStore.View.Admins.Seller" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">

     <div class="container-fluid">
      <div class="row"></div>
      <div class="col"><h2 class ="text-center">MANAGE SELLERS</h2></div>
  </div>
    <div class="row">
        <div class="col-md-4"></div>
       
        <div class="mb-3">
             <label for="" class="form-label text-success">Seller Name</label>
                 <input type="text" placeholder=" Name of seller" autocomplete="off" runat="server" id="SNameTb" class="form-control" />
                </div>
          
        <div class="mb-3">
             <label for="" class="form-label text-success">Seller's Email</label>
                 <input type="text" placeholder=" Email" autocomplete="off"   runat="server" id="EmailTb" class="form-control"  />
                </div>

          
        <div class="mb-3">
             <label for="" class="form-label text-success">Seller Phone</label>
                 <input type="text" placeholder=" Phone number" autocomplete="off"  runat="server" id="PhoneTb" class="form-control" />
                </div>

         <div class="mb-3">
             <label for="" class="form-label text-success">Seller Address</label>
                 <input type="text" placeholder=" Address" autocomplete="off"   runat="server" id="AddressTb" class="form-control" />
                </div>


        <div class="row">
          
        <asp:Label runat ="server" ID="ErrMsg" class="text-danger text-center"> </asp:Label>

        
        <div class="col d-grid"> <asp:Button text="Update" ID="EditBtn" runat="server"   Class ="btn-warning btn-block btn" OnClick="EditBtn_Click"/></div>
        <div class="col d-grid"> <asp:Button text="Save"   ID="SaveBtn" runat="server"   Class="btn-success  btn-block btn" OnClick="SaveBtn_Click"/></div>
        <div class="col d-grid"> <asp:Button text="Delete" id="DeleteBtn" runat="server"   Class="btn-danger  btn-block btn" OnClick="DeleteBtn_Click"/></div>

    </div>
    <div class ="col-md-8">
        
        <asp:GridView ID="SellerList" runat="server" class="table" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="4" GridLines="Vertical" AutoGenerateSelectButton="True" OnSelectedIndexChanged="AuthorList_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
    </div>

</asp:Content>
