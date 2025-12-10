using System;
using System.Windows.Forms;
using VideoGameClub.Business;
using VideoGameClub.Entities;

namespace VideoGameClub.UI
{
    public partial class FrmMemberRegister : Form
    {
        // Declare the service
        private readonly MemberService _memberService;

        public FrmMemberRegister()
        {
            InitializeComponent();
            _memberService = new MemberService();
        }

        private void FrmMemberRegister_Load(object sender, EventArgs e)
        {
            try
            {
                MemberService service = new MemberService();
                var membershipList = service.GetMembershipTypes();

                if (membershipList.Count == 0)
                {
                    MessageBox.Show("Alerta: La base de datos devolvió 0 membresías.");
                }

                // Bind combo box
                cmbMembership.DataSource = membershipList;
                cmbMembership.DisplayMember = "DisplayText";
                cmbMembership.ValueMember = "MembershipTypeId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Member newMember = new Member
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text,
                    Address = txtAddress.Text,
                    BirthDate = dtpBirthDate.Value,
                    MembershipTypeId = Convert.ToInt32(cmbMembership.SelectedValue),
                    Status = 1,
                    JoinDate = DateTime.Now
                };

                _memberService.RegisterMember(newMember);

                MessageBox.Show("¡Miembro registrado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CleanForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Helper method to clear inputs
        private void CleanForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();

            dtpBirthDate.Value = DateTime.Now;

            // Reset combo box selection
            if (cmbMembership.Items.Count > 0)
                cmbMembership.SelectedIndex = 0;

            // Set focus back to first name
            txtFirstName.Focus();
        }

        private void btnTestOverload_Click(object sender, EventArgs e)
        {
            try
            {
                // TEST 1: Search by ID (int) -> Uses Overload 1
                Member member1 = _memberService.FindMember(1);

                // TEST 2: Search by Email (string) -> Uses Overload 2
                Member member2 = _memberService.FindMember("Testeo@gmail.com");

                // Display results
                string message = "";

                if (member1 != null)
                    message += $" Búsqueda por ID (1) encontró a: {member1.FirstName} {member1.LastName}\n";
                else
                    message += " Búsqueda por ID falló.\n";

                if (member2 != null)
                    message += $" Búsqueda por Email encontró a: {member2.FirstName} {member2.LastName}";
                else
                    message += " Búsqueda por Email falló.";

                MessageBox.Show(message, "Prueba de Sobrecarga");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnViewList_Click(object sender, EventArgs e)
        {
            FrmMemberList listForm = new FrmMemberList();
            listForm.ShowDialog();
        }

        // -- Navigation Buttons (Shortcuts) --

        private void btnNewTournament_Click(object sender, EventArgs e)
        {
            FrmTournamentRegister tournamentForm = new FrmTournamentRegister();
            tournamentForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTournamentList listForm = new FrmTournamentList();
            listForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmRegistration regForm = new FrmRegistration();
            regForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmRegistrationList regList = new FrmRegistrationList();
            regList.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}