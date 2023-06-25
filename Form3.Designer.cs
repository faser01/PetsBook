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
            this.buttonEditPet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPetPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPets
            // 
            this.dataGridViewPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPets.Location = new System.Drawing.Point(524, 25);
            this.dataGridViewPets.Name = "dataGridViewPets";
            this.dataGridViewPets.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewPets.TabIndex = 0;
            // 
            // textBoxPetName
            // 
            this.textBoxPetName.Location = new System.Drawing.Point(21, 155);
            this.textBoxPetName.Name = "textBoxPetName";
            this.textBoxPetName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPetName.TabIndex = 1;
            // 
            // listBoxNotifications
            // 
            this.listBoxNotifications.FormattingEnabled = true;
            this.listBoxNotifications.Location = new System.Drawing.Point(208, 25);
            this.listBoxNotifications.Name = "listBoxNotifications";
            this.listBoxNotifications.Size = new System.Drawing.Size(120, 95);
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
            this.textBoxPetBreed.Location = new System.Drawing.Point(21, 187);
            this.textBoxPetBreed.Name = "textBoxPetBreed";
            this.textBoxPetBreed.Size = new System.Drawing.Size(100, 20);
            this.textBoxPetBreed.TabIndex = 4;
            // 
            // textBoxPetAge
            // 
            this.textBoxPetAge.Location = new System.Drawing.Point(21, 225);
            this.textBoxPetAge.Name = "textBoxPetAge";
            this.textBoxPetAge.Size = new System.Drawing.Size(100, 20);
            this.textBoxPetAge.TabIndex = 5;
            // 
            // textBoxOwnerFirstName
            // 
            this.textBoxOwnerFirstName.Location = new System.Drawing.Point(21, 262);
            this.textBoxOwnerFirstName.Name = "textBoxOwnerFirstName";
            this.textBoxOwnerFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxOwnerFirstName.TabIndex = 6;
            // 
            // textBoxOwnerLastName
            // 
            this.textBoxOwnerLastName.Location = new System.Drawing.Point(21, 300);
            this.textBoxOwnerLastName.Name = "textBoxOwnerLastName";
            this.textBoxOwnerLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxOwnerLastName.TabIndex = 7;
            // 
            // textBoxOwnerAddress
            // 
            this.textBoxOwnerAddress.Location = new System.Drawing.Point(21, 345);
            this.textBoxOwnerAddress.Name = "textBoxOwnerAddress";
            this.textBoxOwnerAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxOwnerAddress.TabIndex = 8;
            // 
            // textBoxOwnerPhone
            // 
            this.textBoxOwnerPhone.Location = new System.Drawing.Point(21, 385);
            this.textBoxOwnerPhone.Name = "textBoxOwnerPhone";
            this.textBoxOwnerPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxOwnerPhone.TabIndex = 9;
            // 
            // buttonAddPet
            // 
            this.buttonAddPet.Location = new System.Drawing.Point(187, 245);
            this.buttonAddPet.Name = "buttonAddPet";
            this.buttonAddPet.Size = new System.Drawing.Size(75, 23);
            this.buttonAddPet.TabIndex = 10;
            this.buttonAddPet.Text = "button1";
            this.buttonAddPet.UseVisualStyleBackColor = true;
            this.buttonAddPet.Click += new System.EventHandler(this.buttonAddPet_Click);
            // 
            // buttonDeletePet
            // 
            this.buttonDeletePet.Location = new System.Drawing.Point(390, 245);
            this.buttonDeletePet.Name = "buttonDeletePet";
            this.buttonDeletePet.Size = new System.Drawing.Size(75, 23);
            this.buttonDeletePet.TabIndex = 11;
            this.buttonDeletePet.Text = "button2";
            this.buttonDeletePet.UseVisualStyleBackColor = true;
            this.buttonDeletePet.Click += new System.EventHandler(this.buttonDeletePet_Click);
            // 
            // buttonEditPet
            // 
            this.buttonEditPet.Location = new System.Drawing.Point(284, 245);
            this.buttonEditPet.Name = "buttonEditPet";
            this.buttonEditPet.Size = new System.Drawing.Size(75, 23);
            this.buttonEditPet.TabIndex = 12;
            this.buttonEditPet.Text = "button3";
            this.buttonEditPet.UseVisualStyleBackColor = true;
            this.buttonEditPet.Click += new System.EventHandler(this.buttonEditPet_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEditPet);
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
        private System.Windows.Forms.Button buttonEditPet;
    }
}