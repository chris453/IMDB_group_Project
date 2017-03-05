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
using System.Xml;
using System.Collections;
namespace A3Q1
{
    public partial class EditMovie : Form1
    {
        public EditMovie()
        {
            InitializeComponent();
        }

        public EditMovie(String firstName, string lastName, string age, string gender, string universityYear, string phoneNumber, string address, string trailer, string label)
        {
            InitializeComponent();

            axWindowsMediaPlayer1.settings.autoStart = false;


        }
        public EditMovie(String movieTitle)
        {
            InitializeComponent();
            axWindowsMediaPlayer1.settings.autoStart = false;


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
                
                    MovieTitle.Text = y.Element("title").Value;
                foreach (XElement s in y.Elements("genre"))
                {// int isdsd = y.Elements("genre").Count;
                    if (s.NextNode != null)
                    {
                        Genre.Text += s.Value.ToString() + " ";
                    }
                    else Genre.Text += s.Value.ToString();
                }
                foreach (XElement k in y.Elements("actor"))
                    {
                    if (k.NextNode != null)
                        Cast.Text += k.Value.ToString() + " " ;
                    else
                        Cast.Text += k.Value.ToString();
                    label6.Text = (y.Element("rating").Value);
                    Year.Text = (y.Element("year").Value);
                    Length.Text = y.Element("length").Value;
                    Director.Text = y.Element("director").Value;
                if (y.Element("certification") != null)
                    MPAA.Text = y.Element("certification").Value;
                else MPAA.Text = "Not Rated Yet";
                    
                }
                    if(y.Element("trailer") != null)
                axWindowsMediaPlayer1.URL = y.Element("trailer").Value;
            }


        }

        private void EditMovie_Load(object sender, EventArgs e)
        {
            //one other thing they have multiple genres how do u deal with that ifit's t
            //the issue is the colors cause they would overlap the same space? 
            //  he same movie
            //but if u search up anything title either ur just looking at the first genre not all of them?
            //example adventure of blah has 3 genres it would have 3 dots overlapping each other but your doesn't?
            // i think the color thing might be harder.. 
            //how do  u account for multiple colors overlappinG?
            //how about we use the colours as they are since theres no point in showing that a movie is multiple genres?

            //because that would make the graph more big so you can put titles on the dots to dbl click and open edit if u want 

            //is there a way to re-search the results based on the new scale?
        }

        private void button11_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL.ToString();
            openFileDialog1.ShowDialog();
            //if()
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
          string  strfilename = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
            axWindowsMediaPlayer1.URL = strfilename;

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // New x = new New(label2.Text);

            //var titleQuery = from x in xDoc.Descendants("movie");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.mute = true;
    
            string listName = "";
            New x = new New(MovieTitle.Text, Year.Text, Director.Text, MPAA.Text, Length.Text, Genre.Text, Cast.Text, axWindowsMediaPlayer1.URL.ToString(), label6.Text);
            string filePath = @"Resources\MovieList.xml";
            string filePathforList = @"Resources\ListOfMovies.xml";
            Boolean cheat = false;
            //this.Hide();
            x.ShowDialog();
            if (x.save == true)
            {
                var doc = XDocument.Load(filePath);
                foreach (XElement elem in doc.Descendants("movie").ToList())
                {
                    if (elem.Element("title") != null && elem.Element("title").Value.CompareTo(MovieTitle.Text) == 0)
                    {
                        elem.Remove();
                    }
                }
                

                doc.Save(filePath);

                var xd = XDocument.Load(filePathforList);

                foreach (XElement elem in xd.Descendants("list").ToList())
                {
                    if (elem.Element("title") != null && elem.Element("title").Value.CompareTo(MovieTitle.Text) == 0)
                    {
                        listName = elem.Element("listTitle").Value;
                        cheat = true;
                        elem.Remove();
                    }



                }
                xd.Save(filePathforList);

                MovieTitle.Text = x.textBox1.Text;
                Year.Text = x.textBox2.Text;
                Length.Text = x.textBox5.Text;
                MPAA.Text = x.textBox4.Text;
                Director.Text = x.textBox3.Text;
                                    Genre.Text = x.textBox6.Text;
                label6.Text = x.comboBox1.Text;
                                    Cast.Text = x.textBox7.Text;

                axWindowsMediaPlayer1.URL = x.textBox8.Text;
                string[] genreList = Genre.Text.Split(' ');
                string[] actorList = Cast.Text.Split(' ');
                List<string> list = new List<string>(genreList);
                List<string> list2 = new List<string>(actorList);



                XDocument doctor = XDocument.Load(filePath);
                XElement student = new XElement("movie",

                    new XElement("title", MovieTitle.Text),
                    new XElement("year", Year.Text),
                new XElement("length", Length.Text),
                    new XElement("certification", MPAA.Text),
                    new XElement("rating",label6.Text),

                    new XElement("director", Director.Text),

                         list2.Select(l => new XElement("actor", l)),
                         list.Select(l => new XElement("genre", l)),
                                        new XElement("trailer", axWindowsMediaPlayer1.URL.ToString())
                                                                
                                                                );
               // genre.Add, new XElement("genre", list)));
                doctor.Root.Add(student);
                doctor.Save(filePath);

                
                if (cheat == true)
                {
                    XDocument sesame = XDocument.Load(filePathforList);
                    XElement students = new XElement("list",new XElement("listTitle", listName),

                        new XElement("title", MovieTitle.Text),
                        new XElement("year", Year.Text),
                    new XElement("length", Length.Text),
                    new XElement("rating", label6.Text),
                        new XElement("certification", MPAA.Text),
                        new XElement("director", Director.Text),
                             list.Select(l => new XElement("genre", l)),
                              list2.Select(l => new XElement("actor", l)),
                                            new XElement("trailer", axWindowsMediaPlayer1.URL.ToString()));
                    sesame.Root.Add(students);
                    sesame.Save(filePathforList);


                }



            }

        }
        public void textBox1_TextChanged(object sender, EventArgs e)
        { 

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
                    }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.mute = true;

            addtoListForm atl = new addtoListForm(MovieTitle.Text);
            atl.ShowDialog();
        }

        private void Cast_Click(object sender, EventArgs e)
        {

        }
    }
}
