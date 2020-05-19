using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQLdataAdapterApp
{
    public partial class invulForm : Form
    {
        public event EventHandler<List<string>> wijzigingenOpslaan; 
        public event EventHandler<List<string>> nieuwRecordOpslaan;

        private int mode = -1;

        public invulForm()
        {
            InitializeComponent();
        }

        public void recordAanpassen(int row, string productnaam, string stock, string beschikbaarheid)
        {
            label4.Text = "Record aanpassen";
            this.Text = "MySQL Databasebeheer - record aanpassen";

            mode = row;
            textBox1.Text = productnaam;
            textBox2.Text = stock;
            if (beschikbaarheid == "1")
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
        }

        public void recordToevoegen()
        {
            label4.Text = "Record Toevoegen";
            this.Text = "MySQL Databasebeheer - record toevoegen";

            mode = -1;
            textBox1.Text = "";
            textBox2.Text = "";
            checkBox1.Checked = false;
        }

        protected virtual void OnWijzigingenOpslaan(List<string> e)
        {
            wijzigingenOpslaan?.Invoke(this, e);
        }

        protected virtual void OnNieuwRecordOpslaan(List<string> e)
        {
            nieuwRecordOpslaan?.Invoke(this, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int val;
            if (Int32.TryParse(textBox2.Text, out val))
            {
                List<string> temp = new List<string>();
                temp.Add(textBox1.Text);
                temp.Add(textBox2.Text);
                if (checkBox1.Checked)
                {
                    temp.Add("1");
                }
                else
                {
                    temp.Add("0");
                }

                if (mode != -1)
                {
                    temp.Add(mode.ToString());
                    OnWijzigingenOpslaan(temp);
                }
                else
                {
                    OnNieuwRecordOpslaan(temp);
                }
            }
            else
            {
                MessageBox.Show("Dit is geen getal: " + textBox2.Text);
            }
        }

        private void invulForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
