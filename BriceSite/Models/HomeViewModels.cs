using BricejModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BriceSite.Models
{
    public class HomeViewModels
    {
        public Color Color { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<Education> Educations { get; set; }
        public List<Project> Projects { get; set; }
        public List<Programming> ProgrammingSkills { get; set; }
        public List<Language> LanguageSkills { get; set; }
        public List<Interest> Interests { get; set; }
        public List<Quality> Qualities { get; set; }
        public List<Profile> Profiles { get; set; }
        

        public HomeViewModels(Color c, List<Experience> ex, List<Education> ed,
            List<Project> proj, List<Programming> prog, List<Language> la,
            List<Interest> inter, List<Quality> qua, List<Profile> prof/*, List<Image> im*/)
        {
            Color = c;
            Experiences = ex;
            Educations = ed;
            Projects = proj;
            ProgrammingSkills = prog;
            LanguageSkills = la;
            Interests = inter;
            Qualities = qua;
            Profiles = prof;
            //Images = im;
        }
    }
}