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
using System.Text.RegularExpressions;

namespace A3Q1
{
    public partial class AdvanceSearch : Form1
    {
        Boolean xD = false;
        public AdvanceSearch()
        {
            InitializeComponent();
            textBox6.Text = "";
            comboBox3.Text = "";
            //comboBox1.Visible = true;
        }

        private void AdvanceSearch_Load(object sender, EventArgs e)
        {

        }



        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int aaaaaa;
            Boolean recommand = false;

            // arraylist inital values 6 
            //search by genre 32
            //if genre does not contain initial value remove initial value
            //know when to start  or start with all 
            ArrayList compare = new ArrayList();
            // int i = 0;
            CheckBox[] def = new CheckBox[16];
            def[0] = checkBox1;
            def[1] = checkBox2;
            def[2] = checkBox3;
            def[3] = checkBox4;
            def[4] = checkBox5;
            def[5] = checkBox6;
            def[6] = checkBox7;
            def[7] = checkBox8;
            def[8] = checkBox9;
            def[9] = checkBox10;
            def[10] = checkBox11;
            def[11] = checkBox12;
            def[12] = checkBox13;
            def[13] = checkBox14;
            def[14] = checkBox15;
            def[15] = checkBox16;
            Boolean sdmsdsds = false;

            string filePath = @"Resources\movielist.xml";
            ArrayList potentialValues = new ArrayList();
            XDocument xDoc = null;
            xDoc = XDocument.Load(filePath);

            var allMovies = from d in xDoc.Descendants("movie")
                                //       where d.Element("title") != null && ((d.Element("title").Value.ToString().ToLower().IndexOf(textBox1.Text.ToLower()) > -1))
                            select d;
            foreach (XElement titles in allMovies)
            {

                compare.Add(titles.Element("title").Value);

            }



            if (textBox1.Text != "")
            {
                var titleQuery = from d in xDoc.Descendants("movie")
                                 where d.Element("title") != null && ((d.Element("title").Value.ToString().ToLower().IndexOf(textBox1.Text.ToLower()) > -1))
                                 select d;
                foreach (XElement titles in titleQuery)
                {//if(potentialValues.IndexOf( titles.Element("title").Value ) == -1 )
                    potentialValues.Add(titles.Element("title").Value);

                }

                for (int i = compare.Count - 1; i != -1; i--)
                {
                    /*bigList  perm List
                     

                    arrayList all movies
                    final product
                     arrayList
                     i
                     so
                     ! */
                    for (int k = 0; k < potentialValues.Count; k++)
                    {

                        /* small list temporary sma
                      search parameters
                      titles delete smalllist.clear
                      s
                      d
                      f
                      g

                         */



                        /* fina list 
                        mr i so */
                        if (compare[i].ToString().Equals(potentialValues[k].ToString()) && recommand != true)
                        {
                            recommand = true;

                        }

                    }

                    if (recommand == true)
                    {
                        //y.remove();

                    }
                    else

                        compare.RemoveAt(i);
                    //  Console.WriteLine(i);


                    recommand = false;

                }
                potentialValues.Clear();

            }
            for (int i = 0; i < 16; i++)
            {
                if (def[i].Checked)
                {
                    var genreQuery = from x in xDoc.Descendants("movie")

                                         //where (x.Element(comboBox.ToLower()) != null && ((x.Element(comboBox.ToLower()).Value.ToString().ToLower().IndexOf(textbox.ToLower())) > -1))
                                     select x;

                    foreach (XElement y in genreQuery)
                    {
                        if (y.Element("genre").Value != null)
                            foreach (XElement z in y.Elements("genre".ToLower()))
                                if (z.NextNode != null)
                                    if ((z.Value.ToLower()) == def[i].Text.ToLower())
                                        potentialValues.Add(
                                           (y.Element("title").Value));
                    }

                    for (int thiss = compare.Count - 1; thiss != -1; thiss--)
                    {
                        for (int k = 0; k < potentialValues.Count; k++)
                        {
                            if (compare[thiss].ToString().Equals(potentialValues[k].ToString()) && recommand != true)
                            {
                                recommand = true;

                            }

                        }

                        if (recommand != true)
                        {





                            compare.RemoveAt(thiss);
                            //  Console.WriteLine(i);

                        }
                        recommand = false;

                    }
                    potentialValues.Clear();
                }
            }

