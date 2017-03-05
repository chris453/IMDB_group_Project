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

namespace A3Q1
{
    public partial class New : Form
    {

        public Boolean save = false;
        public Boolean cancel = false;
        public New()
        {
            InitializeComponent();
            cancel = true;
        }

        public New(String firstName, string lastName, string age, string gender, string universityYear, string phoneNumber, string address, string trailer, string rating)
        {
            InitializeComponent();

            textBox1.Text = firstName;
            textBox2.Text = lastName;
            textBox3.Text = age;
            textBox4.Text = gender;
            textBox5.Text = universityYear;
            textBox6.Text = phoneNumber;
            textBox7.Text = address;
            textBox8.Text = trailer;
            comboBox1.Text = rating;
        }
        public New(String title )
        {
            InitializeComponent();
            label1.Text = title;
            
        }
        private void New_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            //string filePath = @"Resources\MovieList.xml";
          //  string filePaths = @"Resources\ListOfMovies.xml";


            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox5.Text != ""  &&  textBox6.Text != "" && textBox7.Text != ""  )
            {
              //  if (cancel)
                //{
                    string filePath = @"Resources\MovieList.xml";
                    string[] genreList = textBox6.Text.Split(' ');
                    string[] actorList = textBox7.Text.Split(' ');
                    List<string> list = new List<string>(genreList);
                    List<string> list2 = new List<string>(actorList);



                    XDocument doctor = XDocument.Load(filePath);
                    XElement student = new XElement("movie",

                        new XElement("title", textBox1.Text),
                        new XElement("year", textBox2.Text),
                    new XElement("length", textBox5.Text),
                        new XElement("certification", textBox4.Text),
                        new XElement("rating", comboBox1.Text),

                        new XElement("director", textBox3.Text),

                             list2.Select(l => new XElement("actor", l)),
                             list.Select(l => new XElement("genre", l)),
                                            new XElement("trailer", textBox8.ToString())

                                                                    );
                    // genre.Add, new XElement("genre", list)));
                    doctor.Root.Add(student);
                    doctor.Save(filePath);
                    save = true;
             //   }
            }

            else
            {

                MessageBox.Show("Error one of the *Parameters  can't be blank");

            }
            if(save)Close();

            //save = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            EditMovie x = new EditMovie();
            //x.textBox1.Text = "hi";
            //this.EditMovie.show();
            cancel = true;
            this.Close();

        }

        private void New_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string strfilename = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
    textBox8.Text = strfilename;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                button1_Click(sender, e);
        }
    }
}
