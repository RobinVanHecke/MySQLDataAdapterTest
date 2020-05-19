namespace MySQLdataAdapterApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnExecuteSelectQuery = new System.Windows.Forms.Button();
            this.DgvProducten = new System.Windows.Forms.DataGridView();
            this.BtnUpdateTabel = new System.Windows.Forms.Button();
            this.BtnRecordToevoegen = new System.Windows.Forms.Button();
            this.BtnRecordVerwijderen = new System.Windows.Forms.Button();
            this.BtnRecordWijzigen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducten)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnExecuteSelectQuery
            // 
            this.BtnExecuteSelectQuery.Location = new System.Drawing.Point(9, 314);
            this.BtnExecuteSelectQuery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnExecuteSelectQuery.Name = "BtnExecuteSelectQuery";
            this.BtnExecuteSelectQuery.Size = new System.Drawing.Size(134, 41);
            this.BtnExecuteSelectQuery.TabIndex = 0;
            this.BtnExecuteSelectQuery.Text = "Voer select-query uit\r\nop tabel producten";
            this.BtnExecuteSelectQuery.UseVisualStyleBackColor = true;
            this.BtnExecuteSelectQuery.Click += new System.EventHandler(this.BtnExecuteSelectQuery_Click);
            // 
            // DgvProducten
            // 
            this.DgvProducten.AllowUserToAddRows = false;
            this.DgvProducten.AllowUserToDeleteRows = false;
            this.DgvProducten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvProducten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProducten.Location = new System.Drawing.Point(9, 10);
            this.DgvProducten.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvProducten.MultiSelect = false;
            this.DgvProducten.Name = "DgvProducten";
            this.DgvProducten.ReadOnly = true;
            this.DgvProducten.RowHeadersWidth = 51;
            this.DgvProducten.RowTemplate.Height = 24;
            this.DgvProducten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProducten.Size = new System.Drawing.Size(767, 300);
            this.DgvProducten.TabIndex = 1;
            this.DgvProducten.SelectionChanged += new System.EventHandler(this.DgvProducten_SelectionChanged);
            this.DgvProducten.DoubleClick += new System.EventHandler(this.DgvProducten_DoubleClick);
            // 
            // BtnUpdateTabel
            // 
            this.BtnUpdateTabel.Location = new System.Drawing.Point(148, 315);
            this.BtnUpdateTabel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnUpdateTabel.Name = "BtnUpdateTabel";
            this.BtnUpdateTabel.Size = new System.Drawing.Size(148, 41);
            this.BtnUpdateTabel.TabIndex = 2;
            this.BtnUpdateTabel.Text = "Update tabel in \r\nprouducten database";
            this.BtnUpdateTabel.UseVisualStyleBackColor = true;
            this.BtnUpdateTabel.Click += new System.EventHandler(this.BtnUpdateTable_Click);
            // 
            // BtnRecordToevoegen
            // 
            this.BtnRecordToevoegen.Location = new System.Drawing.Point(647, 314);
            this.BtnRecordToevoegen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnRecordToevoegen.Name = "BtnRecordToevoegen";
            this.BtnRecordToevoegen.Size = new System.Drawing.Size(129, 41);
            this.BtnRecordToevoegen.TabIndex = 3;
            this.BtnRecordToevoegen.Text = "Record toevoegen";
            this.BtnRecordToevoegen.UseVisualStyleBackColor = true;
            this.BtnRecordToevoegen.Click += new System.EventHandler(this.BtnRecordAdd_Click);
            // 
            // BtnRecordVerwijderen
            // 
            this.BtnRecordVerwijderen.Enabled = false;
            this.BtnRecordVerwijderen.Location = new System.Drawing.Point(387, 314);
            this.BtnRecordVerwijderen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnRecordVerwijderen.Name = "BtnRecordVerwijderen";
            this.BtnRecordVerwijderen.Size = new System.Drawing.Size(129, 41);
            this.BtnRecordVerwijderen.TabIndex = 4;
            this.BtnRecordVerwijderen.Text = "Geselecteerd record \r\nverwijderen";
            this.BtnRecordVerwijderen.UseVisualStyleBackColor = true;
            this.BtnRecordVerwijderen.Click += new System.EventHandler(this.BtnRecordDelete_Click);
            // 
            // BtnRecordWijzigen
            // 
            this.BtnRecordWijzigen.Location = new System.Drawing.Point(520, 314);
            this.BtnRecordWijzigen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnRecordWijzigen.Name = "BtnRecordWijzigen";
            this.BtnRecordWijzigen.Size = new System.Drawing.Size(122, 42);
            this.BtnRecordWijzigen.TabIndex = 5;
            this.BtnRecordWijzigen.Text = "Geselecteerd record\r\nwijzigen";
            this.BtnRecordWijzigen.UseVisualStyleBackColor = true;
            this.BtnRecordWijzigen.Click += new System.EventHandler(this.BtnRecordChange_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 360);
            this.Controls.Add(this.BtnRecordWijzigen);
            this.Controls.Add(this.BtnRecordVerwijderen);
            this.Controls.Add(this.BtnRecordToevoegen);
            this.Controls.Add(this.BtnUpdateTabel);
            this.Controls.Add(this.DgvProducten);
            this.Controls.Add(this.BtnExecuteSelectQuery);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "MySQL Databasebeheer";
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducten)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnExecuteSelectQuery;
        private System.Windows.Forms.DataGridView DgvProducten;
        private System.Windows.Forms.Button BtnUpdateTabel;
        private System.Windows.Forms.Button BtnRecordToevoegen;
        private System.Windows.Forms.Button BtnRecordVerwijderen;
        private System.Windows.Forms.Button BtnRecordWijzigen;
    }
}

