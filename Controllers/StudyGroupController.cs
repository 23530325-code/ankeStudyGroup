using ankeStudyGroup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ankeStudyGroup.Controllers
{
    public class StudyGroupController : Controller
    {
        // GET: StudyGroup
        public ActionResult Index()
        {
            List<StudyGroupMember> members = new List<StudyGroupMember>
            {
                new StudyGroupMember { StudentNumber = "u23530325", Name = "Anke", Surname = "Vosloo", Email = "u23530325@tuks.co.za" },
                new StudyGroupMember { StudentNumber = "u22566521", Name = "Xilia", Surname = "Mononyane", Email = "u22566521@tuks.co.za" },
                new StudyGroupMember { StudentNumber = "u25671470", Name = "Anoeska", Surname = "Hood", Email = "u25671470@tuks.co.za" },
                new StudyGroupMember { StudentNumber = "u22738241", Name = "Dirco", Surname = "Engelbrecht", Email = "u22738241@tuks.co.za" },
                new StudyGroupMember { StudentNumber = "u22558307", Name = "Eliya", Surname = "Mugabe", Email = "u22558307@tuks.co.za" },
                new StudyGroupMember { StudentNumber = "u24987230", Name = "Lesego", Surname = "Muleka", Email = "u24987230@tuks.co.za" }
            };

            return View(members);
        }
    }
}