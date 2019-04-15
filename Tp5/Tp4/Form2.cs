using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp5
{
    public partial class Form2 : Form
    {
        //déclaration globale 
        DataTable table = new DataTable("Personne"); 
        //Création d'une liste de Personne 
        //List<Personne> table = new List<Personne>(); 
    

        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            bindingSource1.DataSource = table;
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1;

          
           
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
     

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DataRow dtr = table.NewRow();
            

            dtr[0] = TxtCin.Text;
            dtr[1] = TxtNom.Text;
            dtr[2] = TxtPrenom.Text;
            dtr[3] = TxtVille.Text;
            dtr[4] = TxtTel.Text;
            dtr[5] = TxtAge.Text;
           
            table.Rows.Add(dtr);

            TxtCin.Text = "";
            TxtNom.Text = "";
            TxtPrenom.Text = "";
            TxtTel.Text = "";
            TxtAge.Text = "";

            TxtCin.Focus(); 
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string ch;
            int nb;
            nb = bindingSource1.Position; 
            ch ="CIN = " + table.Rows[nb][0].ToString() + (char)10 + "Nom =" + table.Rows[nb][1].ToString() + (char)10 +
                "Prenom =" + table.Rows[nb][2].ToString() + (char)10 +
                    "Ville ="  + table.Rows[nb][3].ToString() + (char)10 +
                "Téléphone = " + table.Rows[nb][4].ToString() + (char)10 + 
                  "Age = " + table.Rows[nb][5].ToString();
            MessageBox.Show(ch ,  "Détails de la personne numéro " + nb.ToString()) ; 
                  }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
       


        }
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table.Clear();
        }

        private void form2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            (new Form2()).Show();
            this.Hide();
        }
    }
}
