using System;
using System.Windows.Forms;
using VideoGameClub.Business;

namespace VideoGameClub.UI
{
    public partial class FrmTournamentList : Form
    {
        private readonly TournamentService _service;

        public FrmTournamentList()
        {
            InitializeComponent();
            _service = new TournamentService();
        }

        private void FrmTournamentList_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Load data
                dataGridView1.DataSource = _service.GetTournaments();

                // 2. Configure Columns
                ConfigureColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ConfigureColumns()
        {
            if (dataGridView1.Columns["Game"] != null)
            {
                dataGridView1.Columns["Game"].Visible = true;
                dataGridView1.Columns["Game"].HeaderText = "Juego";
            }

            // Hide Game ID
            if (dataGridView1.Columns["GameId"] != null)
                dataGridView1.Columns["GameId"].Visible = false;

            // B. STATUS (Use StatusText property for display)
            if (dataGridView1.Columns["StatusText"] != null)
            {
                dataGridView1.Columns["StatusText"].Visible = true;
                dataGridView1.Columns["StatusText"].HeaderText = "Estado";
            }

            // Hide numeric Status (0, 1)
            if (dataGridView1.Columns["Status"] != null)
                dataGridView1.Columns["Status"].Visible = false;

            // C. Rename headers to Spanish
            if (dataGridView1.Columns["TournamentId"] != null) dataGridView1.Columns["TournamentId"].HeaderText = "ID";
            if (dataGridView1.Columns["TournamentName"] != null) dataGridView1.Columns["TournamentName"].HeaderText = "Torneo";
            if (dataGridView1.Columns["StartDate"] != null) dataGridView1.Columns["StartDate"].HeaderText = "Fecha Inicio";
            if (dataGridView1.Columns["MaxCapacity"] != null) dataGridView1.Columns["MaxCapacity"].HeaderText = "Cupo Máx.";
            if (dataGridView1.Columns["Prizes"] != null) dataGridView1.Columns["Prizes"].HeaderText = "Premios";
            if (dataGridView1.Columns["TournamentFormat"] != null) dataGridView1.Columns["TournamentFormat"].HeaderText = "Formato";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int tournamentId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["TournamentId"].Value);
                int currentStatus = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Status"].Value);
                string name = dataGridView1.SelectedRows[0].Cells["TournamentName"].Value.ToString();

                int newStatus = 0;
                string newStatusText = "";

                // Logic to advance status
                if (currentStatus == 0)
                {
                    newStatus = 1;
                    newStatusText = "En Curso";
                }
                else if (currentStatus == 1)
                {
                    newStatus = 2;
                    newStatusText = "Finalizado";
                }
                else
                {
                    MessageBox.Show("Este torneo ya está Finalizado.");
                    return;
                }

                var confirm = MessageBox.Show($"¿Cambiar '{name}' a estado {newStatusText}?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    _service.UpdateTournamentStatus(tournamentId, newStatus);
                    FrmTournamentList_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un torneo primero.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["TournamentId"].Value);
                string name = dataGridView1.SelectedRows[0].Cells["TournamentName"].Value.ToString();

                var confirmation = MessageBox.Show($"¿Eliminar el torneo '{name}'?",
                                                   "Confirmar",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Warning);

                if (confirmation == DialogResult.Yes)
                {
                    try
                    {
                        _service.DeleteTournament(id);
                        MessageBox.Show("Torneo eliminado.");
                        FrmTournamentList_Load(sender, e);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se puede eliminar el torneo porque ya tiene jugadores inscritos.", "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona un torneo primero.");
            }
        }


    }
}