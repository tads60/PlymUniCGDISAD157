namespace ISAD
{
    partial class Interface
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
            this.lstFriends = new System.Windows.Forms.ListBox();
            this.lstSchools = new System.Windows.Forms.ListBox();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.txtSearchInput = new System.Windows.Forms.TextBox();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.lstWorkplaces = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lstFriends
            // 
            this.lstFriends.FormattingEnabled = true;
            this.lstFriends.Location = new System.Drawing.Point(407, 80);
            this.lstFriends.Name = "lstFriends";
            this.lstFriends.Size = new System.Drawing.Size(136, 316);
            this.lstFriends.TabIndex = 0;
            this.lstFriends.SelectedIndexChanged += new System.EventHandler(this.lstFriends_SelectedIndexChanged);
            // 
            // lstSchools
            // 
            this.lstSchools.FormattingEnabled = true;
            this.lstSchools.Location = new System.Drawing.Point(563, 275);
            this.lstSchools.Name = "lstSchools";
            this.lstSchools.Size = new System.Drawing.Size(211, 121);
            this.lstSchools.TabIndex = 0;
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.AllowUserToAddRows = false;
            this.dataGridUsers.AllowUserToDeleteRows = false;
            this.dataGridUsers.Location = new System.Drawing.Point(12, 22);
            this.dataGridUsers.MultiSelect = false;
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.ReadOnly = true;
            this.dataGridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridUsers.Size = new System.Drawing.Size(381, 380);
            this.dataGridUsers.TabIndex = 16;
            this.dataGridUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsers_CellContentClick);
            this.dataGridUsers.SelectionChanged += new System.EventHandler(this.DataGridUsers_SelectionChanged);
            // 
            // txtSearchInput
            // 
            this.txtSearchInput.Location = new System.Drawing.Point(505, 23);
            this.txtSearchInput.Name = "txtSearchInput";
            this.txtSearchInput.Size = new System.Drawing.Size(136, 20);
            this.txtSearchInput.TabIndex = 17;
            // 
            // comboType
            // 
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.FormattingEnabled = true;
            this.comboType.Items.AddRange(new object[] {
            "UserId",
            "First Name",
            "Last Name",
            "Home Town",
            "Current Town"});
            this.comboType.Location = new System.Drawing.Point(407, 22);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(92, 21);
            this.comboType.TabIndex = 18;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(715, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(58, 41);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // comboGender
            // 
            this.comboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "Any",
            "Male",
            "Female",
            "Other"});
            this.comboGender.Location = new System.Drawing.Point(647, 25);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(62, 21);
            this.comboGender.TabIndex = 20;
            // 
            // lstWorkplaces
            // 
            this.lstWorkplaces.FormattingEnabled = true;
            this.lstWorkplaces.Location = new System.Drawing.Point(562, 102);
            this.lstWorkplaces.Name = "lstWorkplaces";
            this.lstWorkplaces.Size = new System.Drawing.Size(211, 147);
            this.lstWorkplaces.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(662, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Friends";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(560, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Workplace";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(560, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "University";
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 414);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstFriends);
            this.Controls.Add(this.lstSchools);
            this.Controls.Add(this.lstWorkplaces);
            this.Controls.Add(this.comboGender);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.txtSearchInput);
            this.Controls.Add(this.dataGridUsers);
            this.Name = "Interface";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstFriends;
        private System.Windows.Forms.ListBox lstSchools;
        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.TextBox txtSearchInput;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.ListBox lstWorkplaces;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

