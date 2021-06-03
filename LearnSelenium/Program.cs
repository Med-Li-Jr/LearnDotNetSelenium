using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace LearnSelenium
{
    class Program
    {

        public static IWebDriver driver;
        static void Main(string[] args)
        {
            ChromeOptions options = new ChromeOptions();
            //options.DebuggerAddress = "localhost:9014";
            driver = new ChromeDriver(@"D:\DocStream", options);
            driver.Navigate().GoToUrl("https://mail.google.com/mail/u/0/h/");
            var btnNewMessage = driver.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td[1]/table[1]/tbody/tr[1]/td/b/a"));


            btnNewMessage.Click();


            var emailTo = driver.FindElement(By.Id("to"));
            emailTo.SendKeys("mohamedlawani2107@gmail.com");
            var xpathSubject = "/html/body/table[2]/tbody/tr/td[2]/table[1]/tbody/tr/td[2]/form/table[2]/tbody/tr[4]/td[2]/input";
            var objectEmail = driver.FindElement(By.Name("subject"));
            objectEmail.SendKeys("Who Knows right Email");
            var xpathMessage = "/html/body/table[2]/tbody/tr/td[2]/table[1]/tbody/tr/td[2]/form/table[2]/tbody/tr[8]/td[2]/textarea";
            var messageEmail = driver.FindElement(By.Name("body"));
            messageEmail.SendKeys("C'cmt man Test Email for who knows right");

            var xpathBtnSend = "/html/body/table[2]/tbody/tr/td[2]/table[1]/tbody/tr/td[2]/form/table[3]/tbody/tr/td/input[1]";
            var btnSendNewMessage = driver.FindElement(By.Name("nvp_bu_send"));
            btnSendNewMessage.Click();
            //var btnEnglish = driver.FindElement(By.XPath("//*[@id=\"SIvCob\"]/a[2]"));
            //btnEnglish.Click();
            //            var btnSignIn = driver.FindElement(By.XPath("//*[@id=\"gb\"]/div/div[2]/a"));

            //Thread.Sleep(2000);
            //var btnSignInFox = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div/div[2]/a"));
            //var btnSignInFoxStack = driver.FindElement(By.XPath("/html/body/header/div/ol[2]/li[2]/a[2]"));
            ////Thread.Sleep(3000);
            //btnSignInFoxStack.Click();
            //var btnSigInGoogleStackFox = driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div[2]/div[2]/button[1]"));
            //btnSigInGoogleStackFox.Click();
            ////var inputEmail = driver.FindElement(By.XPath("//*[@id=\"identifierId\"]"));
            ////var inputEmailFox = driver.FindElement(By.XPath("//*[@id=\"identifierId\"]"));
            //var inputEmailStackFox = driver.FindElement(By.XPath("//*[@id=\"identifierId\"]"));
            ////Thread.Sleep(2000);
            //inputEmailStackFox.SendKeys("vj.junior799@gmail.com");
            ////var btnNext = driver.FindElement(By.XPath("//*[@id=\"identifierNext\"]"));
            ////var btnNextFox = driver.FindElement(By.XPath("//*[@id=\"identifierNext\"]"));
            //var btnNextStackGoogleFox = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[2]/div/div[1]/div/div/button"));
            ////Thread.Sleep(3000);
            //btnNextStackGoogleFox.Click();
            //var inputPwdStackFox = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[1]/div[1]/div/div/div/div/div[1]/div/div[1]/input"));
            ////Thread.Sleep(2000);
            //inputPwdStackFox.SendKeys("!Bonjour!Google!Hein!Mew!2018!");
            //var btnNextStackGooglePwdFox = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[2]/div/div[1]/div/div/button"));
            ////Thread.Sleep(3000);
            //btnNextStackGooglePwdFox.Click();
            //Console.WriteLine("Hello World!");
        }
    }
}
