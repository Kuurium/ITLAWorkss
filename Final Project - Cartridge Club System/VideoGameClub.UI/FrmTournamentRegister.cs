using System;
using System.Windows.Forms;
using VideoGameClub.Business;
using VideoGameClub.Entities;

namespace VideoGameClub.UI
{
    public partial class FrmTournamentRegister : Form
    {
        private readonly TournamentService _service;

        public FrmTournamentRegister()
        {
            InitializeComponent();
            _service = new TournamentService();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Tournament newTournament = new Tournament
                {
                    TournamentName = txtName.Text,
                    StartDate = dtpStartDate.Value,
                    TournamentFormat = txtFormat.Text,
                    Prizes = txtPrizes.Text,
                    MaxCapacity = (int)numCapacity.Value,
                    GameId = Convert.ToInt32(txtGameId.Text)
                };

                _service.RegisterTournament(newTournament);

                MessageBox.Show("Torneo creado con éxito.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}