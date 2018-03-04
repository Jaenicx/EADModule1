using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_1_Assigment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lastName_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void parish_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void spackage_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fnamebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastName_Click_1(object sender, EventArgs e)
        {

        }

        private void lnamebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void gender_Click(object sender, EventArgs e)
        {

        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void street_Click(object sender, EventArgs e)
        {

        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void streetbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstName_Click(object sender, EventArgs e)
        {

        }

        private void parish_Click_1(object sender, EventArgs e)
        {

        }

        private void parishcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void citybox_TextChanged(object sender, EventArgs e)
        {

        }

        private void city_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            String first = fnamebox.Text;
            String last = lnamebox.Text;
            String street = streetbox.Text;
            String city = citybox.Text;
            String parish = parishcombo.Text;
            String package = spakagebox.Text;
            String total = vrentbox.Text;

            String gender = "";
            bool isChecked = male.Checked;
            if (isChecked)
            {
                gender = male.Text;
            }
            else
            {
                gender = female.Text;
            }

            String demand = "";
            bool isChecked1 = vdyes.Checked;
            if (isChecked1)
            {
                demand =vdyes.Text;
            }
            else
            {
                demand = vdno.Text;
            }

            MessageBox.Show("First name: " + first + " \nLast Name: " + last + " \nGender: " + gender + " \nStreet: " + street + " \nParish: " + parish + " \nCity: " + city + " \nSubscribed Package: " + package + " \nVideo on Demand: " + demand + " \nTotal Video Rented: " + total);





        }

        private void spakagebox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void s_Click(object sender, EventArgs e)
        {
            fnamebox.Text = String.Empty;
            lnamebox.Text = String.Empty;

            streetbox.Text = String.Empty;
            parishcombo.Text = String.Empty;
            citybox.Text = String.Empty;
            spakagebox.Text = String.Empty;

            vrentbox.Text = String.Empty;
        }

        private void vdyes_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
