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
using System.Collections;

namespace A3Q1
{
    public partial class Form1 : Form
    {
        public static string yolo;

        public static Boolean hey = false;
        public Form1()
        {
            InitializeComponent();
            DataTable table1 = new DataTable();
            if (hey)
            {
                string fbfilePath = @"Resources\fbComments.xml";
                XDocument xDoc3 = null;
                xDoc3 = XDocument.Load(fbfilePath);
                var titleQuery3 = from x in xDoc3.Descendants("comment")
                                  select x;
                //DataTable table1 = new DataTable();
                table1.Columns.Add("Social Media - What's New?");
                ArrayList newList3 = new ArrayList();
                foreach (XElement y in titleQuery3)
                {
                    if (y.Element("text") != null && !newList3.Contains(y.Element("text").Value))
                    {
                        table1.Rows.Add(y.Element("text").Value);
                        newList3.Add(y.Element("text").Value);
                    }
                }
            }
            else
            {
                //DataTable table1 = new DataTable();
                table1.Columns.Add("Social Media - What's New?");
                table1.Rows.Add("Please log in!");
                table1.Rows.Add("(In the top right corner)");

            }

            //------------------------------------------------------
            string moviesfilePath = @"Resources\movielist.xml";

            XDocument xDoc = null;
            xDoc = XDocument.Load(moviesfilePath);
            var titleQuery1 = from x in xDoc.Descendants("movie")
                             select x;

            DataTable temp1 = new DataTable();
            temp1.Columns.Add("Explore New Movies!");
            ArrayList newList = new ArrayList();
            foreach (XElement y in titleQuery1)
            {
                if (y.Element("title") != null && !newList.Contains(y.Element("title").Value))
                {
                    newList.Add(y.Element("title").Value);
                }
            }

            ArrayList newerList = new ArrayList();
            for (int i = 0; i < 20; i++)
            {
                Random rnd = new Random();
                int movie = rnd.Next(1, newList.Count - 1);

                if (!newerList.Contains(newList[movie]))
                {
                    newerList.Add(newList[movie]);
                }
                else
                {
                    while (newerList.Contains(newList[movie]))
                    {
                        movie = rnd.Next(1, newList.Count - 1);
                    }
                    newerList.Add(newList[movie]);
                }
            }
            foreach (var x in newerList)
            {
                temp1.Rows.Add(x);
            }

            /////////////////////////////////////////////////////////
            string listfilePath = @"Resources\ListOfMovies.xml";
            XDocument xDoc2 = null;
            xDoc2 = XDocument.Load(listfilePath);
            var titleQuery2 = from x in xDoc2.Descendants("list")
                             select x;
            DataTable temp = new DataTable();
            temp.Columns.Add("Your lists:");
            ArrayList newList2 = new ArrayList();
            foreach (XElement y in titleQuery2)
            {
                if (y.Element("listTitle") != null && !newList2.Contains(y.Element("listTitle").Value))
                {
                    temp.Rows.Add(y.Element("listTitle").Value);
                    newList2.Add(y.Element("listTitle").Value);
                }
            }


            dataGridView1.Width = 350;
            dataGridView1.DataSource = table1;
            dataGridView2.Width = 350;
            dataGridView2.DataSource = temp1;
            dataGridView3.Width = 350;
            dataGridView3.DataSource = temp;
            if (this.GetType() == typeof(Form1))
            {
                panel1.Visible = true;
                foreach (Control c in panel1.Controls)
                {
                    c.Visible = true;
                }
            }
            else
            {
                foreach (Control c in panel1.Controls)
                {
                    c.Visible = false;
                }
                panel1.Visible = false;
            }
            if (hey)
            {
                // toolStripButton4.Image  = null;
                toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
                toolStripButton4.Text = "logged in as " + yolo + " \n push to log out!";
            }
            else
            {
                toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.GetType() != typeof(ListPage))
            {
                ListPage lp = new ListPage();
                lp.Show();
                if (this.GetType() != typeof(Form1))
                {
                    this.Hide();
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (this.GetType() != typeof(Form1))
            {
                // panel1.Visible = true;
                //foreach (Control c in panel1.Controls)
                //{
                //  c.Visible = true;
                //}
                this.Close();
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (this.GetType() != typeof(ScatterPlot))
            {
                ScatterPlot sp = new ScatterPlot();
                sp.Show();
                if (this.GetType() != typeof(Form1))
                {
                    this.Close();
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (this.GetType() != typeof(ListPage))
            {
                ListPage lp = new ListPage();
                lp.Show();
                if (this.GetType() != typeof(Form1))
                {
                    this.Close();
                }
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (this.GetType() != typeof(search))
            {
                search s = new search();
                s.Show();
                if (this.GetType() != typeof(Form1))
                {
                    this.Close();
                }
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (this.GetType() != typeof(AdvanceSearch))
            {
                AdvanceSearch adv = new AdvanceSearch();
                adv.Show();
                if (this.GetType() != typeof(Form1))
                {
                    this.Close();
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            helpForm hf = new helpForm();
            hf.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
       {
            if (!hey)
            {
                loginPage log = new loginPage();
                log.ShowDialog();
                if (log.loggincorrect)
                    hey = true;
                if (hey)
                {
                    yolo = log.accountName;
                    if (this.GetType() == typeof(Form1))
                        this.label1.Text = "Welcome," + yolo+".";
                    // toolStripButton4.Image  = null;
                    toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
                    toolStripButton4.Text = "logged in as "+ yolo +" \n push to log out!";
                    string fbfilePath = @"Resources\fbComments.xml";
                    XDocument xDoc3 = null;
                    xDoc3 = XDocument.Load(fbfilePath);
                    var titleQuery3 = from x in xDoc3.Descendants("comment")
                                      select x;
                    //DataTable table1 = new DataTable();
                    DataTable table1 = new DataTable();
                    table1.Columns.Add("Social Media - What's New?");
                    ArrayList newList3 = new ArrayList();
                    foreach (XElement y in titleQuery3)
                    {
                        if (y.Element("text") != null && !newList3.Contains(y.Element("text").Value))
                        {
                            table1.Rows.Add(y.Element("text").Value);
                            newList3.Add(y.Element("text").Value);
                        }
                    }
                    dataGridView1.DataSource = table1;
                    // this.Update();
                }
                // if( toolStripButton4.DisplayStyle == System.Windows.Forms.ToolStripItemDisplayStyle.Text) { hey = false; }


            }
            else
            {
                MessageBox.Show("Logged out of " + yolo + "!");
                if (this.GetType() == typeof(Form1))
                    this.label1.Text = "Welcome.";
                hey = false;
                toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ListPage lp = new ListPage();
                lp.Show();
                if (this.GetType() != typeof(Form1))
                {
                    this.Hide();
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                EditMovie emov = new EditMovie(dataGridView2.SelectedCells[0].Value.ToString());
                emov.Show();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                MessageBox.Show(dataGridView1.SelectedCells[0].Value.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
