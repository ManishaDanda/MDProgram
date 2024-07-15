using System.ComponentModel.DataAnnotations;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

internal class Program
{
    private static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("http:/horse.industryconnect.io/");
        driver.Manage().Window.Maximize();
        IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
        usernameTextbox.SendKeys("hari");
        IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
        passwordTextbox.SendKeys("123123");
        IWebElement loginbutton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
        loginbutton.Click();
        IWebElement Hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
        if (Hellohari.Text == "Hello hari!") 
        {

            Console.WriteLine("user logged in successfully.test passed!");
        }
        else 
        {
            Console.WriteLine("User has not logged in.Test failed!");

        }

        IWebElement administrationTextbox = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
        administrationTextbox.Click();


        IWebElement timeAndMaterialTextbox = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
        timeAndMaterialTextbox.Click();


        IWebElement createNewTextbox = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
        createNewTextbox.Click();

        IWebElement typecode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/label"));
        typecode.Click();

        IWebElement typecodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
        typecodeDropdown.Click();

        IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1] "));
        timeOption.Click();

        IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
        codeTextbox.SendKeys("TA MDProgram");

        IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
        descriptionTextbox.SendKeys("This is the MDProgram  Description");

        IWebElement priceTagOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
        priceTagOverlap.Click();

        IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
        priceTextbox.SendKeys("20.50");

        IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
        saveButton.Click();
        Thread.Sleep(3000);

        IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
        goToLastPageButton.Click();
        Thread.Sleep(3000);

        IWebElement newcode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr/td[1]"));



            if (newcode.Text == "TA MDProgram")
        {
            Console.WriteLine("Time Record Created Successfully");

        }
        else
        {
            Console.WriteLine("New time has not been created");
        }
        //Create a edit Record

        //Click on edit Button
        IWebElement ClickEditButtton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr/td[5]/a[1]"));
        ClickEditButtton.Click();


        //Select time from the DropdownBox

        IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
        typeCodeDropdown.Click();

        IWebElement timeoption = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1] "));
        timeoption.Click();

        //Edit Code TextBox
        IWebElement EditCodeTextBox = driver.FindElement(By.Id("Code"));
        EditCodeTextBox.Clear();
        EditCodeTextBox.SendKeys("123");

        //Edit Description TextBox

        IWebElement EditDescriptionBox = driver.FindElement(By.Name("Description"));
        EditDescriptionBox.Clear();
        EditDescriptionBox.SendKeys("This Is manisha Description");

        //Edit Price TextBox
        IWebElement PriceTagOverLap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
        PriceTagOverLap.Clear();

        IWebElement EditPriceTextBox = driver.FindElement(By.XPath("//*[@id=\"Price\"]"));
        EditPriceTextBox.SendKeys("45.20");

        //Click On Save Button

        IWebElement saveButton1 = driver.FindElement(By.Id("SaveButton"));
        saveButton1.Click();

        //Check if time record Has been edited Succesfully
        IWebElement gotoLastPageEditButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
        gotoLastPageEditButton.Click();

        if (gotoLastPageEditButton.Text =="123")
        {
            Console.WriteLine("New time Record Successfully");
        }
        else
        {
            Console.WriteLine("New Time Record Has not been created");
        }











    }
} 