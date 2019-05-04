namespace phone
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.friendshipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonebookDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.phonebookDataSet1 = new phone.phonebookDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlInsertCommand = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand = new System.Data.SqlClient.SqlCommand();
            this.phonebookDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.phonenumber = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.search1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.phoneDataSet = new phone.phoneDataSet();
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peopleTableAdapter = new phone.phoneDataSetTableAdapters.peopleTableAdapter();
            this.phoneDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phone2DataSet1 = new phone.phone2DataSet();
            this.phone2DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.phoneDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.phoneDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.phonebookDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phonebookDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.phonebookDataSet = new phone.phonebookDataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookDataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone2DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(540, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "群組";
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=.\\SQLExpress;Initial Catalog=phone;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.friendshipDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "people";
            this.dataGridView1.DataSource = this.phonebookDataSet1BindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(57, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(423, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // friendshipDataGridViewTextBoxColumn
            // 
            this.friendshipDataGridViewTextBoxColumn.DataPropertyName = "friendship";
            this.friendshipDataGridViewTextBoxColumn.HeaderText = "friendship";
            this.friendshipDataGridViewTextBoxColumn.Name = "friendshipDataGridViewTextBoxColumn";
            // 
            // phonebookDataSet1BindingSource1
            // 
            this.phonebookDataSet1BindingSource1.DataSource = this.phonebookDataSet1;
            this.phonebookDataSet1BindingSource1.Position = 0;
            // 
            // phonebookDataSet1
            // 
            this.phonebookDataSet1.DataSetName = "phonebookDataSet";
            this.phonebookDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Location = new System.Drawing.Point(302, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "查看";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT          ID, name, number, friendship\r\nFROM              people";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "name", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_number", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "number", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_number", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "number", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_friendship", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "friendship", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_friendship", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "friendship", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "people", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("name", "name"),
                        new System.Data.Common.DataColumnMapping("number", "number"),
                        new System.Data.Common.DataColumnMapping("friendship", "friendship")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand;
            // 
            // sqlInsertCommand
            // 
            this.sqlInsertCommand.CommandText = "INSERT INTO [people] ([ID], [name], [number], [friendship]) VALUES (@ID, @name, @" +
    "number, @friendship);\r\nSELECT ID, name, number, friendship FROM people WHERE (ID" +
    " = @ID)";
            this.sqlInsertCommand.Connection = this.sqlConnection1;
            this.sqlInsertCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.NChar, 0, "ID"),
            new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.VarChar, 0, "name"),
            new System.Data.SqlClient.SqlParameter("@number", System.Data.SqlDbType.NChar, 0, "number"),
            new System.Data.SqlClient.SqlParameter("@friendship", System.Data.SqlDbType.VarChar, 0, "friendship")});
            // 
            // sqlUpdateCommand
            // 
            this.sqlUpdateCommand.CommandText = resources.GetString("sqlUpdateCommand.CommandText");
            this.sqlUpdateCommand.Connection = this.sqlConnection1;
            this.sqlUpdateCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.NChar, 0, "ID"),
            new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.VarChar, 0, "name"),
            new System.Data.SqlClient.SqlParameter("@number", System.Data.SqlDbType.NChar, 0, "number"),
            new System.Data.SqlClient.SqlParameter("@friendship", System.Data.SqlDbType.VarChar, 0, "friendship"),
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_name", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "name", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_name", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "name", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_number", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "number", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_number", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "number", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_friendship", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "friendship", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_friendship", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "friendship", System.Data.DataRowVersion.Original, null)});
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(135, 33);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(112, 22);
            this.name.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label2.Location = new System.Drawing.Point(59, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label3.Location = new System.Drawing.Point(59, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phonenumber:";
            // 
            // phonenumber
            // 
            this.phonenumber.Location = new System.Drawing.Point(135, 71);
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.Size = new System.Drawing.Size(112, 22);
            this.phonenumber.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button2.Location = new System.Drawing.Point(302, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "新增";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.LightSkyBlue;
            this.save.Location = new System.Drawing.Point(405, 14);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 9;
            this.save.Text = "儲存";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(405, 54);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 10;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(135, 5);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(112, 22);
            this.number.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label4.Location = new System.Drawing.Point(61, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "編號";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.Location = new System.Drawing.Point(302, 96);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 13;
            this.delete.Text = "刪除";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click_1);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(57, 111);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 14;
            this.search.Text = "查詢";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // search1
            // 
            this.search1.Location = new System.Drawing.Point(135, 113);
            this.search1.Name = "search1";
            this.search1.Size = new System.Drawing.Size(112, 22);
            this.search1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(133, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "___";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "查詢內容";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.Location = new System.Drawing.Point(540, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "儲存成XML";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(540, 178);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.Location = new System.Drawing.Point(540, 140);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "讀取XML";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // phoneDataSet
            // 
            this.phoneDataSet.DataSetName = "phoneDataSet";
            this.phoneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peopleBindingSource
            // 
            this.peopleBindingSource.DataMember = "people";
            this.peopleBindingSource.DataSource = this.phoneDataSet;
            // 
            // peopleTableAdapter
            // 
            this.peopleTableAdapter.ClearBeforeFill = true;
            // 
            // phoneDataSetBindingSource
            // 
            this.phoneDataSetBindingSource.DataSource = this.phoneDataSet;
            this.phoneDataSetBindingSource.Position = 0;
            // 
            // phone2DataSet1
            // 
            this.phone2DataSet1.DataSetName = "phone2DataSet";
            this.phone2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phone2DataSet1BindingSource
            // 
            this.phone2DataSet1BindingSource.DataSource = this.phone2DataSet1;
            this.phone2DataSet1BindingSource.Position = 0;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(60, 353);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(429, 68);
            this.listBox1.TabIndex = 21;
            // 
            // phoneDataSetBindingSource1
            // 
            this.phoneDataSetBindingSource1.DataSource = this.phoneDataSet;
            this.phoneDataSetBindingSource1.Position = 0;
            // 
            // phoneDataSetBindingSource2
            // 
            this.phoneDataSetBindingSource2.DataSource = this.phoneDataSet;
            this.phoneDataSetBindingSource2.Position = 0;
            // 
            // phonebookDataSet1BindingSource
            // 
            this.phonebookDataSet1BindingSource.DataSource = this.phonebookDataSet1;
            this.phonebookDataSet1BindingSource.Position = 0;
            // 
            // phonebookDataSetBindingSource1
            // 
            this.phonebookDataSetBindingSource1.DataSource = this.phonebookDataSet;
            this.phonebookDataSetBindingSource1.Position = 0;
            // 
            // phonebookDataSet
            // 
            this.phonebookDataSet.DataSetName = "phonebookDataSet";
            this.phonebookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(279, 144);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "friendship";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.search1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.search);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.number);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.phonenumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookDataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phone2DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneDataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonebookDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Windows.Forms.BindingSource phonebookDataSetBindingSource;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phonenumber;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox search1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private phoneDataSet phoneDataSet;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private phoneDataSetTableAdapters.peopleTableAdapter peopleTableAdapter;
        private System.Windows.Forms.BindingSource phoneDataSetBindingSource;
        private System.Windows.Forms.BindingSource phone2DataSet1BindingSource;
        private phone2DataSet phone2DataSet1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand;
        private phonebookDataSet phonebookDataSet1;
        private System.Windows.Forms.BindingSource phonebookDataSet1BindingSource;
        private System.Windows.Forms.BindingSource phonebookDataSetBindingSource1;
        private phonebookDataSet phonebookDataSet;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource phonebookDataSet1BindingSource1;
        private System.Windows.Forms.BindingSource phoneDataSetBindingSource1;
        private System.Windows.Forms.BindingSource phoneDataSetBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn friendshipDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
    }
}

