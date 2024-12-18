namespace Test_two
{
    partial class Archivist
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
            this.TabInfo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.OpenAddExhibition = new System.Windows.Forms.Button();
            this.GridExhibits = new System.Windows.Forms.DataGridView();
            this.exhibitionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exhibitionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.museumDBDataSet = new Test_two.MuseumDBDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.OpenEditExibit = new System.Windows.Forms.Button();
            this.OpenAddExhibit = new System.Windows.Forms.Button();
            this.GridExhibit = new System.Windows.Forms.DataGridView();
            this.exhibitIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exhibitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exhibitionsTableAdapter = new Test_two.MuseumDBDataSetTableAdapters.ExhibitionsTableAdapter();
            this.exhibitsTableAdapter = new Test_two.MuseumDBDataSetTableAdapters.ExhibitsTableAdapter();
            this.TabInfo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridExhibits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exhibitionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.museumDBDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridExhibit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exhibitsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TabInfo
            // 
            this.TabInfo.Controls.Add(this.tabPage1);
            this.TabInfo.Controls.Add(this.tabPage2);
            this.TabInfo.Location = new System.Drawing.Point(12, 12);
            this.TabInfo.Name = "TabInfo";
            this.TabInfo.SelectedIndex = 0;
            this.TabInfo.Size = new System.Drawing.Size(714, 426);
            this.TabInfo.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.OpenAddExhibition);
            this.tabPage1.Controls.Add(this.GridExhibits);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(706, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Выставки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(549, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 48);
            this.button2.TabIndex = 3;
            this.button2.Text = "Архивировать выставку";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(549, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Редактровать выставку";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // OpenAddExhibition
            // 
            this.OpenAddExhibition.Location = new System.Drawing.Point(549, 6);
            this.OpenAddExhibition.Name = "OpenAddExhibition";
            this.OpenAddExhibition.Size = new System.Drawing.Size(153, 48);
            this.OpenAddExhibition.TabIndex = 1;
            this.OpenAddExhibition.Text = "Добавить выставку";
            this.OpenAddExhibition.UseVisualStyleBackColor = true;
            // 
            // GridExhibits
            // 
            this.GridExhibits.AllowUserToAddRows = false;
            this.GridExhibits.AutoGenerateColumns = false;
            this.GridExhibits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridExhibits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridExhibits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exhibitionIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn1});
            this.GridExhibits.DataSource = this.exhibitionsBindingSource;
            this.GridExhibits.Location = new System.Drawing.Point(3, 3);
            this.GridExhibits.Name = "GridExhibits";
            this.GridExhibits.Size = new System.Drawing.Size(540, 394);
            this.GridExhibits.TabIndex = 0;
            // 
            // exhibitionIdDataGridViewTextBoxColumn
            // 
            this.exhibitionIdDataGridViewTextBoxColumn.DataPropertyName = "ExhibitionId";
            this.exhibitionIdDataGridViewTextBoxColumn.HeaderText = "ExhibitionId";
            this.exhibitionIdDataGridViewTextBoxColumn.Name = "exhibitionIdDataGridViewTextBoxColumn";
            this.exhibitionIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.exhibitionIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 82;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "Начало выставки";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.Width = 111;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "Окончание выставки";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.Width = 127;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            // 
            // exhibitionsBindingSource
            // 
            this.exhibitionsBindingSource.DataMember = "Exhibitions";
            this.exhibitionsBindingSource.DataSource = this.museumDBDataSet;
            // 
            // museumDBDataSet
            // 
            this.museumDBDataSet.DataSetName = "MuseumDBDataSet";
            this.museumDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.OpenEditExibit);
            this.tabPage2.Controls.Add(this.OpenAddExhibit);
            this.tabPage2.Controls.Add(this.GridExhibit);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(706, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Экспонаты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(547, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 48);
            this.button3.TabIndex = 6;
            this.button3.Text = "Архивировать экспонат";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // OpenEditExibit
            // 
            this.OpenEditExibit.Location = new System.Drawing.Point(547, 60);
            this.OpenEditExibit.Name = "OpenEditExibit";
            this.OpenEditExibit.Size = new System.Drawing.Size(153, 48);
            this.OpenEditExibit.TabIndex = 5;
            this.OpenEditExibit.Text = "Редактровать экспонат";
            this.OpenEditExibit.UseVisualStyleBackColor = true;
            this.OpenEditExibit.Click += new System.EventHandler(this.OpenEditExibit_Click);
            // 
            // OpenAddExhibit
            // 
            this.OpenAddExhibit.Location = new System.Drawing.Point(547, 6);
            this.OpenAddExhibit.Name = "OpenAddExhibit";
            this.OpenAddExhibit.Size = new System.Drawing.Size(153, 48);
            this.OpenAddExhibit.TabIndex = 4;
            this.OpenAddExhibit.Text = "Добавить экспонат";
            this.OpenAddExhibit.UseVisualStyleBackColor = true;
            this.OpenAddExhibit.Click += new System.EventHandler(this.OpenAddExhibit_Click);
            // 
            // GridExhibit
            // 
            this.GridExhibit.AllowUserToAddRows = false;
            this.GridExhibit.AutoGenerateColumns = false;
            this.GridExhibit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridExhibit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridExhibit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exhibitIdDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.yearCreatedDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.GridExhibit.DataSource = this.exhibitsBindingSource;
            this.GridExhibit.Location = new System.Drawing.Point(3, 3);
            this.GridExhibit.Name = "GridExhibit";
            this.GridExhibit.Size = new System.Drawing.Size(531, 391);
            this.GridExhibit.TabIndex = 0;
            // 
            // exhibitIdDataGridViewTextBoxColumn
            // 
            this.exhibitIdDataGridViewTextBoxColumn.DataPropertyName = "ExhibitId";
            this.exhibitIdDataGridViewTextBoxColumn.HeaderText = "ID экспоната";
            this.exhibitIdDataGridViewTextBoxColumn.Name = "exhibitIdDataGridViewTextBoxColumn";
            this.exhibitIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.exhibitIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Название";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 82;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Автор";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.Width = 62;
            // 
            // yearCreatedDataGridViewTextBoxColumn
            // 
            this.yearCreatedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.yearCreatedDataGridViewTextBoxColumn.DataPropertyName = "YearCreated";
            this.yearCreatedDataGridViewTextBoxColumn.HeaderText = "Год";
            this.yearCreatedDataGridViewTextBoxColumn.Name = "yearCreatedDataGridViewTextBoxColumn";
            this.yearCreatedDataGridViewTextBoxColumn.Width = 50;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 51;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // exhibitsBindingSource
            // 
            this.exhibitsBindingSource.DataMember = "Exhibits";
            this.exhibitsBindingSource.DataSource = this.museumDBDataSet;
            // 
            // exhibitionsTableAdapter
            // 
            this.exhibitionsTableAdapter.ClearBeforeFill = true;
            // 
            // exhibitsTableAdapter
            // 
            this.exhibitsTableAdapter.ClearBeforeFill = true;
            // 
            // Archivist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.TabInfo);
            this.Name = "Archivist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archivist";
            this.Load += new System.EventHandler(this.Archivist_Load);
            this.TabInfo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridExhibits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exhibitionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.museumDBDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridExhibit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exhibitsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabInfo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MuseumDBDataSet museumDBDataSet;
        private System.Windows.Forms.DataGridView GridExhibits;
        private System.Windows.Forms.BindingSource exhibitionsBindingSource;
        private MuseumDBDataSetTableAdapters.ExhibitionsTableAdapter exhibitionsTableAdapter;
        private System.Windows.Forms.DataGridView GridExhibit;
        private System.Windows.Forms.BindingSource exhibitsBindingSource;
        private MuseumDBDataSetTableAdapters.ExhibitsTableAdapter exhibitsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn exhibitIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button OpenAddExhibition;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn exhibitionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button OpenEditExibit;
        private System.Windows.Forms.Button OpenAddExhibit;
    }
}