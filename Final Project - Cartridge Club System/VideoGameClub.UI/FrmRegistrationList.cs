using System;
using System.Windows.Forms;
using VideoGameClub.Business;

namespace VideoGameClub.UI
{
    public partial class FrmRegistrationList : Form
    {
        private readonly RegistrationService _service;

        public FrmRegistrationList()
        {
            InitializeComponent();
            _service = new RegistrationService();
        }

        private void FrmRegistrationList_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = _service.GetRegistrationList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar lista: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 1. Validar que haya una fila seleccionada
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // 2. Obtener datos para confirmar
                // OJO: Asegúrate de que la columna "RegistrationId" existe (aunque esté oculta)
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["RegistrationId"].Value);

                string jugador = dataGridView1.SelectedRows[0].Cells["MemberName"].Value.ToString();
                string torneo = dataGridView1.SelectedRows[0].Cells["TournamentName"].Value.ToString();

                // 3. Preguntar al usuario
                var confirmacion = MessageBox.Show($"¿Eliminar la inscripción de '{jugador}' en '{torneo}'?",
                                                   "Confirmar Baja",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    try
                    {
                        // 4. Eliminar
                        _service.DeleteRegistration(id);
                        MessageBox.Show("Inscripción eliminada correctamente.");

                        // 5. Recargar la lista para ver que desapareció
                        FrmRegistrationList_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una inscripción de la lista.");
            }
        }
    }
}