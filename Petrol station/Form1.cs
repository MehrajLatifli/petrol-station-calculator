using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petrol_station
{
    public delegate void MyDelegate(object sender, EventArgs e);
    public partial class PetrolStation : Form
    {
        public PetrolStation()
        {
            InitializeComponent();
        }

        decimal A92price = 0.7M;
        decimal A95price = 0.9M;
        decimal A98price = 1.0M;
        decimal Diesel = 0.8M;
        decimal Gas = 0.5M;

        decimal r = 0;
        decimal g = 0;
        decimal a = 0;

        decimal b = 0;
        decimal m = 0;
        decimal f = 0;
        decimal l = 0;
        decimal b2 = 0;
        decimal m2 = 0;
        decimal f2 = 0;
        decimal l2 = 0;
        decimal r21 = 0;
        decimal r22 = 0;
        decimal r23 = 0;
        decimal r24 = 0;
        decimal r2 = 0;

        decimal r3 = 0;

        private void Gasolineguna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (Gasolineguna2ComboBox1.Text == "A-92")
            {

                Priceguna2TextBox1.Text = $" {A92price} €";
                BycashButton1.Enabled = true;
                BygallonradioButton1.Enabled = true;
            }

            if (Gasolineguna2ComboBox1.Text == "A-95")
            {

                Priceguna2TextBox1.Text = $" {A95price} €";
                BycashButton1.Enabled = true;
                BygallonradioButton1.Enabled = true;
            }

            if (Gasolineguna2ComboBox1.Text == "A-98")
            {

                Priceguna2TextBox1.Text = $" {A98price} €";
                BycashButton1.Enabled = true;
                BygallonradioButton1.Enabled = true;
            }

            if (Gasolineguna2ComboBox1.Text == "Diesel")
            {

                Priceguna2TextBox1.Text = $" {Diesel} €";
                BycashButton1.Enabled = true;
                BygallonradioButton1.Enabled = true;
            }

            if (Gasolineguna2ComboBox1.Text == "Gas")
            {

                Priceguna2TextBox1.Text = $" {Gas} €";
                BycashButton1.Enabled = true;
                BygallonradioButton1.Enabled = true;
            }

          
        }

        private void RefuelingTextBox1_KeyPressButton1_CheckedChanged(object sender, EventArgs e)
        {
           
                if (BygallonradioButton1.Checked)
                {
                    Cashguna2TextBox1.Enabled = false;
                    if (BycashButton1.Checked == false)
                    {
                        Gallonguna2TextBox1.Enabled = true;
                        if (Cashguna2TextBox1.Text != "")
                        {
                            Cashguna2TextBox1.Clear();
                        }
                    }
                }

            


            if (BycashButton1.Checked)
            {
                Gallonguna2TextBox1.Enabled = false;
                if (BygallonradioButton1.Checked == false)
                {
                    Cashguna2TextBox1.Enabled = true;

                    if (Gallonguna2TextBox1.Text != "")
                    {
                        Gallonguna2TextBox1.Clear();
                    }
                }
            }
        }

        string gtext = "";
        string atext = "";
        private void Gallonguna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
       
            }


        }

        private void Amountguna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
         
            }
        }

        private void Result1guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            decimal r = int.Parse(Result1guna2HtmlLabel1.Text);

            decimal g = int.Parse(Gallonguna2TextBox1.Text);

            decimal a = int.Parse(Cashguna2TextBox1.Text);
            if (BygallonradioButton1.Checked == true)
            {
                gtext = Gallonguna2TextBox1.Text;
                r = g;
            }

            if (BycashButton1.Checked == true)
            {
                atext = Cashguna2TextBox1.Text;
                r = a;
            }

            Result1guna2HtmlLabel1.Text = $"{r}";
        }



      



        private void Result1guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (BygallonradioButton1.Enabled==true)
            {
                if (Gasolineguna2ComboBox1.Text == "A-92")
                {

                    if (BygallonradioButton1.Checked == true)
                    {
                        if (Gallonguna2TextBox1.Text != "")
                        {
                            g = decimal.Parse(Gallonguna2TextBox1.Text);

                            r = g * 0.7M;
                        }
                        else
                        {
                            r = 0;
                        }

                    }


                }

                if (Gasolineguna2ComboBox1.Text == "A-95")
                {


                    if (BygallonradioButton1.Checked == true)
                    {
                        if (Gallonguna2TextBox1.Text != "")
                        {
                            g = decimal.Parse(Gallonguna2TextBox1.Text);

                            r = g * 0.9M;
                        }
                        else
                        {
                            r = 0;
                        }
                    }



                }

                if (Gasolineguna2ComboBox1.Text == "A-98")
                {


                    if (BygallonradioButton1.Checked == true)
                    {
                        if (Gallonguna2TextBox1.Text != "")
                        {
                            g = decimal.Parse(Gallonguna2TextBox1.Text);

                            r = g * 1M;
                        }
                        else
                        {
                            r = 0;
                        }
                    }


                }

                if (Gasolineguna2ComboBox1.Text == "Diesel")
                {


                    if (BygallonradioButton1.Checked == true)
                    {
                        if (Gallonguna2TextBox1.Text != "")
                        {
                            g = decimal.Parse(Gallonguna2TextBox1.Text);

                            r = g * 0.8M;
                        }
                        else
                        {
                            r = 0;
                        }
                    }


                }

                if (Gasolineguna2ComboBox1.Text == "Gas")
                {


                    if (BygallonradioButton1.Checked == true)
                    {
                        if (Gallonguna2TextBox1.Text != "")
                        {
                            g = decimal.Parse(Gallonguna2TextBox1.Text);

                            r = g * 0.5M;
                        }
                        else
                        {
                            r = 0;
                        }
                    }


                }
                Result1guna2HtmlLabel1.Text = $"{r}";
            }

            if (BycashButton1.Enabled == true)
            {
                if (Gasolineguna2ComboBox1.Text == "A-92")
                {

                    if (BycashButton1.Checked == true)
                    {
                        if (Cashguna2TextBox1.Text != "")
                        {
                            a = decimal.Parse(Cashguna2TextBox1.Text);

                            r = a / 0.7M;
                        }
                        else
                        {
                            r = 0;
                        }
                    }


                }

                if (Gasolineguna2ComboBox1.Text == "A-95")
                {

                    if (BycashButton1.Checked == true)
                    {
                        if (Cashguna2TextBox1.Text != "")
                        {
                            a = decimal.Parse(Cashguna2TextBox1.Text);

                            r = a / 0.9M;
                        }
                        else
                        {
                            r = 0;
                        }

                    }


                }

                if (Gasolineguna2ComboBox1.Text == "A-98")
                {

                    if (BycashButton1.Checked == true)
                    {
                        if (Cashguna2TextBox1.Text != "")
                        {
                            a = decimal.Parse(Cashguna2TextBox1.Text);

                            r = a / 1M;
                        }
                        else
                        {
                            r = 0;
                        }
                    }


                }

                if (Gasolineguna2ComboBox1.Text == "Diesel")
                {

                    if (BycashButton1.Checked == true)
                    {
                        if (Cashguna2TextBox1.Text != "")
                        {
                            a = decimal.Parse(Cashguna2TextBox1.Text);

                            r = a / 0.8M;
                        }
                        else
                        {
                            r = 0;
                        }
                    }


                }

                if (Gasolineguna2ComboBox1.Text == "Gas")
                {

                    if (BycashButton1.Checked == true)
                    {
                        if (Cashguna2TextBox1.Text != "")
                        {
                            a = decimal.Parse(Cashguna2TextBox1.Text);

                            r = a / 0.5M;
                        }
                        else
                        {
                            r = 0;
                        }
                    }


                }

            }
                r = (decimal)Math.Round(r, 2);

                Result1guna2HtmlLabel1.Text = r.ToString();
        }

        private void LentilsoupcheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            Lentilsoupguna2TextBox2.Enabled = true;
            if(LentilsoupcheckBox2.Checked==false)
            {
                Lentilsoupguna2TextBox2.Enabled = false;

                if (Lentilsoupguna2TextBox2.Text != "")
                {
                    Lentilsoupguna2TextBox2.Clear();
                    r23 = 0;
                }
            }
        }

        private void MeatdonercheckBox2_CheckedChanged(object sender, EventArgs e)
        {
                Meatdonerguna2TextBox2.Enabled = true;
            if (MeatdonercheckBox2.Checked == false)
            {
                Meatdonerguna2TextBox2.Enabled = false;

                if (Meatdonerguna2TextBox2.Text != "")
                {
                    Meatdonerguna2TextBox2.Clear();
                    r22 = 0;
                }
            }
        }

        private void FriedpotatoescheckBox2_CheckedChanged(object sender, EventArgs e)
        {
                Friedpotatoesguna2TextBox1.Enabled = true;
            if (FriedpotatoescheckBox2.Checked == false)
            {
                Friedpotatoesguna2TextBox1.Enabled = false;

                if (Friedpotatoesguna2TextBox1.Text != "")
                {
                    Friedpotatoesguna2TextBox1.Clear();
                    r24 = 0;
                }
            }
        }

        private void ButtermilkcheckBox1_CheckedChanged(object sender, EventArgs e)
        {
                Buttermilkguna2TextBox1.Enabled = true;
            if (ButtermilkcheckBox1.Checked == false)
            {

                Buttermilkguna2TextBox1.Enabled = false;
                if (Buttermilkguna2TextBox1.Text != "")
                {
                    Buttermilkguna2TextBox1.Clear();
                    r21 = 0;
                }
            }
        }

        private void Mealprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

   
        private void Result2guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if(ButtermilkcheckBox1.Checked==true )
            {
                b = decimal.Parse(Buttermilkguna2TextBox1.Text);
                b2 = decimal.Parse(ButtermilkPriceguna2TextBox1.Text);

                if (b2 * b==0)
                {
                    r21 = 0;
                }
                else
                {
                r21 = b2 * b;

                }


            }

            if (MeatdonercheckBox2.Checked == true)
            {
                m = decimal.Parse(Meatdonerguna2TextBox2.Text);
                m2 = decimal.Parse(MeatdonerPriceguna2TextBox2.Text);

                if (m2 * m == 0)
                {
                    r22 = 0;
                }
                else
                {

                r22 = m2 * m;
                }
            }

            if (LentilsoupcheckBox2.Checked == true)
            {
                l = decimal.Parse(Lentilsoupguna2TextBox2.Text);
                l2 = decimal.Parse(LentilSoupPriceguna2TextBox4.Text);


                if (l2 * l == 0)
                {
                    r23 = 0;
                }
                else
                {
                r23 = l2 * l;

                }


            }

            if (FriedpotatoescheckBox2.Checked == true)
            {
                f = decimal.Parse(Friedpotatoesguna2TextBox1.Text);
                f2 = decimal.Parse(FriedPotetoesPriceguna2TextBox3.Text);

               

            
               
                    if (f2 * f == 0)
                    {
                        r24 = 0;
                    }

                    else
                    {
                        r24 = f2 * f;
                    }
                
            }

            r2 = r21 + r22 + r23 + r24;
            r2 = (decimal)Math.Round(r2, 2);

            Result2guna2HtmlLabel1.Text = r2.ToString();
        }

        
        private void Totalguna2GradientButton1_Click(object sender, EventArgs e)
        {
            //Form1 form1 = new Form1();
            //MyDelegate myDelegate = form1.Result1guna2GradientButton1_Click;
            //myDelegate += form1.Result2guna2GradientButton1_Click;
            //myDelegate.Invoke( sender,  e);


            r3 = r + r2;
            r3 = (decimal)Math.Round(r3, 2);
            Result3guna2HtmlLabel1.Text = r3.ToString();
        }

        
    }
}
