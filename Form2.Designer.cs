﻿namespace Kinoteatr
{
    partial class Form2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kinoNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.place0DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.place1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.place2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.place3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.place4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.place5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.place6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.place7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.place8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.place9DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kinoTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seansesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seansDataSet = new Kinoteatr.seansDataSet();
            this.seansesTableTableAdapter = new Kinoteatr.seansDataSetTableAdapters.seansesTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansesTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.BlueViolet;
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(77, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(322, 304);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BlueViolet;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(508, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 118);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить сеанс";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.BlueViolet;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(508, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 118);
            this.button2.TabIndex = 2;
            this.button2.Text = "Перезагрузить страницу";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.kinoNameDataGridViewTextBoxColumn,
            this.place0DataGridViewTextBoxColumn,
            this.place1DataGridViewTextBoxColumn,
            this.place2DataGridViewTextBoxColumn,
            this.place3DataGridViewTextBoxColumn,
            this.place4DataGridViewTextBoxColumn,
            this.place5DataGridViewTextBoxColumn,
            this.place6DataGridViewTextBoxColumn,
            this.place7DataGridViewTextBoxColumn,
            this.place8DataGridViewTextBoxColumn,
            this.place9DataGridViewTextBoxColumn,
            this.kinoTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.seansesTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(714, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.Width = 125;
            // 
            // kinoNameDataGridViewTextBoxColumn
            // 
            this.kinoNameDataGridViewTextBoxColumn.DataPropertyName = "kinoName";
            this.kinoNameDataGridViewTextBoxColumn.HeaderText = "kinoName";
            this.kinoNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kinoNameDataGridViewTextBoxColumn.Name = "kinoNameDataGridViewTextBoxColumn";
            this.kinoNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // place0DataGridViewTextBoxColumn
            // 
            this.place0DataGridViewTextBoxColumn.DataPropertyName = "place0";
            this.place0DataGridViewTextBoxColumn.HeaderText = "place0";
            this.place0DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.place0DataGridViewTextBoxColumn.Name = "place0DataGridViewTextBoxColumn";
            this.place0DataGridViewTextBoxColumn.Width = 125;
            // 
            // place1DataGridViewTextBoxColumn
            // 
            this.place1DataGridViewTextBoxColumn.DataPropertyName = "place1";
            this.place1DataGridViewTextBoxColumn.HeaderText = "place1";
            this.place1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.place1DataGridViewTextBoxColumn.Name = "place1DataGridViewTextBoxColumn";
            this.place1DataGridViewTextBoxColumn.Width = 125;
            // 
            // place2DataGridViewTextBoxColumn
            // 
            this.place2DataGridViewTextBoxColumn.DataPropertyName = "place2";
            this.place2DataGridViewTextBoxColumn.HeaderText = "place2";
            this.place2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.place2DataGridViewTextBoxColumn.Name = "place2DataGridViewTextBoxColumn";
            this.place2DataGridViewTextBoxColumn.Width = 125;
            // 
            // place3DataGridViewTextBoxColumn
            // 
            this.place3DataGridViewTextBoxColumn.DataPropertyName = "place3";
            this.place3DataGridViewTextBoxColumn.HeaderText = "place3";
            this.place3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.place3DataGridViewTextBoxColumn.Name = "place3DataGridViewTextBoxColumn";
            this.place3DataGridViewTextBoxColumn.Width = 125;
            // 
            // place4DataGridViewTextBoxColumn
            // 
            this.place4DataGridViewTextBoxColumn.DataPropertyName = "place4";
            this.place4DataGridViewTextBoxColumn.HeaderText = "place4";
            this.place4DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.place4DataGridViewTextBoxColumn.Name = "place4DataGridViewTextBoxColumn";
            this.place4DataGridViewTextBoxColumn.Width = 125;
            // 
            // place5DataGridViewTextBoxColumn
            // 
            this.place5DataGridViewTextBoxColumn.DataPropertyName = "place5";
            this.place5DataGridViewTextBoxColumn.HeaderText = "place5";
            this.place5DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.place5DataGridViewTextBoxColumn.Name = "place5DataGridViewTextBoxColumn";
            this.place5DataGridViewTextBoxColumn.Width = 125;
            // 
            // place6DataGridViewTextBoxColumn
            // 
            this.place6DataGridViewTextBoxColumn.DataPropertyName = "place6";
            this.place6DataGridViewTextBoxColumn.HeaderText = "place6";
            this.place6DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.place6DataGridViewTextBoxColumn.Name = "place6DataGridViewTextBoxColumn";
            this.place6DataGridViewTextBoxColumn.Width = 125;
            // 
            // place7DataGridViewTextBoxColumn
            // 
            this.place7DataGridViewTextBoxColumn.DataPropertyName = "place7";
            this.place7DataGridViewTextBoxColumn.HeaderText = "place7";
            this.place7DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.place7DataGridViewTextBoxColumn.Name = "place7DataGridViewTextBoxColumn";
            this.place7DataGridViewTextBoxColumn.Width = 125;
            // 
            // place8DataGridViewTextBoxColumn
            // 
            this.place8DataGridViewTextBoxColumn.DataPropertyName = "place8";
            this.place8DataGridViewTextBoxColumn.HeaderText = "place8";
            this.place8DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.place8DataGridViewTextBoxColumn.Name = "place8DataGridViewTextBoxColumn";
            this.place8DataGridViewTextBoxColumn.Width = 125;
            // 
            // place9DataGridViewTextBoxColumn
            // 
            this.place9DataGridViewTextBoxColumn.DataPropertyName = "place9";
            this.place9DataGridViewTextBoxColumn.HeaderText = "place9";
            this.place9DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.place9DataGridViewTextBoxColumn.Name = "place9DataGridViewTextBoxColumn";
            this.place9DataGridViewTextBoxColumn.Width = 125;
            // 
            // kinoTimeDataGridViewTextBoxColumn
            // 
            this.kinoTimeDataGridViewTextBoxColumn.DataPropertyName = "kinoTime";
            this.kinoTimeDataGridViewTextBoxColumn.HeaderText = "kinoTime";
            this.kinoTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kinoTimeDataGridViewTextBoxColumn.Name = "kinoTimeDataGridViewTextBoxColumn";
            this.kinoTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // seansesTableBindingSource
            // 
            this.seansesTableBindingSource.DataMember = "seansesTable";
            this.seansesTableBindingSource.DataSource = this.seansDataSet;
            // 
            // seansDataSet
            // 
            this.seansDataSet.DataSetName = "seansDataSet";
            this.seansDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seansesTableTableAdapter
            // 
            this.seansesTableTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kinoteatr.Properties.Resources.fonKino;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form2";
            this.Text = "Окно администратора";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansesTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private seansDataSet seansDataSet;
        private System.Windows.Forms.BindingSource seansesTableBindingSource;
        private seansDataSetTableAdapters.seansesTableTableAdapter seansesTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kinoNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn place0DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn place1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn place2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn place3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn place4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn place5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn place6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn place7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn place8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn place9DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kinoTimeDataGridViewTextBoxColumn;
    }
}