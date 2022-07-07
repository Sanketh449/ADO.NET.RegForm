namespace ADO.NET.RegForm
{
    partial class Form1
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
            this.LblFirstName = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.LblBirthDate = new System.Windows.Forms.Label();
            this.LblGender = new System.Windows.Forms.Label();
            this.LblEmailId = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblConfirmPassword = new System.Windows.Forms.Label();
            this.LblRegistrationForm = new System.Windows.Forms.Label();
            this.TxtConfirmPassword = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtEmailId = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.DtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.ComboGender = new System.Windows.Forms.ComboBox();
            this.BtnSignin = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnLogIn = new System.Windows.Forms.Button();
            this.LblExixtingCust = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Location = new System.Drawing.Point(163, 38);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(57, 13);
            this.LblFirstName.TabIndex = 0;
            this.LblFirstName.Text = "First Name";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(163, 68);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(58, 13);
            this.LblLastName.TabIndex = 1;
            this.LblLastName.Text = "Last Name";
            // 
            // LblBirthDate
            // 
            this.LblBirthDate.AutoSize = true;
            this.LblBirthDate.Location = new System.Drawing.Point(163, 94);
            this.LblBirthDate.Name = "LblBirthDate";
            this.LblBirthDate.Size = new System.Drawing.Size(54, 13);
            this.LblBirthDate.TabIndex = 2;
            this.LblBirthDate.Text = "Birth Date";
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.Location = new System.Drawing.Point(165, 123);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(42, 13);
            this.LblGender.TabIndex = 3;
            this.LblGender.Text = "Gender";
            // 
            // LblEmailId
            // 
            this.LblEmailId.AutoSize = true;
            this.LblEmailId.Location = new System.Drawing.Point(163, 152);
            this.LblEmailId.Name = "LblEmailId";
            this.LblEmailId.Size = new System.Drawing.Size(44, 13);
            this.LblEmailId.TabIndex = 4;
            this.LblEmailId.Text = "Email Id";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(163, 187);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(53, 13);
            this.LblPassword.TabIndex = 5;
            this.LblPassword.Text = "Password";
            // 
            // LblConfirmPassword
            // 
            this.LblConfirmPassword.AutoSize = true;
            this.LblConfirmPassword.Location = new System.Drawing.Point(163, 220);
            this.LblConfirmPassword.Name = "LblConfirmPassword";
            this.LblConfirmPassword.Size = new System.Drawing.Size(91, 13);
            this.LblConfirmPassword.TabIndex = 6;
            this.LblConfirmPassword.Text = "Confirm Password";
            // 
            // LblRegistrationForm
            // 
            this.LblRegistrationForm.AutoSize = true;
            this.LblRegistrationForm.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LblRegistrationForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblRegistrationForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegistrationForm.Location = new System.Drawing.Point(209, -2);
            this.LblRegistrationForm.Name = "LblRegistrationForm";
            this.LblRegistrationForm.Size = new System.Drawing.Size(155, 22);
            this.LblRegistrationForm.TabIndex = 7;
            this.LblRegistrationForm.Text = "Registration Form";
            // 
            // TxtConfirmPassword
            // 
            this.TxtConfirmPassword.Location = new System.Drawing.Point(318, 213);
            this.TxtConfirmPassword.Name = "TxtConfirmPassword";
            this.TxtConfirmPassword.Size = new System.Drawing.Size(100, 20);
            this.TxtConfirmPassword.TabIndex = 8;
            this.TxtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(318, 180);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(100, 20);
            this.TxtPassword.TabIndex = 9;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // TxtEmailId
            // 
            this.TxtEmailId.Location = new System.Drawing.Point(318, 149);
            this.TxtEmailId.Name = "TxtEmailId";
            this.TxtEmailId.Size = new System.Drawing.Size(100, 20);
            this.TxtEmailId.TabIndex = 10;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(318, 68);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(100, 20);
            this.TxtLastName.TabIndex = 12;
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(318, 38);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(100, 20);
            this.TxtFirstName.TabIndex = 13;
            // 
            // DtpBirthDate
            // 
            this.DtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpBirthDate.Location = new System.Drawing.Point(318, 97);
            this.DtpBirthDate.Name = "DtpBirthDate";
            this.DtpBirthDate.Size = new System.Drawing.Size(100, 20);
            this.DtpBirthDate.TabIndex = 14;
            // 
            // ComboGender
            // 
            this.ComboGender.FormattingEnabled = true;
            this.ComboGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.ComboGender.Location = new System.Drawing.Point(318, 123);
            this.ComboGender.Name = "ComboGender";
            this.ComboGender.Size = new System.Drawing.Size(100, 21);
            this.ComboGender.TabIndex = 15;
            this.ComboGender.Text = "--Select--";
            // 
            // BtnSignin
            // 
            this.BtnSignin.Location = new System.Drawing.Point(289, 276);
            this.BtnSignin.Name = "BtnSignin";
            this.BtnSignin.Size = new System.Drawing.Size(75, 23);
            this.BtnSignin.TabIndex = 16;
            this.BtnSignin.Text = "Sign In";
            this.BtnSignin.UseVisualStyleBackColor = true;
            this.BtnSignin.Click += new System.EventHandler(this.BtnSignin_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(370, 276);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 17;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnLogIn
            // 
            this.BtnLogIn.Location = new System.Drawing.Point(445, 162);
            this.BtnLogIn.Name = "BtnLogIn";
            this.BtnLogIn.Size = new System.Drawing.Size(75, 23);
            this.BtnLogIn.TabIndex = 18;
            this.BtnLogIn.Text = "Log In";
            this.BtnLogIn.UseVisualStyleBackColor = true;
            this.BtnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // LblExixtingCust
            // 
            this.LblExixtingCust.AutoSize = true;
            this.LblExixtingCust.Location = new System.Drawing.Point(442, 187);
            this.LblExixtingCust.Name = "LblExixtingCust";
            this.LblExixtingCust.Size = new System.Drawing.Size(219, 13);
            this.LblExixtingCust.TabIndex = 19;
            this.LblExixtingCust.Text = "(Existing customer only Enter Email and pass)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblExixtingCust);
            this.Controls.Add(this.BtnLogIn);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnSignin);
            this.Controls.Add(this.ComboGender);
            this.Controls.Add(this.DtpBirthDate);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtEmailId);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtConfirmPassword);
            this.Controls.Add(this.LblRegistrationForm);
            this.Controls.Add(this.LblConfirmPassword);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblEmailId);
            this.Controls.Add(this.LblGender);
            this.Controls.Add(this.LblBirthDate);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.LblFirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.Label LblBirthDate;
        private System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.Label LblEmailId;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblConfirmPassword;
        private System.Windows.Forms.Label LblRegistrationForm;
        private System.Windows.Forms.TextBox TxtConfirmPassword;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtEmailId;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.DateTimePicker DtpBirthDate;
        private System.Windows.Forms.ComboBox ComboGender;
        private System.Windows.Forms.Button BtnSignin;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnLogIn;
        private System.Windows.Forms.Label LblExixtingCust;
    }
}

