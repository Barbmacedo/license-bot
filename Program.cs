
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Inicializa o driver do Chrome
        IWebDriver driver = new ChromeDriver();

        //Necessário acesso ao Service Now + coleta de dados por chamado
        //driver.Navigate().GoToUrl("https://landisgyr.service-now.com/");

        // Abre o gerador de licenças do meter
        driver.Navigate().GoToUrl("https://metercomm.sa.bm.net/Login.aspx");

        System.Threading.Thread.Sleep(2000);

        // Localiza o campo de usuário e insere o valor
        driver.FindElement(By.Id("MainContent_Username")).SendKeys("limawa");

        // Localiza o campo de senha e insere o valor
        driver.FindElement(By.Id("MainContent_Password")).SendKeys("Landis@2024");

        // Clica no botão de login
        driver.FindElement(By.XPath("//*[@id=\"Form1\"]/div[5]/div/input")).Click();

        // Clica no botão de Nova Licença
        driver.FindElement(By.XPath("/html/body/div/form/div[3]/div[1]/div/div[2]/a")).Click();

        //Necessário dados + preenchimento dos campos e geração da licença
        //driver.Quit();
    }
}

