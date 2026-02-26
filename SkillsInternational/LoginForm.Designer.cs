namespace SkillsInternational
{
    partial class LoginForm
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
            this.picLogo     = new System.Windows.Forms.PictureBox();
            this.lblTitle    = new System.Windows.Forms.Label();
            this.grpLogin    = new System.Windows.Forms.GroupBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnClear    = new System.Windows.Forms.Button();
            this.btnLogin    = new System.Windows.Forms.Button();
            this.btnExit     = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grpLogin.SuspendLayout();
            this.SuspendLayout();

            // ── picLogo ──────────────────────────────────────────────────────
            this.picLogo.Location = new System.Drawing.Point(155, 18);
            this.picLogo.Name     = "picLogo";
            this.picLogo.Size     = new System.Drawing.Size(90, 75);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabStop  = false;

            // ── lblTitle ─────────────────────────────────────────────────────
            this.lblTitle.AutoSize  = false;
            this.lblTitle.Font      = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 120);
            this.lblTitle.Location  = new System.Drawing.Point(20, 98);
            this.lblTitle.Name      = "lblTitle";
            this.lblTitle.Size      = new System.Drawing.Size(360, 32);
            this.lblTitle.Text      = "Skills International";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── grpLogin ─────────────────────────────────────────────────────
            this.grpLogin.Controls.Add(this.lblUsername);
            this.grpLogin.Controls.Add(this.txtUsername);
            this.grpLogin.Controls.Add(this.lblPassword);
            this.grpLogin.Controls.Add(this.txtPassword);
            this.grpLogin.Controls.Add(this.btnClear);
            this.grpLogin.Controls.Add(this.btnLogin);
            this.grpLogin.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.grpLogin.Location = new System.Drawing.Point(25, 138);
            this.grpLogin.Name     = "grpLogin";
            this.grpLogin.Size     = new System.Drawing.Size(350, 160);
            this.grpLogin.Text     = "Login";

            // ── lblUsername ───────────────────────────────────────────────────
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(15, 38);
            this.lblUsername.Name     = "lblUsername";
            this.lblUsername.Text     = "Username";

            // ── txtUsername ───────────────────────────────────────────────────
            this.txtUsername.Location = new System.Drawing.Point(105, 35);
            this.txtUsername.Name     = "txtUsername";
            this.txtUsername.Size     = new System.Drawing.Size(225, 23);
            this.txtUsername.TabIndex = 0;

            // ── lblPassword ───────────────────────────────────────────────────
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(15, 75);
            this.lblPassword.Name     = "lblPassword";
            this.lblPassword.Text     = "Password";

            // ── txtPassword ───────────────────────────────────────────────────
            this.txtPassword.Location     = new System.Drawing.Point(105, 72);
            this.txtPassword.Name         = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size         = new System.Drawing.Size(225, 23);
            this.txtPassword.TabIndex     = 1;

            // ── btnClear ──────────────────────────────────────────────────────
            this.btnClear.Location = new System.Drawing.Point(15, 115);
            this.btnClear.Name     = "btnClear";
            this.btnClear.Size     = new System.Drawing.Size(75, 28);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text     = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click   += new System.EventHandler(this.btnClear_Click);

            // ── btnLogin ──────────────────────────────────────────────────────
            this.btnLogin.Location = new System.Drawing.Point(215, 115);
            this.btnLogin.Name     = "btnLogin";
            this.btnLogin.Size     = new System.Drawing.Size(75, 28);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text     = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click   += new System.EventHandler(this.btnLogin_Click);

            // ── btnExit ───────────────────────────────────────────────────────
            this.btnExit.Location = new System.Drawing.Point(10, 320);
            this.btnExit.Name     = "btnExit";
            this.btnExit.Size     = new System.Drawing.Size(75, 28);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text     = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click   += new System.EventHandler(this.btnExit_Click);

            // ── LoginForm ─────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.White;
            this.ClientSize          = new System.Drawing.Size(400, 360);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpLogin);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox     = false;
            this.Name            = "LoginForm";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text            = "Login - Skills International";

            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label      lblTitle;
        private System.Windows.Forms.GroupBox   grpLogin;
        private System.Windows.Forms.Label      lblUsername;
        private System.Windows.Forms.TextBox    txtUsername;
        private System.Windows.Forms.Label      lblPassword;
        private System.Windows.Forms.TextBox    txtPassword;
        private System.Windows.Forms.Button     btnClear;
        private System.Windows.Forms.Button     btnLogin;
        private System.Windows.Forms.Button     btnExit;
    }
}
