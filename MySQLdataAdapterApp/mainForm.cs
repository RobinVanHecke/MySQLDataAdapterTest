using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace MySQLdataAdapterApp
{
    public partial class mainForm : Form
    {
        //objecten van belang bij het maken van een connectie met de database
        MySqlConnection myConnection;
        MySqlDataAdapter myDataAdapter;
        MySqlCommandBuilder myCommandBuidler;
        DataTable myTable;
        string connectionString;
        string selectQuery = "SELECT * FROM producten";
        public mainForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
        }

        private void BtnExecuteSelectQuery_Click(object sender, EventArgs e)
        {
            myConnection = new MySqlConnection(connectionString);
            myDataAdapter = new MySqlDataAdapter(selectQuery, myConnection);
            myCommandBuidler = new MySqlCommandBuilder(myDataAdapter);
            myTable = new DataTable();
            myDataAdapter.Fill(myTable);
            DgvProducten.DataSource = myTable;
        }

        private void BtnUpdateTabel_Click(object sender, EventArgs e)
        {
            DataTable myChanges = myTable.GetChanges();
            myDataAdapter.Update(myChanges);
            myTable.AcceptChanges();
        }

        private void DgvProducten_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection geselecteerdeRijen = DgvProducten.SelectedRows;

            StringBuilder sb = new StringBuilder();

            foreach (DataGridViewRow r in geselecteerdeRijen)
            {
                sb.Append(r.Index.ToString());
            }

            MessageBox.Show("rij "+sb.ToString()+ " geselecteerd...");
        }

        private void BtnRecordVerwijderen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Je zal het invulform moeten tonen en via die weg de gegevens toevoegen...");
        }

        private void BtnRecordWijzigen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Je zal het invulform moeten tonen en via die weg de gegevens toevoegen...");
        }

        private void BtnRecordToevoegen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Je zal het invulform moeten tonen en via die weg de gegevens toevoegen...");
        }
    }
}
