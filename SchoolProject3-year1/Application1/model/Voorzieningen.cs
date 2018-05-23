using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject3_year1.Application1.model
{
    class Voorzieningen
    {
        private string naam;
        private string adres;
        private string lastpostcode;
        private string herkomst;
        private string voorzieningen;
        private int wijk_id;

        public string Naam
        {
            get => naam;
            set => naam = value;
        }

        public string Adres
        {
            get => adres;
            set => adres = value;
        }

        public string Lastpostcode
        {
            get => lastpostcode;
            set => lastpostcode = value;
        }

        public string Herkomst
        {
            get => herkomst;
            set => herkomst = value;
        }

        public string Voorzieningen1
        {
            get => voorzieningen;
            set => voorzieningen = value;
        }

        public int WijkId
        {
            get => wijk_id;
            set => wijk_id = value;
        }
    }
}