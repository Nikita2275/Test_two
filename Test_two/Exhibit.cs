using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_two
{
    public class Exhibit
    {
        public int ExhibitId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearCreated { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public ICollection<ExhibitionExhibit> ExhibitionExhibits { get; set; }
    }
}
