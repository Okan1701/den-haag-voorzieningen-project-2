namespace SchoolProject3_year1
{
    partial class window
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(window));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonApplication1 = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_app1 = new System.Windows.Forms.Panel();
            this.btnApp1Help = new System.Windows.Forms.Button();
            this.visualizationButton = new System.Windows.Forms.Button();
            this.btnApp1Filter = new System.Windows.Forms.Button();
            this.btnApp1Return = new System.Windows.Forms.Button();
            this.lbl_app1_dataView = new System.Windows.Forms.Label();
            this.dGrid_main = new System.Windows.Forms.DataGridView();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelDashBoard = new System.Windows.Forms.Panel();
            this.lblDashBoardFoot = new System.Windows.Forms.Label();
            this.lblDashBoard = new System.Windows.Forms.Label();
            this.picBoxDashBoard = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_app1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid_main)).BeginInit();
            this.panelDashBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDashBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonApplication1);
            this.panel1.Controls.Add(this.buttonDashboard);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 709);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonApplication1
            // 
            this.buttonApplication1.FlatAppearance.BorderSize = 0;
            this.buttonApplication1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApplication1.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.buttonApplication1.ForeColor = System.Drawing.Color.White;
            this.buttonApplication1.Location = new System.Drawing.Point(0, 204);
            this.buttonApplication1.Name = "buttonApplication1";
            this.buttonApplication1.Size = new System.Drawing.Size(159, 63);
            this.buttonApplication1.TabIndex = 2;
            this.buttonApplication1.Text = "Voorzieningen in Den Haag\r\n";
            this.buttonApplication1.UseVisualStyleBackColor = true;
            this.buttonApplication1.Click += new System.EventHandler(this.buttonApplication1_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.buttonDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonDashboard.Location = new System.Drawing.Point(0, 135);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(159, 63);
            this.buttonDashboard.TabIndex = 1;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(162, 100);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 49.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 95);
            this.label1.TabIndex = 0;
            this.label1.Text = "HR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_app1
            // 
            this.panel_app1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_app1.Controls.Add(this.btnApp1Help);
            this.panel_app1.Controls.Add(this.visualizationButton);
            this.panel_app1.Controls.Add(this.btnApp1Filter);
            this.panel_app1.Controls.Add(this.btnApp1Return);
            this.panel_app1.Controls.Add(this.lbl_app1_dataView);
            this.panel_app1.Controls.Add(this.dGrid_main);
            this.panel_app1.Location = new System.Drawing.Point(178, 0);
            this.panel_app1.Name = "panel_app1";
            this.panel_app1.Size = new System.Drawing.Size(899, 709);
            this.panel_app1.TabIndex = 1;
            this.panel_app1.Visible = false;
            this.panel_app1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_app1_Paint);
            // 
            // btnApp1Help
            // 
            this.btnApp1Help.FlatAppearance.BorderSize = 0;
            this.btnApp1Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApp1Help.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApp1Help.ForeColor = System.Drawing.Color.White;
            this.btnApp1Help.Location = new System.Drawing.Point(178, 9);
            this.btnApp1Help.Name = "btnApp1Help";
            this.btnApp1Help.Size = new System.Drawing.Size(32, 33);
            this.btnApp1Help.TabIndex = 6;
            this.btnApp1Help.Text = "?";
            this.btnApp1Help.UseVisualStyleBackColor = true;
            this.btnApp1Help.Click += new System.EventHandler(this.btnApp1Help_Click);
            // 
            // visualizationButton
            // 
            this.visualizationButton.FlatAppearance.BorderSize = 0;
            this.visualizationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visualizationButton.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.visualizationButton.ForeColor = System.Drawing.Color.White;
            this.visualizationButton.Location = new System.Drawing.Point(3, 9);
            this.visualizationButton.Name = "visualizationButton";
            this.visualizationButton.Size = new System.Drawing.Size(143, 33);
            this.visualizationButton.TabIndex = 5;
            this.visualizationButton.Text = "Visualisatie";
            this.visualizationButton.UseVisualStyleBackColor = true;
            this.visualizationButton.Visible = false;
            this.visualizationButton.Click += new System.EventHandler(this.visualizationButton_Click);
            // 
            // btnApp1Filter
            // 
            this.btnApp1Filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApp1Filter.FlatAppearance.BorderSize = 0;
            this.btnApp1Filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApp1Filter.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnApp1Filter.ForeColor = System.Drawing.Color.White;
            this.btnApp1Filter.Location = new System.Drawing.Point(668, 6);
            this.btnApp1Filter.Name = "btnApp1Filter";
            this.btnApp1Filter.Size = new System.Drawing.Size(216, 33);
            this.btnApp1Filter.TabIndex = 4;
            this.btnApp1Filter.Text = "Filter...";
            this.btnApp1Filter.UseVisualStyleBackColor = true;
            this.btnApp1Filter.Click += new System.EventHandler(this.btnApp1Filter_Click);
            // 
            // btnApp1Return
            // 
            this.btnApp1Return.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApp1Return.FlatAppearance.BorderSize = 0;
            this.btnApp1Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApp1Return.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnApp1Return.ForeColor = System.Drawing.Color.White;
            this.btnApp1Return.Location = new System.Drawing.Point(668, 45);
            this.btnApp1Return.Name = "btnApp1Return";
            this.btnApp1Return.Size = new System.Drawing.Size(216, 33);
            this.btnApp1Return.TabIndex = 3;
            this.btnApp1Return.Text = "Ga terug naar wijken";
            this.btnApp1Return.UseVisualStyleBackColor = true;
            this.btnApp1Return.Click += new System.EventHandler(this.btnApp1Return_Click);
            // 
            // lbl_app1_dataView
            // 
            this.lbl_app1_dataView.AutoSize = true;
            this.lbl_app1_dataView.ForeColor = System.Drawing.Color.White;
            this.lbl_app1_dataView.Location = new System.Drawing.Point(12, 58);
            this.lbl_app1_dataView.Name = "lbl_app1_dataView";
            this.lbl_app1_dataView.Size = new System.Drawing.Size(44, 23);
            this.lbl_app1_dataView.TabIndex = 2;
            this.lbl_app1_dataView.Text = "null";
            // 
            // dGrid_main
            // 
            this.dGrid_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGrid_main.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.dGrid_main.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGrid_main.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGrid_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrid_main.Location = new System.Drawing.Point(0, 84);
            this.dGrid_main.Name = "dGrid_main";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGrid_main.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGrid_main.RowTemplate.Height = 24;
            this.dGrid_main.Size = new System.Drawing.Size(887, 613);
            this.dGrid_main.TabIndex = 1;
            this.dGrid_main.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGrid_main_CellClick);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelLeft.Location = new System.Drawing.Point(162, 135);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(10, 63);
            this.panelLeft.TabIndex = 2;
            // 
            // panelDashBoard
            // 
            this.panelDashBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDashBoard.AutoSize = true;
            this.panelDashBoard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelDashBoard.Controls.Add(this.lblDashBoardFoot);
            this.panelDashBoard.Controls.Add(this.lblDashBoard);
            this.panelDashBoard.Controls.Add(this.picBoxDashBoard);
            this.panelDashBoard.Location = new System.Drawing.Point(178, 6);
            this.panelDashBoard.Name = "panelDashBoard";
            this.panelDashBoard.Size = new System.Drawing.Size(887, 663);
            this.panelDashBoard.TabIndex = 6;
            // 
            // lblDashBoardFoot
            // 
            this.lblDashBoardFoot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDashBoardFoot.AutoSize = true;
            this.lblDashBoardFoot.Location = new System.Drawing.Point(357, 413);
            this.lblDashBoardFoot.Name = "lblDashBoardFoot";
            this.lblDashBoardFoot.Size = new System.Drawing.Size(159, 23);
            this.lblDashBoardFoot.TabIndex = 2;
            this.lblDashBoardFoot.Text = "INFPRJ3 - INF1H";
            // 
            // lblDashBoard
            // 
            this.lblDashBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDashBoard.AutoSize = true;
            this.lblDashBoard.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashBoard.ForeColor = System.Drawing.Color.White;
            this.lblDashBoard.Location = new System.Drawing.Point(256, 317);
            this.lblDashBoard.Name = "lblDashBoard";
            this.lblDashBoard.Size = new System.Drawing.Size(378, 96);
            this.lblDashBoard.TabIndex = 1;
            this.lblDashBoard.Text = "Welkom!";
            // 
            // picBoxDashBoard
            // 
            this.picBoxDashBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxDashBoard.Image = global::SchoolProject3_year1.Properties.Resources.HR;
            this.picBoxDashBoard.Location = new System.Drawing.Point(165, -8);
            this.picBoxDashBoard.Name = "picBoxDashBoard";
            this.picBoxDashBoard.Size = new System.Drawing.Size(590, 305);
            this.picBoxDashBoard.TabIndex = 0;
            this.picBoxDashBoard.TabStop = false;
            // 
            // window
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1077, 709);
            this.Controls.Add(this.panelDashBoard);
            this.Controls.Add(this.panel_app1);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "window";
            this.Text = "INFPRJ03 - Groep 2";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_app1.ResumeLayout(false);
            this.panel_app1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid_main)).EndInit();
            this.panelDashBoard.ResumeLayout(false);
            this.panelDashBoard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDashBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_app1;
        private System.Windows.Forms.Button buttonApplication1;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.DataGridView dGrid_main;
        private System.Windows.Forms.Label lbl_app1_dataView;
        private System.Windows.Forms.Button btnApp1Return;
        private System.Windows.Forms.Button btnApp1Filter;
        private System.Windows.Forms.Button visualizationButton;
        private System.Windows.Forms.Panel panelDashBoard;
        private System.Windows.Forms.PictureBox picBoxDashBoard;
        private System.Windows.Forms.Label lblDashBoard;
        private System.Windows.Forms.Label lblDashBoardFoot;
        private System.Windows.Forms.Button btnApp1Help;
    }
}

