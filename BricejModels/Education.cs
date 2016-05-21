using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BricejModels
{
    public class Education : ItemCV
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string School { get; set; }
        public string Dates { get; set; }
        public string Link { get; set; }

        // FRENCH
        public string TitleFrench { get; set; }
        public string DescriptionFrench { get; set; }
        public string DatesFrench { get; set; }
    }
}
