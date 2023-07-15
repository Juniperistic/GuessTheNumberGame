using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch14ex8
{
    public partial class Form1 : Form
    {
        int guessedNumber = 0;
        static int computerNumber = 0;
        static string msg;
        static int difference = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guessedNumber = Convert.ToInt32(textBox1.Text);

            if (Math.Abs (computerNumber - guessedNumber) < difference)
                textBox1.BackColor = Color.Red;
            else 
                textBox1.BackColor = Color.Blue;

            if (guessedNumber > computerNumber)
            {
                msg = "too high";
                textBox1.Focus();
            }
            else if (guessedNumber < computerNumber)
            {
                msg = "too low";
                textBox1.Focus();
            }
            else
            {
                msg = "correct!";
                textBox1.BackColor = Color.Green;
                button1.Enabled = false;
            }

            label2.Text = msg;

            difference = Math.Abs (computerNumber - guessedNumber);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            init();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            init();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void init()
        {
            var rand = new Random();
            computerNumber = rand.Next(1, 1001);
            computerNumber = 800; //testing
            button1.Enabled = true;
            textBox1.Clear();
            textBox1.BackColor = Color.White;
            label2.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
