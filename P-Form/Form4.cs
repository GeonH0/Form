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
    public partial class Form4 : Form
    {
        int check;
        public Form4(int check)
        {
            InitializeComponent();
            this.check = check;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
            if(check == 1)
            {
                Close();

            }
          else if(check == 2)
            {
                this.Visible = false;
                Form2 showForm2 = new Form2();
                showForm2.ShowDialog();
            }
            else if (check == 3)
            {
                this.Visible = false;
                Form3 showForm2 = new Form3();
                showForm2.ShowDialog();
            }



        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
