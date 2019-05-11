using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fuel_cost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Pola nie mogą być puste", ("Uwaga"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textBox4.Text = (Double.Parse(textBox1.Text) * Double.Parse(textBox2.Text) * Double.Parse(textBox3.Text) / 100).ToString("N2")+ " zł";


            if (Double.Parse(textBox1.Text) == 0)
            {
                MessageBox.Show("Nie może być wartość 0");

            }

            else if (Double.Parse(textBox2.Text) == 0)
            {
                MessageBox.Show("Nie może być wartość 0");
            }
            else if (Double.Parse(textBox3.Text) == 0)
            {
                MessageBox.Show("Nie może być wartość 0");
            }

            
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program napisany z myślą by nie liczyć na kalkulatorze kosztów przejazdu, a mieć wszystko na gotowca");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Czy na pewno chcesz wyjść z aplikacji?",
               "Exit", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
               
            {
                Application.ExitThread();
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }   
}
