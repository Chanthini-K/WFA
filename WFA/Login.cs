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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            checkedListBoxItems.Items.Add("Give acces to contacts");
            checkedListBoxItems.Items.Add("Give access to gallery");
            checkedListBoxItems.Items.Add("Give access to messages");
          

        }

        private void label1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog1.Title = "Save a Text File";

            //show the save dialog box
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //selected file path
                String filepath = saveFileDialog1.FileName;

                //saving some text to selected file 
                System.IO.File.WriteAllText(filepath, "YOU CAN ADD YOUR INFO HERE");

                //Notify user the file has been saved
                MessageBox.Show("File saved successfully at : " + filepath);

            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //validation
            if (txtUsername.Text == "user" && txtPassword.Text == "password")
            {
                //Shopping mainform = new Shopping();
                //mainform.Show();
                //this.Hide();
            }
            else 
            {
                MessageBox.Show("Invalid username or Password ");
            }

        }

        private void dtpLoginDate_ValueChanged(object sender, EventArgs e)
        {
            dtpLoginDate.Value = DateTime.Now;
        }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Password recovery instructions sent to your mail");
        }

        private void checkBoxAgree_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAgree.Checked) 
            {
                MessageBox.Show("you agreed to the terms");
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
           
        }
    }
}
