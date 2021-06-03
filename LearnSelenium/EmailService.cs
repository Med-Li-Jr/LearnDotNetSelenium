using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LearnSelenium
{
    public class EmailService
    {

        public static IWebDriver Driver;
        public static ChromeOptions Options = new ChromeOptions() { DebuggerAddress = "localhost:9014" };
        public static string PathDriverChrome = @"D:\DocStream";
        public static void SendMail(string sendTo, string objectMail, string messageMail)
        {
            if(Driver == null)
                Driver = new ChromeDriver(PathDriverChrome, Options);
    
            Driver.Navigate().GoToUrl("https://mail.google.com/mail/u/0/h/");

            var btnNewMessage = Driver.FindElement(By.XPath("/html/body/table[2]/tbody/tr/td[1]/table[1]/tbody/tr[1]/td/b/a"));
            btnNewMessage.Click();

            var emailTo = Driver.FindElement(By.Id("to"));
            emailTo.SendKeys(sendTo);

            var xpathSubject = "/html/body/table[2]/tbody/tr/td[2]/table[1]/tbody/tr/td[2]/form/table[2]/tbody/tr[4]/td[2]/input";
            var objectEmail = Driver.FindElement(By.Name("subject"));
            objectEmail.SendKeys(objectMail);

            var xpathMessage = "/html/body/table[2]/tbody/tr/td[2]/table[1]/tbody/tr/td[2]/form/table[2]/tbody/tr[8]/td[2]/textarea";
            var messageEmail = Driver.FindElement(By.Name("body"));
            messageEmail.SendKeys(messageMail);

            var xpathBtnSend = "/html/body/table[2]/tbody/tr/td[2]/table[1]/tbody/tr/td[2]/form/table[3]/tbody/tr/td/input[1]";
            var btnSendNewMessage = Driver.FindElement(By.Name("nvp_bu_send"));
            Thread.Sleep(2000);
            btnSendNewMessage.Click();

        }
    }
}
