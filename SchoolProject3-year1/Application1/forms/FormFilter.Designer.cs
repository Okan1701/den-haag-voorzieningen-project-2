namespace SchoolProject3_year1.Application1.forms
{
    partial class FormFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFilter));
            this.cBoxVoorziening = new System.Windows.Forms.ComboBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.chkBoxVoorzieningType = new System.Windows.Forms.CheckBox();
            this.chkBoxNoFilter = new System.Windows.Forms.CheckBox();
            this.chkBoxPostcode = new System.Windows.Forms.CheckBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cBoxVoorziening
            // 
            this.cBoxVoorziening.FormattingEnabled = true;
            this.cBoxVoorziening.Location = new System.Drawing.Point(34, 39);
            this.cBoxVoorziening.MaxDropDownItems = 15;
            this.cBoxVoorziening.Name = "cBoxVoorziening";
            this.cBoxVoorziening.Size = new System.Drawing.Size(321, 24);
            this.cBoxVoorziening.TabIndex = 1;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(120, 313);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(140, 46);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Toepassen";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // chkBoxVoorzieningType
            // 
            this.chkBoxVoorzieningType.AutoSize = true;
            this.chkBoxVoorzieningType.Location = new System.Drawing.Point(13, 13);
            this.chkBoxVoorzieningType.Name = "chkBoxVoorzieningType";
            this.chkBoxVoorzieningType.Size = new System.Drawing.Size(256, 21);
            this.chkBoxVoorzieningType.TabIndex = 3;
            this.chkBoxVoorzieningType.Text = "Filter op specifieke voorziening type";
            this.chkBoxVoorzieningType.UseVisualStyleBackColor = true;
            // 
            // chkBoxNoFilter
            // 
            this.chkBoxNoFilter.AutoSize = true;
            this.chkBoxNoFilter.Location = new System.Drawing.Point(13, 273);
            this.chkBoxNoFilter.Name = "chkBoxNoFilter";
            this.chkBoxNoFilter.Size = new System.Drawing.Size(173, 21);
            this.chkBoxNoFilter.TabIndex = 4;
            this.chkBoxNoFilter.Text = "Geen filters toepassen";
            this.chkBoxNoFilter.UseVisualStyleBackColor = true;
            this.chkBoxNoFilter.CheckedChanged += new System.EventHandler(this.chkBoxNoFilter_CheckedChanged);
            // 
            // chkBoxPostcode
            // 
            this.chkBoxPostcode.AutoSize = true;
            this.chkBoxPostcode.Location = new System.Drawing.Point(13, 85);
            this.chkBoxPostcode.Name = "chkBoxPostcode";
            this.chkBoxPostcode.Size = new System.Drawing.Size(143, 21);
            this.chkBoxPostcode.TabIndex = 5;
            this.chkBoxPostcode.Text = "Filter op postcode";
            this.chkBoxPostcode.UseVisualStyleBackColor = true;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostcode.Location = new System.Drawing.Point(34, 112);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(321, 24);
            this.txtPostcode.TabIndex = 6;
            // 
            // FormFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 371);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.chkBoxPostcode);
            this.Controls.Add(this.chkBoxNoFilter);
            this.Controls.Add(this.chkBoxVoorzieningType);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.cBoxVoorziening);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormFilter";
            this.Text = "Voorzieningen Filter";
            this.Load += new System.EventHandler(this.FormFilter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cBoxVoorziening;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.CheckBox chkBoxVoorzieningType;
        private System.Windows.Forms.CheckBox chkBoxNoFilter;
        private System.Windows.Forms.CheckBox chkBoxPostcode;
        private System.Windows.Forms.TextBox txtPostcode;
    }
}