namespace VideoGameClub.UI
{
    partial class FrmRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistration));
            label1 = new Label();
            txtTournamentId = new TextBox();
            label2 = new Label();
            txtMemberId = new TextBox();
            dtpDate = new DateTimePicker();
            label3 = new Label();
            btnSave = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(8, 23);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 0;
            label1.Text = "ID del Torneo:";
            // 
            // txtTournamentId
            // 
            txtTournamentId.Location = new Point(12, 47);
            txtTournamentId.Name = "txtTournamentId";
            txtTournamentId.Size = new Size(121, 23);
            txtTournamentId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(8, 86);
            label2.Name = "label2";
            label2.Size = new Size(121, 21);
            label2.TabIndex = 2;
            label2.Text = "ID del Miembro:";
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(8, 110);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(117, 23);
            txtMemberId.TabIndex = 3;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(8, 160);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(8, 136);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 5;
            label3.Text = "Fecha:";
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.Location = new Point(8, 199);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(77, 31);
            btnSave.TabIndex = 6;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Gemini_Generated_Image_9rp54h9rp54h9rp5_removebg_preview;
            pictureBox1.Location = new Point(323, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(480, 341);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(dtpDate);
            Controls.Add(txtMemberId);
            Controls.Add(label2);
            Controls.Add(txtTournamentId);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmRegistration";
            Text = "Registro para Torneo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTournamentId;
        private Label label2;
        private TextBox txtMemberId;
        private DateTimePicker dtpDate;
        private Label label3;
        private Button btnSave;
        private PictureBox pictureBox1;
    }
}