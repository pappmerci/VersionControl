using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance_PAY3AU.Entities;

namespace UserMaintenance_PAY3AU
{
    
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            lastNamelb.Text = Resource1.FullName;
            btnadd.Text = Resource1.Add;
            btnFile.Text = Resource1.File;
            listUsers.DataSource = users;
            listUsers.ValueMember= "ID";
            listUsers.DisplayMember = "FullName";
           

        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "Comma Seperated Values (*.csv)|*.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;
            if (sfd.ShowDialog() != DialogResult.OK) return;
            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.Default))
            {
                foreach (var u in users)
                {
                    sw.WriteLine($"{u.FullName};{u.ID}");
                }
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                FullName = textLastName.Text

            };
            users.Add(u);

        }
    }
}
