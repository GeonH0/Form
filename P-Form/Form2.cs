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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked==true|| checkBox3.Checked == true|| checkBox4.Checked == true)
            {
                

                checkBox1.Checked = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((checkBox1.Checked==false&& checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false)|| 
                    (checkBox5.Checked == false && checkBox6.Checked == false && checkBox7.Checked == false && checkBox8.Checked == false)|| 
                    (checkBox9.Checked == false && checkBox10.Checked == false && checkBox11.Checked == false && checkBox12.Checked == false))
            {
                this.Visible = false;
                Form4 showForm2 = new Form4(2);
                showForm2.Show();
            }
            else
            {
             this.Visible = false;
            Form3 showForm2 = new Form3();
            showForm2.ShowDialog();
            }
                   

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true)
            {


                this.checkBox4.Checked = false;

             
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox4.Checked == true)
            {

                this.checkBox3.Checked = false;

      
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true || checkBox3.Checked == true || checkBox4.Checked == true)
            {

                checkBox2.Checked = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true || checkBox7.Checked == true || checkBox8.Checked == true)
            {
     
                this.checkBox6.Checked = false;


            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true || checkBox7.Checked == true || checkBox8.Checked == true)
            {

                this.checkBox6.Checked = false;


            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true || checkBox6.Checked == true || checkBox8.Checked == true)
            {

                this.checkBox7.Checked = false;

            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true || checkBox6.Checked == true || checkBox7.Checked == true)
            {

                this.checkBox8.Checked = false;


            }
        }
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true || checkBox11.Checked == true || checkBox12.Checked == true)
            {

                this.checkBox8.Checked = false;


            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true || checkBox11.Checked == true || checkBox12.Checked == true)
            {

                this.checkBox10.Checked = false;


            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true || checkBox10.Checked == true || checkBox12.Checked == true)
            {

                this.checkBox11.Checked = false;


            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true || checkBox10.Checked == true || checkBox11.Checked == true)
            {

                this.checkBox12.Checked = false;


            }
        }

   
    }
}
