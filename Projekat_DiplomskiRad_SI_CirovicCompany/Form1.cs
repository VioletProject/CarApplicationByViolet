using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace Projekat_DiplomskiRad_SI_CirovicCompany
{
    public partial class Forma1 : Form
    {
        private CompanyBusiness companyBusiness;


        public Forma1()
        {
            InitializeComponent();
            this.companyBusiness = new CompanyBusiness();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Molim vas da popunite sva polja.");
                textBox1.Focus();
                return;
            }

            if (!Regex.Match(textBox1.Text, "^[A-Z][a-zA-Z ]*$").Success)
            {
                MessageBox.Show("Uneli ste naziv automobila u pogresnom formatu. Stavite prvo slovo veliko.");
                textBox1.Focus();
                return;
            }

            if (!Regex.Match(textBox3.Text, "^[0-9]*$").Success)
            {
                MessageBox.Show("Uneli ste cenu automobila u pogresnom formatu. Morate uneti samo brojcanu vrednost.");
                textBox3.Focus();
                return;
            }

            Car c = new Car();
            c.GetSetNameCar = textBox1.Text;
            c.GetSetTypeCar = textBox2.Text;
            c.GetSetPriceCar = Convert.ToInt32(textBox3.Text);

            this.companyBusiness.InsertCars(c);

            FillProductList();

            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
        }


        private void FillProductList()
        {
            listBox1.Items.Clear();

            List<Car> car = companyBusiness.GetAllCars();

            foreach (Car c in car)
            {
                listBox1.Items.Add("Automobil: " + c.GetSetNameCar + " - tip: " + c.GetSetTypeCar + " - cena: " + c.GetSetPriceCar);
            }
        }


        private void FillCarListWithID()
        {
            listBox1.Items.Clear();

            List<Car> car = companyBusiness.GetAllCars();

            foreach (Car c in car)
            {
                listBox1.Items.Add("ID automobila: " + c.GetSetIdCar + " - automobil: " + c.GetSetNameCar + " - tip: " + c.GetSetTypeCar + " - cena: " + c.GetSetPriceCar);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Molim vas da popunite sva polja.");
                textBox1.Focus();
                return;
            }

            if (!Regex.Match(textBox1.Text, "^[A-Z][a-zA-Z ]*$").Success)
            {
                MessageBox.Show("Uneli ste naziv automobila u pogresnom formatu. Stavite prvo slovo veliko.");
                textBox1.Focus();
                return;
            }

            if (!Regex.Match(textBox3.Text, "^[0-9]*$").Success)
            {
                MessageBox.Show("Uneli ste cenu automobila u pogresnom formatu. Morate uneti samo brojcanu vrednost.");
                textBox3.Focus();
                return;
            }

            Car uc = new Car();
            uc.GetSetIdCar = Convert.ToInt32(textBox4.Text);
            uc.GetSetNameCar = textBox1.Text;
            uc.GetSetTypeCar = textBox2.Text;
            uc.GetSetPriceCar = Convert.ToInt32(textBox3.Text);

            this.companyBusiness.UpdateCars(uc);

            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FillCarListWithID();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        int checker;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checker % 2 == 0)
                textBox4.Enabled = true;
            else
                textBox4.Enabled = false;

            checker++;
        }

        private void Forma1_Load(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            Car dc = new Car();
            dc.GetSetIdCar = Convert.ToInt32(textBox4.Text);

            this.companyBusiness.DeleteCars(dc);

            textBox4.ResetText();
        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checker % 2 == 0)
            {
                button3.Enabled = true;
                textBox4.Enabled = true;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                checkBox1.Enabled = false;
            }
            else
            {
                button3.Enabled = false;
                textBox4.Enabled = false;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                checkBox1.Enabled = true;
            }
            checker++;
        }

        private void Forma1_Load_1(object sender, EventArgs e)
        {

        }

      
    }
}
