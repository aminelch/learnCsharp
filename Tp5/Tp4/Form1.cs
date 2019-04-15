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
    public partial class Form1 : Form
    {
        //déclaration globale 
        DataTable table = new DataTable("Personne"); 
        

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = table;
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1;

          //  new( Form3() ).Show() ; 

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 


        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            table.Clear(); 
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Fichier XML (*.xml) | *.xml |Tous Les Fichiers (*.*) |*.*";
            openFileDialog1.FileName = "";
                if(openFileDialog1.ShowDialog() == DialogResult.OK) {
                   table.ReadXml(@openFileDialog1.FileName);
                    //table.ReadXmlSchema(@openFileDialog1.FileName); 

                }
        }

        private void enregistrerSousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Fichier XML (*.xml) | *.xml |Tous Les Fichiers (*.*) |*.*";
            saveFileDialog1.FileName = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                table.WriteXml(@saveFileDialog1.FileName); 
                //table.WriteXmlSchema(@saveFileDialog1.FileName); 
            }
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

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
