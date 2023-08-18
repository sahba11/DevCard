using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using DevCard_Mvc.Models;

namespace DevCard_Mvc.Data
{
    public class ProjectStore
    {
        public static List<Project> GetProjects()
        {


            return  new List<Project>()
            {
                new Project(1, "تاکسی", "درخواست آنلاین تاکسی برای سفرهای درون شهری","project-1.jpg" ,"Atriya"),
                new Project(2, "زود فود", "درخواست آنلاین غذا برای سراسر کشور","project-2.jpg", "ZoodFood"),
                new Project(3, "مدارس", "سیستم مدیریت یک پارچه", "project-3.jpg","Monop"),
                new Project(4, "فضا پیما", "درخواست آنلاین تاکسی برای سفرهای درون شهری", "project-4.jpg","nasa"),
            };
        }

        public static Project GetProjectBy(long id)
        {
            return GetProjects().FirstOrDefault(x =>x.Id== id);
        }
    }
}
