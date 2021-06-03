using System;


namespace LearnSelenium
{
    class Program
    {

        static void Main(string[] args)
        {

            //Do not forget that cmd line 
            // chrome -remote-debugging-port=9014 --user-data-dir="D:\DocStream\Selenium"

            EmailService.SendMail("mohamedlawani2107@gmail.com", "test class service", "new test again right");

            
        }
    }
}
