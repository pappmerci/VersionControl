
namespace UserMaintenance_PAY3AU
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lastNamelb = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.firstNamelb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(13, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(247, 260);
            this.listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(380, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 22);
            this.textBox1.TabIndex = 1;
            // 
            // lastNamelb
            // 
            this.lastNamelb.AutoSize = true;
            this.lastNamelb.Location = new System.Drawing.Point(302, 61);
            this.lastNamelb.Name = "lastNamelb";
            this.lastNamelb.Size = new System.Drawing.Size(46, 17);
            this.lastNamelb.TabIndex = 2;
            this.lastNamelb.Text = "label1";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(305, 129);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(287, 33);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "button1";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(380, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 22);
            this.textBox2.TabIndex = 4;
            // 
            // firstNamelb
            // 
            this.firstNamelb.AutoSize = true;
            this.firstNamelb.Location = new System.Drawing.Point(302, 89);
            this.firstNamelb.Name = "firstNamelb";
            this.firstNamelb.Size = new System.Drawing.Size(46, 17);
            this.firstNamelb.TabIndex = 5;
            this.firstNamelb.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.firstNamelb);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lastNamelb);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lastNamelb;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label firstNamelb;
    }
}

