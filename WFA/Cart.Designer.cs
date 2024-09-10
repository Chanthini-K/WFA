namespace WFA
{
    partial class Cart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstCartItems = new System.Windows.Forms.ListBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.rtbcartDetails = new System.Windows.Forms.RichTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lstCartItems
            // 
            this.lstCartItems.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstCartItems.FormattingEnabled = true;
            this.lstCartItems.Items.AddRange(new object[] {
            "Iron Box                          -----------> 1",
            "Saree                               -----------> 3",
            "One Indian Girl              -----------> 1",
            "Kettle                              -----------> 4",
            "Shirt                                ----------->7"});
            this.lstCartItems.Location = new System.Drawing.Point(546, 108);
            this.lstCartItems.Name = "lstCartItems";
            this.lstCartItems.Size = new System.Drawing.Size(200, 95);
            this.lstCartItems.TabIndex = 0;
            this.lstCartItems.SelectedIndexChanged += new System.EventHandler(this.lstCartItems_SelectedIndexChanged);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCheckout.Location = new System.Drawing.Point(338, 355);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(144, 23);
            this.btnCheckout.TabIndex = 1;
            this.btnCheckout.Text = "Click to checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // rtbcartDetails
            // 
            this.rtbcartDetails.AcceptsTab = true;
            this.rtbcartDetails.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rtbcartDetails.Location = new System.Drawing.Point(546, 251);
            this.rtbcartDetails.Name = "rtbcartDetails";
            this.rtbcartDetails.Size = new System.Drawing.Size(215, 68);
            this.rtbcartDetails.TabIndex = 2;
            this.rtbcartDetails.Text = "Comment Here...........\n\n";
            this.rtbcartDetails.TextChanged += new System.EventHandler(this.rtbcartDetails_TextChanged);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(84, 96);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(343, 223);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(559, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Cart Items";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.Location = new System.Drawing.Point(110, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Available ";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.rtbcartDetails);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.lstCartItems);
            this.Name = "Cart";
            this.Text = "Cart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCartItems;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.RichTextBox rtbcartDetails;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}