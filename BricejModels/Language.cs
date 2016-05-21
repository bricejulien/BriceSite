using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BricejModels
{
    public class Language : Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        // FRENCH
        public string NameFrench { get; set; }
    }
}
