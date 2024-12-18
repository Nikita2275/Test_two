using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_two
{
    public class Exhibition
    {
        public int ExhibitionId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }

        public ICollection<ExhibitionExhibit> ExhibitionExhibits { get; set; }
    }
}
