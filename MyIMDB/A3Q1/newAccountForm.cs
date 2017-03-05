using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace A3Q1
{
    public partial class newAccountForm : Form
    {
        public newAccountForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void newAccountForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (desUserTB.Text != "")
            {
                if (desPasswordTB.Text != "")
                {
                    if (desPasswordTB.Text.Length >= 8)
                    {
                        Boolean found = false;
                        string filePath = @"Resources\accountList.xml";
                        XDocument xDoc = null;
                        xDoc = XDocument.Load(filePath);
                        var titleQuery = from x in xDoc.Descendants("account")
                                         select x;

                        foreach (XElement y in titleQuery)
                        {
                            if ((y.Element("username").Value.ToString()).CompareTo(desUserTB.Text) == 0)
                            {
                                found = true;
                            }
                        }
                        if (found)
                        {
                            MessageBox.Show("Sorry, an account with that username already exists.");
                        }
                        else
                        {
                            XDocument doc = XDocument.Load(filePath);

                            XElement y = new XElement("account", new XElement("username", desUserTB.Text), new XElement("password", desPasswordTB.Text));
                            doc.Root.Add(y);
                            doc.Save(filePath);
                            MessageBox.Show("Welcome to the Movie Organizer, " + desUserTB.Text + ".");
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please ensure your password is greater than 8 characters.");
                    }
                }
                else
                {
                    MessageBox.Show("Please ensure you have filled out the  required fields.");
                }
            }
            else
            {
                MessageBox.Show("Please ensure you have filled out the required fields.");
            }
        }

        private void desPasswordTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void desUserTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                button1_Click(sender, e);
        }
    }
}
