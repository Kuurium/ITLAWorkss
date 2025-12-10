using System;
using System.Windows.Forms;
using VideoGameClub.Business;
using VideoGameClub.Entities;

namespace VideoGameClub.UI
{
    public partial class FrmRegistration : Form
    {
        private readonly RegistrationService _service;

        public FrmRegistration()
        {
            InitializeComponent();
            _service = new RegistrationService();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Basic Validation
                if (string.IsNullOrWhiteSpace(txtTournamentId.Text) || string.IsNullOrWhiteSpace(txtMemberId.Text))
                {
                    MessageBox.Show("Por favor, ingresa tanto el ID del Torneo como el ID del Miembro.");
                    return;
                }

                Registration newRegistration = new Registration
                {
                    TournamentId = Convert.ToInt32(txtTournamentId.Text),
                    MemberId = Convert.ToInt32(txtMemberId.Text),
                    RegistrationDate = dtpDate.Value
                };

                _service.RegisterMember(newRegistration);

                MessageBox.Show("¡Inscripción realizada con éxito!");
                this.Close();
            }
            catch (Exception ex)
            {
                // Catches database errors (e.g., ID does not exist, or tournament full)
                MessageBox.Show("Error al inscribir: " + ex.Message);
            }
        }
    }
}