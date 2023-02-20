namespace SchoolProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwSchool = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.tbxDistrict = new System.Windows.Forms.TextBox();
            this.tbxType = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxUType = new System.Windows.Forms.TextBox();
            this.lblUName = new System.Windows.Forms.Label();
            this.tbxUDistrict = new System.Windows.Forms.TextBox();
            this.lblUCity = new System.Windows.Forms.Label();
            this.tbxUCity = new System.Windows.Forms.TextBox();
            this.lblUDistrict = new System.Windows.Forms.Label();
            this.tbxUName = new System.Windows.Forms.TextBox();
            this.lblUType = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSchool)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwSchool
            // 
            this.dgwSchool.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwSchool.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSchool.Location = new System.Drawing.Point(12, 12);
            this.dgwSchool.Name = "dgwSchool";
            this.dgwSchool.RowTemplate.Height = 25;
            this.dgwSchool.Size = new System.Drawing.Size(783, 134);
            this.dgwSchool.TabIndex = 0;
            this.dgwSchool.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwSchool_CellClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(32, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Okul Adı";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(32, 66);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(13, 15);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "İl";
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Location = new System.Drawing.Point(32, 99);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(25, 15);
            this.lblDistrict.TabIndex = 3;
            this.lblDistrict.Text = "İlçe";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(32, 134);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(24, 15);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Tür";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(98, 27);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 23);
            this.tbxName.TabIndex = 5;
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(98, 58);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(100, 23);
            this.tbxCity.TabIndex = 6;
            // 
            // tbxDistrict
            // 
            this.tbxDistrict.Location = new System.Drawing.Point(98, 91);
            this.tbxDistrict.Name = "tbxDistrict";
            this.tbxDistrict.Size = new System.Drawing.Size(100, 23);
            this.tbxDistrict.TabIndex = 7;
            // 
            // tbxType
            // 
            this.tbxType.Location = new System.Drawing.Point(98, 126);
            this.tbxType.Name = "tbxType";
            this.tbxType.Size = new System.Drawing.Size(100, 23);
            this.tbxType.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.tbxType);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.tbxDistrict);
            this.groupBox1.Controls.Add(this.lblCity);
            this.groupBox1.Controls.Add(this.tbxCity);
            this.groupBox1.Controls.Add(this.lblDistrict);
            this.groupBox1.Controls.Add(this.tbxName);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Location = new System.Drawing.Point(12, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 194);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a school";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(98, 165);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.tbxUType);
            this.gbxUpdate.Controls.Add(this.lblUName);
            this.gbxUpdate.Controls.Add(this.tbxUDistrict);
            this.gbxUpdate.Controls.Add(this.lblUCity);
            this.gbxUpdate.Controls.Add(this.tbxUCity);
            this.gbxUpdate.Controls.Add(this.lblUDistrict);
            this.gbxUpdate.Controls.Add(this.tbxUName);
            this.gbxUpdate.Controls.Add(this.lblUType);
            this.gbxUpdate.Location = new System.Drawing.Point(335, 152);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(268, 194);
            this.gbxUpdate.TabIndex = 10;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update a school";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(98, 165);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxUType
            // 
            this.tbxUType.Location = new System.Drawing.Point(98, 126);
            this.tbxUType.Name = "tbxUType";
            this.tbxUType.Size = new System.Drawing.Size(100, 23);
            this.tbxUType.TabIndex = 8;
            // 
            // lblUName
            // 
            this.lblUName.AutoSize = true;
            this.lblUName.Location = new System.Drawing.Point(32, 35);
            this.lblUName.Name = "lblUName";
            this.lblUName.Size = new System.Drawing.Size(53, 15);
            this.lblUName.TabIndex = 1;
            this.lblUName.Text = "Okul Adı";
            // 
            // tbxUDistrict
            // 
            this.tbxUDistrict.Location = new System.Drawing.Point(98, 91);
            this.tbxUDistrict.Name = "tbxUDistrict";
            this.tbxUDistrict.Size = new System.Drawing.Size(100, 23);
            this.tbxUDistrict.TabIndex = 7;
            // 
            // lblUCity
            // 
            this.lblUCity.AutoSize = true;
            this.lblUCity.Location = new System.Drawing.Point(32, 66);
            this.lblUCity.Name = "lblUCity";
            this.lblUCity.Size = new System.Drawing.Size(13, 15);
            this.lblUCity.TabIndex = 2;
            this.lblUCity.Text = "İl";
            // 
            // tbxUCity
            // 
            this.tbxUCity.Location = new System.Drawing.Point(98, 58);
            this.tbxUCity.Name = "tbxUCity";
            this.tbxUCity.Size = new System.Drawing.Size(100, 23);
            this.tbxUCity.TabIndex = 6;
            // 
            // lblUDistrict
            // 
            this.lblUDistrict.AutoSize = true;
            this.lblUDistrict.Location = new System.Drawing.Point(32, 99);
            this.lblUDistrict.Name = "lblUDistrict";
            this.lblUDistrict.Size = new System.Drawing.Size(25, 15);
            this.lblUDistrict.TabIndex = 3;
            this.lblUDistrict.Text = "İlçe";
            // 
            // tbxUName
            // 
            this.tbxUName.Location = new System.Drawing.Point(98, 27);
            this.tbxUName.Name = "tbxUName";
            this.tbxUName.Size = new System.Drawing.Size(100, 23);
            this.tbxUName.TabIndex = 5;
            // 
            // lblUType
            // 
            this.lblUType.AutoSize = true;
            this.lblUType.Location = new System.Drawing.Point(32, 134);
            this.lblUType.Name = "lblUType";
            this.lblUType.Size = new System.Drawing.Size(24, 15);
            this.lblUType.TabIndex = 4;
            this.lblUType.Text = "Tür";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(662, 317);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwSchool);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSchool)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgwSchool;
        private Label lblName;
        private Label lblCity;
        private Label lblDistrict;
        private Label lblType;
        private TextBox tbxName;
        private TextBox tbxCity;
        private TextBox tbxDistrict;
        private TextBox tbxType;
        private GroupBox groupBox1;
        private Button btnAdd;
        private GroupBox gbxUpdate;
        private Button btnUpdate;
        private TextBox tbxUType;
        private Label lblUName;
        private TextBox tbxUDistrict;
        private Label lblUCity;
        private TextBox tbxUCity;
        private Label lblUDistrict;
        private TextBox tbxUName;
        private Label lblUType;
        private Button btnDelete;
    }
}