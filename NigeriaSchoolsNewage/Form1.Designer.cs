namespace NigeriaSchoolsNewage
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtWebsite = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txtgeo_zone_ID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtStateID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtLgaID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtYearEstablished = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtSchool_Ownership = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtSchool_Type_ID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtSchool_Subtype_ID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.dgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgWebsite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dggeo_zone_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgstate_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dglga_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgyear_established = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgschool_ownership_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgschool_type_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgschool_subtype_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nigeria School Newage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name :";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(271, 91);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(209, 27);
            this.TxtName.TabIndex = 2;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // TxtAddress
            // 
            this.TxtAddress.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddress.Location = new System.Drawing.Point(271, 137);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(209, 27);
            this.TxtAddress.TabIndex = 4;
            this.TxtAddress.TextChanged += new System.EventHandler(this.TxtAddress_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(197, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TxtPhone
            // 
            this.TxtPhone.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPhone.Location = new System.Drawing.Point(271, 182);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(209, 27);
            this.TxtPhone.TabIndex = 6;
            this.TxtPhone.TextChanged += new System.EventHandler(this.TxtPhone_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(197, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(271, 226);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(209, 27);
            this.TxtEmail.TabIndex = 8;
            this.TxtEmail.TextChanged += new System.EventHandler(this.TxtEmail_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(197, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // TxtWebsite
            // 
            this.TxtWebsite.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtWebsite.Location = new System.Drawing.Point(637, 94);
            this.TxtWebsite.Name = "TxtWebsite";
            this.TxtWebsite.Size = new System.Drawing.Size(184, 27);
            this.TxtWebsite.TabIndex = 10;
            this.TxtWebsite.TextChanged += new System.EventHandler(this.TxtWebsite_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(514, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Website :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Txtgeo_zone_ID
            // 
            this.Txtgeo_zone_ID.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtgeo_zone_ID.Location = new System.Drawing.Point(637, 140);
            this.Txtgeo_zone_ID.Name = "Txtgeo_zone_ID";
            this.Txtgeo_zone_ID.Size = new System.Drawing.Size(92, 27);
            this.Txtgeo_zone_ID.TabIndex = 12;
            this.Txtgeo_zone_ID.Text = "4";
            this.Txtgeo_zone_ID.TextChanged += new System.EventHandler(this.Txtgeo_zone_ID_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(510, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "GeoZoneID :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // TxtStateID
            // 
            this.TxtStateID.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStateID.Location = new System.Drawing.Point(637, 193);
            this.TxtStateID.Name = "TxtStateID";
            this.TxtStateID.Size = new System.Drawing.Size(92, 27);
            this.TxtStateID.TabIndex = 14;
            this.TxtStateID.TextChanged += new System.EventHandler(this.TxtStateID_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(510, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "StateID :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // TxtLgaID
            // 
            this.TxtLgaID.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLgaID.Location = new System.Drawing.Point(637, 243);
            this.TxtLgaID.Name = "TxtLgaID";
            this.TxtLgaID.Size = new System.Drawing.Size(92, 27);
            this.TxtLgaID.TabIndex = 16;
            this.TxtLgaID.TextChanged += new System.EventHandler(this.TxtLgaID_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(510, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "LgaID :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // TxtYearEstablished
            // 
            this.TxtYearEstablished.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtYearEstablished.Location = new System.Drawing.Point(1059, 97);
            this.TxtYearEstablished.Name = "TxtYearEstablished";
            this.TxtYearEstablished.Size = new System.Drawing.Size(83, 27);
            this.TxtYearEstablished.TabIndex = 18;
            this.TxtYearEstablished.TextChanged += new System.EventHandler(this.TxtYearEstablished_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(882, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 19);
            this.label10.TabIndex = 17;
            this.label10.Text = "Year_Established :";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // TxtSchool_Ownership
            // 
            this.TxtSchool_Ownership.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSchool_Ownership.Location = new System.Drawing.Point(1059, 154);
            this.TxtSchool_Ownership.Name = "TxtSchool_Ownership";
            this.TxtSchool_Ownership.Size = new System.Drawing.Size(83, 27);
            this.TxtSchool_Ownership.TabIndex = 20;
            this.TxtSchool_Ownership.TextChanged += new System.EventHandler(this.TxtSchool_Ownership_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(882, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 19);
            this.label11.TabIndex = 19;
            this.label11.Text = "School_Ownership :";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // TxtSchool_Type_ID
            // 
            this.TxtSchool_Type_ID.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSchool_Type_ID.Location = new System.Drawing.Point(1059, 202);
            this.TxtSchool_Type_ID.Name = "TxtSchool_Type_ID";
            this.TxtSchool_Type_ID.Size = new System.Drawing.Size(83, 27);
            this.TxtSchool_Type_ID.TabIndex = 22;
            this.TxtSchool_Type_ID.TextChanged += new System.EventHandler(this.TxtSchool_Type_ID_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(885, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 19);
            this.label12.TabIndex = 21;
            this.label12.Text = "School_Type_ID :";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // TxtSchool_Subtype_ID
            // 
            this.TxtSchool_Subtype_ID.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSchool_Subtype_ID.Location = new System.Drawing.Point(1059, 267);
            this.TxtSchool_Subtype_ID.Name = "TxtSchool_Subtype_ID";
            this.TxtSchool_Subtype_ID.Size = new System.Drawing.Size(83, 27);
            this.TxtSchool_Subtype_ID.TabIndex = 24;
            this.TxtSchool_Subtype_ID.TextChanged += new System.EventHandler(this.TxtSchool_Subtype_ID_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(898, 268);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 19);
            this.label13.TabIndex = 23;
            this.label13.Text = "School_Subtype_ID :";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(276, 341);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(167, 41);
            this.BtnSave.TabIndex = 25;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSaVE_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgID,
            this.dgName,
            this.dgAddress,
            this.dgPhone,
            this.dgEmail,
            this.dgWebsite,
            this.dggeo_zone_ID,
            this.dgstate_ID,
            this.dglga_ID,
            this.dgyear_established,
            this.dgschool_ownership_ID,
            this.dgschool_type_ID,
            this.dgschool_subtype_ID});
            this.dataGridView.Location = new System.Drawing.Point(12, 411);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(1297, 262);
            this.dataGridView.TabIndex = 26;
            this.dataGridView.DoubleClick += new System.EventHandler(this.dataGridView_DoubleClick);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(489, 341);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(167, 41);
            this.BtnDelete.TabIndex = 27;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(692, 341);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(167, 41);
            this.BtnCancel.TabIndex = 28;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(900, 341);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(167, 41);
            this.BtnExit.TabIndex = 29;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // dgID
            // 
            this.dgID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgID.DataPropertyName = "ID";
            this.dgID.HeaderText = "ID";
            this.dgID.Name = "dgID";
            this.dgID.ReadOnly = true;
            this.dgID.Visible = false;
            this.dgID.Width = 43;
            // 
            // dgName
            // 
            this.dgName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgName.DataPropertyName = "Name";
            this.dgName.HeaderText = "Name";
            this.dgName.Name = "dgName";
            this.dgName.ReadOnly = true;
            // 
            // dgAddress
            // 
            this.dgAddress.DataPropertyName = "Address";
            this.dgAddress.HeaderText = "Address";
            this.dgAddress.Name = "dgAddress";
            this.dgAddress.ReadOnly = true;
            // 
            // dgPhone
            // 
            this.dgPhone.DataPropertyName = "Phone";
            this.dgPhone.HeaderText = "Phone";
            this.dgPhone.Name = "dgPhone";
            this.dgPhone.ReadOnly = true;
            // 
            // dgEmail
            // 
            this.dgEmail.DataPropertyName = "Email";
            this.dgEmail.HeaderText = "Email";
            this.dgEmail.Name = "dgEmail";
            this.dgEmail.ReadOnly = true;
            // 
            // dgWebsite
            // 
            this.dgWebsite.DataPropertyName = "Website";
            this.dgWebsite.HeaderText = "Website";
            this.dgWebsite.Name = "dgWebsite";
            this.dgWebsite.ReadOnly = true;
            // 
            // dggeo_zone_ID
            // 
            this.dggeo_zone_ID.DataPropertyName = "geo_zone_ID";
            this.dggeo_zone_ID.HeaderText = "geo_zone_ID";
            this.dggeo_zone_ID.Name = "dggeo_zone_ID";
            this.dggeo_zone_ID.ReadOnly = true;
            // 
            // dgstate_ID
            // 
            this.dgstate_ID.DataPropertyName = "state_ID";
            this.dgstate_ID.HeaderText = "state_ID";
            this.dgstate_ID.Name = "dgstate_ID";
            this.dgstate_ID.ReadOnly = true;
            // 
            // dglga_ID
            // 
            this.dglga_ID.DataPropertyName = "lga_ID";
            this.dglga_ID.HeaderText = "lga_ID";
            this.dglga_ID.Name = "dglga_ID";
            this.dglga_ID.ReadOnly = true;
            // 
            // dgyear_established
            // 
            this.dgyear_established.DataPropertyName = "year_established";
            this.dgyear_established.HeaderText = "year_established";
            this.dgyear_established.Name = "dgyear_established";
            this.dgyear_established.ReadOnly = true;
            // 
            // dgschool_ownership_ID
            // 
            this.dgschool_ownership_ID.DataPropertyName = "school_ownership_ID";
            this.dgschool_ownership_ID.HeaderText = "school_ownership_ID";
            this.dgschool_ownership_ID.Name = "dgschool_ownership_ID";
            this.dgschool_ownership_ID.ReadOnly = true;
            // 
            // dgschool_type_ID
            // 
            this.dgschool_type_ID.DataPropertyName = "school_type_ID";
            this.dgschool_type_ID.HeaderText = "school_type_ID";
            this.dgschool_type_ID.Name = "dgschool_type_ID";
            this.dgschool_type_ID.ReadOnly = true;
            // 
            // dgschool_subtype_ID
            // 
            this.dgschool_subtype_ID.DataPropertyName = "school_subtype_ID";
            this.dgschool_subtype_ID.HeaderText = "school_subtype_ID";
            this.dgschool_subtype_ID.Name = "dgschool_subtype_ID";
            this.dgschool_subtype_ID.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 676);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtSchool_Subtype_ID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxtSchool_Type_ID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtSchool_Ownership);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtYearEstablished);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtLgaID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtStateID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Txtgeo_zone_ID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtWebsite);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Newage Nigeria Schools";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtWebsite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txtgeo_zone_ID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtStateID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtLgaID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtYearEstablished;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtSchool_Ownership;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtSchool_Type_ID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtSchool_Subtype_ID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgWebsite;
        private System.Windows.Forms.DataGridViewTextBoxColumn dggeo_zone_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgstate_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dglga_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgyear_established;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgschool_ownership_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgschool_type_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgschool_subtype_ID;
    }
}

