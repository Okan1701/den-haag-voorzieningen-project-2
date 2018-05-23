namespace SchoolProject3_year1.Application1.forms
{
    partial class FormFilterWijk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFilterWijk));
            this.chkStadsdeel = new System.Windows.Forms.CheckBox();
            this.cBoxStadsdeel = new System.Windows.Forms.ComboBox();
            this.chkScore = new System.Windows.Forms.CheckBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.chkName = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.chkNoFilter = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkStadsdeel
            // 
            this.chkStadsdeel.AutoSize = true;
            this.chkStadsdeel.Location = new System.Drawing.Point(13, 13);
            this.chkStadsdeel.Name = "chkStadsdeel";
            this.chkStadsdeel.Size = new System.Drawing.Size(146, 21);
            this.chkStadsdeel.TabIndex = 0;
            this.chkStadsdeel.Text = "Filter op stadsdeel";
            this.chkStadsdeel.UseVisualStyleBackColor = true;
            // 
            // cBoxStadsdeel
            // 
            this.cBoxStadsdeel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxStadsdeel.FormattingEnabled = true;
            this.cBoxStadsdeel.Location = new System.Drawing.Point(38, 40);
            this.cBoxStadsdeel.Name = "cBoxStadsdeel";
            this.cBoxStadsdeel.Size = new System.Drawing.Size(322, 24);
            this.cBoxStadsdeel.TabIndex = 1;
            // 
            // chkScore
            // 
            this.chkScore.AutoSize = true;
            this.chkScore.Location = new System.Drawing.Point(13, 78);
            this.chkScore.Name = "chkScore";
            this.chkScore.Size = new System.Drawing.Size(287, 21);
            this.chkScore.TabIndex = 2;
            this.chkScore.Text = "Weergeef wijken met een minimum score";
            this.chkScore.UseVisualStyleBackColor = true;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(38, 106);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(322, 22);
            this.txtScore.TabIndex = 3;
            this.txtScore.TextChanged += new System.EventHandler(this.txtScore_TextChanged);
            // 
            // chkName
            // 
            this.chkName.AutoSize = true;
            this.chkName.Location = new System.Drawing.Point(13, 143);
            this.chkName.Name = "chkName";
            this.chkName.Size = new System.Drawing.Size(142, 21);
            this.chkName.TabIndex = 4;
            this.chkName.Text = "Filter op wijknaam";
            this.chkName.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(38, 171);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(322, 22);
            this.txtName.TabIndex = 5;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(121, 269);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(148, 52);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "Toepassen";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // chkNoFilter
            // 
            this.chkNoFilter.AutoSize = true;
            this.chkNoFilter.Location = new System.Drawing.Point(13, 223);
            this.chkNoFilter.Name = "chkNoFilter";
            this.chkNoFilter.Size = new System.Drawing.Size(173, 21);
            this.chkNoFilter.TabIndex = 7;
            this.chkNoFilter.Text = "Geen filters toepassen";
            this.chkNoFilter.UseVisualStyleBackColor = true;
            this.chkNoFilter.CheckedChanged += new System.EventHandler(this.chkNoFilter_CheckedChanged);
            // 
            // FormFilterWijk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 333);
            this.Controls.Add(this.chkNoFilter);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.chkName);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.chkScore);
            this.Controls.Add(this.cBoxStadsdeel);
            this.Controls.Add(this.chkStadsdeel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormFilterWijk";
            this.Text = "Filter wijken";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkStadsdeel;
        private System.Windows.Forms.ComboBox cBoxStadsdeel;
        private System.Windows.Forms.CheckBox chkScore;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.CheckBox chkName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.CheckBox chkNoFilter;
    }
}