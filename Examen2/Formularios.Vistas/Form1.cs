using Formularios.Bss;

namespace Formularios.Vistas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NombreCompletoBss bss = new NombreCompletoBss();

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListaNombreCompletoBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
            Close();
            
        }
    }
}