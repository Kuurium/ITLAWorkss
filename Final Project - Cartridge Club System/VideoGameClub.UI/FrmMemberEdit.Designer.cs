namespace VideoGameClub.UI
{
    partial class FrmMemberEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMemberEdit));
            label6 = new Label();
            cmbMembership = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSave = new Button();
            dtpBirthDate = new DateTimePicker();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label7 = new Label();
            txtAddress = new TextBox();
            label8 = new Label();
            cmbSkill = new ComboBox();
            label9 = new Label();
            cmbRole = new ComboBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(5, 223);
            label6.Name = "label6";
            label6.Size = new Size(92, 21);
            label6.TabIndex = 30;
            label6.Text = "Membresia";
            // 
            // cmbMembership
            // 
            cmbMembership.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMembership.FormattingEnabled = true;
            cmbMembership.Location = new Point(5, 251);
            cmbMembership.Name = "cmbMembership";
            cmbMembership.Size = new Size(164, 23);
            cmbMembership.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(5, 330);
            label5.Name = "label5";
            label5.Size = new Size(163, 21);
            label5.TabIndex = 28;
            label5.Text = "Fecha de Nacimiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(5, 174);
            label4.Name = "label4";
            label4.Size = new Size(150, 21);
            label4.TabIndex = 27;
            label4.Text = "Numero Telefonico";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(5, 118);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 26;
            label3.Text = "Correo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(5, 60);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 25;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 5);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 24;
            label1.Text = "Nombre";
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(5, 397);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(151, 31);
            btnSave.TabIndex = 23;
            btnSave.Text = "Guardar Cambios";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(5, 357);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(224, 23);
            dtpBirthDate.TabIndex = 22;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(5, 198);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Ingrese el nuevo num telefonico";
            txtPhone.Size = new Size(181, 23);
            txtPhone.TabIndex = 21;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(5, 142);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Ingrese el nuevo correo";
            txtEmail.Size = new Size(164, 23);
            txtEmail.TabIndex = 20;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(5, 84);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Ingrese el nuevo apellido";
            txtLastName.Size = new Size(142, 23);
            txtLastName.TabIndex = 19;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(5, 29);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "Ingrese el nuevo nombre";
            txtFirstName.Size = new Size(142, 23);
            txtFirstName.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(5, 277);
            label7.Name = "label7";
            label7.Size = new Size(79, 21);
            label7.TabIndex = 31;
            label7.Text = "Dirección";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(5, 301);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Ingrese la nueva direccion";
            txtAddress.Size = new Size(164, 23);
            txtAddress.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(256, 5);
            label8.Name = "label8";
            label8.Size = new Size(47, 21);
            label8.TabIndex = 33;
            label8.Text = "Nivel";
            // 
            // cmbSkill
            // 
            cmbSkill.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSkill.FormattingEnabled = true;
            cmbSkill.Items.AddRange(new object[] { "Principiante", "Intermedio", "Avanzado", "Pro" });
            cmbSkill.Location = new Point(256, 29);
            cmbSkill.Name = "cmbSkill";
            cmbSkill.Size = new Size(121, 23);
            cmbSkill.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(256, 60);
            label9.Name = "label9";
            label9.Size = new Size(34, 21);
            label9.TabIndex = 35;
            label9.Text = "Rol";
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Jugador", "Staff", "Admin", "Caster" });
            cmbRole.Location = new Point(256, 84);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(121, 23);
            cmbRole.TabIndex = 36;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Gemini_Generated_Image_9rp54h9rp54h9rp5_removebg_preview;
            pictureBox1.Location = new Point(383, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(419, 296);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // FrmMemberEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(cmbRole);
            Controls.Add(label9);
            Controls.Add(cmbSkill);
            Controls.Add(label8);
            Controls.Add(txtAddress);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cmbMembership);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(dtpBirthDate);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMemberEdit";
            Text = "Editar Miembros";
            Load += FrmMemberEdit_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private ComboBox cmbMembership;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSave;
        private DateTimePicker dtpBirthDate;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label7;
        private TextBox txtAddress;
        private Label label8;
        private ComboBox cmbSkill;
        private Label label9;
        private ComboBox cmbRole;
        private PictureBox pictureBox1;
    }
}