using System;
using System.Collections.ObjectModel;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;


namespace WebDriverApplication
{
    public partial class Form1 : Form
    {
        IWebDriver Browser;
        String str;
        public Form1()
        {
            InitializeComponent();
            Browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            Browser.Manage().Window.Maximize();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Browser.Navigate().GoToUrl("https://careers.veeam.com/");
            
                if (SelectCountry(countryTextBox.Text))
                {
                    str = "Страна " + countryTextBox.Text + " выбрана.";
                    logListBox.Items.Add(str);
                }
                else
                {
                    str = "Страна " + countryTextBox.Text + " не найдена.";
                    logListBox.Items.Add(str);
                }

                if (SelectLanguage(languageTextBox.Text))
                {
                    str = "Язык " + languageTextBox.Text + " выбран.";
                    logListBox.Items.Add(str);
                }
                else
                {
                    str = "Язык " + languageTextBox.Text + " не найден.";
                    logListBox.Items.Add(str);
                }

                try
                {
                    IWebElement link = Browser.FindElement(By.ClassName("content-loader-button"));
                    Thread.Sleep(2000);
                    if (link.Displayed) link.Click();
                    Thread.Sleep(2000);
                    int vacanciesQuantity = Browser.FindElements(By.ClassName("vacancies-blocks-item")).Count;
                    str = "Ожидаесое кол-во вакансий :" + expectionTextBox.Text;
                    logListBox.Items.Add(str);
                    str = "Фактическое кол-во вакансий: " + vacanciesQuantity.ToString();
                    logListBox.Items.Add(str);
                }
                catch (NoSuchElementException ex)
                {

                }
            
        }




        private bool SelectCountry(String value)
        {
            bool countryIsPresent = false;
            try
            {
                IWebElement selecter = Browser.FindElement(By.Id("country-element")).FindElement(By.ClassName("selecter"));
                selecter.Click();
                ReadOnlyCollection<IWebElement> countryCollection = selecter.FindElements(By.TagName("span"));

                foreach (IWebElement element in countryCollection)
                {
                    if (element.GetAttribute("data-value")==value)
                    {
                        element.Click();
                        countryIsPresent = true;
                    }
                }
            }
            catch (NoSuchElementException ex)
            {

            }

            return countryIsPresent;
        }

        private bool  SelectLanguage(String value)
        {
            bool languageIsPresent = false;
            try
            {
                IWebElement selecter = Browser.FindElement(By.Id("language"));
                selecter.Click();

                foreach (IWebElement element in selecter.FindElements(By.TagName("label")))
                {
                    if (element.Text.Equals(value))
                    {
                        element.Click();
                        languageIsPresent = true;
                    }
                }

                selecter.FindElement(By.LinkText("Apply")).Click();
            }
            catch (NoSuchElementException ex)
            {

            }
            return languageIsPresent;
        }

    }
}
