using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        DataSet myDS = new DataSet();
        //make connection
        SqlConnection cnStr = DBHelper.GetConnection();
        SqlDataAdapter dAdapt = null;
        public Form1()
        {
            InitializeComponent();

            //load data from database to the data set
            initDataSet();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void initDataSet()
        {
            //Fill the DataSet with a new DataTable
            dAdapt = new SqlDataAdapter("select * from SVien", cnStr);
            //using SqlCommandBuilder to generate SQL query commands
            SqlCommandBuilder invBuilder = new SqlCommandBuilder(dAdapt);
        }
        public void loadData()
        {
            try
            {
                dAdapt.Fill(myDS, "SVien");
                dataGrid.DataSource = myDS.Tables["SVien"];
            }
            catch (Exception e)
            {
                MessageBox.Show("Cannot load data " + e.Message);
                dataGrid.DataSource = null;
            }
        }
    }
}
