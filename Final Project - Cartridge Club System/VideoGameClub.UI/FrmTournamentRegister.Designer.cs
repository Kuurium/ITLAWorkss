namespace VideoGameClub.UI
{
    partial class FrmTournamentRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTournamentRegister));
            txtName = new TextBox();
            dtpStartDate = new DateTimePicker();
            numCapacity = new NumericUpDown();
            txtFormat = new ComboBox();
            txtPrizes = new TextBox();
            txtGameId = new TextBox();
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numCapacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(3, 40);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 0;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(3, 331);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(200, 23);
            dtpStartDate.TabIndex = 1;
            
            // 
            // numCapacity
            // 
            numCapacity.Location = new Point(3, 94);
            numCapacity.Name = "numCapacity";
            numCapacity.Size = new Size(120, 23);
            numCapacity.TabIndex = 2;
            // 
            // txtFormat
            // 
            txtFormat.FormattingEnabled = true;
            txtFormat.Items.AddRange(new object[] { "1 vs 1", "2 vs 2", "3 vs 3", "5 vs 5", "Battle Royale", "Eliminación Directa", "Round Robin" });
            txtFormat.Location = new Point(3, 149);
            txtFormat.Name = "txtFormat";
            txtFormat.Size = new Size(121, 23);
            txtFormat.TabIndex = 3;
            // 
            // txtPrizes
            // 
            txtPrizes.Location = new Point(3, 205);
            txtPrizes.Name = "txtPrizes";
            txtPrizes.Size = new Size(100, 23);
            txtPrizes.TabIndex = 4;
            // 
            // txtGameId
            // 
            txtGameId.Location = new Point(3, 259);
            txtGameId.Name = "txtGameId";
            txtGameId.Size = new Size(100, 23);
            txtGameId.TabIndex = 5;
            
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(3, 372);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 31);
            btnSave.TabIndex = 6;
            btnSave.Text = "Guardar Torneo";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 16);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 7;
            label1.Text = "Torneo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 70);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 8;
            label2.Text = "Capacidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 125);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 9;
            label3.Text = "Formato";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(2, 181);
            label4.Name = "label4";
            label4.Size = new Size(56, 21);
            label4.TabIndex = 10;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(2, 235);
            label5.Name = "label5";
            label5.Size = new Size(72, 21);
            label5.TabIndex = 11;
            label5.Text = "Game ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(1, 298);
            label6.Name = "label6";
            label6.Size = new Size(130, 21);
            label6.TabIndex = 12;
            label6.Text = "Fecha de Torneo";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Gemini_Generated_Image_9rp54h9rp54h9rp5_removebg_preview;
            pictureBox1.Location = new Point(321, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(480, 314);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // FrmTournamentRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(txtGameId);
            Controls.Add(txtPrizes);
            Controls.Add(txtFormat);
            Controls.Add(numCapacity);
            Controls.Add(dtpStartDate);
            Controls.Add(txtName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmTournamentRegister";
            Text = "Registro de Torneo";
            ((System.ComponentModel.ISupportInitialize)numCapacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private DateTimePicker dtpStartDate;
        private NumericUpDown numCapacity;
        private ComboBox txtFormat;
        private TextBox txtPrizes;
        private TextBox txtGameId;
        private Button btnSave;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
    }
}