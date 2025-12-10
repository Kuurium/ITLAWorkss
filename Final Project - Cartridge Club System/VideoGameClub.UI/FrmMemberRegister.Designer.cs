namespace VideoGameClub.UI
{
    partial class FrmMemberRegister
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMemberRegister));
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            dtpBirthDate = new DateTimePicker();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnViewList = new Button();
            imageList1 = new ImageList(components);
            btnNewTournament = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            cmbMembership = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            txtAddress = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(8, 33);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "Ingrese su nombre";
            txtFirstName.Size = new Size(121, 23);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(8, 88);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Ingrese su apellido";
            txtLastName.Size = new Size(121, 23);
            txtLastName.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(8, 138);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Ingrese su correo electronico";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(8, 188);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Ingrese su Num Telefonico";
            txtPhone.Size = new Size(155, 23);
            txtPhone.TabIndex = 3;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(4, 340);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(221, 23);
            dtpBirthDate.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(4, 378);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(185, 33);
            btnSave.TabIndex = 5;
            btnSave.Text = "Registrar miembro";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 6;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 64);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 7;
            label2.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 114);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 8;
            label3.Text = "Correo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(8, 164);
            label4.Name = "label4";
            label4.Size = new Size(154, 21);
            label4.TabIndex = 9;
            label4.Text = "Numero Telefonico:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(8, 316);
            label5.Name = "label5";
            label5.Size = new Size(163, 21);
            label5.TabIndex = 10;
            label5.Text = "Fecha de Nacimiento";
            // 
            // btnViewList
            // 
            btnViewList.AutoSize = true;
            btnViewList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewList.Location = new Point(4, 415);
            btnViewList.Name = "btnViewList";
            btnViewList.Size = new Size(185, 31);
            btnViewList.TabIndex = 11;
            btnViewList.Text = "Ver lista de miembros";
            btnViewList.UseVisualStyleBackColor = true;
            btnViewList.Click += btnViewList_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // btnNewTournament
            // 
            btnNewTournament.AutoSize = true;
            btnNewTournament.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNewTournament.Location = new Point(195, 415);
            btnNewTournament.Name = "btnNewTournament";
            btnNewTournament.Size = new Size(145, 31);
            btnNewTournament.TabIndex = 12;
            btnNewTournament.Text = "Nuevo torneo";
            btnNewTournament.UseVisualStyleBackColor = true;
            btnNewTournament.Click += btnNewTournament_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(346, 415);
            button1.Name = "button1";
            button1.Size = new Size(140, 31);
            button1.TabIndex = 13;
            button1.Text = "Lista de torneos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(492, 415);
            button2.Name = "button2";
            button2.Size = new Size(156, 31);
            button2.TabIndex = 14;
            button2.Text = "Inscribir Miembro";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(654, 415);
            button3.Name = "button3";
            button3.Size = new Size(115, 31);
            button3.TabIndex = 15;
            button3.Text = "Ver registros";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // cmbMembership
            // 
            cmbMembership.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMembership.FormattingEnabled = true;
            cmbMembership.Location = new Point(4, 238);
            cmbMembership.Name = "cmbMembership";
            cmbMembership.Size = new Size(159, 23);
            cmbMembership.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(8, 214);
            label6.Name = "label6";
            label6.Size = new Size(92, 21);
            label6.TabIndex = 17;
            label6.Text = "Membresia";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(8, 266);
            label7.Name = "label7";
            label7.Size = new Size(83, 21);
            label7.TabIndex = 18;
            label7.Text = "Dirección:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(4, 290);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Ingrese su direccion";
            txtAddress.Size = new Size(200, 23);
            txtAddress.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Gemini_Generated_Image_9rp54h9rp54h9rp5_removebg_preview;
            pictureBox1.Location = new Point(315, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(454, 292);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // FrmMemberRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(777, 458);
            Controls.Add(pictureBox1);
            Controls.Add(txtAddress);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cmbMembership);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnNewTournament);
            Controls.Add(btnViewList);
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
            Name = "FrmMemberRegister";
            Text = "Registro de Miembro";
            Load += FrmMemberRegister_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;      
        private TextBox txtPhone;
        private DateTimePicker dtpBirthDate;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnViewList;
        private ImageList imageList1;
        private Button btnNewTournament;
        private Button button1;
        private Button button2;
        private Button button3;
        private ComboBox cmbMembership;
        private Label label6;
        private Label label7;
        private TextBox txtAddress;
        private PictureBox pictureBox1;
    }
}