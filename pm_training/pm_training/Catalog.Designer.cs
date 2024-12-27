
namespace pm_training
{
    partial class Catalog
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
            this.components = new System.ComponentModel.Container();
            this.printParks = new System.Windows.Forms.Button();
            this.tableParks = new System.Windows.Forms.DataGridView();
            this.parksDataSet = new pm_training.ParksDataSet();
            this.parkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parkTableAdapter = new pm_training.ParksDataSetTableAdapters.ParkTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableParks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // printParks
            // 
            this.printParks.Location = new System.Drawing.Point(592, 391);
            this.printParks.Name = "printParks";
            this.printParks.Size = new System.Drawing.Size(179, 23);
            this.printParks.TabIndex = 0;
            this.printParks.Text = "Вывести парки";
            this.printParks.UseVisualStyleBackColor = true;
            this.printParks.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableParks
            // 
            this.tableParks.AutoGenerateColumns = false;
            this.tableParks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableParks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn});
            this.tableParks.DataSource = this.parkBindingSource;
            this.tableParks.Location = new System.Drawing.Point(32, 22);
            this.tableParks.Name = "tableParks";
            this.tableParks.RowHeadersWidth = 51;
            this.tableParks.RowTemplate.Height = 24;
            this.tableParks.Size = new System.Drawing.Size(739, 353);
            this.tableParks.TabIndex = 1;
            // 
            // parksDataSet
            // 
            this.parksDataSet.DataSetName = "ParksDataSet";
            this.parksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parkBindingSource
            // 
            this.parkBindingSource.DataMember = "Park";
            this.parkBindingSource.DataSource = this.parksDataSet;
            // 
            // parkTableAdapter
            // 
            this.parkTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.Width = 125;
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableParks);
            this.Controls.Add(this.printParks);
            this.Name = "Catalog";
            this.Text = "Catalog";
            this.Load += new System.EventHandler(this.Catalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableParks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button printParks;
        private System.Windows.Forms.DataGridView tableParks;
        private ParksDataSet parksDataSet;
        private System.Windows.Forms.BindingSource parkBindingSource;
        private ParksDataSetTableAdapters.ParkTableAdapter parkTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
    }
}