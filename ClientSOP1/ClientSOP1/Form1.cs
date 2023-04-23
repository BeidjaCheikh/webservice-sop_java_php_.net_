using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClientSOP
{
    public partial class Form1 : Form  

    {
        ServiceReference1.BanqueServiceClient stub;

        public Form1()
        {
            InitializeComponent();
            stub = new ServiceReference1.BanqueServiceClient();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.compte[] comptes = stub.compteList();
            DataTable data = new DataTable("comptes");
            data.Columns.Add("code");
            data.Columns.Add("solde");
            for (int i = 0; i < comptes.Length; i++) {
                data.Rows.Add(comptes[i].code, comptes[i].solde);
            }
            dataGridView1.DataSource = data;


        }

        private void btnConvertion_Click(object sender, EventArgs e)
        {
            double mt = Double.Parse(textBoxMT.Text);
            double res = stub.conversation(mt);
            textBoxRes.Text = res.ToString();
        }

        private void textBoxRes_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
