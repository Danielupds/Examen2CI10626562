using Formularios.Bss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios.Vistas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        IngresosBss bss = new IngresosBss();

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaIngresosBss();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("");
        }
    }
}
