using System;
using System.Windows.Forms;
using VideoGameClub.Business;
using VideoGameClub.Entities;

namespace VideoGameClub.UI
{
    public partial class FrmMemberEdit : Form
    {
        private readonly MemberService _service;
        private readonly int _memberIdToEdit;

        public FrmMemberEdit(int memberId)
        {
            InitializeComponent();
            _service = new MemberService();
            _memberIdToEdit = memberId;
        }

        private void FrmMemberEdit_Load(object sender, EventArgs e)
        {
            try
            {
                // A. Load Membership ComboBox (Same as Register form)
                var membershipTypes = _service.GetMembershipTypes();
                cmbMembership.DataSource = membershipTypes;
                cmbMembership.DisplayMember = "DisplayText";
                cmbMembership.ValueMember = "MembershipTypeId";

                // B. Load current Member data
                Member member = _service.GetMemberById(_memberIdToEdit);

                if (member != null)
                {
                    txtFirstName.Text = member.FirstName;
                    txtLastName.Text = member.LastName;
                    txtEmail.Text = member.Email;
                    txtPhone.Text = member.Phone;
                    txtAddress.Text = member.Address ?? "";
                    dtpBirthDate.Value = member.BirthDate;

                    // Set selected items for skill and role
                    cmbSkill.SelectedItem = member.SkillLevel;
                    cmbRole.SelectedItem = member.ClubRole;

                    // Automatically select their current membership type
                    cmbMembership.SelectedValue = member.MembershipTypeId;
                }
                else
                {
                    MessageBox.Show("No se encontró el miembro.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Member updatedMember = new Member
                {
                    Id = _memberIdToEdit,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text,
                    Address = txtAddress.Text,
                    SkillLevel = cmbSkill.SelectedItem?.ToString(),
                    ClubRole = cmbRole.SelectedItem?.ToString(),
                    BirthDate = dtpBirthDate.Value,
                    MembershipTypeId = Convert.ToInt32(cmbMembership.SelectedValue),
                    Status = 1
                };

                _service.UpdateMember(updatedMember);

                MessageBox.Show("¡Datos actualizados correctamente!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }
    }
}