namespace _18._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void piros_ValueChanged(object sender, EventArgs e)
        {
            sz�n.BackColor = Color.FromArgb(piros.Value, z�ld.Value, k�k.Value);
        }

        private void m�ret_ValueChanged(object sender, EventArgs e)
        {
            sz�n.Width = sz�n.Height = m�ret.Value;
            sz�m.Text = m�ret.Value.ToString();
        }

        private void k�k_ValueChanged(object sender, EventArgs e)
        {
            sz�n.BackColor = Color.FromArgb(piros.Value, z�ld.Value, k�k.Value);
        }

        private void z�ld_ValueChanged(object sender, EventArgs e)
        {
            sz�n.BackColor = Color.FromArgb(piros.Value, z�ld.Value, k�k.Value);
        }
    }
}