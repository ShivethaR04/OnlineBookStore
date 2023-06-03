using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineBookStore.View.Admins
{
    public partial class Books : System.Web.UI.Page
    {
        Models.Functions Con;
        
        protected void Page_Load(object sender, EventArgs e)
        {
Con = new Models.Functions();

            if (!IsPostBack)
            {
                //Functions to be shown on Manage Books Page

                ShowBooks();
                GetCategories();
                GetAuthors();



            }
            ShowBooks();

        }
        private void ShowBooks()
        {
            //Shows books that are stored in database

            string Query = " Select * from BookTbl";
            BooksList.DataSource = Con.GetData(Query);
            BooksList.DataBind();
        }

        private void GetCategories()
        {
            //Shows categories from database

            string Query = "select *from CategoryTbl";
            BCatCb.DataTextField =  Con.GetData(Query).Columns["CatName"].ToString();
            BCatCb.DataValueField = Con.GetData(Query).Columns["CatId"].ToString();
            BCatCb.DataSource =     Con.GetData(Query);
            BCatCb.DataBind();


        }
        private void GetAuthors()
        {
            //Shows authors from database

            string Query = "select *from AuthorTbl";
            BAuthCb.DataTextField =  Con.GetData(Query).Columns["AutName"].ToString();
            BAuthCb.DataValueField = Con.GetData(Query).Columns["AutId"].ToString();
            BAuthCb.DataSource =     Con.GetData(Query);
            BAuthCb.DataBind();


        }

        //SAVE BUTTON CODE

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (BNameTb.Value == " " || BAuthCb.SelectedIndex == -1|| BCatCb.SelectedIndex == -1|| QtyTb.Value == " " || PriceTb.Value==" ")
                {
                    ErrMsg.Text = "Missing fields";

                }
                else
                {


                    string BName =     BNameTb.Value;
                    string BAuth =     BAuthCb.SelectedValue.ToString();
                    string BCategory = BCatCb.SelectedValue.ToString();
                    int Quantity = Convert.ToInt32(QtyTb.Value);
                    int Price =    Convert.ToInt32(PriceTb.Value);



                    string Query = "insert  into BookTbl values('{0}' ,{1}, {2} ,{3},{4})";  //inserts code into database
                    Query = string.Format(Query, BName, BAuth, BCategory, Quantity, Price);
                    Con.SetData(Query);
                    ShowBooks();
                    ErrMsg.Text = "BOOK INSERTED!!!";
                    BNameTb.Value = "";
                    BAuthCb.SelectedIndex = -1;
                    BCatCb.SelectedIndex = -1;
                    QtyTb.Value = "";
                    PriceTb.Value = " "; 
                    


                }

            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;

            }


        }
        int key = 0;

        //Code for select in table
        protected void AuthorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            BNameTb.Value =         BooksList.SelectedRow.Cells[2].Text;
            BAuthCb.SelectedValue = BooksList.SelectedRow.Cells[3].Text;
            BCatCb.SelectedValue =  BooksList.SelectedRow.Cells[4].Text;
            QtyTb.Value =           BooksList.SelectedRow.Cells[5].Text;
            PriceTb.Value =         BooksList.SelectedRow.Cells[6].Text;
            if (BNameTb.Value == "")
            {
                key = 0;

            }
            else
            {
                key = Convert.ToInt32(BooksList.SelectedRow.Cells[1].Text);
            }

        }


        //DELETE BUTTON CODE
        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (BNameTb.Value == " " || BAuthCb.SelectedIndex == -1 || BCatCb.SelectedIndex == -1 || QtyTb.Value == " " || PriceTb.Value == " ")
                {
                    ErrMsg.Text = "Missing fields";

                }
                else
                {


                    string BName =     BNameTb.Value;
                    string BAuth =     BAuthCb.SelectedValue.ToString();
                    string BCategory = BCatCb.SelectedValue.ToString();
                    int Quantity = Convert.ToInt32(QtyTb.Value);
                    int Price = Convert.ToInt32(PriceTb.Value);



                    string Query = "delete BookTbl  where BId={0}";
                    Query = string.Format(Query,BooksList.SelectedRow.Cells[2].Text);
                    Con.SetData(Query);
                    ShowBooks();
                    ErrMsg.Text = "BOOK DELETED!!!";
                    BNameTb.Value = "";
                    BAuthCb.SelectedIndex = -1;
                    BCatCb.SelectedIndex = -1;
                    QtyTb.Value = "";
                    PriceTb.Value = " ";



                }

            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;

            }
        }
    

        //UPDATE BUTTON CODE
        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (BNameTb.Value == " " || BAuthCb.SelectedIndex == -1 || BCatCb.SelectedIndex == -1 || QtyTb.Value == " " || PriceTb.Value == " ")
                {
                    ErrMsg.Text = "Missing fields";

                }
                else
                {


                    string BName =     BNameTb.Value;
                    string BAuth =     BAuthCb.SelectedValue.ToString();
                    string BCategory = BCatCb.SelectedValue.ToString();
                    int Quantity = Convert.ToInt32(QtyTb.Value);
                    int Price = Convert.ToInt32(PriceTb.Value);



                    string Query = "update BookTbl set BName= '{0}' ,BAuthor={1},Bcategory ={2} , BQty={3},BPrice={4} where BId={5)";
                    Query = string.Format(Query, BName, BAuth, BCategory, Quantity, Price, BooksList.SelectedRow.Cells[2].Text);
                    Con.SetData(Query);
                    ShowBooks();
                    ErrMsg.Text = "BOOK UPDATED!!!";
                    BNameTb.Value = "";
                    BAuthCb.SelectedIndex = -1;
                    BCatCb.SelectedIndex = -1;
                    QtyTb.Value = "";
                    PriceTb.Value = " ";



                }

            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;

            }

        }
    }
}