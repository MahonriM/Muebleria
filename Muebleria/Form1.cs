using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Muebleria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                txttv.Enabled=true;
            }
            else
            {
                txttv.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                txtcomedor.Enabled = true;
            }
            else
            {
                txtcomedor.Enabled = false;
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                txtliteras.Enabled = true;
            }
            else
            {
                txtliteras.Enabled = false;
                
            }
        }

        private void btnvender_Click(object sender, EventArgs e)
        {
            lst.Items.Clear();
            if (checkBox1.Checked==true)
            {
                int cantidad =int.Parse(txttv.Text);
                int pagar;
                pagar=cantidad*4500;
                lst.Items.Add("Total a pagar es "+ pagar);
                lst.Items.Add("Articulos comprados "+cantidad);
                lst.Items.Add("Gracias por su compra");
            }
            if (checkBox2.Checked == true)
            {
                int cantidad = int.Parse(txtcomedor.Text);
                int pagar;
                pagar = cantidad * 7500;
                lst.Items.Add("Total a pagar es " + pagar);
                lst.Items.Add("Articulos comprados " + cantidad);
                lst.Items.Add("Gracias por su compra");
            }
            if (checkBox3.Checked == true)
            {
                int cantidad = int.Parse(txtliteras.Text);
                int pagar;
                pagar = cantidad * 2500;
                lst.Items.Add("Total a pagar es " + pagar);
                lst.Items.Add("Articulos comprados " + cantidad);
                lst.Items.Add("Gracias por su compra");
            }
            if (checkBox3.Checked == true&&checkBox2.Checked==true)
            {
                lst.Items.Clear();
                int cantidadl = int.Parse(txtliteras.Text);
                int cantidadc = int.Parse(txtcomedor.Text);
                int pagarl,pagarc,pagartotal,cntotal;
                pagarl = cantidadl * 2500;
                pagarc = cantidadc *7500;
                pagartotal = pagarl + pagarc;
                cntotal=cantidadc+cantidadl;
                lst.Items.Add("Total a pagar es " + pagartotal);
                lst.Items.Add("Articulos comprados " + cntotal);
                lst.Items.Add("Gracias por su compra");
            }
            if (checkBox1.Checked==true&&checkBox3.Checked==true)
            {
                lst.Items.Clear();
                int cntv = int.Parse(txttv.Text);
                int cantidadl = int.Parse(txtliteras.Text);
                int pagart, pagarc, pagartotal, cntotal;
                pagart = cntv * 4500;
                pagarc = cantidadl * 2500;
                pagartotal = pagart + pagarc;
                cntotal = cntv + cantidadl;
                lst.Items.Add("Total a pagar es " + pagartotal);
                lst.Items.Add("Articulos comprados " + cntotal);
                lst.Items.Add("Gracias por su compra");
            }
            if (checkBox1.Checked==true&&checkBox2.Checked==true)
            {
                lst.Items.Clear();
                int cantidadtv = int.Parse(txttv.Text);
                int cantcomedor = int.Parse(txtcomedor.Text);
                int pagartotal, cntotal;
                pagartotal = (cantidadtv * 4500) +  (cantcomedor * 7500);
                cntotal = cantcomedor + cantidadtv ;
                lst.Items.Add("Total a pagar es " + pagartotal);
                lst.Items.Add("Articulos comprados " + cntotal);
                lst.Items.Add("Gracias por su compra");

            }
            if (checkBox1.Checked==true&&checkBox2.Checked==true&&checkBox3.Checked==true)
            {
                lst.Items.Clear();
                int cantidadtv = int.Parse(txttv.Text);
                int cantidadliteras = int.Parse(txtliteras.Text);
                int cantcomedor = int.Parse(txtcomedor.Text);
                int pagartotal,cntotal;
                pagartotal = (cantidadtv * 4500) + (cantidadliteras * 2500) + (cantcomedor * 7500);
                cntotal = cantcomedor + cantidadtv + cantidadliteras;
                lst.Items.Add("Total a pagar es " + pagartotal);
                lst.Items.Add("Articulos comprados " + cntotal);
                lst.Items.Add("Gracias por su compra");
            }
        }
        private void cancelar_Click(object sender, EventArgs e)
        {
            txttv.Text = "0";
            txtcomedor.Text = "0";
            txtliteras.Text = "0";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            lst.Items.Clear();
            lst.Items.Add("Total a pagar es " + "________________");
            lst.Items.Add("Articulos comprados " + "________________");
            lst.Items.Add("Gracias por su compra");
        }
    }
}
