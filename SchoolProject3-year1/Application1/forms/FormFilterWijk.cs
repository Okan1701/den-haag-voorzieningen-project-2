using SchoolProject3_year1.Application1.dao;
using System;
using System.Data;
using System.Windows.Forms;

namespace SchoolProject3_year1.Application1.forms
{
    public partial class FormFilterWijk : Form
    {
        private PostgresSQL db;
        private window mainForm;
        public FormFilterWijk(window form, PostgresSQL conn)
        {

            db = conn;
            mainForm = form;
            InitializeComponent();
            DataTable dt = new DataTable();
            dt.Load(db.QueryDataReader("SELECT DISTINCT stadsdeel FROM wijken"));
            cBoxStadsdeel.DataSource = dt;
            cBoxStadsdeel.DisplayMember = "stadsdeel"; cBoxStadsdeel.ValueMember = "stadsdeel";
            
        }

        private void chkNoFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNoFilter.Checked)
            {
                chkStadsdeel.Checked = false;
                chkStadsdeel.Enabled = false;
                cBoxStadsdeel.Enabled = false;

                chkScore.Checked = false;
                chkScore.Enabled = false;
                txtScore.Text = "";
                txtScore.Enabled = false;

                chkName.Checked = false;
                chkName.Enabled = false;
                txtName.Text = "";
                txtName.Enabled = false;
            }
            else
            {
                chkStadsdeel.Enabled = true;
                cBoxStadsdeel.Enabled = true;

                chkScore.Enabled = true;
                txtScore.Enabled = true;

                chkName.Enabled = true;
                txtName.Enabled = true;

            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {

            if (!chkNoFilter.Checked)
            {
                string filter = "";
                bool noInitial = true;

                if (chkStadsdeel.Checked)
                {
                    string initial = "";
                    if (!noInitial) { initial = " AND"; }
                    filter += string.Format(initial + " stadsdeel = '{0}'",cBoxStadsdeel.Text);
                    noInitial = false;
                }
                if (chkScore.Checked)
                {
                    if (!string.IsNullOrWhiteSpace(txtScore.Text))
                    {
                        string initial = "";
                        if (!noInitial) { initial = " AND"; }
                        filter += string.Format(initial + " totaal_score > {0}", int.Parse(txtScore.Text));
                        noInitial = false;
                    }
                }
                if (chkName.Checked)
                {
                    if (!string.IsNullOrWhiteSpace(txtName.Text))
                    {
                        string initial = "";
                        if (!noInitial) { initial = " AND"; }
                        filter += string.Format(initial + " wijk LIKE '%{0}%' OR wijk LIKE '%{1}%' OR wijk LIKE '%{2}%'", txtName.Text.ToLower(), txtName.Text.ToUpper(), (txtName.Text.ToLower())[0].ToString().ToUpper() + txtName.Text.ToLower().Substring(1));
                        noInitial = false;
                    }
                }
                if (filter != "")
                {
                    mainForm.LoadDataGridInitial(" WHERE"+filter);
                    Close();
                }
                else { Close(); }
            }
            else { mainForm.LoadDataGridInitial(); Close(); }
        }

        private void txtScore_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtScore.Text, out int number) && !string.IsNullOrWhiteSpace(txtScore.Text))
            {
                MessageBox.Show(this, "Eén of meerdere karakters die je in de minimum score box getypt heb is niet een geldige getal!" 
                    + Environment.NewLine + Environment.NewLine 
                    + "Voor de score filter moet je alleen gehele getallen invoeren, geen letters of decimalen!",
                    "Ongeldige karakter!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtScore.Text = txtScore.Text.Remove(txtScore.Text.Length - 1);
            }
        }
    }
}
