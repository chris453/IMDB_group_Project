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
    public partial class addtoListForm : Form
    {
        public addtoListForm()
        {
            InitializeComponent();
        }

        public addtoListForm(string movieTitle)
        {
            InitializeComponent();
            label2.Text = movieTitle;

            string filePath = @"Resources\ListOfMovies.xml";

            XDocument xDoc = XDocument.Load(filePath);
            var titleQuery = from x in xDoc.Descendants("list")
                             select x;
            DataTable temp = new DataTable("newTable");
            temp.Columns.Add("list Title");
            ArrayList newList = new ArrayList();
            foreach (XElement y in titleQuery)
            {
                if (!newList.Contains(y.Element("listTitle").Value))
                {
                    temp.Rows.Add(y.Element("listTitle").Value);
                    newList.Add(y.Element("listTitle").Value);
                }
            }
            listDGV.DataSource = temp;


        }

        private void listDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void listDGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Boolean ssdsdsssds = false;
            string hey = @"Resources\ListOfMovies.xml";
            XDocument super = XDocument.Load(hey);
            var xD = from sss in super.Descendants("list")
                     where (sss.Element("listTitle").Value == this.listDGV.SelectedCells[0].Value.ToString())
                     select sss;

            foreach (XElement y in xD)
            {
                if (y.Element("title") != null && y.Element("title").Value == label2.Text)
                {
                    ssdsdsssds = true;

                }
            }
            XElement theMovie = null;
            string movieTitle = label2.Text;
            string filePath = @"Resources\movielist.xml";//interesting error you need two xmls file 
                                                         //but what if u delete a movie from the movies.xml should u delete it from list as well? 
                                                         // var doc = XDocument.Load(filePath);                XDocument xDoc = null;
            XDocument xDoc = null;
            xDoc = XDocument.Load(filePath);
            var titleQuery = from x in xDoc.Descendants("movie")
                             where x.Element("title") != null && x.Element("title").Value.CompareTo(movieTitle) == 0
                             select x;
            foreach (XElement y in titleQuery)
            {
                //Got the movie...
                XName listName = "listTitle";
                theMovie = new XElement("list");
                XElement newListName = new XElement(listName, this.listDGV.SelectedCells[0].Value.ToString());
                theMovie.Add(newListName);
                //Console.WriteLine(theMovie);
                if (y.Element("title") != null)
                {
                    XElement title = new XElement("title", y.Element("title").Value.ToString());
                    theMovie.Add(title);
                }
                if (y.Element("year") != null)
                {
                    XElement year = y.Element("year");
                    theMovie.Add(year);
                }
                if (y.Element("length") != null)
                {
                    theMovie.Add(y.Element("length"));
                }
                if (y.Element("certification") != null)
                {
                    theMovie.Add(y.Element("certification"));
                }
                if (y.Element("director") != null)
                {
                    theMovie.Add(y.Element("director"));
                }
                if (y.Element("rating") != null)
                {
                    theMovie.Add(y.Element("rating"));
                }
                if (y.Element("genre") != null)
                {
                    foreach (XElement z in y.Elements("genre"))
                    {
                        theMovie.Add(z);
                    }
                }
                if (y.Element("actor") != null)
                {
                    foreach (XElement z in y.Elements("actor"))
                    {
                        theMovie.Add(z);
                    }
                }
                filePath = @"Resources\ListOfMovies.xml";
                xDoc = XDocument.Load(filePath);
                xDoc.Root.Add(theMovie);
                //Boolean hey = false;
                //var xD = from z in xDoc.Descendants("list")
                //       select z;
                //foreach (XElement mrss in xD) {
                //   if(theMovie.Element("listTitle").Value ==  mrss.Element("listTitle").Value && mrss.Element("title").Value == theMovie.Element("title)").Value){
                //     hey = true;
                //}

            }
            DialogResult dialogResult = MessageBox.Show("Save addition to list?", "Save Changes", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            { //{if (!hey)
                if (!ssdsdsssds)
                {
                    xDoc.Save(filePath);
                    this.Close();
                }
                else MessageBox.Show("Duplicate title found");
            }
            else if (dialogResult == DialogResult.No)
            {
                //ListPage newPage = new ListPage();
                //newPage.Show();
                this.Close();
            }
        }
    }
}

