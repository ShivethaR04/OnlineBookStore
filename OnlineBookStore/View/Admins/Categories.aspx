<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admins/Admin.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="OnlineBookStore.View.Admins.Categories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">

    <div class="container-fluid">
      <div class="row"></div>
      <div class="col"><h2
          class ="text-center">MANAGE CATEGORIES</h2></div>
  </div>
    <div class="row">
        <div class="col-md-4"></div>
       
        <div class="mb-3">
             <label for="" class="form-label text-success">Category Name</label>
                 <input type="text" placeholder=" Title" autocomplete="off" class="form-control" runat="server" id="CatNameTb"/>
                </div>

        <div class="mb-3">
             <label for="" class="form-label text-success">Category Description</label>
            <input type="text" placeholder=" Description" autocomplete="off" class="form-control" runat="server" id="DescriptionTb" />
           
                
                </div>

        <div class ="row">

        
            <asp:Label runat ="server" ID="ErrMsg" class="text-danger text-center"> </asp:Label>
       
        <div class="col d-grid"> <asp:Button text="Update" runat="server"  id="EditBtn" Class="btn-warning btn-block btn" OnClick="EditBtn_Click"/></div>
        <div class="col d-grid"> <asp:Button text="Save" runat="server" id="savebtn" Class="btn-success btn-block btn" OnClick="savebtn_Click" Width="81px"/></div>
        <div class="col d-grid"> <asp:Button text="Delete" runat="server"  id="deletebtn" Class="btn-danger  btn-block btn" OnClick="deletebtn_Click"/></div>

    </div>
    <div class ="col-md-8">
        <asp:GridView ID="CategoriesList" runat="server" class="table" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="4" GridLines="Vertical" AutoGenerateSelectButton="True" OnSelectedIndexChanged="AuthorList_SelectedIndexChanged">
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
