using System;
using System.Windows.Forms;
using VideoGameClub.Business;

namespace VideoGameClub.UI
{
    public partial class FrmAdminRegister : Form
    {
        private readonly UserService _service;

        public FrmAdminRegister()
        {
            InitializeComponent();
            _service = new UserService();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _service.Register(txtUser.Text, txtPass.Text);
                MessageBox.Show("Admin registrado.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}