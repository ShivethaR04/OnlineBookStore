<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admins/Admin.Master" AutoEventWireup="true" CodeBehind="Books.aspx.cs" Inherits="OnlineBookStore.View.Admins.Books" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
  <div class="container-fluid">
      <div class="row"></div>
      <div class="col"><h2 class ="text-center" >MANAGE BOOKS</h2></div>
  </div>
    <div class="row">
        <div class="col-md-4"></div>
       
        <div class="mb-3">
             <label for="" class="form-label text-success">Books Title</label>
                 <input type="text" placeholder=" Title" id="BNameTb" runat="server" autocomplete="off" class="form-control" />
                </div>

        <div class="mb-3">
             <label for="" class="form-label text-success">Books Author</label>
            <asp:DropDownList   id="BAuthCb"  runat="server" class="form-control"></asp:DropDownList>
                
                </div>

        <div class="mb-3">
             <label for="" class="form-label text-success">Categories</label>
           
            <asp:DropDownList  id="BCatCb" runat="server" class="form-control"></asp:DropDownList>
                </div>

        <div class="mb-3">
             <label for="" class="form-label text-success">Price</label>
                 <input type="text" placeholder=" Price"  id="PriceTb" runat="server" autocomplete="off" class="form-control" />
                </div>

        <div class="mb-3">
             <label for="" class="form-label text-success">Quantity</label>
                 <input type="text" placeholder=" Quantity" id="QtyTb" runat="server" autocomplete="off" class="form-control" />
                </div>

        <div class="row">
        
            <asp:Label runat ="server" ID="ErrMsg" class="text-danger text-center"> </asp:Label>

        <div class="col d-grid"> <asp:Button text="Update" runat="server"  ID="UpdateBtn" Class="btn-warning btn-block btn" OnClick="UpdateBtn_Click"/></div>
        <div class="col d-grid"> <asp:Button text="Save" runat="server"  id= "AddBtn" Class="btn-success  btn-block btn" OnClick="AddBtn_Click" Width="84px"/></div>
        <div class="col d-grid"> <asp:Button text="Delete" runat="server"  id="DeleteBtn" Class="btn-danger  btn-block btn" OnClick="DeleteBtn_Click"/></div>

    </div>
    <div class ="col-md-8">
         
        <asp:GridView ID="BooksList" runat="server" class="table" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="4" GridLines="Vertical" AutoGenerateSelectButton="True" OnSelectedIndexChanged="AuthorList_SelectedIndexChanged">
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
