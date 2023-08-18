
using System.Collections.Generic;
using DevCard_Mvc.Data;
using DevCard_Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Project = DevCard_Mvc.Models.Project;


namespace DevCard_Mvc.ViewComponents
{
	public class ProjectsViewComponent:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			//var projects = new List<Project>
			//{
			//	new Project(1, "تاکسی", "درخواست آنلاین تاکسی برای سفرهای درون شهری","project-1.jpg" ,"Atriya"),
			//	new Project(2, "زود فود", "درخواست آنلاین غذا برای سراسر کشور","project-2.jpg", "ZoodFood"),
			//	new Project(3, "مدارس", "سیستم مدیریت یک پارچه", "project-3.jpg","Monop"),
			//	new Project(4, "فضا پیما", "درخواست آنلاین تاکسی برای سفرهای درون شهری", "project-4.jpg","nasa"),
			//};
            var projects = ProjectStore.GetProjects();
			return View("_Projects",projects);
		}
	}


}
