using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA
{
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
            InitializeListView();


        }

        private void lstCartItems_SelectedIndexChanged(object sender, EventArgs e)
        {
         

        }
        private void Cart_load(object sender, EventArgs e)
        {
            lstCartItems.Items.Add("IronBox");
            lstCartItems.Items.Add("One Indian Girl");
            lstCartItems.Items.Add("Saree");

            rtbcartDetails.Text = "Your cart contains the following items: \n" +
                                    "1.IronBox\n" +
                                    "2. One Indian Girl\n" +
                                    "3. Saree";

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proceeding to checkout");
            this.Close();
            Application.Exit();
        }

        private void rtbcartDetails_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
  
        }
        private void InitializeListView()
        {
            listView1.Columns.Add("Available items", 100);
            listView1.Columns.Add("Quantity", 200);

            ListViewItem item1 = new ListViewItem("Iron Box");
            item1.SubItems.Add("4");
            listView1.Items.Add(item1);

            ListViewItem item2 = new ListViewItem("Kettle");
            item2.SubItems.Add("2");
            listView1.Items.Add(item2);

            ListViewItem item3 = new ListViewItem("Saree");
            item3.SubItems.Add("1");
            listView1.Items.Add(item3);

            ListViewItem item4 = new ListViewItem("Shirt");
            item4.SubItems.Add("2");
            listView1.Items.Add(item4);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
