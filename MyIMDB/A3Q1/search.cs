using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3Q1
{
    public partial class search : Form1
    {
        public search()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void search_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Advance Search")
            {
                AdvanceSearch x = new AdvanceSearch();
                this.Close();
                x.Show();
            }
            }

        private void button1_Click(object sender, EventArgs e)
        {

            searchResults x = new searchResults(textBox1.Text, comboBox1.Text);
            this.Close();
            x.Show();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                button1_Click(sender, e);
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                button1_Click(sender, e);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
