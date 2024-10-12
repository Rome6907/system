using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Queueing_system
{
    public partial class Form2 : Form
    {
        private string placeholdertext1 = "Enter FullName ";
        private string placeholdertext2 = "Enter Date Of Birth ";
        private string placeholdertext3 = "Enter Your Address ";
        private string placeholdertext4 = "Enter Fathers Name ";
        private string placeholdertext5 = "Enter Fathers Occupation ";
        public Form2()
        {
            InitializeComponent();
            StyleTextBox();
            SetPlaceHolder(textBox1, placeholdertext1);
            SetPlaceHolder(textBox2, placeholdertext2);
            SetPlaceHolder(textBox3, placeholdertext3);
            SetPlaceHolder(textBox4, placeholdertext4);
            SetPlaceHolder(textBox5, placeholdertext5);
        }

        private void StyleTextBox()
        {
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;
            textBox1.Font = new Font("Inter", 13, FontStyle.Bold);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Padding = new Padding(20);

            textBox2.BackColor = Color.White;
            textBox2.ForeColor = Color.Black;
            textBox2.Font = new Font("Inter", 13, FontStyle.Bold);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Padding = new Padding(20);

            textBox3.BackColor = Color.White;
            textBox3.ForeColor = Color.Black;
            textBox3.Font = new Font("Inter", 13, FontStyle.Bold);
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Padding = new Padding(20);

            textBox4.BackColor = Color.White;
            textBox4.ForeColor = Color.Black;
            textBox4.Font = new Font("Inter", 13, FontStyle.Bold);
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Padding = new Padding(20);

            textBox5.BackColor = Color.White;
            textBox5.ForeColor = Color.Black;
            textBox5.Font = new Font("Inter", 13, FontStyle.Bold);
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Padding = new Padding(20);

            textBox1.Enter += (s, e) => RemovePlaceholder(textBox1, placeholdertext1);
            textBox1.Leave += (s, e) => SetPlaceHolder(textBox1, placeholdertext1);

            textBox2.Enter += (s, e) => RemovePlaceholder(textBox2, placeholdertext2);
            textBox2.Leave += (s, e) => SetPlaceHolder(textBox2, placeholdertext2);

            textBox3.Enter += (s, e) => RemovePlaceholder(textBox3, placeholdertext3);
            textBox3.Leave += (s, e) => SetPlaceHolder(textBox3, placeholdertext3);

            textBox4.Enter += (s, e) => RemovePlaceholder(textBox4, placeholdertext4);
            textBox4.Leave += (s, e) => SetPlaceHolder(textBox4, placeholdertext4);

            textBox5.Enter += (s, e) => RemovePlaceholder(textBox5, placeholdertext5);
            textBox5.Leave += (s, e) => SetPlaceHolder(textBox5, placeholdertext5);
        }
        private void SetPlaceHolder(System.Windows.Forms.TextBox textBox, string placeholder)
        {
            if (string.IsNullOrEmpty(textBox.Text) || textBox.Text == placeholder)
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray;
            }
        }

        private void RemovePlaceholder(System.Windows.Forms.TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = string.Empty;
                textBox.ForeColor = Color.Black;
            }
        }










        private void Textbox1_LostFocus(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 formal3 = new Form3();
            this.Hide();
            

        }
    }
}
