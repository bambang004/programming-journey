namespace kasir_toko_elektronik
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // login agar masuk ke form utama 
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                FormTransaksi formMain = new FormTransaksi();
                formMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
