using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace UnitTestProject2

{
    [TestClass]
    public class UnitTest1
    {

        string url = string.Empty;
        string url2 = string.Empty;
        string kullaniciAdi = string.Empty;
        string parola = string.Empty;
        string metin = string.Empty;

        // IWebDriver driver;

        [TestMethod]
        public void TestMethod1()
        {

           
            url = "https://www.n11.com/giris-yap";
            url2 = "https://www.n11.com";
            kullaniciAdi = "aaaaaa";
            parola = "1881.1881";
            metin = "samsung";

            /*geçersiz kullanıcı adı ve şifresi kullanıldığı için sayfa yönlendirmesi iki url kullanıldı. */

            IWebDriver driver = new FirefoxDriver();

            driver.Manage().Window.Maximize();


            driver.Navigate().GoToUrl(url2);
            Console.WriteLine("n11 sayfası açıldı...");
         

            driver.Navigate().GoToUrl(url);
            Console.WriteLine("Login sayfası açıldı...");


            driver.FindElement(By.Id("email")).SendKeys(kullaniciAdi);
            Console.WriteLine("Kullanıcı adı olarak {0} değeri gönderildi...", kullaniciAdi);
            driver.FindElement(By.Id("password")).SendKeys(parola);
            Console.WriteLine("Parola olarak {0} değeri gönderildi...", parola);         
            driver.FindElement(By.Id("loginButton")).Click();            
            Console.WriteLine("Giriş Yap butonuna basıldı...");


            driver.Navigate().GoToUrl(url2);
            Console.WriteLine("n11 sayfası açıldı...");


            driver.FindElement(By.Id("searchData")).SendKeys(metin);
            driver.FindElement(By.Id("searchData")).SendKeys(Keys.Enter);
            Console.WriteLine("Metin olarak {0} değeri gönderildi...", metin);


            /*aşağıda yazılan kod blogu hatalıdır.
             * Bunları kapattığımızda test hatasız çalışıyor. 
             * Fakat "samsung" araması yapmıyor. 
             * Açtığımızda ise samsung araması yapıyor fakat test hatalı çalışıyor. */

            driver.FindElement(By.Id("searchBtn")).Click();
            Console.WriteLine("Arama Yap butonuna basıldı...");
            driver.FindElement(By.XPath(".//*[@id='contentListing']/div/div/div[2]/div[3]/a[1]")).Click();



            driver.Quit();

        }

    
        }
    }
