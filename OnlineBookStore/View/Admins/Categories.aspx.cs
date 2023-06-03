using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineBookStore.View.Admins
{


    public partial class Categories : System.Web.UI.Page
    {
        Models.Functions Con;

    protected void Page_Load(object sender, EventArgs e)
        {

            Con = new Models.Functions();
            ShowCategories();


        }

        private void ShowCategories()
        {
            string Query = " Select * from CategoryTbl";
            CategoriesList.DataSource = Con.GetData(Query);
            CategoriesList.DataBind();
        }

        //SAVE BUTTON CODE
            protected void savebtn_Click(object sender, EventArgs e)
            {

            
            try
            {
                if (CatNameTb.Value == " " || DescriptionTb.Value == " ")
                {
                    ErrMsg.Text = "Missing fields";

                }
                else
                {


                    string CName = CatNameTb.Value;
                    string CDesc = DescriptionTb.Value;


                    string Query = "insert  into CategoryTbl values('{0} ','{1}')";
                    Query = string.Format(Query, CName, CDesc);
                    Con.SetData(Query);
                    ShowCategories();
                    ErrMsg.Text = "CATEGORY INSERTED!!!";
                    CatNameTb.Value = "";
                    DescriptionTb.Value = "";


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
            CatNameTb.Value =     CategoriesList.SelectedRow.Cells[2].Text;
            DescriptionTb.Value = CategoriesList.SelectedRow.Cells[3].Text;
            
            if (CatNameTb.Value == "")
            {
                key = 0;

            }
            else
            {
                key = Convert.ToInt32(CategoriesList.SelectedRow.Cells[1].Text);
            }

        }

        //UPDATE BUTTON CODE
        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatNameTb.Value == " " || DescriptionTb.Value == " ")
                {
                    ErrMsg.Text = "Missing fields";

                }
                else
                {


                    string CName = CatNameTb.Value;
                    string CDesc = DescriptionTb.Value;


                    string Query = "update CategoryTbl set CatName = '{0} ',CatDescription= ' {1}' where CatId = {2} ";
                    Query = string.Format(Query,CName,CDesc, CategoriesList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowCategories();
                    ErrMsg.Text = "CATEGORY UPDATED!!!";
                    CatNameTb.Value = "";
                    DescriptionTb.Value = "";


                }

            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;

            }

        }

        //DELETE BUTTON CODE
        protected void deletebtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (CatNameTb.Value == " " || DescriptionTb.Value == " ")
                {
                    ErrMsg.Text = "Missing fields";

                }
                else
                {


                    string CName = CatNameTb.Value;
                    string CDesc = DescriptionTb.Value;


                    string Query = "delete from CategoryTbl where CatId = {0} ";
                    Query = string.Format(Query, CategoriesList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowCategories();
                    ErrMsg.Text = "CATEGORY REMOVED!!!";
                    CatNameTb.Value = "";
                    DescriptionTb.Value = "";


                }

            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;

            }

        }

    }

}