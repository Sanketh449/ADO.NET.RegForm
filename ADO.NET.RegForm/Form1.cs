using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ADO.NET.RegForm
{
    public partial class Form1 : Form
    {
        private SqlConnection con = null;
        private SqlCommand cmd = null;
        private SqlDataReader reader = null;
        public Form1()
        {
            InitializeComponent();
        }
        public void ClearText()
        {
            TxtFirstName.Clear();
            TxtLastName.Clear();
            DtpBirthDate.Text = "";
            ComboGender.Text = "";
            TxtEmailId.Text = "";
            TxtFirstName.Focus();
            TxtPassword.Text = "";
            TxtConfirmPassword.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["masterCon"].ConnectionString);

            cmd = new SqlCommand("Select vFirstName,vLastName,dBirthDate,cGender,vEmailId,cPassword from RegistrationFormm", con);


            con.Open();
            reader = cmd.ExecuteReader();
            reader.Read();

            TxtFirstName.Text = reader["vFirstName"].ToString();
            TxtLastName.Text = reader["vLastName"].ToString();
            DtpBirthDate.Text = reader["dBirthDate"].ToString();
            ComboGender.Text = reader["cGender"].ToString();
            TxtEmailId.Text = reader["vEmailId"].ToString();
            TxtPassword.Text = reader["cPassword"].ToString();


            reader.Close();
            cmd.Dispose();
            con.Close();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            this.ClearText();
        }

        private void BtnSignin_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["masterCon"].ConnectionString))
            {
                using (cmd = new SqlCommand("usp_AddNew", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FirstName", TxtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", TxtLastName.Text);
                    cmd.Parameters.AddWithValue("@BirthDate", DtpBirthDate.Text);
                    cmd.Parameters.AddWithValue("@Gender", ComboGender.Text);
                    cmd.Parameters.AddWithValue("@EmailId", TxtEmailId.Text);
                    cmd.Parameters.AddWithValue("@Password", TxtPassword.Text);
                    //cmd.Parameters.AddWithValue("@ConfirmPassword", TxtConfirmPassword.Text);

                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    cmd.ExecuteNonQuery(); //used for DML operation
                }
            }
            MessageBox.Show("SignIn Successfull");
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["masterCon"].ConnectionString))
            {

                if ((TxtEmailId.Text == "") || (TxtPassword.Text == ""))
                {
                    MessageBox.Show("Please Enter EmailId and Password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                con.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter("select * from RegistrationFormm WHERE vEmailId='" + TxtEmailId.Text + "' AND cPassword='" + TxtPassword.Text + "'", con);
                sda.Fill(ds);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Invalid EmailId or Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (ds.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("Welcome", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.ClearText();
            }
        }

    }

    /*private void TxtEmailId_TextChanged(object sender, EventArgs e)
    {
        //this.CheckEmailid();

        using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["masterCon"].ConnectionString))
        {

                Boolean emailavailable = false;
                string myquery = "select * from RegistrationFormm where EmailId =" + TxtEmailId.Text + " ";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = myquery;

                cmd.Connection = con;
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    emailavailable = true;
                }
                con.Close();

        } */




}

