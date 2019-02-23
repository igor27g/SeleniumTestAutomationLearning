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
		internal TestUser TheTestUser { get; private set; }

		[TestInitialize]
		public void SetupForEverySingleTestMethod()
		{
			Driver = GetChromeDriver();
			TheTestUser = new TestUser();
			TheTestUser.FirstName = "Nikolay";
			TheTestUser.LastName = "Blahzah";
			TheTestUser.GenderType = Gender.Female;

		}

		[TestMethod]
		[Description("Validate that user is able to fill out the form successfully using valid data.")]
		public void Test1()
		{
			

			Driver = GetChromeDriver();
			var sampleApplicationPage = new SampleApplicationPageTest(Driver);
			sampleApplicationPage.maximizeWindow();
			sampleApplicationPage.GoTo();

			var ultimateQAHomePage = sampleApplicationPage.FillOutFormAndSubmit(TheTestUser);
			Assert.IsTrue(ultimateQAHomePage.IsVisible, "UltimateQA home page was not visible.");
		}


		[TestMethod]
		[Description("Validate that user is able to fill out the form successfully using valid data.")]
		public void PretendTestNumber2()
		{
			var sampleApplicationPage = new SampleApplicationPageTest(Driver);
			sampleApplicationPage.maximizeWindow();
			sampleApplicationPage.GoTo();
			

			var ultimateQAHomePage = sampleApplicationPage.FillOutFormAndSubmit(TheTestUser);
			Assert.IsFalse(!ultimateQAHomePage.IsVisible, "UltimateQA home page was not visible.");			
		}


		[TestMethod]
		
		public void Test3()
		{
			var sampleApplicationPage = new SampleApplicationPageTest(Driver);
			sampleApplicationPage.maximizeWindow();
			sampleApplicationPage.GoTo();
			var ultimateQAHomePage = sampleApplicationPage.FillOutFormAndSubmit(TheTestUser);


		}
		/*
		[TestCleanup]
		public void CleanUpAfterEveryTestMethod()
		{
			Driver.Close();
			Driver.Quit();
		}
		*/
	

		private IWebDriver GetChromeDriver()
		{
			var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			return new ChromeDriver(outPutDirectory);
		}


	}

		
	}

