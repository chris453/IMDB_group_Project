using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace A3Q1
{
    public partial class ScatterPlot : Form1
    {
        public ScatterPlot()
        {
            InitializeComponent();
            lengthCB.Text = "=";
            certificationCB.Text = " ";
            numItemsLabel.Text = "Number of movies shown: 0";
            /*
            string filePath = @"Resources\movielist.xml";
            XDocument xDoc = null;
            xDoc = XDocument.Load(filePath);
            var titleQuery = from x in xDoc.Descendants("movie")
                             select x;
            foreach (XElement y in titleQuery)
            {
                scatterChart.Series[y.Element("genre").Value.ToString().ToLower()].Points.AddXY(int.Parse(y.Element("year").Value), int.Parse(y.Element("rating").Value));
            }
            */

        }

        private void drawPlot(string parameter, string value)
        {
            int numItems = 0;

            //Clear the old data
            foreach (var series in scatterChart.Series)
            {
                series.Points.Clear();
            }

            scatterChart.Annotations.Clear();
            warningLabel.Visible = false;

            int year1;
            int year2;
            string filePath = @"Resources\movielist.xml";

            if ((parameter.ToLower()).CompareTo("year") == 0)
            {
                int number;
                if ((int.TryParse(year1TB.Text, out number) == true) && int.TryParse(year2TB.Text, out number) == true)
                    { 
                year1 = int.Parse(year1TB.Text);
                year2 = int.Parse(year2TB.Text);

                XDocument xDoc = null;
                xDoc = XDocument.Load(filePath);
                var titleQuery = from x in xDoc.Descendants("movie")
                                 select x;
                    foreach (XElement y in titleQuery)
                    {
                        if ((int.Parse((y.Element(parameter.ToLower()).Value)) >= year1
                                     && (int.Parse((y.Element(parameter.ToLower()).Value)) <= year2)))
                        {
                            TextAnnotation newAnnot = new TextAnnotation();
                            newAnnot.Name = y.Element("title").Value.ToString();
                            newAnnot.Text = y.Element("title").Value.ToString();
                            newAnnot.ToolTip = y.Element("title").Value.ToString();
                            newAnnot.Visible = true;
                            newAnnot.AnchorX = (int.Parse(y.Element("year").Value));
                            newAnnot.AnchorY = (int.Parse(y.Element("rating").Value));
                            if (scatterChart.Annotations.FindByName(y.Element("title").Value.ToString()) == null)
                            {
                                scatterChart.Annotations.Add(newAnnot);
                            }
                            numItems++;
                            scatterChart.Series[y.Element("genre").Value.ToString().ToLower()].Points.AddXY(int.Parse(y.Element("year").Value), int.Parse(y.Element("rating").Value));
                        }
                    }
                    }
            }
            else if ((parameter.ToLower()).CompareTo("certification") == 0)
            {
                XDocument xDoc = null;
                xDoc = XDocument.Load(filePath);
                var titleQuery = from x in xDoc.Descendants("movie")
                                 where (x.Element(parameter) != null)
                                 select x;
                foreach (XElement y in titleQuery)
                {
                    if ((y.Element(parameter).Value.ToString()).CompareTo(certificationCB.Text) == 0)
                    {
                        TextAnnotation newAnnot = new TextAnnotation();
                        newAnnot.Name = y.Element("title").Value.ToString();
                        newAnnot.Text = y.Element("title").Value.ToString();
                        newAnnot.ToolTip = y.Element("title").Value.ToString();
                        newAnnot.Visible = true;
                        newAnnot.AnchorX = (int.Parse(y.Element("year").Value));
                        newAnnot.AnchorY = (int.Parse(y.Element("rating").Value));
                        if (scatterChart.Annotations.FindByName(y.Element("title").Value.ToString()) == null)
                            scatterChart.Annotations.Add(newAnnot);
                        scatterChart.Series[y.Element("genre").Value.ToString().ToLower()].Points.AddXY(int.Parse(y.Element("year").Value), int.Parse(y.Element("rating").Value));
                        numItems++;
                    }
                    }
            }
            else if ((parameter.ToLower().CompareTo("director") == 0))
            {
                XDocument xDoc = null;
                xDoc = XDocument.Load(filePath);
                var titleQuery = from x in xDoc.Descendants("movie")
                                 where (x.Element(parameter) != null)
                                 select x;

                foreach (XElement y in titleQuery)
                {
                    Boolean found = false;
                    string[] directorFindArray = directorTB.Text.ToLower().Split(' ');
                    string[] directorArray = (y.Element("director").Value.ToString().ToLower().Split(' '));

                    for (int i = 0; i < directorArray.Length && !found; i++)
                    {
                        for (int j = 0; j < directorFindArray.Length && !found; j++)
                        {
                            if ((directorFindArray[j].CompareTo(directorArray[i]) == 0) || (directorArray[i].Contains(directorFindArray[j]) == true))
                                found = true;
                        }
                    }

                    if (found)
                    {
                        TextAnnotation newAnnot = new TextAnnotation();
                        newAnnot.Name = y.Element("title").Value.ToString();
                        newAnnot.Text = y.Element("title").Value.ToString();
                        newAnnot.ToolTip = y.Element("title").Value.ToString();
                        newAnnot.Visible = true;
                        newAnnot.AnchorX = (int.Parse(y.Element("year").Value));
                        newAnnot.AnchorY = (int.Parse(y.Element("rating").Value));
                        if (scatterChart.Annotations.FindByName(y.Element("title").Value.ToString()) == null)
                            scatterChart.Annotations.Add(newAnnot);
                        numItems++;
                        scatterChart.Series[y.Element("genre").Value.ToString().ToLower()].Points.AddXY(int.Parse(y.Element("year").Value), int.Parse(y.Element("rating").Value));
                    }
                }
            }
            else if ((parameter.ToLower()).CompareTo("genre") == 0)
            {
                XDocument xDoc = null;
                xDoc = XDocument.Load(filePath);
                var titleQuery = from x in xDoc.Descendants("movie")
                                 where (x.Element(parameter) != null)
                                 select x;

                foreach (XElement y in titleQuery)
                {
                    if ((y.Element("genre").Value.ToString().ToLower().CompareTo(genreCB.Text.ToString().ToLower()) == 0))
                    {
                        TextAnnotation newAnnot = new TextAnnotation();
                        newAnnot.Name = y.Element("title").Value.ToString();
                        newAnnot.Text = y.Element("title").Value.ToString();
                        newAnnot.ToolTip = y.Element("title").Value.ToString();
                        newAnnot.Visible = true;
                        newAnnot.AnchorX = (int.Parse(y.Element("year").Value));
                        newAnnot.AnchorY = (int.Parse(y.Element("rating").Value));
                        if (scatterChart.Annotations.FindByName(y.Element("title").Value.ToString()) == null)
                            scatterChart.Annotations.Add(newAnnot);
                        numItems++;
                        scatterChart.Series[y.Element("genre").Value.ToString().ToLower()].Points.AddXY(int.Parse(y.Element("year").Value), int.Parse(y.Element("rating").Value));
                    }
                }
            }
            else
            {
                XDocument xDoc = null;
                xDoc = XDocument.Load(filePath);
                var titleQuery = from x in xDoc.Descendants("movie")
                                 where x.Element(parameter.ToLower()) != null && ((x.Element(parameter.ToLower()).Value.ToString().ToLower().IndexOf(value.ToLower())) > -1)
                                 select x;
                foreach (XElement y in titleQuery)
                {
                    TextAnnotation newAnnot = new TextAnnotation();
                    newAnnot.Name = y.Element("title").Value.ToString();
                    newAnnot.Text = y.Element("title").Value.ToString();
                    newAnnot.ToolTip = y.Element("title").Value.ToString();
                    newAnnot.Visible = true;
                    newAnnot.AnchorX = (int.Parse(y.Element("year").Value));
                    newAnnot.AnchorY = (int.Parse(y.Element("rating").Value));
                    if (scatterChart.Annotations.FindByName(y.Element("title").Value.ToString()) == null)
                        scatterChart.Annotations.Add(newAnnot);
                    numItems++;
                    scatterChart.Series[y.Element("genre").Value.ToString().ToLower()].Points.AddXY(int.Parse(y.Element("year").Value), int.Parse(y.Element("rating").Value));
                }
                xTrackBar.Value = 10;
                yTrackBar.Value = 10;
            }

            if (scatterChart.Annotations.Count < 40)
            {

                foreach (Annotation text in scatterChart.Annotations)
                {
                    text.AxisX = scatterChart.ChartAreas[0].AxisX;
                    text.AxisY = scatterChart.ChartAreas[0].AxisY;
                }
            }
            else
            {
                warningLabel.Visible = true;
            }

            numItemsLabel.Text = "Number of movies shown: " + numItems.ToString();
        }//drawPlot

        private void genreCB_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Draw the background 
            e.DrawBackground();

            // Get the item text    
            string text = "";
            if (e.Index > 0)
            {
                text = ((ComboBox)sender).Items[e.Index].ToString();
            }
            else text = "Genre";

            // Determine the forecolor based on whether or not the item is selected    
            Brush brush;

            if (text.CompareTo("Horror") == 0)
            {
                brush = Brushes.Red;
            }
            else if (text.CompareTo("Genre") == 0)
            {
                brush = Brushes.Black;
            }
            else if (text.CompareTo("Action") == 0)
            {
                brush = Brushes.Orange;
            }
            else if (text.CompareTo("Adventure") == 0)
            {
                brush = Brushes.Green;
            }
            else if (text.CompareTo("Crime") == 0)
            {
                brush = Brushes.Gray;
            }
            else if (text.CompareTo("Western") == 0)
            {
                brush = Brushes.Brown;
            }
            else if (text.CompareTo("Mystery") == 0)
            {
                brush = Brushes.Purple;
            }
            else if (text.CompareTo("Sport") == 0)
            {
                brush = Brushes.Blue;
            }
            else if (text.CompareTo("Biography") == 0)
            {
                brush = Brushes.SandyBrown;
            }
            else if (text.CompareTo("Romance") == 0)
            {
                brush = Brushes.DeepPink;
            }
            else if (text.CompareTo("Family") == 0)
            {
                brush = Brushes.Pink;
            }
            else if (text.CompareTo("Short") == 0)
            {
                brush = Brushes.Violet;
            }
            else if (text.CompareTo("Sci-Fi") == 0)
            {
                brush = Brushes.Blue;
            }
            else if (text.CompareTo("Thriller") == 0)
            {
                brush = Brushes.Yellow;
            }
            else if (text.CompareTo("Drama") == 0)
            {
                brush = Brushes.DarkOrchid;
            }
            else if (text.CompareTo("Comedy") == 0)
            {
                brush = Brushes.Magenta;
            }
            else if (text.CompareTo("Fantasy") == 0)
            {
                brush = Brushes.DarkSeaGreen;
            }
            else if (text.CompareTo("Animation") == 0)
            {
                brush = Brushes.Lime;
            }
            else if (text.CompareTo("Film-Noir") == 0)
            {
                brush = Brushes.Black;
            }
            else if (text.CompareTo("Adult") == 0)
            {
                brush = Brushes.Linen;
            }
            else if (text.CompareTo("Musical") == 0)
            {
                brush = Brushes.LightSteelBlue;
            }
            else if (text.CompareTo("Music") == 0)
            {
                brush = Brushes.LightSkyBlue;
            }
            else
            {
                brush = Brushes.Khaki;
            }

            // Draw the text    
            e.Graphics.DrawString(text, ((Control)sender).Font, brush, e.Bounds.X, e.Bounds.Y);
        }

        private void titleSearch_Click(object sender, EventArgs e)
        {
            string parameter = "title";
            string value = titleTB.Text.ToLower();
            drawPlot(parameter, value);
        }

        private void directorSearch_Click(object sender, EventArgs e)
        {
            string parameter = "director";
            string value = directorTB.Text.ToLower();
            drawPlot(parameter, value);
        }

        private void certificationSearch_Click(object sender, EventArgs e)
        {
            string parameter = "certification";
            string value = certificationCB.Text.ToLower();
            drawPlot(parameter, value);
        }

        private void genreSearch_Click(object sender, EventArgs e)
        {
            string parameter = "genre";
            string value = genreCB.Text.ToLower();
            drawPlot(parameter, value);
        }

        private void yearSearch_Click(object sender, EventArgs e)
        {
            string parameter = "year";
            string value = null;
            drawPlot(parameter, value);
        }

        private void lengthSearch_Click(object sender, EventArgs e)
        {
            int numItems = 0;
            //Clear the old data
            foreach (var series in scatterChart.Series)
            {
                series.Points.Clear();
            }
            scatterChart.Annotations.Clear();
            warningLabel.Visible = false;

            int number;
            if (int.TryParse(lengthTB.Text.ToString(), out number) == true)
            {
                string filePath = @"Resources\movielist.xml";
                int length = int.Parse(lengthTB.Text);

                string[] movieVals = new string[2];

                if (lengthCB.Text.CompareTo("=") == 0)
                {
                    XDocument xDoc = null;
                    xDoc = XDocument.Load(filePath);
                    var titleQuery = from x in xDoc.Descendants("movie")
                                     select x;
                    foreach (XElement y in titleQuery)
                    {
                        movieVals = (y.Element("length").Value.ToString()).Split(' ');
                        if (int.Parse(movieVals[0]) == length)
                        {
                            TextAnnotation newAnnot = new TextAnnotation();
                            newAnnot.Name = y.Element("title").Value.ToString();
                            newAnnot.Text = y.Element("title").Value.ToString();
                            newAnnot.ToolTip = y.Element("title").Value.ToString();
                            newAnnot.Visible = true;
                            newAnnot.AnchorX = (int.Parse(y.Element("year").Value));
                            newAnnot.AnchorY = (int.Parse(y.Element("rating").Value));
                            if (scatterChart.Annotations.FindByName(y.Element("title").Value.ToString()) == null)
                                scatterChart.Annotations.Add(newAnnot);
                            numItems++;
                            scatterChart.Series[y.Element("genre").Value.ToString().ToLower()].Points.AddXY(int.Parse(y.Element("year").Value), int.Parse(y.Element("rating").Value));
                        }
                    }
                }
                else if (lengthCB.Text.CompareTo("<") == 0)
                {
                    XDocument xDoc = null;
                    xDoc = XDocument.Load(filePath);
                    var titleQuery = from x in xDoc.Descendants("movie")
                                     select x;
                    foreach (XElement y in titleQuery)
                    {
                        movieVals = (y.Element("length").Value.ToString()).Split(' ');
                        if (int.Parse(movieVals[0]) < length)
                        {
                            TextAnnotation newAnnot = new TextAnnotation();
                            newAnnot.Name = y.Element("title").Value.ToString();
                            newAnnot.Text = y.Element("title").Value.ToString();
                            newAnnot.ToolTip = y.Element("title").Value.ToString();
                            newAnnot.Visible = true;
                            newAnnot.AnchorX = (int.Parse(y.Element("year").Value));
                            newAnnot.AnchorY = (int.Parse(y.Element("rating").Value));
                            if (scatterChart.Annotations.FindByName(y.Element("title").Value.ToString()) == null)
                                scatterChart.Annotations.Add(newAnnot);
                            numItems++;
                            scatterChart.Series[y.Element("genre").Value.ToString().ToLower()].Points.AddXY(int.Parse(y.Element("year").Value), int.Parse(y.Element("rating").Value));
                        }
                    }
                }
                else
                {
                    XDocument xDoc = null;
                    xDoc = XDocument.Load(filePath);
                    var titleQuery = from x in xDoc.Descendants("movie")
                                     select x;
                    foreach (XElement y in titleQuery)
                    {
                        movieVals = (y.Element("length").Value.ToString()).Split(' ');
                        if (int.Parse(movieVals[0]) > length)
                        {
                            TextAnnotation newAnnot = new TextAnnotation();
                            newAnnot.Name = y.Element("title").Value.ToString();
                            newAnnot.Text = y.Element("title").Value.ToString();
                            newAnnot.ToolTip = y.Element("title").Value.ToString();
                            newAnnot.Visible = true;
                            newAnnot.AnchorX = (int.Parse(y.Element("year").Value));
                            newAnnot.AnchorY = (int.Parse(y.Element("rating").Value));
                            if (scatterChart.Annotations.FindByName(y.Element("title").Value.ToString()) == null)
                                scatterChart.Annotations.Add(newAnnot);
                            numItems++;
                            scatterChart.Series[y.Element("genre").Value.ToString().ToLower()].Points.AddXY(int.Parse(y.Element("year").Value), int.Parse(y.Element("rating").Value));
                        }
                    }
                }
            }
            xTrackBar.Value = 10;
            yTrackBar.Value = 10;

            if (scatterChart.Annotations.Count < 40)
            {

                foreach (Annotation text in scatterChart.Annotations)
                {
                    text.AxisX = scatterChart.ChartAreas[0].AxisX;
                    text.AxisY = scatterChart.ChartAreas[0].AxisY;
                }
            }
            else
            {
                warningLabel.Visible = true;
            }
            numItemsLabel.Text = "Number of movies shown: " + numItems.ToString();
        }

        private void actorSearch_Click(object sender, EventArgs e)
        {
            foreach (var series in scatterChart.Series)
            {
                series.Points.Clear();
            }
            int numItems = 0;
            scatterChart.Annotations.Clear();
            warningLabel.Visible = false;

            string[] targetActors = actorsTB.Text.Split();
            string[] searchActors;

            string filePath = @"Resources\movielist.xml";

            XDocument xDoc = null;
            xDoc = XDocument.Load(filePath);
            var titleQuery = from x in xDoc.Descendants("movie")
                             select x;
            foreach (XElement y in titleQuery)
                if (y.Element("actor").Value != null)
                    foreach (XElement k in y.Elements("actor"))
                    {
                        for (int i = 0; i < targetActors.Length; i++)
                        {
                            searchActors = k.Value.ToString().Split(',');
                            for (int j = 0; j < searchActors.Length; j++)
                            {
                                string[] actorSubArray = searchActors[j].Split(' ');
                                for (int l = 0; l < actorSubArray.Length; l++)
                                {
                                    if ((actorSubArray[l].ToLower().CompareTo(targetActors[i].ToLower())) == 0)
                                    {
                                        TextAnnotation newAnnot = new TextAnnotation();
                                        newAnnot.Name = y.Element("title").Value.ToString();
                                        newAnnot.Text = y.Element("title").Value.ToString();
                                        newAnnot.ToolTip = y.Element("title").Value.ToString();
                                        newAnnot.Visible = true;
                                        newAnnot.AnchorX = (int.Parse(y.Element("year").Value));
                                        newAnnot.AnchorY = (int.Parse(y.Element("rating").Value));
                                        if (scatterChart.Annotations.FindByName(y.Element("title").Value.ToString()) == null)
                                            scatterChart.Annotations.Add(newAnnot);
                                        numItems++;
                                        scatterChart.Series[y.Element("genre").Value.ToString().ToLower()].Points.AddXY(int.Parse(y.Element("year").Value), int.Parse(y.Element("rating").Value));
                                    }
                                }
                            }
                        }
                    }
            xTrackBar.Value = 10;
            yTrackBar.Value = 10;

            if (scatterChart.Annotations.Count < 40)
            {

                foreach (Annotation text in scatterChart.Annotations)
                {
                    text.AxisX = scatterChart.ChartAreas[0].AxisX;
                    text.AxisY = scatterChart.ChartAreas[0].AxisY;
                }
            }
            else
            {
                warningLabel.Visible = true;
            }
            numItemsLabel.Text = "Number of movies shown: " + numItems.ToString();
        }

        private void star1_Click(object sender, EventArgs e)
        {

        }

        private void ratingSearch_Click(object sender, EventArgs e)
        {
            int numItems = 0;
            foreach (var series in scatterChart.Series)
            {
                series.Points.Clear();
            }
            scatterChart.Annotations.Clear();
            warningLabel.Visible = false;

            int rating = int.Parse(ratingUpDown.Text);
            string filePath = @"Resources\movielist.xml";

            XDocument xDoc = null;
            xDoc = XDocument.Load(filePath);
            var titleQuery = from x in xDoc.Descendants("movie")
                             select x;
            foreach (XElement y in titleQuery)
            {
                if (int.Parse((y.Element("rating").Value)) == rating)
                {
                    TextAnnotation newAnnot = new TextAnnotation();
                    newAnnot.Name = y.Element("title").Value.ToString();
                    newAnnot.Text = y.Element("title").Value.ToString();
                    newAnnot.ToolTip = y.Element("title").Value.ToString();
                    newAnnot.Visible = true;
                    newAnnot.AnchorX = (int.Parse(y.Element("year").Value));
                    newAnnot.AnchorY = (int.Parse(y.Element("rating").Value));
                    if (scatterChart.Annotations.FindByName(y.Element("title").Value.ToString()) == null)
                        scatterChart.Annotations.Add(newAnnot);
                    numItems++;
                    scatterChart.Series[y.Element("genre").Value.ToString().ToLower()].Points.AddXY(int.Parse(y.Element("year").Value), int.Parse(y.Element("rating").Value));
                }
            }

            xTrackBar.Value = 10;
            yTrackBar.Value = 10;

            if (scatterChart.Annotations.Count < 40)
            {

                foreach (Annotation text in scatterChart.Annotations)
                {
                    text.AxisX = scatterChart.ChartAreas[0].AxisX;
                    text.AxisY = scatterChart.ChartAreas[0].AxisY;
                }
            }
            else
            {
                warningLabel.Visible = true;
            }
            numItemsLabel.Text = "Number of movies shown: " + numItems.ToString();
        }

        private void xTrackBar_Scroll(object sender, EventArgs e)
        {
            //manipulatePoints('x');
            manipulatePoints();
        }

        private void manipulatePoints()
        {
            List<System.Windows.Forms.DataVisualization.Charting.DataPoint[]> seriesList = new List<System.Windows.Forms.DataVisualization.Charting.DataPoint[]>();

            System.Windows.Forms.DataVisualization.Charting.DataPoint[] adventureArray = scatterChart.Series["adventure"].Points.ToArray();
            seriesList.Add(adventureArray);
            System.Windows.Forms.DataVisualization.Charting.DataPoint[] crimeArray = scatterChart.Series["crime"].Points.ToArray();
            seriesList.Add(crimeArray);
            System.Windows.Forms.DataVisualization.Charting.DataPoint[] westernArray = scatterChart.Series["western"].Points.ToArray();
            seriesList.Add(westernArray);
            System.Windows.Forms.DataVisualization.Charting.DataPoint[] actionArray = scatterChart.Series["action"].Points.ToArray();
            seriesList.Add(actionArray);
            System.Windows.Forms.DataVisualization.Charting.DataPoint[] mysteryArray = scatterChart.Series["mystery"].Points.ToArray();
            seriesList.Add(mysteryArray);
            System.Windows.Forms.DataVisualization.Charting.DataPoint[] biographyArray = scatterChart.Series["biography"].Points.ToArray();
            seriesList.Add(biographyArray);
            System.Windows.Forms.DataVisualization.Charting.DataPoint[] romanceArray = scatterChart.Series["romance"].Points.ToArray();
            seriesList.Add(romanceArray);
            System.Windows.Forms.DataVisualization.Charting.DataPoint[] familyArray = scatterChart.Series["family"].Points.ToArray();
            seriesList.Add(familyArray);
            System.Windows.Forms.DataVisualization.Charting.DataPoint[] horrorArray = scatterChart.Series["horror"].Points.ToArray();
            seriesList.Add(horrorArray);
            System.Windows.Forms.DataVisualization.Charting.DataPoint[] shortArray = scatterChart.Series["short"].Points.ToArray();
            seriesList.Add(shortArray);
            System.Windows.Forms.DataVisualization.Charting.DataPoint[] scifiArray = scatterChart.Series["sci-fi"].Points.ToArray();
            seriesList.Add(scifiArray);
            System.Windows.Forms.DataVisualization.Charting.DataPoint[] thrillerArray = scatterChart.Series["thriller"].Points.ToArray();
            seriesList.Add(thrillerArray);
            System.Windows.Forms.DataVisualization.Charting.DataPoint[] dramaArray = scatterChart.Series["drama"].Points.ToArray();
            seriesList.Add(dramaArray);
            System.Windows.Forms.DataVisualization.Charting.DataPoint[] comedyArray = scatterChart.Series["comedy"].Points.ToArray();
            seriesList.Add(comedyArray);
            System.Windows.Forms.DataVisualization.Charting.DataPoint[] fantasyArray = scatterChart.Series["fantasy"].Points.ToArray();
            seriesList.Add(fantasyArray);
            System.Windows.Forms.DataVisualization.Charting.DataPoint[] animationArray = scatterChart.Series["animation"].Points.ToArray();
            seriesList.Add(animationArray);
            System.Windows.Forms.DataVisualization.Charting.DataPoint[] warArray = scatterChart.Series["war"].Points.ToArray();
            seriesList.Add(warArray);
            System.Windows.Forms.DataVisualization.Charting.DataPoint[] documentaryArray = scatterChart.Series["documentary"].Points.ToArray();
            seriesList.Add(documentaryArray);
            System.Windows.Forms.DataVisualization.Charting.DataPoint[] musicalArray = scatterChart.Series["musical"].Points.ToArray();
            seriesList.Add(musicalArray);
            System.Windows.Forms.DataVisualization.Charting.DataPoint[] adultArray = scatterChart.Series["adult"].Points.ToArray();
            seriesList.Add(adultArray);
            System.Windows.Forms.DataVisualization.Charting.DataPoint[] filmnoirArray = scatterChart.Series["film-noir"].Points.ToArray();
            seriesList.Add(filmnoirArray);
            System.Windows.Forms.DataVisualization.Charting.DataPoint[] sportArray = scatterChart.Series["sport"].Points.ToArray();
            seriesList.Add(sportArray);
            System.Windows.Forms.DataVisualization.Charting.DataPoint[] musicArray = scatterChart.Series["music"].Points.ToArray();
            seriesList.Add(musicArray);

            clearPoints(seriesList);
        }

        private void clearPoints(List<System.Windows.Forms.DataVisualization.Charting.DataPoint[]> series)
        {
            foreach (System.Windows.Forms.DataVisualization.Charting.DataPoint[] seriesArray in series)
            {
                for (int i = 0; i < seriesArray.Length; i++)
                {
                    Color currColor = seriesArray[i].Color;
                    if ((seriesArray[i].YValues[0] < yTrackBar.Value) && (seriesArray[i].XValue < (1900 + 11 * (xTrackBar.Value))))
                    {
                        seriesArray[i].MarkerSize = 15;
                    }
                    else
                    {
                        seriesArray[i].MarkerSize = 0;
                    }
                }
                foreach (Annotation a in scatterChart.Annotations)
                {
                    if ((a.AnchorY < yTrackBar.Value) && (a.AnchorX < (1900 + 11 * (xTrackBar.Value))))
                    {
                        a.Visible = true;
                    }
                    else
                    {
                        a.Visible = false;
                    }
                }
            }
        }

        private void yTrackBar_Scroll(object sender, EventArgs e)
        {
            manipulatePoints();
        }

        private void genreCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int numItems = 0;
            foreach (var series in scatterChart.Series)
            {
                series.Points.Clear();
            }

            int numItems = 0;
            scatterChart.Annotations.Clear();
            warningLabel.Visible = false;

            string filePath = @"Resources\movielist.xml";
            XDocument xDoc = null;
            xDoc = XDocument.Load(filePath);
            var titleQuery = from x in xDoc.Descendants("movie").ToList()
                             select x;
            foreach (XElement y in titleQuery)
            {
                Boolean removed = false;

                if (titleTB.Text.CompareTo("Title") != 0)
                {
                    Boolean found = false;
                    string[] titleFindArray = titleTB.Text.ToLower().Split(' ');
                    string[] titleArray = (y.Element("title").Value.ToString().ToLower().Split(' '));

                    for (int i = 0; i < titleArray.Length && !found; i++)
                    {
                        for (int j = 0; j < titleFindArray.Length && !found; j++)
                        {
                            if ((titleFindArray[j].CompareTo(titleArray[i]) == 0) || (titleArray[i].Contains(titleFindArray[j]) == true))
                                found = true;
                        }
                    }

                    if (!found)
                    {
                        y.Remove();
                        removed = true;
                    }
                }

                if (genreCB.Text.CompareTo("Genre") != 0 && genreCB.Text.CompareTo("") != 0 && !removed)
                {
                        if (y.Element("genre").Value != null)
                        {
                            Boolean found = false;
                            foreach (XElement k in y.Elements("genre"))
                            {
                                if ((k.Value.ToString().ToLower().CompareTo(genreCB.Text.ToString().ToLower()) == 0))
                                {
                                    found = true;
                                }
                            }

                            if (!found)
                            {
                            y.Remove();
                            removed = true;
                            }
                        }
                }

                if (((year1TB.Text.CompareTo("Year 1") != 0)) && (year2TB.Text.CompareTo("Year 2") != 0) && !removed)
                {
                    int year1 = int.Parse(year1TB.Text);
                    int year2 = int.Parse(year2TB.Text);

                    if ((int.Parse((y.Element("year".ToLower()).Value)) < year1
                || (int.Parse((y.Element("year".ToLower()).Value)) > year2)))
                    {
                        y.Remove();
                        removed = true;
                    }
                }

                if (ratingUpDown.Value != 10 && !removed)
                {
                    if (int.Parse(y.Element("rating").Value) != ratingUpDown.Value)
                    {
                        y.Remove();
                        removed = true;
                    }
                }

                if (certificationCB.Text.CompareTo(" ") != 0 && !removed)
                {
                    if ((y.Element("certification") == null) || (y.Element("certification").Value.ToString().ToLower()).CompareTo(certificationCB.Text.ToLower()) != 0)
                    {
                        y.Remove();
                        removed = true;
                    }
                }

                if (directorTB.Text.CompareTo("") != 0 && !removed)
                {
                    Boolean found = false;

                    string[] directorFindArray = directorTB.Text.ToLower().Split(' ');
                    string[] directorArray = (y.Element("director").Value.ToString().ToLower().Split(' '));

                    for (int i = 0; i < directorArray.Length && !found; i++)
                    {
                        for (int j = 0; j < directorFindArray.Length && !found; j++)
                        {
                            if ((directorFindArray[j].CompareTo(directorArray[i]) == 0) || (directorArray[i].Contains(directorFindArray[j]) == true))
                                found = true;
                        }
                    }

                    if (!found)
                    {
                        y.Remove();
                        removed = true;
                    }
                }

                if (actorsTB.Text.CompareTo("") != 0 && !removed)
                {
                    string[] targetActors = actorsTB.Text.Split();
                    string[] searchActors;
                    Boolean found = false;

                    if (y.Element("actor").Value != null)
                        foreach (XElement k in y.Elements("actor"))
                        {
                            for (int i = 0; i < targetActors.Length; i++)
                            {
                                searchActors = k.Value.ToString().Split(',');
                                for (int j = 0; j < searchActors.Length; j++)
                                {
                                    string[] actorSubArray = searchActors[j].Split(' ');
                                    for (int l = 0; l < actorSubArray.Length; l++)
                                    {
                                        if ((actorSubArray[l].ToLower().CompareTo(targetActors[i].ToLower())) == 0)
                                        {
                                            found = true;
                                        }
                                    }
                                }
                            }
                        }
                    if (!found)
                    {
                        y.Remove();
                        removed = true;
                    }
                }

                int number;
                if (int.TryParse(lengthTB.Text.ToString(), out number) == true && !removed)
                {
                    int length = int.Parse(lengthTB.Text);
                    string[] movieVals = new string[2];

                    if (lengthCB.Text.CompareTo("=") == 0)
                    {
                        movieVals = (y.Element("length").Value.ToString()).Split(' ');
                        if (int.Parse(movieVals[0]) != length)
                        {
                            y.Remove();
                            removed = true;
                        }
                    }
                    else if (lengthCB.Text.CompareTo("<") == 0)
                    {
                        movieVals = (y.Element("length").Value.ToString()).Split(' ');
                        if (int.Parse(movieVals[0]) >= length)
                        {
                            y.Remove();
                            removed = true;
                        }
                    }
                    else
                    {
                        movieVals = (y.Element("length").Value.ToString()).Split(' ');
                        if (int.Parse(movieVals[0]) <= length)
                        {
                            y.Remove();
                            removed = true;
                        }
                    }
                }

                if (!removed)
                {
                    TextAnnotation newAnnot = new TextAnnotation();
                    newAnnot.Name = y.Element("title").Value.ToString();
                    newAnnot.Text = y.Element("title").Value.ToString();
                    newAnnot.ToolTip = y.Element("title").Value.ToString();
                    newAnnot.Visible = true;
                    newAnnot.AnchorX = (int.Parse(y.Element("year").Value));
                    newAnnot.AnchorY = (int.Parse(y.Element("rating").Value));
                    if (scatterChart.Annotations.FindByName(y.Element("title").Value.ToString()) == null)
                        scatterChart.Annotations.Add(newAnnot);
                    numItems++;
                    scatterChart.Series[y.Element("genre").Value.ToString().ToLower()].Points.AddXY(int.Parse(y.Element("year").Value), int.Parse(y.Element("rating").Value));
                }
                numItemsLabel.Text = "Number of movies shown: " + numItems.ToString();
            }

            if (scatterChart.Annotations.Count < 40)
            {

                foreach (Annotation text in scatterChart.Annotations)
                {
                    text.AxisX = scatterChart.ChartAreas[0].AxisX;
                    text.AxisY = scatterChart.ChartAreas[0].AxisY;
                }
            }
            else
            {
                warningLabel.Visible = true;
            }
        }
        
        private void scatterChart_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void scatterChart_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void scatterChart_Click(object sender, EventArgs e)
        {

        }

        private void titleTB_MouseClick(object sender, MouseEventArgs e)
        {
            titleTB.Text = "";
        }

        private void year1TB_MouseClick(object sender, MouseEventArgs e)
        {
            year1TB.Text = "";
        }

        private void year2TB_MouseClick(object sender, MouseEventArgs e)
        {
            year2TB.Text = "";
        }

        private void titleTB_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void titleSearch_KeyDown(object sender, KeyEventArgs e)
        {
            // not made by Chris

        }

        private void titleTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                titleSearch_Click(sender, e);

        }

        private void year2TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void year1TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void year1TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                yearSearch_Click(sender, e);
        }

        private void year2TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                yearSearch_Click(sender, e);
        }

        private void genreCB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                genreSearch_Click(sender, e);
        }

        private void ratingUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                ratingSearch_Click(sender, e);
        }

        private void lengthTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                lengthSearch_Click(sender, e);
        }

        private void lengthCB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                lengthSearch_Click(sender, e);
        }

        private void certificationCB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                certificationSearch_Click(sender, e);
        }

        private void directorTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                directorSearch_Click(sender, e);
        }

        private void actorsTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                actorSearch_Click(sender, e);
        }

        private void ScatterPlot_Load(object sender, EventArgs e)
        {

        }
    }
}
