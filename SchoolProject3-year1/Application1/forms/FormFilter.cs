using SchoolProject3_year1.Application1.dao;
using System;
using System.Data;
using System.Windows.Forms;

namespace SchoolProject3_year1.Application1.forms
{
    public partial class FormFilter : Form
    {
        private window mainWindow;
        //private PostgresSQL db;
        public FormFilter(window form, PostgresSQL db, string lastPostcode)
        {
            DataTable dt = new DataTable();

            InitializeComponent();
            mainWindow = form;
            dt.Load(db.QueryDataReader("SELECT DISTINCT voorzieningen FROM voorzieningen"));
            cBoxVoorziening.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxVoorziening.DataSource = dt;
            cBoxVoorziening.DisplayMember = "voorzieningen";
            cBoxVoorziening.ValueMember = "voorzieningen";

            if (lastPostcode != null)
            {
                txtPostcode.Text = lastPostcode;
            }
            
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string filter = "";

            if (chkBoxVoorzieningType.Checked)
            {
                filter += string.Format(" AND voorzieningen = '{0}'", cBoxVoorziening.Text);
            }
            if (chkBoxPostcode.Checked && !string.IsNullOrWhiteSpace(txtPostcode.Text))
            {
                filter += string.Format(" AND lastpostcode LIKE '%{0}%'", txtPostcode.Text);
                window.filteredPostcode = txtPostcode.Text;
            }
            else if (chkBoxPostcode.Checked && string.IsNullOrWhiteSpace(txtPostcode.Text))
            {
                MessageBox.Show(this, "Je hebt geen postcode ingevoerd!", "Lege veld!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            mainWindow.LoadDataGridResults(mainWindow.application1DataGridCurrentWijkID, mainWindow.application1DataGridCurrentWijkName, filter);           
            this.Close();
        }

        private void chkBoxNoFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxNoFilter.Checked)
            {
                chkBoxVoorzieningType.Checked = false;
                chkBoxVoorzieningType.Enabled = false;
                cBoxVoorziening.Text = string.Empty;
                cBoxVoorziening.Enabled = false;
                chkBoxPostcode.Enabled = false;
                txtPostcode.Enabled = false;
            }
            else
            {
                chkBoxVoorzieningType.Checked = true;
                chkBoxVoorzieningType.Enabled = true;
                cBoxVoorziening.Text = string.Empty;
                cBoxVoorziening.Enabled = true;
                chkBoxPostcode.Enabled = true;
                txtPostcode.Enabled = true;
            }
        }

        private void FormFilter_Load(object sender, EventArgs e)
        {

        }
    }
}
