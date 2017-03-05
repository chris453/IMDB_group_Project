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
using System.Collections;

namespace A3Q1
{
    public partial class searchResults : Form1
    {
        public searchResults(ArrayList x)
        { int z = 0;
            InitializeComponent();
            DataTable temp = new DataTable("newTable");
            temp.Columns.Add("Title");
            //search by title for everything years,rating
            for (int i = 0; i < x.Count; i++)
            {
                temp.Rows.Add(x[i]);
                z++;
            }
            label1.Text = "Result from Advance Search #of movies found is " + z;

            dataGridView1.DataSource = temp;
        }

        public searchResults(String textbox, string comboBox)
        {
            int zdd = 0;

            InitializeComponent();
            string filePath = @"Resources\movielist.xml";

            XDocument xDoc = null;
            xDoc = XDocument.Load(filePath);
            DataTable temp = new DataTable("newTable");

            if (comboBox.ToLower() == "year" || comboBox.ToLower() == "rating")
            {
                var genreQuerys = from x in xDoc.Descendants("movie")

                                      //where  (x.Element(comboBox) != null) && ((x.Element(comboBox.ToLower()).Value) == (textbox))
                                  select x;
                temp.Columns.Add("Title");
                foreach (XElement y in genreQuerys)
                {
                    if (y.Element(comboBox.ToLower()).Value == textbox)
                    {
                        temp.Rows.Add(
                            (y.Element("title").Value));
                        zdd++;
                    }
                }
            }
            else if (comboBox.ToLower() == "actor" || comboBox.ToLower() == "genre")
            {

                var genreQuery = from x in xDoc.Descendants("movie")

                                     //where (x.Element(comboBox.ToLower()) != null && ((x.Element(comboBox.ToLower()).Value.ToString().ToLower().IndexOf(textbox.ToLower())) > -1))
                                 select x;

                temp.Columns.Add("Title");
                foreach (XElement y in genreQuery)
                {
                    if (y.Element(comboBox.ToLower()).Value != null)
                        if (y.Elements(comboBox.ToLower()) != null)
                            foreach (XElement z in y.Elements(comboBox.ToLower()))
                                if (z.NextNode != null)
                                    if ((z.Value.ToLower()).IndexOf(textbox.ToLower()) > -1)
                                    {
                                        temp.Rows.Add(
                                             (y.Element("title").Value));
                                        zdd++;
                                    }
                                    else if (y.Element(comboBox.ToLower()).Value.IndexOf(textbox.ToLower()) > -1)
                                    {
                                        temp.Rows.Add((y.Element("title").Value));
                                        zdd++;
                                    }
                                    }

            }
            else
            {
                var genreQuery = from x in xDoc.Descendants("movie")

                                 where (x.Element(comboBox.ToLower()) != null && ((x.Element(comboBox.ToLower()).Value.ToString().ToLower().IndexOf(textbox.ToLower())) > -1))
                                 select x;

                temp.Columns.Add("Title");
                foreach (XElement y in genreQuery)
                {
                    zdd++;
                    temp.Rows.Add(
                       (y.Element("title").Value));
                }


            }
            dataGridView1.DataSource = temp;

            //   Console.Write("hey");
            label1.Text = "Search results for " + textbox + " based on parameter: " + comboBox + "  # of movies found are " + zdd;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchResults_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {






        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                EditMovie emov = new EditMovie(dataGridView1.SelectedCells[0].Value.ToString());
                emov.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            New news = new New();
            news.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedRowCount = this.dataGridView1.SelectedRows.Count;
            string movieTitle;

            while (selectedRowCount > -1)
            {

                var currentStu = this.dataGridView1.SelectedCells;

                string filePath = @"Resources\movielist.xml";//interesting error you need two xmls file 
                                                             //but what if u delete a movie from the movies.xml should u delete it from list as well? 
                                                             // var doc = XDocument.Load(filePath); XDocument xDoc = null;
                XDocument xDoc = null;
                xDoc = XDocument.Load(filePath);
                var titleQuery = from x in xDoc.Descendants("movie")
                                 select x;
                foreach (XElement y in titleQuery)
                {
                    if (y.Element("title") != null && y.Element("title").Value.CompareTo(currentStu[0].Value) == 0)
                    {
                        movieTitle = y.Element("title").Value;
                        EditMovie z = new EditMovie(movieTitle);
                        this.Close();
                        z.Show();
                    }


                }



                selectedRowCount--;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PerformAutoScale();

            int selectedRowCount = 1;//this.dataGridView1.SelectedRows.Count;
            var currentStu = this.dataGridView1.SelectedCells;

            string filePath = @"Resources\movielist.xml";
            string filePath2 = @"Resources\ListOfMovies.xml";

            var doc = XDocument.Load(filePath);
            Boolean xaaaa = false;
            Console.WriteLine(selectedRowCount);

            foreach (XElement elem in doc.Descendants("movie").ToList())
            {
                if (elem.Element("title") != null && elem.Element("title").Value.CompareTo(currentStu[0].Value) == 0)
                {
                    elem.Remove();
                }
            }
            
            var doctor = XDocument.Load(filePath2);



            foreach (XElement elem in doc.Descendants("list").ToList())
            {
                if (elem.Element("title") != null && elem.Element("title").Value.CompareTo(currentStu[0].Value) == 0)
                {
                    xaaaa = true;

                    elem.Remove();
                }
            }

            while (selectedRowCount > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                this.dataGridView1.Rows.Remove( selectedRow);
                selectedRowCount--;

            }
            selectedRowCount++;
           if(xaaaa) doctor.Save(filePath2);
            doc.Save(filePath);
            
        //     searchResults x = new searchResults(textBox1.text())
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                button2_Click(sender, e);
        }
    }
    }



