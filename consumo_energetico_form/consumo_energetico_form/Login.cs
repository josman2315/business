namespace consumo_energetico_form
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            interfaceDashboard dashboardForm = new interfaceDashboard();
            dashboardForm.Show();
            this.Hide();
        }

        private void form_Load(object sender, EventArgs e)
        {

        }

        private void register_Click(object sender, EventArgs e)
        {
            formRegister registerForm = new formRegister();
            registerForm.Show();
            this.Hide();
        }
    }
}
