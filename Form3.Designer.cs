namespace PetsBook
{
    partial class Form3
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
            this.dataGridViewPets = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxPetName = new System.Windows.Forms.TextBox();
            this.listBoxNotifications = new System.Windows.Forms.ListBox();
            this.pictureBoxPetPhoto = new System.Windows.Forms.PictureBox();
            this.textBoxPetBreed = new System.Windows.Forms.TextBox();
            this.textBoxPetAge = new System.Windows.Forms.TextBox();
            this.textBoxOwnerFirstName = new System.Windows.Forms.TextBox();
            this.textBoxOwnerLastName = new System.Windows.Forms.TextBox();
            this.textBoxOwnerAddress = new System.Windows.Forms.TextBox();
            this.textBoxOwnerPhone = new System.Windows.Forms.TextBox();
            this.buttonAddPet = new System.Windows.Forms.Button();
            this.buttonDeletePet = new System.Windows.Forms.Button();
            this.ButtonEditPet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPetPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPets
            // 
            this.dataGridViewPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewPets.Location = new System.Drawing.Point(283, 12);
            this.dataGridViewPets.Name = "dataGridViewPets";
            this.dataGridViewPets.Size = new System.Drawing.Size(505, 150);
            this.dataGridViewPets.TabIndex = 0;
            this.dataGridViewPets.SelectionChanged += new System.EventHandler(this.dataGridViewPets_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // textBoxPetName
            // 
            this.textBoxPetName.Location = new System.Drawing.Point(140, 158);
            this.textBoxPetName.Name = "textBoxPetName";
            this.textBoxPetName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPetName.TabIndex = 1;
            // 
            // listBoxNotifications
            // 
            this.listBoxNotifications.FormattingEnabled = true;
            this.listBoxNotifications.Location = new System.Drawing.Point(274, 212);
            this.listBoxNotifications.Name = "listBoxNotifications";
            this.listBoxNotifications.Size = new System.Drawing.Size(120, 173);
            this.listBoxNotifications.TabIndex = 2;
            // 
            // pictureBoxPetPhoto
            // 
            this.pictureBoxPetPhoto.Location = new System.Drawing.Point(21, 12);
            this.pictureBoxPetPhoto.Name = "pictureBoxPetPhoto";
            this.pictureBoxPetPhoto.Size = new System.Drawing.Size(115, 115);
            this.pictureBoxPetPhoto.TabIndex = 3;
            this.pictureBoxPetPhoto.TabStop = false;
            // 
            // textBoxPetBreed
            // 
            this.textBoxPetBreed.Location = new System.Drawing.Point(140, 188);
            this.textBoxPetBreed.Name = "textBoxPetBreed";
            this.textBoxPetBreed.Size = new System.Drawing.Size(100, 20);
            this.textBoxPetBreed.TabIndex = 4;
            // 
            // textBoxPetAge
            // 
            this.textBoxPetAge.Location = new System.Drawing.Point(140, 214);
            this.textBoxPetAge.Name = "textBoxPetAge";
            this.textBoxPetAge.Size = new System.Drawing.Size(100, 20);
            this.textBoxPetAge.TabIndex = 5;
            // 
            // textBoxOwnerFirstName
            // 
            this.textBoxOwnerFirstName.Location = new System.Drawing.Point(140, 242);
            this.textBoxOwnerFirstName.Name = "textBoxOwnerFirstName";
            this.textBoxOwnerFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxOwnerFirstName.TabIndex = 6;
            // 
            // textBoxOwnerLastName
            // 
            this.textBoxOwnerLastName.Location = new System.Drawing.Point(140, 272);
            this.textBoxOwnerLastName.Name = "textBoxOwnerLastName";
            this.textBoxOwnerLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxOwnerLastName.TabIndex = 7;
            // 
            // textBoxOwnerAddress
            // 
            this.textBoxOwnerAddress.Location = new System.Drawing.Point(140, 308);
            this.textBoxOwnerAddress.Name = "textBoxOwnerAddress";
            this.textBoxOwnerAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxOwnerAddress.TabIndex = 8;
            // 
            // textBoxOwnerPhone
            // 
            this.textBoxOwnerPhone.Location = new System.Drawing.Point(140, 334);
            this.textBoxOwnerPhone.Name = "textBoxOwnerPhone";
            this.textBoxOwnerPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxOwnerPhone.TabIndex = 9;
            // 
            // buttonAddPet
            // 
            this.buttonAddPet.Location = new System.Drawing.Point(110, 391);
            this.buttonAddPet.Name = "buttonAddPet";
            this.buttonAddPet.Size = new System.Drawing.Size(130, 23);
            this.buttonAddPet.TabIndex = 10;
            this.buttonAddPet.Text = "добавить питомца";
            this.buttonAddPet.UseVisualStyleBackColor = true;
            this.buttonAddPet.Click += new System.EventHandler(this.buttonAddPet_Click);
            // 
            // buttonDeletePet
            // 
            this.buttonDeletePet.Location = new System.Drawing.Point(467, 391);
            this.buttonDeletePet.Name = "buttonDeletePet";
            this.buttonDeletePet.Size = new System.Drawing.Size(161, 23);
            this.buttonDeletePet.TabIndex = 11;
            this.buttonDeletePet.Text = "удалить данные";
            this.buttonDeletePet.UseVisualStyleBackColor = true;
            this.buttonDeletePet.Click += new System.EventHandler(this.buttonDeletePet_Click);
            // 
            // ButtonEditPet
            // 
            this.ButtonEditPet.Location = new System.Drawing.Point(259, 391);
            this.ButtonEditPet.Name = "ButtonEditPet";
            this.ButtonEditPet.Size = new System.Drawing.Size(186, 23);
            this.ButtonEditPet.TabIndex = 12;
            this.ButtonEditPet.Text = "редактировать данные ";
            this.ButtonEditPet.UseVisualStyleBackColor = true;
            this.ButtonEditPet.Click += new System.EventHandler(this.ButtonEditPet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "имя питомца";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "порода питомца";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "возраст питомца";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Имя владельца";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Фамилия владельца";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "адрес владельца";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "номер телефона";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonEditPet);
            this.Controls.Add(this.buttonDeletePet);
            this.Controls.Add(this.buttonAddPet);
            this.Controls.Add(this.textBoxOwnerPhone);
            this.Controls.Add(this.textBoxOwnerAddress);
            this.Controls.Add(this.textBoxOwnerLastName);
            this.Controls.Add(this.textBoxOwnerFirstName);
            this.Controls.Add(this.textBoxPetAge);
            this.Controls.Add(this.textBoxPetBreed);
            this.Controls.Add(this.pictureBoxPetPhoto);
            this.Controls.Add(this.listBoxNotifications);
            this.Controls.Add(this.textBoxPetName);
            this.Controls.Add(this.dataGridViewPets);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPetPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPets;
        private System.Windows.Forms.TextBox textBoxPetName;
        private System.Windows.Forms.ListBox listBoxNotifications;
        private System.Windows.Forms.PictureBox pictureBoxPetPhoto;
        private System.Windows.Forms.TextBox textBoxPetBreed;
        private System.Windows.Forms.TextBox textBoxPetAge;
        private System.Windows.Forms.TextBox textBoxOwnerFirstName;
        private System.Windows.Forms.TextBox textBoxOwnerLastName;
        private System.Windows.Forms.TextBox textBoxOwnerAddress;
        private System.Windows.Forms.TextBox textBoxOwnerPhone;
        private System.Windows.Forms.Button buttonAddPet;
        private System.Windows.Forms.Button buttonDeletePet;
        private System.Windows.Forms.Button ButtonEditPet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}