using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using SchoolProject3_year1.Application1.dao;
using SchoolProject3_year1.Application1.model;

namespace SchoolProject3_year1
{
    public partial class Form2 : Form
    {
        PostgresSQL db;

        public Form2(PostgresSQL db)
        {
            this.db = db;
            InitializeComponent();
        }

        List<string> series = new List<string>();
        List<Wijken> wijken = new List<Wijken>();

        private void Form2_Load(object sender, EventArgs e)
        {
            menuStrip1.Items.Clear();

            DataTable dt = new DataTable();
            var reader = db.QueryDataReader("SELECT DISTINCT voorzieningen FROM voorzieningen");

            int count = reader.FieldCount;
            while (reader.Read())
            {
                for (int i = 0; i < count; i++)
                {
                    series.Add(reader.GetValue(i).ToString());
                }
            }

            reader.Dispose();

            var readerWijken = db.QueryDataReader("SELECT id, wijk FROM wijken");

            int countWijken = readerWijken.FieldCount;
            while (readerWijken.Read())
            {
                Wijken wijk = new Wijken();
                wijk.Id = int.Parse(readerWijken[0].ToString());
                wijk.Wijk = readerWijken[1].ToString();
                wijken.Add(wijk);
            }

            readerWijken.Dispose();

            ToolStripMenuItem menuItem = new ToolStripMenuItem("Filter");

            barChart.ChartAreas[0].AxisX.Interval = 1;
            foreach (string serieName in series)
            {
                Series serie = new Series(serieName);
                serie.ChartType = SeriesChartType.StackedBar;
                barChart.Series.Add(serie);
                // menuStrip1.Items.Add(serieName, null, myContextMenuStrip_ItemClicked);


                ToolStripMenuItem foo = new ToolStripMenuItem(serieName);
                foo.Click += new EventHandler(myContextMenuStrip_ItemClicked);
                menuItem.DropDownItems.Add(foo);

                int i = 0;

                foreach (Wijken wijk in wijken)
                {
                    var readerCountFilter =
                        db.queryScalar("SELECT COUNT(*) FROM voorzieningen WHERE voorzieningen = '" +
                                       serieName + "' AND wijk_id = " + wijk.Id + "");
                    barChart.Series[serieName].Points.AddY(readerCountFilter);
                    barChart.Series[serieName].Points[i].AxisLabel = wijk.Wijk;

                    i++;
                }
            }

            ToolStripMenuItem last = new ToolStripMenuItem("None");
            last.Click += new EventHandler(myContextMenuStrip_ItemClicked);
            menuItem.DropDownItems.Add(last);

            menuStrip1.Items.Add(menuItem);
        }

        private void myContextMenuStrip_ItemClicked(object sender, EventArgs eventArgs)
        {
            if (sender.ToString() != "None")
            {
                foreach (string serieName in series)
                {
                    barChart.Series[serieName].Enabled = false;
                    barChart.Series[sender.ToString()].Enabled = true;
                    barChart.DataManipulator.FilterSetEmptyPoints = false;
                }
            }
            else
            {
                foreach (string serieName in series)
                {
                    barChart.Series[serieName].Enabled = true;
                }
            }
        }
    }
}