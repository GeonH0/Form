using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_Form
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
 
         }

        private void button1_Click(object sender, EventArgs e)
        {
            if((radioButton1.Checked ==false && radioButton2.Checked ==false)||(comboBox1.SelectedIndex==-1)||(textBox1.Text==""))
            {

                Form4 showForm2 = new Form4(1);
                showForm2.ShowDialog();
            }
            else
            {
            this.Visible = false;
            Form2 showForm2 = new Form2();
            showForm2.ShowDialog();
            }

        } 

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

  
    }



