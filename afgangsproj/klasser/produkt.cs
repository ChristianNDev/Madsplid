using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace afgangsprojekt.pattens
{
    class produkt
    {
        public string tilbud_titel {
            get; set;
        }
        public string tilbud_beskrivelse { get; set; }
        public int tilbud_antal { get; set; }
        public int tilbud_pris { get; set; }
        public double tilbud_kg { get; set; }
        public DateTime tilbud_datetil { get; set; }
        public DateTime tilbud_fradato { get; set; }
        public int tilbud_stjerner { get; set; }
        public int tilbud_antalD { get; set; }
    }
}
