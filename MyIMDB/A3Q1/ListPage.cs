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
    public partial class ListPage : Form1
    {
        public ListPage()
        {
            InitializeComponent();
            string filePath = @"Resources\ListOfMovies.xml";


            XDocument xDoc = null;
            xDoc = XDocument.Load(filePath);
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

        private void ListPage_Load(object sender, EventArgs e)
        {

        }

        private void listDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int selectedRowCount = this.listDGV.SelectedRows.Count;

            while (selectedRowCount > -1)
            {
                var currentStu = this.listDGV.SelectedCells;

                string filePath = @"Resources\ListOfMovies.xml";
                XDocument xDoc = null;
                xDoc = XDocument.Load(filePath);
                var titleQuery = from x in xDoc.Descendants("list")
                                 select x;
                DataTable temp = new DataTable("newTable");
                temp.Columns.Add("Movies");


                foreach (XElement y in titleQuery)
                {
                    if (y.Element("listTitle") != null && y.Element("listTitle").Value.CompareTo(currentStu[0].Value) == 0)
                    {
                        if (y.Element("title") != null)
                            foreach (XElement z in y.Elements("title"))
                            {
                                temp.Rows.Add(z.Value);
                            }
                    }
                }
                movieDGV.DataSource = temp;

                selectedRowCount--;

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            listMessageBox x = new listMessageBox();
            x.ShowDialog();
            //OnActivated (x.Close)

            if (x.get)
            {
                listDGV.Update();

                ListPage newPage = new ListPage();
                newPage.Show();
                this.Close();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        //DROPPING TO listDGV
        private void listDGV_DragDrop(object sender, DragEventArgs e)
        {
            // The mouse locations are relative to the screen, so they must be 
            // converted to client coordinates.
            Point clientPoint = listDGV.PointToClient(new Point(e.X, e.Y));
            XElement newElement = null;
            // If the drag operation was a copy then add the row to the other control.
            if (e.Effect == DragDropEffects.Copy)
            {
                string cellvalue = e.Data.GetData(typeof(string)) as string;
                var hittest = listDGV.HitTest(clientPoint.X, clientPoint.Y);
                if (hittest.ColumnIndex != -1 && hittest.RowIndex != -1)
                {
                    string searchParam = listDGV[hittest.ColumnIndex, hittest.RowIndex].Value.ToString();
                    //searchparem == 
                    Console.WriteLine(cellvalue + "sear parem is this" + searchParam);
                    Boolean heyy = false;
                    string filePath = @"Resources\ListOfMovies.xml";
                    XDocument xDoc2 = null;
                    xDoc2 = XDocument.Load(filePath);
                    var titleQuery2 = from x in xDoc2.Descendants("list")

                                      select x;

                    foreach (XElement m in titleQuery2)
                    {
                        if (m.Element("listTitle") != null && m.Element("title") != null &&m.Element("listTitle").Value == searchParam && m.Element("title").Value == cellvalue)
                        {
                            heyy = true;
                        }

                    }

                    if (!heyy)
                    {
                        DialogResult dialogResult = MessageBox.Show("Save changes to list?", "Save Changes", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            XElement y = new XElement("list", new XElement("listTitle", searchParam), new XElement("title",cellvalue));
                            xDoc2.Root.Add(y);
                            xDoc2.Save(filePath);
                            //xDoc2.Root.Add(cellvalue);


                          //  xDoc2.Save(filePath);
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            ListPage newPage = new ListPage();
                            newPage.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Duplicate title found in list.");
                    }
                }
            }
        }
                    /*     {
                if (m.Element("title") != null)
                {
                    Boolean found = false;
                    foreach (XElement ttl in m.Elements("title"))
                    {
                        if (!found)
                        {
                            if ((ttl.Value.ToString().CompareTo(cellvalue) == 0))
                            {
                                newElement = new XElement(m);
                                newElement.Element("listTitle").Value = searchParam;
                                found = true;
                            }
                        }
                    }
                }
            }


            //int selectedRowCount = this.listDGV.SelectedRows.Count;
            XDocument xDoc = null;
            xDoc = XDocument.Load(filePath);
            var titleQuery = from x in xDoc.Descendants("list")
                             select x;
            DataTable temp = new DataTable("newTable");
            temp.Columns.Add("Movies");

            ArrayList newList = new ArrayList();

            Boolean added = false;
            foreach (XElement y in titleQuery)
            {
                if (y.Element("listTitle") != null && y.Element("listTitle").Value.CompareTo(searchParam) == 0 && !newList.Contains(y.Element("listTitle").Value.ToString()))
                {
                    newList.Add(y.Element("listTitle").Value.ToString());
                    if (newElement != null && !added)
                    {
                        xDoc.Root.Add(newElement);
                        added = true;
                    }

                    if (y.Element("title") != null)
                    {
                        foreach (XElement z in y.Elements("title"))
                        {
                            temp.Rows.Add(z.Value);
                        }
                    }
                }
            }
            movieDGV.DataSource = temp;

            var q = from z in xDoc.Descendants("list")
                    select z;
            Boolean a = false;
            foreach (XElement m in q)
            {
                if (newElement.Element("listTitle") != null && newElement.Element("title") != null)
                {
                    if (m.Element("listTitle") != null && m.Element("title") != null)
                    {
                        if ((newElement.Element("listTitle").Value) == m.Element("listTitle").Value && m.Element("title").Value == newElement.Element("title").Value)
                        {
                            a = true;
                        }
                    }
                }

            }

            if (!a)
            {
                DialogResult dialogResult = MessageBox.Show("Save changes to list?", "Save Changes", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    xDoc.Save(filePath);
                }
                else if (dialogResult == DialogResult.No)
                {
                    ListPage newPage = new ListPage();
                    newPage.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Duplicate title found in list.");
            }

        }
    }*/
                

        //DRAGGING FROM movieDGV
        private void movieDGV_MouseDown(object sender, MouseEventArgs e)
        {
            // Get the index of the item the mouse is below.
            var hittestInfo = movieDGV.HitTest(e.X, e.Y);

            if (hittestInfo.RowIndex != -1 && hittestInfo.ColumnIndex != -1)
            {
                valueFromMouseDown = movieDGV.Rows[hittestInfo.RowIndex].Cells[hittestInfo.ColumnIndex].Value;
                if (valueFromMouseDown != null)
                {
                    // Remember the point where the mouse down occurred. 
                    // The DragSize indicates the size that the mouse can move 
                    // before a drag event should be started.                
                    Size dragSize = SystemInformation.DragSize;

                    // Create a rectangle using the DragSize, with the mouse position being
                    // at the center of the rectangle.
                    dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
                }
            }
            else
                // Reset the rectangle if the mouse is not over an item in the ListBox.
                dragBoxFromMouseDown = Rectangle.Empty;
        }

        //DROPPING TO listDGV
        private void listDGV_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        //DRAG OVER
        private void listDGV_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        //DRAG AND DROP
        private Rectangle dragBoxFromMouseDown;
        private object valueFromMouseDown;
        private void movieDGV_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown != Rectangle.Empty && !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {
                    // Proceed with the drag and drop, passing in the list item.                    
                    DragDropEffects dropEffect = movieDGV.DoDragDrop(valueFromMouseDown, DragDropEffects.Copy);
                }
            }
        }

        private void fbPB_Click(object sender, EventArgs e)
        {
            fbForm fb = new fbForm();
            fb.Show();
        }

        private void igPB_Click(object sender, EventArgs e)
        {
            igForm ig = new igForm();
            ig.Show();
        }

        private void twtrPB_Click(object sender, EventArgs e)
        {
            twtrForm twtr = new twtrForm();
            twtr.Show();
        }

        private void mailPB_Click(object sender, EventArgs e)
        {
            mailForm mail = new mailForm();
            mail.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (movieDGV.SelectedCells.Count > 0)
            {
                string filePath = @"Resources\ListOfMovies.xml";
                XDocument xDoc = null;
                xDoc = XDocument.Load(filePath);
                var titleQuery = from x in xDoc.Descendants("list")
                                 select x;
                DataTable temp = new DataTable("newTable");
                temp.Columns.Add("Movies");
                Boolean removed = false;

                for (int i = titleQuery.Count() - 1; i >= 0; i--)
                {
                    XElement y = titleQuery.ElementAt(i);
                    if (y.Element("listTitle") != null && y.Element("listTitle").Value.CompareTo(listDGV.SelectedCells[0].Value) == 0)
                    {
                        if (y.Element("title") != null)
                            if ((y.Element("title").Value.ToString()).CompareTo(movieDGV.SelectedCells[0].Value.ToString()) == 0)
                            {
                                //Console.WriteLine(y.Element("title").Value.ToString());
                                XElement newList = new XElement("list");
                                newList.Add(new XElement("listTitle", y.Element("listTitle").Value.ToString()));
                                xDoc.Root.Add(newList);
                                y.Remove();
                                removed = true;
                            }
                            else
                            {
                                temp.Rows.Add(y.Element("title").Value.ToString());
                            }
                    }
                }
                movieDGV.DataSource = temp;
                DialogResult dialogResult = MessageBox.Show("Save removal from list?", "Save Changes", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    xDoc.Save(filePath);
                }
                else if (dialogResult == DialogResult.No)
                {
                    ListPage newPage = new ListPage();
                    newPage.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Error: No movie selected to delete.");
            }
        }

        private void movieDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditMovie emov = new EditMovie(movieDGV.SelectedCells[0].Value.ToString());
            emov.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listDGV.SelectedCells.Count > 0)
            {
                string filePath = @"Resources\ListOfMovies.xml";
                string toDelete = listDGV.SelectedCells[0].Value.ToString();
                Boolean removed = false;
                XDocument xDoc = null;
                xDoc = XDocument.Load(filePath);
                var titleQuery = from x in xDoc.Descendants("list")
                                 select x;

                for (int i = titleQuery.Count() - 1; i >= 0 && !removed; i--)
                {
                    if ((titleQuery.ElementAt(i).Element("listTitle").Value.ToString()).CompareTo(toDelete) == 0)
                    {
                        titleQuery.ElementAt(i).Remove();
                    }
                }

                DialogResult dialogResult = MessageBox.Show("WARNING: This list will be removed permanently.\nContinue?", "Save Changes", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    xDoc.Save(filePath);
                    ListPage newPage = new ListPage();
                    newPage.Show();
                    this.Hide();
                }
                else if (dialogResult == DialogResult.No)
                {
                    ListPage newPage = new ListPage();
                    newPage.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Error: No list selected to delete.");
            }
        }

        private void movieDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
