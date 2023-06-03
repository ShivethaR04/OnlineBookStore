using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineBookStore.View.Admins
{
    public partial class Author : System.Web.UI.Page
    {
        Models.Functions Con;

        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowAuthors();


        }
        private void ShowAuthors()
        {
            string Query = " Select * from AuthorTbl";
            AuthorList.DataSource = Con.GetData(Query);
            AuthorList.DataBind();

        }

        //SAVE BUTTON
        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ANameTb.Value == " " || GenCb.SelectedIndex == -1 || CountryCb.SelectedIndex == -1)
                {
                    ErrMsg.Text = "Missing fields";

                }
                else
                {


                    string AName =   ANameTb.Value;
                    string Gender =  GenCb.SelectedItem.ToString();
                    string Country = CountryCb.SelectedItem.ToString();

                    string Query = "insert  into AuthorTbl values('{0} ',' {1} ',' {2}')";
                    Query = string.Format(Query, AName, Gender, Country);
                    Con.SetData(Query);
                    ShowAuthors();
                    ErrMsg.Text = "AUTHOR INSERTED!!!";
                    ANameTb.Value = " ";
                    GenCb.SelectedIndex     = -1;
                    CountryCb.SelectedIndex = -1;

                }

            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;

            }
        }
        //Code for select option in table
        int key = 0;

        protected void AuthorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ANameTb.Value =                AuthorList.SelectedRow.Cells[2].Text;
            GenCb.SelectedItem.Value =     AuthorList.SelectedRow.Cells[3].Text;
            CountryCb.SelectedItem.Value = AuthorList.SelectedRow.Cells[4].Text;
            if (ANameTb.Value == "")
            {
                key = 0;

            }
            else
            {
                key = Convert.ToInt32(AuthorList.SelectedRow.Cells[1].Text);
            }

        }
        


        

        //UPDATE BUTTON
        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ANameTb.Value == " " || GenCb.SelectedIndex == -1 || CountryCb.SelectedIndex == -1)
                {
                    ErrMsg.Text = "Missing fields";

                }
                else
                {


                    string AName=   ANameTb.Value;
                    string Gender=  GenCb.SelectedIndex.ToString();
                    string Country= CountryCb.SelectedIndex.ToString();

                    string Query = "update  AuthorTbl set AutName='{0}', AutGender= '{1}', AutCountry='{2}' where AutId= {3}";
                    Query = string.Format(Query, AName, Gender, Country, AuthorList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowAuthors();
                    ErrMsg.Text = "UPDATED!!!";
                    ANameTb.Value = " ";
                    GenCb.SelectedIndex = -1;
                    CountryCb.SelectedIndex = -1;

                }

            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;

            }
        }

        //DELETE BUTTON
        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ANameTb.Value == " " || GenCb.SelectedIndex == -1 || CountryCb.SelectedIndex == -1)
                {
                    ErrMsg.Text = "Select an Author";

                }
                else
                {


                    string AName =   ANameTb.Value;
                    string Gender =  GenCb.SelectedIndex.ToString();
                    string Country = CountryCb.SelectedIndex.ToString();

                    string Query = "delete from  AuthorTbl  where AutId= {0}";
                    Query = string.Format(Query,AuthorList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowAuthors();
                    ErrMsg.Text = "AUTHOR DELETED!!!";
                    ANameTb.Value = " ";
                    GenCb.SelectedIndex = -1;
                    CountryCb.SelectedIndex = -1;

                }

            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;

            }

        }
    }
    }
