                                                                                                                                                                                                             using CollectionsTestsuite.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Actions = OpenQA.Selenium.Interactions.Actions;

namespace CollectionsTestsuite.Collections

{ 

        [TestFixture]
        public class Collections : Base.Base
    {

            private string sheet;
            [OneTimeSetUp]
            public void startBrowser()
            {

               
                _driver = SiteConnection();

            }
            public void SpoolerNavigation()
            {
                Delay(2);

            //click on digital stack 
            _driver.FindElement(By.Name("sv_Main")).Click();

            Delay(2);
            //job manager
            _driver.FindElement(By.Name("jm_Main")).Click();

            Delay(2);
            //job process
            _driver.FindElement(By.Name("jm_Proc")).Click();



            Delay(2);
            //job process
            _driver.FindElement(By.Name("jm_Processing_jmtjo")).Click();



            Delay(2);
            //Job reference
            _driver.FindElement(By.Name("fcJobReference")).SendKeys("Bank Import");
             
            //Template:	
            SelectElement Template = new SelectElement(_driver.FindElement(By.Name("fcTemplateObj")));
            Template.SelectByValue("184141614");

            //From Run Date:
            _driver.FindElement(By.Name("f")).SendKeys("");

            //Pick a datetime
            _driver.FindElement(By.Name("")).SendKeys("");

            //Schedule:	
            SelectElement Schedule = new SelectElement(_driver.FindElement(By.Name("")));
            Schedule.SelectByText("");

            //To Run Date:
            _driver.FindElement(By.Name("")).SendKeys("");

            //Pick a datetime
            _driver.FindElement(By.Name("")).SendKeys("");

            //Status:	
            SelectElement Status = new SelectElement(_driver.FindElement(By.Name("")));
            Status.SelectByText("");

            //User Code:	 
            _driver.FindElement(By.Name("")).SendKeys("");

            //Linked to Entity:	
            SelectElement Entity = new SelectElement(_driver.FindElement(By.Name("")));
            Entity.SelectByText("");

            //Run in Administration Mode:	
            SelectElement oSelect = new SelectElement(_driver.FindElement(By.Name("")));
            oSelect.SelectByText("");

            //View jobs from day(s) ago
            _driver.FindElement(By.Name("")).SendKeys("");


        }
            private void clickOnMainMenu()
            {
                try
                {
                    //find the contract search option
                    var search = _driver.FindElement(By.XPath("/html/body/center/center/form[3]/table/tbody/tr[2]/td[1]/table/tbody/tr/td/table/tbody/tr[1]/td/div[7]/table[4]/tbody/tr/td/a"));
                }
                catch
                {
                    //clickOnMainMenu
                    _driver.FindElement(By.Name("CBWeb")).Click();
                }
            }
        [Test, TestCaseSource("GetTestData", new object[] { "BankStatementImport" })]
        public void BankStatementImport(string BankStatementImport, string scenarioID)

        {

            if (String.IsNullOrEmpty(BankStatementImport))
            {
                Assert.Ignore();
            }

            string errMsg = String.Empty;
            string results = String.Empty;
            {

                SpoolerNavigation();

            }
        }

        [Test, TestCaseSource("GetTestData", new object[] { "CommercialFileImport" })]
        public void CommercialFileImport(string CommercialFileImport, string scenarioID)

        {

            if (String.IsNullOrEmpty(CommercialFileImport))
            {
                Assert.Ignore();
            }

            string errMsg = String.Empty;
            string results = String.Empty;
            {

                SpoolerNavigation();

            }
        }

        [Test, TestCaseSource("GetTestData", new object[] { "ReconcileTransactions" })]
        public void ReconcileTransactions(string ReconcileTransactions, string scenarioID)

        {

            if (String.IsNullOrEmpty(ReconcileTransactions))
            {
                Assert.Ignore();
            }

            string errMsg = String.Empty;
            string results = String.Empty;
            {

                SpoolerNavigation();

            }
        }

        [Test, TestCaseSource("GetTestData", new object[] { "BatchPostingJob" })]
        public void BatchPostingJob(string BatchPostingJob, string scenarioID)

        {

            if (String.IsNullOrEmpty(BatchPostingJob))
            {
                Assert.Ignore();
            }

            string errMsg = String.Empty;
            string results = String.Empty;
            {

                SpoolerNavigation();

            }
        }

        [Test, TestCaseSource("GetTestData", new object[] { "LaunchWorkflow" })]
        public void LaunchWorkflow(string LaunchWorkflow, string scenarioID)

        {

            if (String.IsNullOrEmpty(LaunchWorkflow))
            {
                Assert.Ignore();
            }

            string errMsg = String.Empty;
            string results = String.Empty;
            {

                SpoolerNavigation();

            }
        }



        [OneTimeTearDown]
            public void closeBrowser()
            {
                EmailReport();
                DisconnectBrowser();
            }
        }
    }                                                           
