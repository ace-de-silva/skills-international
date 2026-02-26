using System;
using System.Data;
using System.Windows.Forms;

namespace SkillsInternational
{
    public partial class RegistrationForm : Form
    {
        private readonly Form _loginForm;

        public RegistrationForm(Form loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            LoadRegNos();
        }

        // ── Helpers ──────────────────────────────────────────────────────────

        private void LoadRegNos()
        {
            cmbRegNo.Items.Clear();
            try
            {
                DataTable dt = DatabaseHelper.GetAllRegNos();
                foreach (DataRow row in dt.Rows)
                    cmbRegNo.Items.Add(row["regNo"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateFields(DataRow row)
        {
            txtFirstName.Text  = row["firstName"].ToString();
            txtLastName.Text   = row["lastName"].ToString();

            if (row["dateOfBirth"] != DBNull.Value)
                dtpDOB.Value = Convert.ToDateTime(row["dateOfBirth"]);

            string gender = row["gender"].ToString();
            rbMale.Checked   = gender == "Male";
            rbFemale.Checked = gender == "Female";

            txtAddress.Text     = row["address"].ToString();
            txtEmail.Text       = row["email"].ToString();
            txtMobilePhone.Text = row["mobilePhone"] == DBNull.Value ? "" : row["mobilePhone"].ToString();
            txtHomePhone.Text   = row["homePhone"]   == DBNull.Value ? "" : row["homePhone"].ToString();
            txtParentName.Text  = row["parentName"].ToString();
            txtNIC.Text         = row["nic"].ToString();
            txtContactNo.Text   = row["contactNo"]   == DBNull.Value ? "" : row["contactNo"].ToString();
        }

        private void ClearFields()
        {
            cmbRegNo.Text = "";
            txtFirstName.Clear();
            txtLastName.Clear();
            dtpDOB.Value = DateTime.Now;
            rbMale.Checked   = false;
            rbFemale.Checked = false;
            txtAddress.Clear();
            txtEmail.Clear();
            txtMobilePhone.Clear();
            txtHomePhone.Clear();
            txtParentName.Clear();
            txtNIC.Clear();
            txtContactNo.Clear();
        }

        private bool ValidateRequiredFields()
        {
            if (string.IsNullOrWhiteSpace(cmbRegNo.Text) || !int.TryParse(cmbRegNo.Text, out _))
            {
                MessageBox.Show("Please enter a valid Registration Number.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRegNo.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First Name is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return false;
            }
            return true;
        }

        // ── ComboBox: Reg No ─────────────────────────────────────────────────

        private void cmbRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRegNo.SelectedItem == null) return;
            if (!int.TryParse(cmbRegNo.SelectedItem.ToString(), out int regNo)) return;

            try
            {
                DataRow row = DatabaseHelper.GetStudentByRegNo(regNo);
                if (row != null) PopulateFields(row);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading record: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Buttons ───────────────────────────────────────────────────────────

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!ValidateRequiredFields()) return;

            try
            {
                int    regNo  = int.Parse(cmbRegNo.Text.Trim());
                string gender = rbMale.Checked ? "Male" : rbFemale.Checked ? "Female" : "";

                bool success = DatabaseHelper.RegisterStudent(
                    regNo, txtFirstName.Text, txtLastName.Text, dtpDOB.Value,
                    gender, txtAddress.Text, txtEmail.Text,
                    txtMobilePhone.Text, txtHomePhone.Text,
                    txtParentName.Text, txtNIC.Text, txtContactNo.Text);

                if (success)
                {
                    MessageBox.Show("Record Added Succesfully", "Register Student",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRegNos();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateRequiredFields()) return;

            try
            {
                int    regNo  = int.Parse(cmbRegNo.Text.Trim());
                string gender = rbMale.Checked ? "Male" : rbFemale.Checked ? "Female" : "";

                bool success = DatabaseHelper.UpdateStudent(
                    regNo, txtFirstName.Text, txtLastName.Text, dtpDOB.Value,
                    gender, txtAddress.Text, txtEmail.Text,
                    txtMobilePhone.Text, txtHomePhone.Text,
                    txtParentName.Text, txtNIC.Text, txtContactNo.Text);

                if (success)
                    MessageBox.Show("Record Updated Succesfully", "Update Student",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No record found with that Registration Number.", "Update Student",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbRegNo.Text))
            {
                MessageBox.Show("Please select a Registration Number to delete.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure, Do you really want to Delete this Record...?",
                "Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                int regNo = int.Parse(cmbRegNo.Text.Trim());
                bool success = DatabaseHelper.DeleteStudent(regNo);

                if (success)
                {
                    MessageBox.Show("Record Deleted Succesfully", "Delete Student",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRegNos();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // ── Link Labels ───────────────────────────────────────────────────────

        private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            _loginForm.Show();
        }

        private void lnkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure, Do you really want to Exit...?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }
    }
}
