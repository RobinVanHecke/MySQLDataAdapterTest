using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace MySQLdataAdapterApp
{
    public partial class MainForm : Form
    {
        // objects of interest when making a connection to the database
        private MySqlConnection myConnection;
        private MySqlDataAdapter myDataAdapter;
        MySqlCommandBuilder myCommandBuilder;
        private DataTable myTable;
        private readonly string connectionString;
        private const string SelectQuery = "SELECT * FROM producten";

        private readonly invulForm fillInForm = new invulForm();
        public MainForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            fillInForm.Hide();
            fillInForm.wijzigingenOpslaan += FillInFormOnSaveChanges;
            fillInForm.nieuwRecordOpslaan += FillInFormOnSaveNewRecord;
        }

        private void FillInFormOnSaveNewRecord(object sender, List<string> e)
        {
            DataRow r = myTable.NewRow();
            r[0] = DBNull.Value;
            r[1] = e[0];
            r[2] = e[1];
            r[3] = e[2];
            myTable.Rows.Add(r);
            fillInForm.Hide();
        }

        private void FillInFormOnSaveChanges(object sender, List<string> e)
        {
            int rij = int.Parse(e[3]);
            AdjustDataTable(myTable, rij, 1, e[0]);
            AdjustDataTable(myTable, rij, 2, e[1]);
            AdjustDataTable(myTable, rij, 3, e[2]);
            fillInForm.Hide();
        }

        private void BtnExecuteSelectQuery_Click(object sender, EventArgs e)
        {
            myConnection = new MySqlConnection(connectionString);
            using (myDataAdapter = new MySqlDataAdapter(SelectQuery, myConnection))
            {
                myCommandBuilder = new MySqlCommandBuilder(myDataAdapter);
                myTable = new DataTable();
                myDataAdapter.Fill(myTable);
                DgvProducten.DataSource = myTable;
                myTable.AcceptChanges();
            }

            DgvProducten.ClearSelection();
            BtnRecordVerwijderen.Enabled = false;
            BtnRecordWijzigen.Enabled = false;

        }

        private void BtnUpdateTable_Click(object sender, EventArgs e)
        {
            DataTable myChanges = myTable.GetChanges();
            if (myChanges != null)
            {
                using (myDataAdapter = new MySqlDataAdapter(SelectQuery, myConnection))
                {
                    myCommandBuilder = new MySqlCommandBuilder(myDataAdapter);
                    myDataAdapter.Update(myChanges);
                    myTable.AcceptChanges();
                }
            }
            else
                MessageBox.Show(@"There were no changes");
        }

        private void DgvProducten_DoubleClick(object sender, EventArgs e)
        {

            DataGridViewSelectedRowCollection selectedRows = DgvProducten.SelectedRows;

            StringBuilder sb = new StringBuilder();

            foreach (DataGridViewRow r in selectedRows)
                sb.Append(r.Index.ToString());

            MessageBox.Show(@"Row "+ sb + @" selected");
        }

        private static void AdjustDataTable(DataTable table, int rij, int kol, string data)
        {
            if (rij < table.Rows.Count && kol < table.Columns.Count)
                table.Rows[rij][kol] = data;
        }


        private void DeleteRecordData(DataGridView grid, int rij)
        {
            if (rij >= grid.RowCount) return;
            grid.Rows.RemoveAt(rij);
            BtnRecordVerwijderen.Enabled = false;
            BtnRecordWijzigen.Enabled = false;
        }


        private void BtnRecordDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show(@"Are you sure that you want to delete " + DgvProducten.SelectedRows[0].Cells[1].Value + @" ?", @"Confirm removal!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
                DeleteRecordData(DgvProducten, DgvProducten.SelectedRows[0].Index);
        }

        private void BtnRecordChange_Click(object sender, EventArgs e)
        {
            DataGridViewRow temp = DgvProducten.SelectedRows[0];
            fillInForm.recordAanpassen(temp.Index, temp.Cells[1].Value.ToString(), temp.Cells[2].Value.ToString(), temp.Cells[3].Value.ToString());
            fillInForm.Show();
            fillInForm.BringToFront();
        }

        private void BtnRecordAdd_Click(object sender, EventArgs e)
        {
            fillInForm.recordToevoegen();
            fillInForm.Show();
            fillInForm.BringToFront();
        }

        private void DgvProducten_SelectionChanged(object sender, EventArgs e)
        { 
            BtnRecordVerwijderen.Enabled = true;
            BtnRecordWijzigen.Enabled = true;
        }
    }
}
