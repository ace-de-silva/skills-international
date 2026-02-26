namespace SkillsInternational
{
    partial class RegistrationForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // ── Declare all controls ──────────────────────────────────────────
            this.lnkLogout       = new System.Windows.Forms.LinkLabel();
            this.lblTitle        = new System.Windows.Forms.Label();
            this.lnkExit         = new System.Windows.Forms.LinkLabel();

            // Student Registration group
            this.grpStudentReg   = new System.Windows.Forms.GroupBox();
            this.lblRegNo        = new System.Windows.Forms.Label();
            this.cmbRegNo        = new System.Windows.Forms.ComboBox();

            // Basic Details group
            this.grpBasicDetails = new System.Windows.Forms.GroupBox();
            this.lblFirstName    = new System.Windows.Forms.Label();
            this.txtFirstName    = new System.Windows.Forms.TextBox();
            this.lblLastName     = new System.Windows.Forms.Label();
            this.txtLastName     = new System.Windows.Forms.TextBox();
            this.lblDOB          = new System.Windows.Forms.Label();
            this.dtpDOB          = new System.Windows.Forms.DateTimePicker();
            this.lblGender       = new System.Windows.Forms.Label();
            this.rbMale          = new System.Windows.Forms.RadioButton();
            this.rbFemale        = new System.Windows.Forms.RadioButton();

            // Contact Details group
            this.grpContact      = new System.Windows.Forms.GroupBox();
            this.lblAddress      = new System.Windows.Forms.Label();
            this.txtAddress      = new System.Windows.Forms.TextBox();
            this.lblEmail        = new System.Windows.Forms.Label();
            this.txtEmail        = new System.Windows.Forms.TextBox();
            this.lblMobilePhone  = new System.Windows.Forms.Label();
            this.txtMobilePhone  = new System.Windows.Forms.TextBox();
            this.lblHomePhone    = new System.Windows.Forms.Label();
            this.txtHomePhone    = new System.Windows.Forms.TextBox();

            // Parent Details group
            this.grpParent       = new System.Windows.Forms.GroupBox();
            this.lblParentName   = new System.Windows.Forms.Label();
            this.txtParentName   = new System.Windows.Forms.TextBox();
            this.lblNIC          = new System.Windows.Forms.Label();
            this.txtNIC          = new System.Windows.Forms.TextBox();
            this.lblContactNo    = new System.Windows.Forms.Label();
            this.txtContactNo    = new System.Windows.Forms.TextBox();

            // Action buttons
            this.btnRegister     = new System.Windows.Forms.Button();
            this.btnUpdate       = new System.Windows.Forms.Button();
            this.btnClear        = new System.Windows.Forms.Button();
            this.btnDelete       = new System.Windows.Forms.Button();

            this.grpStudentReg.SuspendLayout();
            this.grpBasicDetails.SuspendLayout();
            this.grpContact.SuspendLayout();
            this.grpParent.SuspendLayout();
            this.SuspendLayout();

            // ── lnkLogout ────────────────────────────────────────────────────
            this.lnkLogout.AutoSize  = true;
            this.lnkLogout.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lnkLogout.LinkColor = System.Drawing.Color.FromArgb(192, 0, 0);
            this.lnkLogout.Location  = new System.Drawing.Point(10, 12);
            this.lnkLogout.Name      = "lnkLogout";
            this.lnkLogout.TabIndex  = 20;
            this.lnkLogout.TabStop   = true;
            this.lnkLogout.Text      = "Logout";
            this.lnkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogout_LinkClicked);

            // ── lblTitle ─────────────────────────────────────────────────────
            this.lblTitle.AutoSize  = false;
            this.lblTitle.Font      = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 120);
            this.lblTitle.Location  = new System.Drawing.Point(10, 5);
            this.lblTitle.Name      = "lblTitle";
            this.lblTitle.Size      = new System.Drawing.Size(520, 34);
            this.lblTitle.Text      = "Skills International";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ══════════════════════════════════════════════════════════════════
            //  GROUP: Student Registration  (y = 45)
            // ══════════════════════════════════════════════════════════════════
            this.grpStudentReg.Controls.Add(this.lblRegNo);
            this.grpStudentReg.Controls.Add(this.cmbRegNo);
            this.grpStudentReg.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.grpStudentReg.Location = new System.Drawing.Point(10, 45);
            this.grpStudentReg.Name     = "grpStudentReg";
            this.grpStudentReg.Size     = new System.Drawing.Size(520, 60);
            this.grpStudentReg.Text     = "Student Registration";

            // lblRegNo
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.Location = new System.Drawing.Point(10, 27);
            this.lblRegNo.Name     = "lblRegNo";
            this.lblRegNo.Text     = "Reg No";

            // cmbRegNo
            this.cmbRegNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbRegNo.Location      = new System.Drawing.Point(100, 24);
            this.cmbRegNo.Name          = "cmbRegNo";
            this.cmbRegNo.Size          = new System.Drawing.Size(200, 23);
            this.cmbRegNo.TabIndex      = 0;
            this.cmbRegNo.SelectedIndexChanged += new System.EventHandler(this.cmbRegNo_SelectedIndexChanged);

            // ══════════════════════════════════════════════════════════════════
            //  GROUP: Basic Details  (y = 115)
            // ══════════════════════════════════════════════════════════════════
            this.grpBasicDetails.Controls.Add(this.lblFirstName);
            this.grpBasicDetails.Controls.Add(this.txtFirstName);
            this.grpBasicDetails.Controls.Add(this.lblLastName);
            this.grpBasicDetails.Controls.Add(this.txtLastName);
            this.grpBasicDetails.Controls.Add(this.lblDOB);
            this.grpBasicDetails.Controls.Add(this.dtpDOB);
            this.grpBasicDetails.Controls.Add(this.lblGender);
            this.grpBasicDetails.Controls.Add(this.rbMale);
            this.grpBasicDetails.Controls.Add(this.rbFemale);
            this.grpBasicDetails.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.grpBasicDetails.Location = new System.Drawing.Point(10, 115);
            this.grpBasicDetails.Name     = "grpBasicDetails";
            this.grpBasicDetails.Size     = new System.Drawing.Size(520, 185);
            this.grpBasicDetails.Text     = "Basic Details";

            // lblFirstName
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(10, 30);
            this.lblFirstName.Name     = "lblFirstName";
            this.lblFirstName.Text     = "First Name";

            // txtFirstName
            this.txtFirstName.Location = new System.Drawing.Point(110, 27);
            this.txtFirstName.Name     = "txtFirstName";
            this.txtFirstName.Size     = new System.Drawing.Size(390, 23);
            this.txtFirstName.TabIndex = 1;

            // lblLastName
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(10, 65);
            this.lblLastName.Name     = "lblLastName";
            this.lblLastName.Text     = "Last Name";

            // txtLastName
            this.txtLastName.Location = new System.Drawing.Point(110, 62);
            this.txtLastName.Name     = "txtLastName";
            this.txtLastName.Size     = new System.Drawing.Size(390, 23);
            this.txtLastName.TabIndex = 2;

            // lblDOB
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(10, 100);
            this.lblDOB.Name     = "lblDOB";
            this.lblDOB.Text     = "Date of Birth";

            // dtpDOB
            this.dtpDOB.Format   = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(110, 97);
            this.dtpDOB.Name     = "dtpDOB";
            this.dtpDOB.Size     = new System.Drawing.Size(200, 23);
            this.dtpDOB.TabIndex = 3;

            // lblGender
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(10, 140);
            this.lblGender.Name     = "lblGender";
            this.lblGender.Text     = "Gender";

            // rbMale
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(110, 138);
            this.rbMale.Name     = "rbMale";
            this.rbMale.Size     = new System.Drawing.Size(51, 19);
            this.rbMale.TabIndex = 4;
            this.rbMale.Text     = "Male";

            // rbFemale
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(210, 138);
            this.rbFemale.Name     = "rbFemale";
            this.rbFemale.Size     = new System.Drawing.Size(59, 19);
            this.rbFemale.TabIndex = 5;
            this.rbFemale.Text     = "Female";

            // ══════════════════════════════════════════════════════════════════
            //  GROUP: Contact Details  (y = 310)
            // ══════════════════════════════════════════════════════════════════
            this.grpContact.Controls.Add(this.lblAddress);
            this.grpContact.Controls.Add(this.txtAddress);
            this.grpContact.Controls.Add(this.lblEmail);
            this.grpContact.Controls.Add(this.txtEmail);
            this.grpContact.Controls.Add(this.lblMobilePhone);
            this.grpContact.Controls.Add(this.txtMobilePhone);
            this.grpContact.Controls.Add(this.lblHomePhone);
            this.grpContact.Controls.Add(this.txtHomePhone);
            this.grpContact.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.grpContact.Location = new System.Drawing.Point(10, 310);
            this.grpContact.Name     = "grpContact";
            this.grpContact.Size     = new System.Drawing.Size(520, 180);
            this.grpContact.Text     = "Contact Details";

            // lblAddress
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(10, 30);
            this.lblAddress.Name     = "lblAddress";
            this.lblAddress.Text     = "Address";

            // txtAddress (multiline)
            this.txtAddress.Location   = new System.Drawing.Point(110, 27);
            this.txtAddress.Multiline  = true;
            this.txtAddress.Name       = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.Size       = new System.Drawing.Size(390, 55);
            this.txtAddress.TabIndex   = 6;

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(10, 98);
            this.lblEmail.Name     = "lblEmail";
            this.lblEmail.Text     = "Email";

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(110, 95);
            this.txtEmail.Name     = "txtEmail";
            this.txtEmail.Size     = new System.Drawing.Size(390, 23);
            this.txtEmail.TabIndex = 7;

            // lblMobilePhone
            this.lblMobilePhone.AutoSize = true;
            this.lblMobilePhone.Location = new System.Drawing.Point(10, 138);
            this.lblMobilePhone.Name     = "lblMobilePhone";
            this.lblMobilePhone.Text     = "Mobile Phone";

            // txtMobilePhone
            this.txtMobilePhone.Location = new System.Drawing.Point(110, 135);
            this.txtMobilePhone.Name     = "txtMobilePhone";
            this.txtMobilePhone.Size     = new System.Drawing.Size(140, 23);
            this.txtMobilePhone.TabIndex = 8;

            // lblHomePhone
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Location = new System.Drawing.Point(275, 138);
            this.lblHomePhone.Name     = "lblHomePhone";
            this.lblHomePhone.Text     = "Home Phone";

            // txtHomePhone
            this.txtHomePhone.Location = new System.Drawing.Point(370, 135);
            this.txtHomePhone.Name     = "txtHomePhone";
            this.txtHomePhone.Size     = new System.Drawing.Size(130, 23);
            this.txtHomePhone.TabIndex = 9;

            // ══════════════════════════════════════════════════════════════════
            //  GROUP: Parent Details  (y = 500)
            // ══════════════════════════════════════════════════════════════════
            this.grpParent.Controls.Add(this.lblParentName);
            this.grpParent.Controls.Add(this.txtParentName);
            this.grpParent.Controls.Add(this.lblNIC);
            this.grpParent.Controls.Add(this.txtNIC);
            this.grpParent.Controls.Add(this.lblContactNo);
            this.grpParent.Controls.Add(this.txtContactNo);
            this.grpParent.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.grpParent.Location = new System.Drawing.Point(10, 500);
            this.grpParent.Name     = "grpParent";
            this.grpParent.Size     = new System.Drawing.Size(520, 130);
            this.grpParent.Text     = "Parent Details";

            // lblParentName
            this.lblParentName.AutoSize = true;
            this.lblParentName.Location = new System.Drawing.Point(10, 30);
            this.lblParentName.Name     = "lblParentName";
            this.lblParentName.Text     = "Parent Name";

            // txtParentName
            this.txtParentName.Location = new System.Drawing.Point(110, 27);
            this.txtParentName.Name     = "txtParentName";
            this.txtParentName.Size     = new System.Drawing.Size(390, 23);
            this.txtParentName.TabIndex = 10;

            // lblNIC
            this.lblNIC.AutoSize = true;
            this.lblNIC.Location = new System.Drawing.Point(10, 65);
            this.lblNIC.Name     = "lblNIC";
            this.lblNIC.Text     = "NIC";

            // txtNIC
            this.txtNIC.Location = new System.Drawing.Point(110, 62);
            this.txtNIC.Name     = "txtNIC";
            this.txtNIC.Size     = new System.Drawing.Size(160, 23);
            this.txtNIC.TabIndex = 11;

            // lblContactNo
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Location = new System.Drawing.Point(10, 100);
            this.lblContactNo.Name     = "lblContactNo";
            this.lblContactNo.Text     = "Contact Number";

            // txtContactNo
            this.txtContactNo.Location = new System.Drawing.Point(110, 97);
            this.txtContactNo.Name     = "txtContactNo";
            this.txtContactNo.Size     = new System.Drawing.Size(160, 23);
            this.txtContactNo.TabIndex = 12;

            // ── Action Buttons  (y = 645) ─────────────────────────────────────
            // btnRegister
            this.btnRegister.Location = new System.Drawing.Point(10, 645);
            this.btnRegister.Name     = "btnRegister";
            this.btnRegister.Size     = new System.Drawing.Size(80, 30);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text     = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click  += new System.EventHandler(this.btnRegister_Click);

            // btnUpdate
            this.btnUpdate.Location = new System.Drawing.Point(100, 645);
            this.btnUpdate.Name     = "btnUpdate";
            this.btnUpdate.Size     = new System.Drawing.Size(80, 30);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text     = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click   += new System.EventHandler(this.btnUpdate_Click);

            // btnClear
            this.btnClear.Location = new System.Drawing.Point(350, 645);
            this.btnClear.Name     = "btnClear";
            this.btnClear.Size     = new System.Drawing.Size(80, 30);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text     = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click   += new System.EventHandler(this.btnClear_Click);

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(440, 645);
            this.btnDelete.Name     = "btnDelete";
            this.btnDelete.Size     = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text     = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click   += new System.EventHandler(this.btnDelete_Click);

            // ── lnkExit  (y = 690) ────────────────────────────────────────────
            this.lnkExit.AutoSize  = true;
            this.lnkExit.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lnkExit.LinkColor = System.Drawing.Color.FromArgb(192, 0, 0);
            this.lnkExit.Location  = new System.Drawing.Point(495, 690);
            this.lnkExit.Name      = "lnkExit";
            this.lnkExit.TabIndex  = 21;
            this.lnkExit.TabStop   = true;
            this.lnkExit.Text      = "Exit";
            this.lnkExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkExit_LinkClicked);

            // ── RegistrationForm ──────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.White;
            this.ClientSize          = new System.Drawing.Size(540, 715);
            this.Controls.Add(this.lnkLogout);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpStudentReg);
            this.Controls.Add(this.grpBasicDetails);
            this.Controls.Add(this.grpContact);
            this.Controls.Add(this.grpParent);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lnkExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox     = false;
            this.Name            = "RegistrationForm";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text            = "Student Registration - Skills International";
            this.Load           += new System.EventHandler(this.RegistrationForm_Load);

            this.grpStudentReg.ResumeLayout(false);
            this.grpStudentReg.PerformLayout();
            this.grpBasicDetails.ResumeLayout(false);
            this.grpBasicDetails.PerformLayout();
            this.grpContact.ResumeLayout(false);
            this.grpContact.PerformLayout();
            this.grpParent.ResumeLayout(false);
            this.grpParent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // ── Control declarations ──────────────────────────────────────────────
        private System.Windows.Forms.LinkLabel   lnkLogout;
        private System.Windows.Forms.Label       lblTitle;
        private System.Windows.Forms.LinkLabel   lnkExit;

        private System.Windows.Forms.GroupBox    grpStudentReg;
        private System.Windows.Forms.Label       lblRegNo;
        private System.Windows.Forms.ComboBox    cmbRegNo;

        private System.Windows.Forms.GroupBox    grpBasicDetails;
        private System.Windows.Forms.Label       lblFirstName;
        private System.Windows.Forms.TextBox     txtFirstName;
        private System.Windows.Forms.Label       lblLastName;
        private System.Windows.Forms.TextBox     txtLastName;
        private System.Windows.Forms.Label       lblDOB;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label       lblGender;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;

        private System.Windows.Forms.GroupBox    grpContact;
        private System.Windows.Forms.Label       lblAddress;
        private System.Windows.Forms.TextBox     txtAddress;
        private System.Windows.Forms.Label       lblEmail;
        private System.Windows.Forms.TextBox     txtEmail;
        private System.Windows.Forms.Label       lblMobilePhone;
        private System.Windows.Forms.TextBox     txtMobilePhone;
        private System.Windows.Forms.Label       lblHomePhone;
        private System.Windows.Forms.TextBox     txtHomePhone;

        private System.Windows.Forms.GroupBox    grpParent;
        private System.Windows.Forms.Label       lblParentName;
        private System.Windows.Forms.TextBox     txtParentName;
        private System.Windows.Forms.Label       lblNIC;
        private System.Windows.Forms.TextBox     txtNIC;
        private System.Windows.Forms.Label       lblContactNo;
        private System.Windows.Forms.TextBox     txtContactNo;

        private System.Windows.Forms.Button      btnRegister;
        private System.Windows.Forms.Button      btnUpdate;
        private System.Windows.Forms.Button      btnClear;
        private System.Windows.Forms.Button      btnDelete;
    }
}
