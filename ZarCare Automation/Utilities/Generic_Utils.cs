namespace ZarCare_Automation.Utilities
{
    public class Generic_Utils : WebdriverSession
    {
        public static void Initilize_Browser(string browser)
        {
            switch (browser)
            {
                case "chrome":

                   // new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver();
                    break;

                case "firefox":

                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    driver = new FirefoxDriver();
                    break;

                case "edge":

                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                    driver = new EdgeDriver();
                    break;
            }
        }

        public static void Initilize_URL(string environment, string urlType)
        {
            string url = Json_Reader.ReadJsonText(Generic_Utils.getDataPath("TestResources") + "\\URL.json")[environment][urlType].ToString();
            Generic_Utils.NavigateToURL(url);
            Wait.implicitWait(3);

        }

        public static string getDataPath(string foldername)
        {
            // Get the path of the current executing assembly
            string assemblyPath = Assembly.GetExecutingAssembly().Location;

            // Get the directory of the assembly
            string assemblyDirectory = Path.GetDirectoryName(assemblyPath);

            // Get the parent directory of the assembly directory (i.e. the project folder)
            string projectDirectory = Directory.GetParent(assemblyDirectory).Parent.Parent.FullName;

            // Combine the project directory path with the "data" folder name to get the "data" folder path
            string dataFolderPath = Path.Combine(projectDirectory, foldername);

            return dataFolderPath;
        }

        public static string GetScreenshot(string message)
        {
            // Take a screenshot
            Screenshot sc = ((ITakesScreenshot)driver).GetScreenshot();
            string screenshot = ((ITakesScreenshot)driver).GetScreenshot().AsBase64EncodedString;

            // Save the screenshot to a local file
            string screenshotPath = Path.Combine(Reports.screenshotFolderName, $"{DateTime.Now:HH-mm-ss}_screenshot.png");
            sc.SaveAsFile(screenshotPath);

            // Attach the screenshot to the Extent Report
            Reports.childLog.AddScreenCaptureFromPath(screenshotPath);

            Reports.childLog.Log(Status.Info, message, MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot).Build());

            return screenshotPath;
        }

        public static string CaptureFailScreenshot()
        {
            // Take a screenshot
            Screenshot sc = ((ITakesScreenshot)driver).GetScreenshot();

            // Save the screenshot to a local file
            string screenshotPath = Path.Combine(Reports.screenshotFolderName, $"{DateTime.Now:HH-mm-ss}_Test fail screenshot.png");
            sc.SaveAsFile(screenshotPath);

            return screenshotPath;
        }

        public static string CapturePassScreenshot()
        {
            // Take a screenshot
            Screenshot sc = ((ITakesScreenshot)driver).GetScreenshot();

            // Save the screenshot to a local file
            string screenshotPath = Path.Combine(Reports.screenshotFolderName, $"{DateTime.Now:HH-mm-ss}_Test pass screenshot.png");
            sc.SaveAsFile(screenshotPath);

            return screenshotPath;
        }

        public static void NavigateToURL(string url)
        {
            driver.Url = url;
        }

        public static void BrowserMaximize()
        {
            driver.Manage().Window.Maximize();
        }

        public static void BrowserMinimize()
        {
            driver.Manage().Window.Minimize();
        }

        public static void QuitDriver()
        {
            driver.Quit();
        }

        public static void CloseDriver()
        {
            driver.Close();
        }

        public static void RefreshPage(string url)
        {
            driver.Navigate().Refresh();
        }

        public static bool IsElementDisplayed(By locator)
        {
            try
            {
                return driver.FindElement(locator).Displayed;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void ScrollToBottom()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0, document.body.scrollHeight)");
        }

        public static void ScrollToElement(IWebElement element)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView()", element);
        }
        public static void ScrollToMidOfPage()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight / 2);");
        }

        public static void GetCurrentDate()
        {
            DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss").Trim();
        }


        public static string getTitle()
        {
            string Title = driver.Title;
            return Title;


        public static string getTitle()
        {
            return driver.Title;

        }

        public static string getText(IWebElement element)
        {
            return element.Text;
        }



        public static void winHandle()
        {
            var current_window = driver.CurrentWindowHandle;
            var all_windows = driver.WindowHandles;
            foreach (string windows in all_windows)
            {
                if (windows != current_window)
                {
                    driver.SwitchTo().Window(current_window);
                }
            }
        }

        public static void getUrl()
        {
            string url = driver.Url;
        }


        public static void Dropdown_Handle_With_Value(IWebElement element, string value)
        {
            SelectElement selectElement = new SelectElement(element);
            selectElement.SelectByValue(value);
        }


        public static void Dropdown_Handle_With_Index(IWebElement element, int value)
        {
            SelectElement selectElement = new SelectElement(element);
            selectElement.SelectByIndex(6);
        }

        public static void Dropdown_Handle_With_Text(IWebElement element, string value)
        {
            SelectElement selectElement = new SelectElement(element);
            selectElement.SelectByText(value);
        }

        protected static bool IsElementDisplayed(object by_Category_Title)
        {
            throw new NotImplementedException();

        public static void DropwoenHandle_with_text(IWebElement element, string text)
        {
            SelectElement selectElementtext = new SelectElement(element);
            selectElementtext.SelectByText(text);
        }
        public static void DropDownHandle_with_index(IWebElement element, int index)
        {
            SelectElement selectelementIndex = new SelectElement(element);
            selectelementIndex.SelectByIndex(index);

        }

    }

    public class Wait : WebdriverSession
    {
        public static void GenericWait(int milliseconds)
        {
            Thread.Sleep(milliseconds);
        }

        public static void implicitWait(int seconds)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
        }

        public static void WaitTillPageLoad()
        {
            WebDriverWait webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

            try
            {
                webDriverWait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void WaitForURLMatching(string url)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.UrlMatches(url));
        }

        public static void InvisibilityOfElementLocated(By locator, int second)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(second));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(locator));
        }

        public static void ElementIsVisible(By locator, int second)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(second));
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

       
    }
}
