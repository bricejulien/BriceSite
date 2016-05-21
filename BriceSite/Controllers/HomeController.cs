using BricejModels;
using BriceSite.Context;
using BriceSite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace BriceSite.Controllers
{
    
    public class HomeController : Controller
    {
        private BricejContext _db;

        public HomeController()
        {
            _db = new BricejContext();
        }

        public ActionResult Index()
        {
            /* new */
            Color Color;
            List<Profile> Profiles = new List<Profile>();
            List<Experience> Experiences = new List<Experience>();
            List<Education> Educations = new List<Education>();
            List<Project> Projects = new List<Project>();
            List<Programming> ProgrammingSkills = new List<Programming>();
            List<Language> LanguageSkills = new List<Language>();
            List<Interest> Interests = new List<Interest>();
            List<Quality> Qualities = new List<Quality>();

            if (_db.Color.Count() > 0)
            {
                Color = _db.Color.First();
            }
            else
            {
                Color = new Color { Value = "#113F59" };
            }

            if(_db.Experience.Count() > 0)
            {
                Experiences = _db.Experience.ToList();
            }

            if (_db.Education.Count() > 0)
            {
                Educations = _db.Education.ToList();
            }

            if (_db.Project.Count() > 0)
            {
                Projects = _db.Project.ToList();
            }

            if (_db.Programming.Count() > 0)
            {
                ProgrammingSkills = _db.Programming.ToList();
            }

            if (_db.Language.Count() > 0)
            {
                LanguageSkills = _db.Language.ToList();
            }

            if (_db.Interest.Count() > 0)
            {
                Interests = _db.Interest.ToList();
            }

            if (_db.Quality.Count() > 0)
            {
                Qualities = _db.Quality.ToList();
            }

            if (_db.Profile.Count() > 0)
            {
                Profiles = _db.Profile.ToList();
            }

            HomeViewModels model = new HomeViewModels(Color, Experiences, Educations,
                Projects, ProgrammingSkills, LanguageSkills, Interests, Qualities, Profiles);
            /* end new */
            return View(model);
        }

        [HttpPost]
        public ActionResult changeMainColor(string color, string selectors)
        {
            if (User.Identity.IsAuthenticated && User.Identity.Name.Equals("bricejulien.thespider@gmail.com"))
            {
                Color currentColor;
                if (_db.Color.Count() > 0)
                {
                    currentColor = _db.Color.First();
                    currentColor.Value = color;
                    currentColor.Selector = selectors;
                }
                else
                {
                    currentColor = new Color();
                    currentColor.Value = color;
                    currentColor.Selector = selectors;
                    _db.Color.Add(currentColor);
                }
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
