using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA
{
    public partial class Shopping : Form
    {
        public Shopping()
        {
            InitializeComponent();
            InitializeTreeView();
            //InitilizeComboBox();
        }
        private void InitializeTreeView()
        {
            populateTreeView();

        }

        private void populateTreeView()
        {
            treeCategories.ImageList = imageList1;
            TreeNode electronicsNode = new TreeNode("Electronics");
            electronicsNode.Nodes.Add("Smartphones");
            electronicsNode.Nodes.Add("Laptops");
            electronicsNode.Nodes.Add("Headphones");

            TreeNode clothingNode = new TreeNode("Clothing");
            clothingNode.Nodes.Add("Men's clothing");
            clothingNode.Nodes.Add("Women's clothing");
            clothingNode.Nodes.Add("kids's clothing");

            TreeNode booksNode = new TreeNode("Books ");
            booksNode.Nodes.Add("Fiction");
            booksNode.Nodes.Add("NON - Fiction");
            booksNode.Nodes.Add("Children's book");

            treeCategories.Nodes.Add(electronicsNode);
            treeCategories.Nodes.Add(clothingNode);
            treeCategories.Nodes.Add(booksNode);


        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            Cart shoppingCartForm = new Cart();
            shoppingCartForm.Show();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            Cart ShoppingCartForm = new Cart();
            ShoppingCartForm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Home clicked");

        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Profile Clicked");
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logginggg  out");
            this.Close();
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("About this application");
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact us at : support@gmail.com");
        }
        private void InitilizeComboBox()
        {
            //    try
            //    {
            //        categoriesDataset = new DataSet();


            //        //create a table to hold caegory data
            //        DataTable categoriesTable = new DataTable("categories");

            //        //add columns to data table
            //        categoriesTable.Columns.Add("Category id ", typeof(int));
            //        categoriesTable.Columns.Add("CAtegory name ", typeof(string));

            //        //add sample rows to Datatable
            //        categoriesTable.Rows.Add(1, "Electronics");
            //        categoriesTable.Rows.Add(2, "Books");

            //        //add datatable to dataset
            //        categoriesDataset.Tables.Add(categoriesTable);

            //        ComboBox comboBoxCategories = this.comboBoxCategories;

            //        if (categoriesDataset.Tables.Contains("Ccategories"))
            //        {
            //            DataTable dt = categoriesDataset.Tables["Categories"];
            //            if (dt.Columns.Contains("Category ID") && dt.Columns.Contains("CategotyName"))
            //            {
            //                comboBoxCategories.DataSource = dt;
            //                comboBoxCategories.DisplayMember = "Category Name";
            //                comboBoxCategories.ValueMember = "Category ID";
            //            }
            //            else
            //            {
            //                MessageBox.Show("The required columns are missing in the data table", "Error");
            //            }
            //        }
            //        else
            //        { 
            //            MessageBox.Show("The dataTable ' category' is not found in the dataset ", "error");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"An error occured: {ex.Message}", "Error");
            //    }



        }
        
        
    }
}