            if (textBox2.Text != "")
            {

                var directorQuery = from x in xDoc.Descendants("movie")
                                    where (x.Element("director").Value.ToLower().IndexOf(textBox2.Text.ToLower()) > -1)
                                    select x;
                foreach (XElement director in directorQuery)
                {
                    potentialValues.Add(director.Element("title").Value);

                }
                for (int i = compare.Count - 1; i != -1; i--)
                {
                    for (int k = 0; k < potentialValues.Count; k++)
                    {
                        if (compare[i].ToString().Equals(potentialValues[k].ToString()) && recommand != true)
                        {
                            recommand = true;

                        }

                    }

                    if (recommand == true)
                    {


                    }
                    else

                        compare.RemoveAt(i);
                    //  Console.WriteLine(i);


                    recommand = false;

                }
                potentialValues.Clear();
            }

            if (textBox3.Text != "")
            {
                var actorQuery = from x in xDoc.Descendants("movie")

                                     //where (x.Element(comboBox.ToLower()) != null && ((x.Element(comboBox.ToLower()).Value.ToString().ToLower().IndexOf(textbox.ToLower())) > -1))
                                 select x;

                foreach (XElement y in actorQuery)
                {
                 //   if (y.Element("actor").Value != null)
                        foreach (XElement z in y.Elements("actor"))
                            if (z.NextNode != null)
                                if ((z.Value).ToLower().IndexOf(textBox3.Text.ToLower()) > -1)
                                    potentialValues.Add(
                                       (y.Element("title").Value));
                }
                for (int i = compare.Count - 1; i != -1; i--)
                {
                    for (int k = 0; k < potentialValues.Count; k++)
                    {
                        if (compare[i].ToString().Equals(potentialValues[k].ToString()) && recommand != true)
                        {
                            recommand = true;

                        }

                    }

                    if (recommand == true)
                    {


                    }
                    else

                        compare.RemoveAt(i);
                    //  Console.WriteLine(i);


                    recommand = false;

                }
                potentialValues.Clear();
            }

            if (textBox4.Text != "")
                xD = true; if (textBox5.Text != "")
                xD = true;
            int super;
            int mr;
            if (int.TryParse(textBox4.Text, out super) && int.TryParse(textBox5.Text, out mr))
            {
                var actorQuerys = from x in xDoc.Descendants("movie")

                                      //where (x.Element(comboBox.ToLower()) != null && ((x.Element(comboBox.ToLower()).Value.ToString().ToLower().IndexOf(textbox.ToLower())) > -1))
                                  select x;
                //  Console.WriteLine(super + " sf"+  mr);
                foreach (XElement y in actorQuerys)
                {

                    if (int.Parse(y.Element("year").Value) >= super && int.Parse(y.Element("year").Value) <= mr)
                    {// Console.WriteLine(y.Element("title") );
                        potentialValues.Add(y.Element("title").Value);
                    }
                }

                for (int i = compare.Count - 1; i != -1; i--)
                {
                    for (int k = 0; k < potentialValues.Count; k++)
                    {
                        if (compare[i].ToString().Equals(potentialValues[k].ToString()) && recommand != true)
                        {
                            recommand = true;

                        }

                    }

                    if (recommand == true)
                    {


                    }
                    else

                        compare.RemoveAt(i);
                    //  Console.WriteLine(i);


                    recommand = false;

                }
                potentialValues.Clear();
            }
            if (comboBox1.Text != "")
            {
                var actorQuerys = from x in xDoc.Descendants("movie")

                                      //where (x.Element(comboBox.ToLower()) != null && ((x.Element(comboBox.ToLower()).Value.ToString().ToLower().IndexOf(textbox.ToLower())) > -1))
                                  select x;
                foreach (XElement y in actorQuerys)
                {
                    if (comboBox1.Text == y.Element("rating").Value)
                        potentialValues.Add(y.Element("title").Value);

                }
                for (int i = compare.Count - 1; i != -1; i--)
                {
                    for (int k = 0; k < potentialValues.Count; k++)
                    {
                        if (compare[i].ToString().Equals(potentialValues[k].ToString()) && recommand != true)
                        {
                            recommand = true;

                        }

                    }

                    if (recommand == true)
                    {


                    }
                    else

                        compare.RemoveAt(i);
                    //  Console.WriteLine(i);


                    recommand = false;

                }
                potentialValues.Clear();
            }
            if (comboBox2.Text != "")
            {
                var actorQuerys = from x in xDoc.Descendants("movie")
                                  where(x.Element("certification") !=  null)
                                      //where (x.Element(comboBox.ToLower()) != null && ((x.Element(comboBox.ToLower()).Value.ToString().ToLower().IndexOf(textbox.ToLower())) > -1))
                                  select x;
                foreach (XElement y in actorQuerys)
                {
                    if (y.Element("certification").Value.ToString().Equals(comboBox2.Text.ToString()) )
                        potentialValues.Add(y.Element("title").Value);

                }
                for (int i = compare.Count - 1; i != -1; i--)
                {
                    for (int k = 0; k < potentialValues.Count; k++)
                    {
                        if (compare[i].ToString().Equals(potentialValues[k].ToString()) && recommand != true)
                        {
                            recommand = true;

                        }

                    }

                    if (recommand == true)
                    {


                    }
                    else

                        compare.RemoveAt(i);
                    //  Console.WriteLine(i);


                    recommand = false;

                }
                potentialValues.Clear();
            }

