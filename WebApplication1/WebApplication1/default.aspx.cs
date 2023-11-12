using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadRecord();
            }
        }

        SqlConnection sqlConnection = new SqlConnection("Data Source = KRISHNA; Initial Catalog = ProgramDB; Integrated Security = True");
        protected void BtnInsert_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Insert into StudentInfo_Tab values('" + int.Parse(txtStudentID.Text) + "','" + txtStudentName.Text + "','" + ddlAddress.SelectedValue + "','" + float.Parse(txtAge.Text) + "','" + txtContact.Text + "')", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Inserted');", true);
            LoadRecord();
        }

        void LoadRecord()
        {
            SqlCommand sqlCommand = new SqlCommand("select * from StudentInfo_Tab", sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
        }

        protected void DdlAddress_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Update StudentInfo_Tab set StudentName = '" + txtStudentName.Text + "', Address = '" + ddlAddress.SelectedValue + "', Age = '" + float.Parse(txtAge.Text) + "', Contact = '" + txtContact.Text + "' where StudentID = '" + int.Parse(txtStudentID.Text) + "'", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Updated');", true);
            LoadRecord();
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Delete StudentInfo_Tab where StudentID = '" + int.Parse(txtStudentID.Text) + "'", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Deleted');", true);
            LoadRecord();
        }

        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("select * from StudentInfo_Tab where studentID = '" + int.Parse(txtStudentID.Text) + "'", sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            GridView1.DataSource = dataTable;
            GridView1.DataBind();
        }

        protected void BtnGet_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from StudentInfo_Tab where studentID = '" + int.Parse(txtStudentID.Text) + "'", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                txtStudentName.Text = sqlDataReader.GetValue(1).ToString();
                ddlAddress.SelectedValue = sqlDataReader.GetValue(2).ToString();
                txtAge.Text = sqlDataReader.GetValue(3).ToString();
                txtContact.Text = sqlDataReader.GetValue(4).ToString();
            }
        }
    }
}