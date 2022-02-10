using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int bornYear = int.Parse(txtYear.Text);
            int currentYear = 2022;

            if(bornYear > 1900 && bornYear < 2022)
            {
                int age = currentYear - bornYear;
                MessageBox.Show("Hi...! " + name + ",Your age is : " + age);
            }
            else
            {
                MessageBox.Show("You entered a wrong year");
            }
            
        }

        private void btnHobbies_Click(object sender, EventArgs e)
        {
            txtHobbies.Text = String.Empty;

            txtHobbies.Text = "Your selected hobbies : \n";
            foreach(var items in chkListHobbies.CheckedItems)
            {
                txtHobbies.Text += items.ToString() + "\n";
            }
        }
    }
}
