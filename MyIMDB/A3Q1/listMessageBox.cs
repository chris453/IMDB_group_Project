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
using System.IO;
using System.Collections;


namespace A3Q1
{
    public partial class listMessageBox : Form
    {
        ArrayList x = new ArrayList();
        public Boolean get = false;
        public listMessageBox()
        {
            InitializeComponent();
            label2.Text += "\n ";
            string filePath = @"Resources\ListOfMovies.xml";
            XDocument xDoc = null;
            xDoc = XDocument.Load(filePath);
            var titleQuery = from x in xDoc.Descendants("list")
                             select x;


            foreach (XElement y in titleQuery)
            {
                if (y.Element("listTitle") != null && !x.Contains(y.Element("listTitle").Value.ToString().ToLower()))
                {
                    x.Add(y.Element("listTitle").Value.ToString().ToLower());
                    label2.Text += ((y.Element("listTitle").Value) + "\n");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = @"Resources\ListOfMovies.xml";
            XDocument xDoc = null;
            xDoc = XDocument.Load(filePath);
            var titleQuery = from x in xDoc.Descendants("list")
                             select x;

            Boolean found = false;
            for (int i = x.Count-1; i >= 0 && !found; i--)
            {
                if ((textBox1.Text.ToLower()).Equals(x[i]))
                {
                    found = true;
                }
            }

            if (found == true)
            {
                MessageBox.Show("Error: A list with that name already exists.");
            }
            else
            {
                XDocument doc = XDocument.Load(filePath);

                XElement y = new XElement("list", new XElement("listTitle", textBox1.Text));
                doc.Root.Add(y);
                doc.Save(filePath);
                this.Close();
                get = true;

            }
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
