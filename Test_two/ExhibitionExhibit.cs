using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_two
{
    public class ExhibitionExhibit
    {
        public int ExhibitionExhibitId { get; set; }
        public int ExhibitId { get; set; }
        public Exhibit Exhibit { get; set; }

        public int ExhibitionId { get; set; }
        public Exhibition Exhibition { get; set; }
    }
}
