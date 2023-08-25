using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowTask.Pages
{
    internal class LanguageAndSkillsPage
    {
        //LANGUAGE SECTION------------------------

        //Adding New Language
        public void CreateLanguage(IWebDriver driver)
        {
            IWebElement addNewLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewLanguage.Click();
            IWebElement addLanguagetext = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addLanguagetext.SendKeys("Italian");
            Thread.Sleep(1000);
            IWebElement addLanguageLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]"));
            addLanguageLevel.Click();
            IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addButton.Click();
            Thread.Sleep(2000);
            //IWebElement newLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[3]/tr/td[1]"));

            //if (newLanguage.Text == "Italian")
            //{
            //    Console.WriteLine("Language added successfully");
            //}
            //else
            //{
            //    Console.WriteLine("Language not added successfully");
            //}

            Thread.Sleep(2000);
        }

        //Get the newly added language code
        public string GetLanguage(IWebDriver driver)
        {
            IWebElement newLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[3]/tr/td[1]"));
            return newLanguage.Text;

        }

        //Update a existing language
        public void UpdateLanguage(IWebDriver driver, string language)
        {
            //Edit Langauge

            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]"));
            editButton.Click();

            //edit and enter new values
            IWebElement editLanguageText = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
            editLanguageText.Clear();
            Thread.Sleep(2000);

            //adding the dynamic value parameter
            editLanguageText.SendKeys(language);

            IWebElement editLanguageLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select/option[4]"));
            editLanguageLevel.Click();
            IWebElement clickUpdateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));
            clickUpdateButton.Click();
        }

        //Get the newly edited language code
        public string GetEditedLanguage(IWebDriver driver)
        {
            Thread.Sleep(5000);
            //IWebElement editedLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select/option[4]"));
            IWebElement editedLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            
            return editedLanguage.Text;
        }

        //Delete Language record
        public void DeleteLanguage(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]"));
            deleteButton.Click();
        }

        //Get deleted Language
        public string GetDeletedLanguage(IWebDriver driver) {
            Thread.Sleep(3000);
            IWebElement deletedLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            Assert.That(deletedLanguage.Text != "Italian", "Record hasn't been deleted.");
            return deletedLanguage.Text;
        }   

        //SKILLS SECTION-------------------------------

        //Adding New Skill
        public void CreateSkill(IWebDriver driver)
        {
            IWebElement clickSkills = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            clickSkills.Click();
            Thread.Sleep(2000);

            IWebElement clickAddNew = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            clickAddNew.Click();

            IWebElement clickAddSkillText = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            clickAddSkillText.SendKeys("Software Testing");          

            IWebElement addSkillLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]"));
            addSkillLevel.Click();

            IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addButton.Click();

            Thread.Sleep(5000);
        }

        //Get newly added skills
        public string GetSkills(IWebDriver driver) { 
            //IWebElement newSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            IWebElement newSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            return newSkill.Text;
        }

        //Update a existing skill
        public void UpdateSkill(IWebDriver driver, string skill)
        {
            //Edit Skill
            IWebElement clickSkills = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            clickSkills.Click();
            Thread.Sleep(1000);

            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]"));
            editButton.Click();

            //edit and enter new values
            IWebElement editSkillText = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input"));
            editSkillText.Clear();
            Thread.Sleep(2000);

            //adding the dynamic value parameter
            editSkillText.SendKeys(skill);

            IWebElement editSkillLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select/option[3]"));
            editSkillLevel.Click();

            IWebElement clickUpdateButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));
            clickUpdateButton.Click();
            Thread.Sleep(2000);
        }

        //Get the newly edited skill code
        public string GetEditedSkill(IWebDriver driver)
        {
            IWebElement editedSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return editedSkill.Text;
        }

        //Delete Skill record
        public void DeleteSkill(IWebDriver driver)
        {
            //Click Skill
            IWebElement clickSkills = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            clickSkills.Click();
            Thread.Sleep(1000);

            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]"));
            deleteButton.Click();
            Thread.Sleep(1000);

        }

    }
}
