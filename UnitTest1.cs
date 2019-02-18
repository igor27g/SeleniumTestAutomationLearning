using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit;

namespace UnitTestProject1
{
	[TestClass]
	[TestCategory("SampleApplicationOne")]
	public class SampleApplicationOneTest
	{
		private IWebDriver Driver { get; set; }

		[TestMethod] 
		public void Test1()
		{
			Driver = GetChromeDriver();
			var sampleApplicationPage = new SampleApplicationPageTest(Driver);
			sampleApplicationPage.maximizeWindow();
			sampleApplicationPage.GoTo();
			//Assert.IsTrue(sampleApplicationPage.IsVisible);

			var ultimateQAHomePage = sampleApplicationPage.FillOutFormAndSubmit("Igor");
			Assert.IsTrue(ultimateQAHomePage.IsVisible);
			Driver.Close();
			Driver.Quit();
		}

		

		private IWebDriver GetChromeDriver()
		{
			var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			return new ChromeDriver(outPutDirectory);
		}


	}

		
	}

