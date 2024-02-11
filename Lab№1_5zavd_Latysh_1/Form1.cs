using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_5zavd_Latysh_1
{
    public partial class Form1 : Form
    {
        private int ColorNumber = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Opacity = 1.5 - this.Opacity;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Color[] colors = { Color.LightGray, Color.Green, Color.Yellow, Color.Red };
            ColorNumber++;
            this.BackColor = colors[ColorNumber % 4];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!\nКарантин закінчився!");  
        }

        private void btnSetOfActions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я супермегакнопка,\nі цього мене не позбавиш!");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                btnSetOfActions.Click += button1_Click;
            else
                btnSetOfActions.Click -= button1_Click;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                btnSetOfActions.Click += button2_Click;
            else
                btnSetOfActions.Click -= button2_Click;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                btnSetOfActions.Click += button3_Click;
            else
                btnSetOfActions.Click -= button3_Click;
        }
    }
}