            // for (int z = 0; z < potentialValues.Count; z++)
            //   Console.Write(potentialValues[z]);

            if (textBox6.Text != "") sdmsdsds = true;
if(                comboBox3.Text != "") sdmsdsds = true;
           // if (comboBox3.Text != "") sdmsdsds = true;
               // {     sdmsdsds = true;
                if (int.TryParse(textBox6.Text, out aaaaaa))
                {
                    //sdmsdsds = true;
                    var actorQuerys = from x in xDoc.Descendants("movie")
                                      where (x.Element("length") != null)
                                      //where (x.Element(comboBox.ToLower()) != null && ((x.Element(comboBox.ToLower()).Value.ToString().ToLower().IndexOf(textbox.ToLower())) > -1))
                                      select x;

                    //  Console.WriteLine(super + " sf"+  mr);
                    foreach (XElement y in actorQuerys)
                    {
                        string resultString = Regex.Match(y.Element("length").Value, @"\d+").Value;
                        if (comboBox3.Text == ">")
                        {
                            if ((int.Parse(resultString) >= aaaaaa))
                            {// Console.WriteLine(y.Element("title") );
                                potentialValues.Add(y.Element("title").Value);
                            }
                        } else if (comboBox3.Text == "<") {
                            if ((int.Parse(resultString) <= aaaaaa))
                            {// Console.WriteLine(y.Element("title") );
                                potentialValues.Add(y.Element("title").Value);
                            }
                        }
                        else if (comboBox3.Text == "=") {
                            if ((int.Parse(resultString) == aaaaaa))
                            {// Console.WriteLine(y.Element("title") );
                                potentialValues.Add(y.Element("title").Value);
                            }
                        }
                    }

                    for (int i = compare.Count - 1; i != -1; i--)
                    {
                        for (int k = 0; k < potentialValues.Count; k++)
                        {
                            if (compare[i].ToString().Equals(potentialValues[k].ToString()) && recommand != true)
                            {
                                recommand = true;

                            }

                        }

                        if (recommand == true)
                        {


                        }
                        else

                            compare.RemoveAt(i);
                        //  Console.WriteLine(i);


                        recommand = false;

                    }
                    potentialValues.Clear();
                
           // }
            }
            if (xD && sdmsdsds)
            {
                if (int.TryParse(textBox6.Text, out aaaaaa) && comboBox3.Text != "")
                {
                    if (int.TryParse(textBox4.Text, out super) && int.TryParse(textBox5.Text, out mr))
                    {

                        searchResults dsss = new searchResults(compare);
                        this.Close();
                        dsss.Show();
                    }
                    else MessageBox.Show("Error one of the year parameters are not valid ");



                }
                else MessageBox.Show("Error the length parameters is not valid ");

            }
            else if (sdmsdsds)
            {
                if (int.TryParse(textBox6.Text, out aaaaaa) && comboBox3.Text != "")
                {
                    searchResults dsss = new searchResults(compare);
                    this.Close();
                    dsss.Show();
                }
                else MessageBox.Show("Error the length parameters is not valid ");
            }
            else if (xD == true)
            {
                if (int.TryParse(textBox4.Text, out super) && int.TryParse(textBox5.Text, out mr))
                {
                    searchResults dsss = new searchResults(compare);
                    this.Close();
                    dsss.Show();
                }
                else MessageBox.Show("Error one of the year parameters are not valid ");
            }
            else
            {
                searchResults dsss = new searchResults(compare);
                this.Close();
                dsss.Show();
            }
            

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
         

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                button2_Click(sender, e);
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                button2_Click(sender, e);
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                button2_Click(sender, e);
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                button2_Click(sender, e);
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                button2_Click(sender, e);
        }

        private void checkBox5_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter)
                button2_Click(sender, e);
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}


