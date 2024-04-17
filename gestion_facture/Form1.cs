using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gestion_facture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void clearData(){
            numero.Clear();
            date.Text = "";
            ht.Clear();
            tva.Clear();
            ttc.Clear();
        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            int r = int.Parse(ht.Text) + int.Parse(tva.Text);
            ttc.Text = r.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add(numero.Text, date.Text, ht.Text, tva.Text, ttc.Text);
            clearData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows.RemoveAt(e.RowIndex);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
