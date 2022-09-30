using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            listUsers.DataSource = users;
            listUsers.DataSource = users;
            listUsers.DisplayMember = "FullName";
            var u = new User()
            {
                FullName = textLastName.Text

            };
            users.Add(u);

        }
    }
}
