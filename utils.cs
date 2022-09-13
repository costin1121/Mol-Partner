using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace MolPartner
{
	class utils
	{
		public static void startBot(string usernameTBI, string passwordTBI, string serverDatabase, string usernameDatabase, string passwordDatabase, string usernameMol, string passwordMol, int interval)
		{
			try
			{
				var driver = new ChromeDriver();
				string url = "https://b2b.mol.hu/openam/UI/Logout?goto=https://b2bpartnerportal.com/pp/login?lang=ro";
				driver.Manage().Window.Maximize();
				driver.Navigate().GoToUrl(url);
				WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
				IWebElement molPartenerChangeLanguage = wait.Until(i => i.FindElement(By.Id("langDropdown")));
				IWebElement molPartenerChangeLanguageSelect = wait.Until(i => i.FindElement(By.Id("langRo")));
				IWebElement molPartenerLoginUsername = wait.Until(i => i.FindElement(By.Name("username")));
				IWebElement molPartenerLoginPassword = wait.Until(i => i.FindElement(By.Name("password")));
				molPartenerLoginUsername.SendKeys(usernameMol);
				molPartenerLoginPassword.SendKeys(passwordMol);
				molPartenerLoginPassword.SendKeys(OpenQA.Selenium.Keys.Enter);
			}catch(Exception e)
			{
				frmMain.main.log = "[" + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss") + "] - " + e.Message + Environment.NewLine;
			}



		}
	}
}
