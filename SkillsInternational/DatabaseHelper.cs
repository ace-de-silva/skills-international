using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SkillsInternational
{
    public static class DatabaseHelper
    {
        private static readonly string ConnectionString =
            ConfigurationManager.ConnectionStrings["StudentDB"].ConnectionString;

        private static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        // Validates login: first checks hardcoded Admin credential, then DB Logins table if available
        public static bool ValidateLogin(string username, string password)
        {
            if (username == "Admin" && password == "Skills@123")
                return true;

            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT COUNT(*) FROM Logins WHERE username = @u AND password = @p";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@u", username);
                        cmd.Parameters.AddWithValue("@p", password);
                        return (int)cmd.ExecuteScalar() > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        // Returns all registration numbers for the ComboBox
        public static DataTable GetAllRegNos()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string sql = "SELECT regNo FROM Registration ORDER BY regNo";
                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        // Returns a single student record by registration number
        public static DataRow GetStudentByRegNo(int regNo)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string sql = "SELECT * FROM Registration WHERE regNo = @regNo";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@regNo", regNo);
                    DataTable dt = new DataTable();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    return dt.Rows.Count > 0 ? dt.Rows[0] : null;
                }
            }
        }

        // Inserts a new student registration record
        public static bool RegisterStudent(int regNo, string firstName, string lastName,
            DateTime dob, string gender, string address, string email,
            string mobilePhone, string homePhone, string parentName, string nic, string contactNo)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string sql = @"INSERT INTO Registration
                    (regNo, firstName, lastName, dateOfBirth, gender, address, email,
                     mobilePhone, homePhone, parentName, nic, contactNo)
                    VALUES
                    (@regNo, @firstName, @lastName, @dob, @gender, @address, @email,
                     @mobile, @home, @parentName, @nic, @contactNo)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@regNo", regNo);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@dob", dob);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@mobile", ParseNullableInt(mobilePhone));
                    cmd.Parameters.AddWithValue("@home", ParseNullableInt(homePhone));
                    cmd.Parameters.AddWithValue("@parentName", parentName);
                    cmd.Parameters.AddWithValue("@nic", nic);
                    cmd.Parameters.AddWithValue("@contactNo", ParseNullableInt(contactNo));
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Updates an existing student registration record
        public static bool UpdateStudent(int regNo, string firstName, string lastName,
            DateTime dob, string gender, string address, string email,
            string mobilePhone, string homePhone, string parentName, string nic, string contactNo)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string sql = @"UPDATE Registration SET
                    firstName    = @firstName,
                    lastName     = @lastName,
                    dateOfBirth  = @dob,
                    gender       = @gender,
                    address      = @address,
                    email        = @email,
                    mobilePhone  = @mobile,
                    homePhone    = @home,
                    parentName   = @parentName,
                    nic          = @nic,
                    contactNo    = @contactNo
                WHERE regNo = @regNo";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@regNo", regNo);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@dob", dob);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@mobile", ParseNullableInt(mobilePhone));
                    cmd.Parameters.AddWithValue("@home", ParseNullableInt(homePhone));
                    cmd.Parameters.AddWithValue("@parentName", parentName);
                    cmd.Parameters.AddWithValue("@nic", nic);
                    cmd.Parameters.AddWithValue("@contactNo", ParseNullableInt(contactNo));
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // Deletes a student record by registration number
        public static bool DeleteStudent(int regNo)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM Registration WHERE regNo = @regNo";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@regNo", regNo);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        private static object ParseNullableInt(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return DBNull.Value;
            if (int.TryParse(value, out int result)) return result;
            return DBNull.Value;
        }
    }
}
