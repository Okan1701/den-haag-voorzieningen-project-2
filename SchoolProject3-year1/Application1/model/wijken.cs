using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject3_year1.Application1.model
{
    class Wijken
    {
        private int id;
        private string wijk;
        private string wijknr;
        private string stadsdeel;
        private int totaal_score;
        private int publiekruimte;
        private int huisvestiging;


        /// <summary>
        /// Determines if the given point is inside the polygon
        /// </summary>
        /// <param name="polygon">the vertices of polygon</param>
        /// <param name="testPoint">the given point</param>
        /// <returns>true if the point is inside the polygon; otherwise, false</returns>
        public bool IsPointInPolygon4(PointF[] polygon, PointF testPoint)
        {
            bool result = false;
            int j = polygon.Count() - 1;
            for (int i = 0; i < polygon.Count(); i++)
            {
                if (polygon[i].Y < testPoint.Y && polygon[j].Y >= testPoint.Y ||
                    polygon[j].Y < testPoint.Y && polygon[i].Y >= testPoint.Y)
                {
                    if (polygon[i].X + (testPoint.Y - polygon[i].Y) / (polygon[j].Y - polygon[i].Y) *
                        (polygon[j].X - polygon[i].X) < testPoint.X)
                    {
                        result = !result;
                    }
                }

                j = i;
            }

            return result;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Wijk
        {
            get => wijk;
            set => wijk = value;
        }

        public string Wijknr
        {
            get => wijknr;
            set => wijknr = value;
        }

        public string Stadsdeel
        {
            get => stadsdeel;
            set => stadsdeel = value;
        }

        public int TotaalScore
        {
            get => totaal_score;
            set => totaal_score = value;
        }

        public int Publiekruimte
        {
            get => publiekruimte;
            set => publiekruimte = value;
        }

        public int Huisvestiging
        {
            get => huisvestiging;
            set => huisvestiging = value;
        }
    }
}