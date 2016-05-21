using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BricejModels
{
    public class Profile
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Birthdate { get; set; }
        public string Phone { get; set; }
        public string Skype { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Address { get; set; }
        public string LinkTwitter { get; set; }
        public string LinkFacebook { get; set; }
        public string LinkGoogle { get; set; }
        public string LinkLinkedIn { get; set; }

        // FRENCH
        public string TitleFrench { get; set; }
        public string SubtitleFrench { get; set; }
        public string DescriptionFrench { get; set; }
        public string BirthdateFrench { get; set; }
    }
}
