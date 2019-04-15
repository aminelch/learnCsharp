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
    public partial class Form3 : Form
    {
     List<Personne> P = new List<Personne>();
      
        
        DataTable table = new DataTable("Personne"); 
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            bindingSource1.DataSource = table; 
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1; 
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            string ch;
            int nb;
            nb = bindingSource1.Position;
            ch = "CIN = " + table.Rows[nb][0].ToString() + (char)10 + "Nom =" + table.Rows[nb][1].ToString() + (char)10 +
                "Prenom =" + table.Rows[nb][2].ToString() + (char)10 +
                    "Ville =" + table.Rows[nb][3].ToString() + (char)10 +
                "Téléphone = " + table.Rows[nb][4].ToString() + (char)10 +
                  "Age = " + table.Rows[nb][5].ToString();
            MessageBox.Show(ch, "Détails de la personne numéro " + nb.ToString()); 
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
              Personne Personne = new Personne();

            Personne.CIN = TxtCin.Text;
            Personne.Nom= TxtNom.Text;
            Personne.Prenom = TxtCin.Text;
            Personne.Ville= TxtCin.Text;
            Personne.Tel = TxtCin.Text;
            Personne.Age = int.Parse(TxtAge.Text);
            
            P.Add(Personne); 
            bindingSource1.ResetBindings(true);
        
            TxtCin.Text = "";
            TxtNom.Text = "";
            TxtPrenom.Text = "";
            TxtTel.Text = "";
            TxtAge.Text = "";

        }


        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Form2()).Show();
            this.Hide();
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Form3()).Show();
            this.Hide();


        }
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }

        private void form3ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            (new Form3()).Show();
            this.Hide();
        }

        private void quitterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit(); 

        }
    }
}
