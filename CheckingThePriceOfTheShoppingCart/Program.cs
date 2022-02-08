
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text.RegularExpressions;


namespace CheckingThePriceOfTheShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            //שימו לב המוצרים נלקחו מהדילים אז יש מצב שהם ישתנו 
            //פשוט תקחו מוצרים חדשים וזה יעבוד
            // Create a driver instance for chromedriver
            IWebDriver driver = new ChromeDriver();

            //Navigate to google page
            driver.Navigate().GoToUrl("https://www.ebay.com/");


            //Maximize the window
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            /*var sign = driver.FindElement(By.CssSelector("#gh-ug > a"));
            sign.Click();
            Thread.Sleep(15000);

            var user = driver.FindElement(By.CssSelector("#userid"));
            user.SendKeys("aviasigroni@walla.co.il");
            Thread.Sleep(5000);

            var pass = driver.FindElement(By.CssSelector("#signin-form > div.null > div > div > label"));
            pass.SendKeys("A1357911a*");*/

            var Deals = driver.FindElement(By.CssSelector("#gh-p-1 > a"));
            Deals.Click();

            var Prodact0 = driver.FindElement(By.CssSelector("#refit-spf-container > div.sections-container > div.ebayui-dne-featured-card.ebayui-dne-featured-with-padding > div.ebayui-dne-item-featured-card.ebayui-dne-item-featured-card > div > div:nth-child(5) > div > div > a"));
            Prodact0.Click();
            Thread.Sleep(2000);

            var AddToCart0 = driver.FindElement(By.CssSelector("#isCartBtn_btn"));
            AddToCart0.Click();
            Thread.Sleep(3000);

            var Deals1 = driver.FindElement(By.CssSelector("#gh-p-1 > a"));
            Deals1.Click();
            Thread.Sleep(3000);

            var Prodact1 = driver.FindElement(By.CssSelector("#refit-spf-container > div.sections-container > div.ebayui-dne-featured-card.ebayui-dne-featured-with-padding > div.ebayui-dne-item-featured-card.ebayui-dne-item-featured-card > div > div:nth-child(1) > div > div.dne-itemtile-detail > a"));
            Prodact1.Click();
            Thread.Sleep(2000);

            var AddToCart1 = driver.FindElement(By.CssSelector("#isCartBtn_btn"));
            AddToCart1.Click();
            Thread.Sleep(3000);

            var Deals2 = driver.FindElement(By.CssSelector("#gh-p-1 > a"));
            Deals2.Click();
            Thread.Sleep(3000);

            var Prodact2 = driver.FindElement(By.CssSelector("#refit-spf-container > div.sections-container > div:nth-child(2) > div > div:nth-child(1) > div:nth-child(2) > div > div.dne-itemtile-detail > a"));
            Prodact2.Click();
            Thread.Sleep(2000);

            var AddToCart2 = driver.FindElement(By.CssSelector("#isCartBtn_btn"));
            AddToCart2.Click();
            Thread.Sleep(3000);

            float Number0 = 0;
            float Number1 = 0;
            float Number2 = 0;
            float Number3 = 0;
            float Sum = 0;

            var Price0 = driver.FindElement(By.XPath("//*[@id='mainContent']/div/div[3]/div[1]/div/div[2]/div[2]/div[2]/div/div/div/div[1]/div/div[3]/div/div[1]/div[2]/div/div[1]/span/span/span"));
            string text0 = Price0.Text;
            float parsedNumber0;
            Regex re0 = new Regex(@"[0-9.,]+");
            var matches0 = re0.Matches(text0);


            foreach (Match m0 in matches0)
            {
                if (float.TryParse(m0.Value, out parsedNumber0))
                {
                    float FloatNumber0 = parsedNumber0;

                    Number0 = FloatNumber0;
                }
                else
                {
                    Console.WriteLine("itay sigron king0");
                }

            }


            var Price1 = driver.FindElement(By.XPath("//*[@id='mainContent']/div/div[3]/div[1]/div/div[2]/div[2]/div[1]/div/div/div/div[1]/div/div[3]/div/div[1]/div[2]/div/div/span/span/span"));
            string text1 = Price1.Text;
            float parsedNumber1;
            Regex re1 = new Regex(@"[0-9.,]+");
            var matches1 = re1.Matches(text1);


            foreach (Match m1 in matches1)
            {
                if (float.TryParse(m1.Value, out parsedNumber1))
                {
                    float FloatNumber1 = parsedNumber1;

                    Number1 = FloatNumber1;
                }
                else
                {
                    Console.WriteLine("itay sigron king1");
                }

            }


            var Price2 = driver.FindElement(By.XPath("//*[@id='mainContent']/div/div[3]/div[1]/div/div[1]/div[2]/div/div[1]/div/div/div[1]/div/div[3]/div/div[1]/div[2]/div/div[1]/span/span/span"));
            string text2 = Price2.Text;
            float parsedNumber2;
            Regex re2 = new Regex(@"[0-9.,]+");
            var matches2 = re2.Matches(text2);


            foreach (Match m2 in matches2)
            {
                if (float.TryParse(m2.Value, out parsedNumber2))
                {
                    float FloatNumber2 = parsedNumber2;

                    Number2 = FloatNumber2;
                }
                else
                {
                    Console.WriteLine("itay sigron king2");
                }

            }


            /*Console.WriteLine("the" + Number0);
            Console.WriteLine("the" + Number1);
            Console.WriteLine("the" + Number2);*/

            Sum = Number0 + Number1 + Number2;


            var Subtotal = driver.FindElement(By.XPath("//*[@id='mainContent']/div/div[4]/div/div[2]/div[4]/div[2]/span/span/span"));
            string text3 = Subtotal.Text;
            float parsedNumber3;
            Regex re3 = new Regex(@"[0-9.,]+");
            var matches3 = re3.Matches(text3);


            foreach (Match m3 in matches3)
            {
                if (float.TryParse(m3.Value, out parsedNumber3))
                {
                    float FloatNumber3 = parsedNumber3;
                    Number3 = FloatNumber3;
                }
                else
                {
                    Console.WriteLine("itay sigron king3");
                }

            }




            if (Sum == Number3)
            {
                Console.WriteLine("the price is ok " + Number3);
            }
            else
            {
                Console.WriteLine("the price is not ok " + Number3);
            }




        }
    }
}
    

