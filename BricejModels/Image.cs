using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BricejModels
{
    public class Image
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }

        // FRENCH
        public string TitleFrench { get; set; }
        public string SubtitleFrench { get; set; }
        public string DescriptionFrench { get; set; }
    }
}
