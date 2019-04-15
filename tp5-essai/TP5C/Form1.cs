using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP5C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable("Personne");

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add(new DataColumn("CIN", typeof(String)));
            table.Columns.Add(new DataColumn("Nom", typeof(String)));
            table.Columns.Add(new DataColumn("Prenom", typeof(String)));
            table.Columns.Add(new DataColumn("Ville", typeof(String)));
            table.Columns.Add(new DataColumn("Telephone", typeof(String)));
            table.Columns.Add(new DataColumn("Age", typeof(int)));
            bindingSource1.DataSource = table;
            bindingNavigator1.BindingSource = bindingSource1;
            dataGridView1.DataSource = bindingSource1;    

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            table.Clear();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Fichier XML(*.xml)|*.xml|Tous Les Fichiers(*.*)|*.*";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                table.ReadXml(@openFileDialog1.FileName);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Fichier XML(*.xml)|*.xml|Tous Les Fichiers(*.*)|*.*";
            saveFileDialog1.FileName = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK&& saveFileDialog1.FileName!="")
                table.WriteXml(@saveFileDialog1.FileName);
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ficheirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Form2()).Show();
            this.Hide();
        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
