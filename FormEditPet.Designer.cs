namespace PetsBook
{
    partial class FormEditPet
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
            this.textBoxPetName = new System.Windows.Forms.TextBox();
            this.pictureBoxPetPhoto = new System.Windows.Forms.PictureBox();
            this.textBoxPetBreed = new System.Windows.Forms.TextBox();
            this.textBoxPetAge = new System.Windows.Forms.TextBox();
            this.textBoxOwnerPhone = new System.Windows.Forms.TextBox();
            this.textBoxOwnerFirstName = new System.Windows.Forms.TextBox();
            this.textBoxOwnerLastName = new System.Windows.Forms.TextBox();
            this.textBoxOwnerAddress = new System.Windows.Forms.TextBox();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPetPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPetName
            // 
            this.textBoxPetName.Location = new System.Drawing.Point(46, 34);
            this.textBoxPetName.Name = "textBoxPetName";
            this.textBoxPetName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPetName.TabIndex = 0;
            // 
            // pictureBoxPetPhoto
            // 
            this.pictureBoxPetPhoto.Location = new System.Drawing.Point(387, 34);
            this.pictureBoxPetPhoto.Name = "pictureBoxPetPhoto";
            this.pictureBoxPetPhoto.Size = new System.Drawing.Size(100, 150);
            this.pictureBoxPetPhoto.TabIndex = 1;
            this.pictureBoxPetPhoto.TabStop = false;
            // 
            // textBoxPetBreed
            // 
            this.textBoxPetBreed.Location = new System.Drawing.Point(46, 76);
            this.textBoxPetBreed.Name = "textBoxPetBreed";
            this.textBoxPetBreed.Size = new System.Drawing.Size(100, 20);
            this.textBoxPetBreed.TabIndex = 2;
            // 
            // textBoxPetAge
            // 
            this.textBoxPetAge.Location = new System.Drawing.Point(46, 120);
            this.textBoxPetAge.Name = "textBoxPetAge";
            this.textBoxPetAge.Size = new System.Drawing.Size(100, 20);
            this.textBoxPetAge.TabIndex = 3;
            // 
            // textBoxOwnerPhone
            // 
            this.textBoxOwnerPhone.Location = new System.Drawing.Point(204, 164);
            this.textBoxOwnerPhone.Name = "textBoxOwnerPhone";
            this.textBoxOwnerPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxOwnerPhone.TabIndex = 4;
            // 
            // textBoxOwnerFirstName
            // 
            this.textBoxOwnerFirstName.Location = new System.Drawing.Point(204, 34);
            this.textBoxOwnerFirstName.Name = "textBoxOwnerFirstName";
            this.textBoxOwnerFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxOwnerFirstName.TabIndex = 5;
            // 
            // textBoxOwnerLastName
            // 
            this.textBoxOwnerLastName.Location = new System.Drawing.Point(204, 76);
            this.textBoxOwnerLastName.Name = "textBoxOwnerLastName";
            this.textBoxOwnerLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxOwnerLastName.TabIndex = 6;
            // 
            // textBoxOwnerAddress
            // 
            this.textBoxOwnerAddress.Location = new System.Drawing.Point(204, 120);
            this.textBoxOwnerAddress.Name = "textBoxOwnerAddress";
            this.textBoxOwnerAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxOwnerAddress.TabIndex = 7;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Location = new System.Drawing.Point(88, 249);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(175, 23);
            this.buttonSaveChanges.TabIndex = 8;
            this.buttonSaveChanges.Text = "Сохранить изменения";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // FormEditPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.textBoxOwnerAddress);
            this.Controls.Add(this.textBoxOwnerLastName);
            this.Controls.Add(this.textBoxOwnerFirstName);
            this.Controls.Add(this.textBoxOwnerPhone);
            this.Controls.Add(this.textBoxPetAge);
            this.Controls.Add(this.textBoxPetBreed);
            this.Controls.Add(this.pictureBoxPetPhoto);
            this.Controls.Add(this.textBoxPetName);
            this.Name = "FormEditPet";
            this.Text = "FormEditPet";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPetPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPetName;
        private System.Windows.Forms.PictureBox pictureBoxPetPhoto;
        private System.Windows.Forms.TextBox textBoxPetBreed;
        private System.Windows.Forms.TextBox textBoxPetAge;
        private System.Windows.Forms.TextBox textBoxOwnerPhone;
        private System.Windows.Forms.TextBox textBoxOwnerFirstName;
        private System.Windows.Forms.TextBox textBoxOwnerLastName;
        private System.Windows.Forms.TextBox textBoxOwnerAddress;
        private System.Windows.Forms.Button buttonSaveChanges;
    }
}