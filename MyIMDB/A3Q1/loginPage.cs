using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;

namespace A3Q1
{
    public partial class loginPage : Form
    {
        public string accountName;

        public Boolean loggincorrect = false;
        public loginPage()
        {
            InitializeComponent();
            passwordTB.Text = "";
            // The password character is an asterisk.
            passwordTB.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            passwordTB.MaxLength = 14;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Boolean found = false;
            Boolean passwordCorrect = false;
            string filePath = @"Resources\accountList.xml";
            XDocument xDoc = null;
            xDoc = XDocument.Load(filePath);
            var titleQuery = from x in xDoc.Descendants("account")
                             select x;

            foreach (XElement y in titleQuery)
            {
                Console.WriteLine(y.Element("username").Value.ToString());
                if ((y.Element("username").Value.ToString()).CompareTo(usernameTB.Text) == 0)
                {
                    found = true;
                    if (found && (y.Element("password").Value.ToString()).CompareTo(passwordTB.Text) == 0)
                    {
                        passwordCorrect = true;
                        accountName = usernameTB.Text;
                    }
                }
            }

            if (!found)
            {
                MessageBox.Show("Username not found or the password you entered\nwas incorrecct.\n\nDo you have caps lock enabled?");
            }
            if (found && passwordCorrect)
            {
                MessageBox.Show("Welcome back, " + accountName + ".");
                loggincorrect = true;
                this.Close();
            }
        }

        private void newAccountLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            newAccountForm newAcc = new newAccountForm();
            newAcc.Show();
        }

        private void loginPage_Load(object sender, EventArgs e)
        {

        }

        private void passwordTB_TextChanged(object sender, EventArgs e)
        {


        }
        private void InitializeMyControl()
        {
            // Set to no text.
            passwordTB.Text = "";
            // The password character is an asterisk.
            passwordTB.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            passwordTB.MaxLength = 14;
        }

        private void passwordTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                button1_Click(sender, e);
        }
    }
}
