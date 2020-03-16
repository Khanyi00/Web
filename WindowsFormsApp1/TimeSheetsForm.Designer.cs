namespace WindowsFormsApp1
{
    partial class TimeSheetsForm
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
            this.btnHoursPerPerson = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimeslots = new System.Windows.Forms.Button();
            this.btnHoursPerProject = new System.Windows.Forms.Button();
            this._yearComboBox = new System.Windows.Forms.ComboBox();
            this._monthComboBox = new System.Windows.Forms.ComboBox();
            this._txtUserName = new System.Windows.Forms.TextBox();
            this.btnUsers = new System.Windows.Forms.Button();
            this._timeSheetsGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._timeSheetsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Date :";
            // 
            // btnHoursPerPerson
            // 
            this.btnHoursPerPerson.Location = new System.Drawing.Point(263, 10);
            this.btnHoursPerPerson.Name = "btnHoursPerPerson";
            this.btnHoursPerPerson.Size = new System.Drawing.Size(116, 23);
            this.btnHoursPerPerson.TabIndex = 5;
            this.btnHoursPerPerson.Text = "Hours Per Person";
            this.btnHoursPerPerson.UseVisualStyleBackColor = true;
            this.btnHoursPerPerson.Click += new System.EventHandler(this.btnHoursPerPerson_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnTimeslots);
            this.panel1.Controls.Add(this.btnHoursPerProject);
            this.panel1.Controls.Add(this._yearComboBox);
            this.panel1.Controls.Add(this._monthComboBox);
            this.panel1.Controls.Add(this._txtUserName);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHoursPerPerson);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 46);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(501, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Enter User Name:";
            // 
            // btnTimeslots
            // 
            this.btnTimeslots.Location = new System.Drawing.Point(783, 11);
            this.btnTimeslots.Name = "btnTimeslots";
            this.btnTimeslots.Size = new System.Drawing.Size(105, 23);
            this.btnTimeslots.TabIndex = 12;
            this.btnTimeslots.Text = "List Timeslots";
            this.btnTimeslots.UseVisualStyleBackColor = true;
            this.btnTimeslots.Click += new System.EventHandler(this.btnTimeslots_Click);
            // 
            // btnHoursPerProject
            // 
            this.btnHoursPerProject.Location = new System.Drawing.Point(385, 10);
            this.btnHoursPerProject.Name = "btnHoursPerProject";
            this.btnHoursPerProject.Size = new System.Drawing.Size(109, 23);
            this.btnHoursPerProject.TabIndex = 11;
            this.btnHoursPerProject.Text = "Hours Per Project";
            this.btnHoursPerProject.UseVisualStyleBackColor = true;
            this.btnHoursPerProject.Click += new System.EventHandler(this.btnHoursPerProject_Click);
            // 
            // _yearComboBox
            // 
            this._yearComboBox.DisplayMember = "Date";
            this._yearComboBox.FormattingEnabled = true;
            this._yearComboBox.Location = new System.Drawing.Point(174, 12);
            this._yearComboBox.Name = "_yearComboBox";
            this._yearComboBox.Size = new System.Drawing.Size(65, 21);
            this._yearComboBox.TabIndex = 10;
            this._yearComboBox.ValueMember = "Date";
            // 
            // _monthComboBox
            // 
            this._monthComboBox.FormattingEnabled = true;
            this._monthComboBox.Location = new System.Drawing.Point(73, 12);
            this._monthComboBox.Name = "_monthComboBox";
            this._monthComboBox.Size = new System.Drawing.Size(95, 21);
            this._monthComboBox.TabIndex = 8;
            // 
            // _txtUserName
            // 
            this._txtUserName.Location = new System.Drawing.Point(598, 12);
            this._txtUserName.Name = "_txtUserName";
            this._txtUserName.Size = new System.Drawing.Size(105, 20);
            this._txtUserName.TabIndex = 7;
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(709, 11);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(68, 23);
            this.btnUsers.TabIndex = 6;
            this.btnUsers.Text = "List Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // _timeSheetsGrid
            // 
            this._timeSheetsGrid.AllowUserToDeleteRows = false;
            this._timeSheetsGrid.AllowUserToOrderColumns = true;
            this._timeSheetsGrid.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this._timeSheetsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._timeSheetsGrid.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this._timeSheetsGrid.Location = new System.Drawing.Point(8, 43);
            this._timeSheetsGrid.Name = "_timeSheetsGrid";
            this._timeSheetsGrid.ReadOnly = true;
            this._timeSheetsGrid.Size = new System.Drawing.Size(882, 406);
            this._timeSheetsGrid.TabIndex = 4;
            // 
            // TimeSheetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 449);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._timeSheetsGrid);
            this.Name = "TimeSheetsForm";
            this.Text = "Time Sheet";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._timeSheetsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHoursPerPerson;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView _timeSheetsGrid;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.TextBox _txtUserName;
        private System.Windows.Forms.ComboBox _monthComboBox;
        private System.Windows.Forms.ComboBox _yearComboBox;
        private System.Windows.Forms.Button btnHoursPerProject;
        private System.Windows.Forms.Button btnTimeslots;
        private System.Windows.Forms.Label label2;
    }
}

