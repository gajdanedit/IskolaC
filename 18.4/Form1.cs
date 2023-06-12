namespace _18._4
{
    public partial class Mozog : Form
    {
        public Mozog()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Opacity < 1.0) Opacity += 0.1;
        }

        private void Bt_Kozepre_Click(object sender, EventArgs e)
        {
            Left = (Screen.PrimaryScreen.Bounds.Width - Width) / 2; 
            Top = (Screen.PrimaryScreen.Bounds.Height - Height) / 2;
            Bt_Le.Visible = Bt_Le.Visible = Bt_Fel.Visible = 
            Bt_Fel.Visible = Bt_Balra.Visible = 
            Bt_Balra.Visible = Bt_Jobbra.Visible =
            Bt_Jobbra.Visible = true;
        }

        private void Bt_Fel_Click(object sender, EventArgs e)
        {
            Top = 0; 
            Bt_Fel.Visible = Bt_Fel.Visible = false;
            Bt_Le.Visible = Bt_Le.Visible = true;
        }
    }
}