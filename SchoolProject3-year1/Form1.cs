using SchoolProject3_year1.Application1.dao;
using SchoolProject3_year1.Application1.forms;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SchoolProject3_year1
{
    public partial class window : Form
    {
        //App1 fields
        public static string filteredPostcode = null;
        public string application1DataGridCurrentWijkName;
        public int application1DataGridCurrentWijkID;
        private string application1DataGridCurrent;

        private PostgresSQL db = new PostgresSQL();

        public window()
        {
            InitializeComponent();

            panelLeft.Height = buttonDashboard.Height;
            panelLeft.Top = buttonDashboard.Top;

            db.CreateConnection();
            LoadDataGridInitial();
            dGrid_main.RowHeadersVisible = false;
            dGrid_main.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None;
            dGrid_main.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None;
            dGrid_main.AllowUserToResizeRows = false;
            dGrid_main.AllowUserToResizeColumns = false;
        }

        public void LoadDataGridInitial(string filter = "")
        {
            string sql = "SELECT wijknr, wijk, stadsdeel, totaal_score FROM wijken";

            application1DataGridCurrent = "wijken";
            btnApp1Return.Visible = false;
            //btnApp1Filter.Visible = false;
            lbl_app1_dataView.Text = "U bekijkt momenteel: Alle Wijken (Den Haag)";
            DataTable dt = new DataTable();
            if (filter != "")
            {
                lbl_app1_dataView.Text += " (filtered)";
                sql += filter;
            }
            //MessageBox.Show(sql);
            dt.Load(db.QueryDataReader(sql));
            dGrid_main.DataSource = dt;


            foreach (DataGridViewColumn column in dGrid_main.Columns)
            {
                column.ReadOnly = true;
                column.DefaultCellStyle.BackColor = Color.FromArgb(41, 41, 51);
                column.DefaultCellStyle.ForeColor = Color.White;
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.Resizable = DataGridViewTriState.True;
                column.HeaderText = column.HeaderText[0].ToString().ToUpper() + column.HeaderText.Substring(1);
                column.HeaderText = column.HeaderText.Replace("_", " ");
            }
        }

        public void LoadDataGridResults(int id, string name, string filter = "")
        {
            string sql =
                string.Format(
                    "SELECT naam, adres, lastpostcode, herkomst, voorzieningen FROM voorzieningen, wijken WHERE wijken.id = voorzieningen.wijk_id",
                    id);

            application1DataGridCurrent = "voorzieningen";
            btnApp1Return.Visible = true;
            //btnApp1Filter.Visible = true;

            lbl_app1_dataView.Text = string.Format("U bekijkt momenteel: Voorzieningen in '{0}'",
                (name[0].ToString().ToUpper() + name.Substring(1)).Replace("_", " "));
            if (!string.IsNullOrWhiteSpace(filter))
            {
                sql += " " + filter;
                lbl_app1_dataView.Text += " (filtered)";
            }
            DataTable dt = new DataTable();
            dt.Load(db.QueryDataReader(sql));
            dGrid_main.DataSource = dt;

            foreach (DataGridViewColumn column in dGrid_main.Columns)
            {
                column.ReadOnly = true;
                column.DefaultCellStyle.BackColor = Color.FromArgb(41, 41, 51);
                column.DefaultCellStyle.ForeColor = Color.White;
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                column.Resizable = DataGridViewTriState.True;
                column.HeaderText = column.HeaderText[0].ToString().ToUpper() + column.HeaderText.Substring(1);
                column.HeaderText = column.HeaderText.Replace("_", " ");
            }
        }

        private void dGrid_main_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (application1DataGridCurrent == "wijken" && e.RowIndex > -1 && e.RowIndex < dGrid_main.Rows.Count - 1)
            {
                int id = int.Parse(dGrid_main[0, int.Parse(e.RowIndex.ToString())].Value.ToString());
                string name = dGrid_main[1, int.Parse(e.RowIndex.ToString())].Value.ToString();
                application1DataGridCurrentWijkID = id;
                application1DataGridCurrentWijkName = name;
                LoadDataGridResults(id, name);
            }
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonDashboard.Height;
            panelLeft.Top = buttonDashboard.Top;
            panelDashBoard.Visible = true;
            panel_app1.Visible = false;
        }

        private void buttonApplication1_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonApplication1.Height;
            panelLeft.Top = buttonApplication1.Top;
            panel_app1.Visible = true;
            panelDashBoard.Visible = false;
            visualizationButton.Visible = true;
        }

        int mouseX = 0, mouseY = 0, mouseinX, mouseinY;
        bool mouseDown;

        private void navigation_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
        }

        private void panel_app1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnApp1Return_Click(object sender, EventArgs e)
        {
            LoadDataGridInitial();
        }

        private void btnApp1Filter_Click(object sender, EventArgs e)
        {
            if (application1DataGridCurrent == "wijken") { new FormFilterWijk(this, db).Show(); }
            else { new FormFilter(this, db, filteredPostcode).Show(); }
        }

        private void visualizationButton_Click(object sender, EventArgs e)
        {
            Form2 openForm = new Form2(db);
            openForm.Show();
        }

        private void btnApp1Help_Click(object sender, EventArgs e)
        {
            string txt =
                "Met de 'Voorzieningen in Den Haag' sectie van deze Applicatie kunt " +
                "u een gedetaileerde lijst bekijken van alle voorziening in Den Haag." 
                + Environment.NewLine + Environment.NewLine +
                "In het beginscherm ziet u een lijst van alle wijken in Den Haag met wat " +
                "extra info voor elke wijk." + Environment.NewLine +
                "Wanneer u op een wijknaam klikt wordt er automatisch een lijst met alle" +
                " voorzieningen van die specifieke wijk weergeven. Ook weergeeft het (indien " +
                "beschikbaar) ook wat extra informatie per voorzieningen." + Environment.NewLine + "" +
                Environment.NewLine + "Verder is er een knop die 'Visualisatie' heet. " +
                "Deze knop opent een venster die een staafdiagram laat zien." +
                "Op deze diagram ziet u een overzicht van alle wijken en hoeveel voorzieningen " +
                "elke wijk heeft. Ook ziet u per wijk hoeveel voorzieningstypes er per wijk zijn." 
                + Environment.NewLine + Environment.NewLine +
                "Wanneer u de resultaten in het lijst bekijkt kunt u op de knop 'filter' drukken. " +
                "Afhankelijk of u de wijken of voorzieningen van een specifieke wijk bekijkt " +
                "krijgt u een venster waar een aantal filter opties erop staan.";

            MessageBox.Show(this, txt, "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void navigation_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - mouseinX;
                mouseY = MousePosition.Y - mouseinY;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void navigation_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void labelQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}