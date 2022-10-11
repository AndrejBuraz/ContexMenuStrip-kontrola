namespace ContextMenuStripKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lijevoNaDesnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void desnoNaLijevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text;
        }

        private void ctrlDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}