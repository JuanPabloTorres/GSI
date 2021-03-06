﻿namespace GymSignIn
{
    partial class NewUserForm
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
            this.NameTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PhoneTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.button1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.radioButtonMonth = new System.Windows.Forms.RadioButton();
            this.radioButtonAnnual = new System.Windows.Forms.RadioButton();
            this.emailtxtbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.takePictureBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.clientPicureBox = new System.Windows.Forms.PictureBox();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientPicureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NameTextBox.Depth = 0;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NameTextBox.Hint = "Name";
            this.NameTextBox.Location = new System.Drawing.Point(12, 82);
            this.NameTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PasswordChar = '\0';
            this.NameTextBox.SelectedText = "";
            this.NameTextBox.SelectionLength = 0;
            this.NameTextBox.SelectionStart = 0;
            this.NameTextBox.Size = new System.Drawing.Size(224, 23);
            this.NameTextBox.TabIndex = 5;
            this.NameTextBox.UseSystemPasswordChar = false;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PhoneTextBox.Depth = 0;
            this.PhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PhoneTextBox.Hint = "Phone Number";
            this.PhoneTextBox.Location = new System.Drawing.Point(12, 111);
            this.PhoneTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.PasswordChar = '\0';
            this.PhoneTextBox.SelectedText = "";
            this.PhoneTextBox.SelectionLength = 0;
            this.PhoneTextBox.SelectionStart = 0;
            this.PhoneTextBox.Size = new System.Drawing.Size(224, 23);
            this.PhoneTextBox.TabIndex = 6;
            this.PhoneTextBox.UseSystemPasswordChar = false;
            // 
            // button1
            // 
            this.button1.Depth = 0;
            this.button1.Location = new System.Drawing.Point(450, 490);
            this.button1.MouseState = MaterialSkin.MouseState.HOVER;
            this.button1.Name = "button1";
            this.button1.Primary = true;
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(6, 490);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(75, 33);
            this.materialRaisedButton1.TabIndex = 8;
            this.materialRaisedButton1.Text = "Back";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // radioButtonMonth
            // 
            this.radioButtonMonth.AutoSize = true;
            this.radioButtonMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMonth.Location = new System.Drawing.Point(167, 25);
            this.radioButtonMonth.Name = "radioButtonMonth";
            this.radioButtonMonth.Size = new System.Drawing.Size(127, 35);
            this.radioButtonMonth.TabIndex = 9;
            this.radioButtonMonth.TabStop = true;
            this.radioButtonMonth.Text = "Monthly";
            this.radioButtonMonth.UseVisualStyleBackColor = true;
            this.radioButtonMonth.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonAnnual
            // 
            this.radioButtonAnnual.AutoSize = true;
            this.radioButtonAnnual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAnnual.Location = new System.Drawing.Point(370, 25);
            this.radioButtonAnnual.Name = "radioButtonAnnual";
            this.radioButtonAnnual.Size = new System.Drawing.Size(116, 35);
            this.radioButtonAnnual.TabIndex = 10;
            this.radioButtonAnnual.TabStop = true;
            this.radioButtonAnnual.Text = "Annual";
            this.radioButtonAnnual.UseVisualStyleBackColor = true;
            this.radioButtonAnnual.CheckedChanged += new System.EventHandler(this.radioButtonAnnual_CheckedChanged);
            // 
            // emailtxtbox
            // 
            this.emailtxtbox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.emailtxtbox.Depth = 0;
            this.emailtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtxtbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.emailtxtbox.Hint = "Email";
            this.emailtxtbox.Location = new System.Drawing.Point(253, 111);
            this.emailtxtbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.emailtxtbox.Name = "emailtxtbox";
            this.emailtxtbox.PasswordChar = '\0';
            this.emailtxtbox.SelectedText = "";
            this.emailtxtbox.SelectionLength = 0;
            this.emailtxtbox.SelectionStart = 0;
            this.emailtxtbox.Size = new System.Drawing.Size(251, 23);
            this.emailtxtbox.TabIndex = 11;
            this.emailtxtbox.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButtonAnnual);
            this.groupBox1.Controls.Add(this.radioButtonMonth);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 70);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Membresia";
            // 
            // takePictureBtn
            // 
            this.takePictureBtn.Depth = 0;
            this.takePictureBtn.Location = new System.Drawing.Point(6, 245);
            this.takePictureBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.takePictureBtn.Name = "takePictureBtn";
            this.takePictureBtn.Primary = true;
            this.takePictureBtn.Size = new System.Drawing.Size(75, 58);
            this.takePictureBtn.TabIndex = 13;
            this.takePictureBtn.Text = "Start Camera";
            this.takePictureBtn.UseVisualStyleBackColor = true;
            this.takePictureBtn.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // clientPicureBox
            // 
            this.clientPicureBox.Location = new System.Drawing.Point(93, 245);
            this.clientPicureBox.Name = "clientPicureBox";
            this.clientPicureBox.Size = new System.Drawing.Size(432, 239);
            this.clientPicureBox.TabIndex = 14;
            this.clientPicureBox.TabStop = false;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(6, 309);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(75, 58);
            this.materialRaisedButton2.TabIndex = 15;
            this.materialRaisedButton2.Text = "Take Picture";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click_1);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(6, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(93, 35);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Daily";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(537, 535);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.clientPicureBox);
            this.Controls.Add(this.takePictureBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.emailtxtbox);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "NewUserForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.NewUserForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientPicureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField NameTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField PhoneTextBox;
        private MaterialSkin.Controls.MaterialRaisedButton button1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.RadioButton radioButtonMonth;
        private System.Windows.Forms.RadioButton radioButtonAnnual;
        private MaterialSkin.Controls.MaterialSingleLineTextField emailtxtbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRaisedButton takePictureBtn;
        private System.Windows.Forms.PictureBox clientPicureBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
    }
}