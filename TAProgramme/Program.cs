using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class Program
{
    private static void Main(string[] args)
    {
        // Open Chrome Browser
        IWebDriver driver = new ChromeDriver();

        // Launch TurnUp portal
        driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
        driver.Manage().Window.Maximize();
        Thread.Sleep(1000);

        // Identify username textbox and enter valid username
        IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
        usernameTextbox.SendKeys("hari");
        

        // Identify password textbox and enter valid password
        IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
        passwordTextbox.SendKeys("123123");

        // Identify login buton and click on it
        IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
        loginButton.Click();
        Thread.Sleep(2000);

        // Check if user has logged in successfully
        IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

        if(helloHari.Text == "Hello hari!")
        {
            Console.WriteLine("User has logged in successfullly. Test passed!");
        }
        else
        {
            Console.WriteLine("User has not logged in. Test failed!");
        }

        // Create a Time record

        // Navigate to Time and Material Page
        IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
        administrationTab.Click();

        IWebElement timeAndMaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
        timeAndMaterialOption.Click();

        // Click on Create New Button
        IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
        createNewButton.Click();

        // Select Time from dropdown
        IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
        typeCodeDropdown.Click();

        IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
        timeOption.Click();

        // Type code into Code textbox
        IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
        codeTextbox.SendKeys("TA Programme");

        //Type description into Description textbox
        IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
        descriptionTextbox.SendKeys("This is a description");

        // Type price into Price textbox
        IWebElement priceTagOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
        priceTagOverlap.Click();
        
        IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
        priceTextbox.SendKeys("12");

        // Click on Save button
        IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
        saveButton.Click();
        Thread.Sleep(3000);

        // Check if Time record has been created successfully
        IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
        goToLastPageButton.Click();

        IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

        if(newCode.Text == "TA Programme")
        {
            Console.WriteLine("Time record created successfuly!");
        }
        else
        {
            Console.WriteLine("New time record has not been created!");
        }
    }
}