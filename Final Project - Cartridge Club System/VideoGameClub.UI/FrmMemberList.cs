using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VideoGameClub.Business;
using VideoGameClub.Entities;

namespace VideoGameClub.UI
{
    public partial class FrmMemberList : Form
    {
        private readonly MemberService _service;

        public FrmMemberList()
        {
            InitializeComponent();
            _service = new MemberService();
        }

        private void FrmMemberList_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Get list from service
                var memberList = _service.GetMembers();

                // 2. Bind to grid
                dataGridView1.DataSource = memberList;

                // 3. Configure columns
                ConfigureColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int searchId;
            Member foundMember;

            // Determine search method logic
            if (int.TryParse(txtSearch.Text, out searchId))
            {
                // Case A: Input is a number -> Search by ID
                foundMember = _service.FindMember(searchId);
            }
            else
            {
                // Case B: Input is text -> Search by Email
                foundMember = _service.FindMember(txtSearch.Text);
            }

            // Display results
            if (foundMember != null)
            {
                // DataGridView requires a List, even for a single object
                var resultList = new List<Member> { foundMember };
                dataGridView1.DataSource = resultList;

                // Re-apply formatting as source change resets it
                ConfigureColumns();
            }
            else
            {
                MessageBox.Show("No se encontró a nadie con esos datos.");
                // Optional: Reload full list if not found
                // FrmMemberList_Load(sender, e); 
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                FrmMemberEdit editForm = new FrmMemberEdit(selectedId);
                editForm.ShowDialog();

                // Refresh list after closing edit form
                FrmMemberList_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un miembro de la lista para editar.");
            }
        }

        private void ConfigureColumns()
        {
            if (dataGridView1.Columns["Id"] != null)
                dataGridView1.Columns["Id"].HeaderText = "ID";

            if (dataGridView1.Columns["FirstName"] != null)
                dataGridView1.Columns["FirstName"].HeaderText = "Nombre";

            if (dataGridView1.Columns["LastName"] != null)
                dataGridView1.Columns["LastName"].HeaderText = "Apellido";

            if (dataGridView1.Columns["NickName"] != null)
                dataGridView1.Columns["NickName"].HeaderText = "Apodo";

            if (dataGridView1.Columns["Email"] != null)
                dataGridView1.Columns["Email"].HeaderText = "Correo";

            if (dataGridView1.Columns["Phone"] != null)
                dataGridView1.Columns["Phone"].HeaderText = "Teléfono";

            if (dataGridView1.Columns["MembershipType"] != null)
            {
                dataGridView1.Columns["MembershipType"].Visible = true;
                dataGridView1.Columns["MembershipType"].HeaderText = "Membresía";
                dataGridView1.Columns["MembershipType"].DisplayIndex = 2;
            }

            if (dataGridView1.Columns["MembershipTypeId"] != null)
                dataGridView1.Columns["MembershipTypeId"].Visible = false;

            if (dataGridView1.Columns["Status"] != null)
                dataGridView1.Columns["Status"].Visible = false;

            if (dataGridView1.Columns["Address"] != null)
                dataGridView1.Columns["Address"].HeaderText = "Dirección";

            if (dataGridView1.Columns["RenewalDate"] != null)
                dataGridView1.Columns["RenewalDate"].HeaderText = "Renovación";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                string memberName = dataGridView1.SelectedRows[0].Cells["FirstName"].Value.ToString();

                var confirmation = MessageBox.Show($"¿Estás seguro de ELIMINAR a '{memberName}'?\nEsta acción no se puede deshacer.",
                                                   "Confirmar Eliminación",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Warning);

                if (confirmation == DialogResult.Yes)
                {
                    try
                    {
                        _service.DeleteMember(id);
                        MessageBox.Show("Miembro eliminado correctamente.");
                        FrmMemberList_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo eliminar.\nProbablemente este miembro tiene registros en torneos.\n\nError técnico: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila primero.");
            }
        }
    }
}