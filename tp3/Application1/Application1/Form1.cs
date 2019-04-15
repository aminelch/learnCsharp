using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //lbldate.Text = DateTime.Now.ToShortDateString();
            timer1.Enabled = true; 
            // coche le radio 
            RdMas.Checked = true;
            TxtCin.MaxLength = 8; 

          
        }

        //affichage de l'heure et date 
        private void timer1_Tick(object sender, EventArgs e)
        {

            LblDate.Text = "Date:" + DateTime.Now.ToShortDateString() + "  " + " Heure:" + DateTime.Now.ToLongTimeString(); 

        }

   

        private void TxtCin_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TxtLang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (( (e.KeyChar  < '0')   || (e.KeyChar> '9' ) ) ) 
                    e.KeyChar= (char) 0  ; 


        }

        private void TxtTech_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < '0') || (e.KeyChar > '9')))
                e.KeyChar = (char)0; 
        }

        private void TxtLang_Validating(object sender, CancelEventArgs e)
        {
            if (TxtLang.Text == "")
            {
                MessageBox.Show("Il faut saisir  une note ");
                e.Cancel = true;

            }
            else
            {
                if ( int.Parse(TxtLang.Text )> 20 )  {
                   MessageBox.Show("La note doit etre entre 0 et 20 ");
                  TxtLang.SelectAll(); 

                    e.Cancel = true;

                 }
            }
        }

        private void BtnChance_Click(object sender, EventArgs e)
        {
            int x;
            Random alea = new Random() ; 
            x  = alea.Next(0,16) ;
            TxtChance.Text = x.ToString();
 
        }

        private void BtnInit_Click(object sender, EventArgs e)
        {
            TxtCin.Text = "" ;
            TxtLang.Text = "0";
            RdFem.Checked = false;
            CmbAge.SelectedIndex = 1;
            BtnAjout.Enabled = true; 



        }
    }
}
