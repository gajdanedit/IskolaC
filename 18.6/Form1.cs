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
            szín.BackColor = Color.FromArgb(piros.Value, zöld.Value, kék.Value);
        }

        private void méret_ValueChanged(object sender, EventArgs e)
        {
            szín.Width = szín.Height = méret.Value;
            szám.Text = méret.Value.ToString();
        }

        private void kék_ValueChanged(object sender, EventArgs e)
        {
            szín.BackColor = Color.FromArgb(piros.Value, zöld.Value, kék.Value);
        }

        private void zöld_ValueChanged(object sender, EventArgs e)
        {
            szín.BackColor = Color.FromArgb(piros.Value, zöld.Value, kék.Value);
        }
    }
}