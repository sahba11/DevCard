using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DevCard_Mvc.Models;



namespace DevCard_Mvc.ViewComponents
{
	public class LatestArticlesViewComponent:ViewComponent
	{
		public IViewComponentResult Invoke()
		{

			var articles = new List<Article>()
			{
				new Article(1,"آموزش Asp.net Core mvc","کاملترین پکیج آموزشasp.net cor mvc","blog-post-thumb-1.jpg"),
				new Article(2," Git and GitHubآموزش Asp.net Core mvc","کاملترین پکیج آموزشasp.net cor mvc","blog-post-thumb-2.jpg"),
				new Article(3,"آموزش Onion Architecture","کاملترین پکیج آموزشasp.net cor mvc","blog-post-thumb-3.jpg"),
				new Article(4,"آموزش طراحی سایت","کاملترین پکیج آموزشasp.net cor mvc","blog-post-thumb-4.jpg")



			};
			return View("_latestArticles", articles);
		}

	}
}
