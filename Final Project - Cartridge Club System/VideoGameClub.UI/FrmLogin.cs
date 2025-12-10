using System;
using System.Windows.Forms;
using VideoGameClub.Business;

namespace VideoGameClub.UI
{
    public partial class FrmLogin : Form
    {
        private readonly UserService _service;

        public FrmLogin()
        {
            InitializeComponent();
            _service = new UserService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Verify username and password
                if (_service.Login(txtUser.Text, txtPass.Text))
                {
                    MessageBox.Show("¡Bienvenido!");
                    this.Hide();

                    // Open Main Menu
                    FrmMemberRegister mainMenu = new FrmMemberRegister();

                    // Ensure the entire app closes when the main menu is closed
                    mainMenu.FormClosed += (s, args) => this.Close();

                    mainMenu.Show();
                }
                else
                {
                    MessageBox.Show("Datos incorrectos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmAdminRegister registerForm = new FrmAdminRegister();
            registerForm.ShowDialog();
        }
    }
}