	using MoneyPennyTest4.Models;
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web;
	using System.Web.Mvc;

namespace MoneyPennyTest4.Controllers
{
	public class HomeController : Controller
	{
		private List<Developers> dev;
		private List<Testers> test;
		private List<ProductOwners> prod;
		public HomeController()
		{
			
			// GET: Testers

			{
				test = new List<Testers>()
					{
					new Testers()
					{ EmployeeID =4,EmployeeName="Pete",Position="Tester", Skills="Manual testing, load testing", },
					new Testers()
					{ EmployeeID =5,EmployeeName="Jack",Position="Tester", Skills="Gherkin, Selenium, Specflow", },
					new Testers()
					{ EmployeeID =6,EmployeeName="Sam",Position="Tester", Skills="Gherkin, Selenium", },

					};
				// GET: Product Owners
				{
					{
						prod = new List<ProductOwners>()
					{
					new ProductOwners()
					{ EmployeeID =7,EmployeeName="Lauren",Position="Product Owner", Skills="Confluence, TFS", },
					new ProductOwners()
					{ EmployeeID =8,EmployeeName="John",Position="Product Owner", Skills="Confluence, TFS, Visio, UML", },
					new ProductOwners()
					{ EmployeeID =9,EmployeeName="Claire",Position="Product Owner", Skills="Confluence, TFS, Visio, Lucid Chart", },

				};
					}
					// GET: Developers

					{
						dev = new List<Developers>()
				{
					new Developers()
					{ EmployeeID =1,EmployeeName="Bob",Position="Developer", Skills="Web Api, Entity Framework, MVC", },
					new Developers()
					{ EmployeeID =2,EmployeeName="Joseph",Position="Developer", Skills="Vue, React, node, JavaScript", },
					new Developers()
					{ EmployeeID =3,EmployeeName="Chris",Position="Developer", Skills="VB.Net, WPF, WCF", },


					};
						
					}
				}
			}
		}

		public ActionResult Index()
		{

			return View();
		}
		public ActionResult Developers()
		{

			return View(dev);
		}
		public ActionResult Testers()
		{

			return View(test);
		}

		public ActionResult ProductOwners()
		{

			return View(prod);
		}
	}
}