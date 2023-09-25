using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowTask.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowTask.Pages
{
   
    public class LanguageAndSkillsPage : CommonDriver
    {

        //LANGUAGE SECTION------------------------

        //Adding New Language
        public void CreateLanguage(IWebDriver driver)
        {
            IWebElement addNewLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewLanguage.Click();
            IWebElement addLanguagetext = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addLanguagetext.SendKeys("Sinhala");
            Thread.Sleep(1000);
            IWebElement addLanguageLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]"));
            addLanguageLevel.Click();
            IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addButton.Click();
            Thread.Sleep(2000);
        }

        //Get the newly added language code
        public string GetLanguage(IWebDriver driver)
        {
            IWebElement newLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return newLanguage.Text;

        }

        //Addig multiple languages
        public void AddMultipleLanguage(IWebDriver driver, string language, string level)
        {
            IWebElement addNewLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewLanguage.Click();
            IWebElement addLanguagetext = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addLanguagetext.SendKeys(language);
            Thread.Sleep(1000);
            IWebElement addLanguageLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            addLanguageLevel.SendKeys(level);
            IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addButton.Click();
            Thread.Sleep(3000);
        }

        //Check disable adding button when adding no more than 4 languages
        public void CheckAddNewButtonPresent(IWebDriver driver)
        {
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            //Assert.That(addNewButton.Text == "Add New", "User can add no more than 4 records");
            bool element_displayed = addNewButton.Displayed;
            if (element_displayed)
            {
                Console.WriteLine("Language added successfully");
            }
            else
            {
                Console.WriteLine("Language not added successfully");
            }
            //Assert.IsFalse(element_displayed);
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
            Thread.Sleep(3000);
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]"));
            deleteButton.Click();
        }

        //Get deleted Language
        public string GetDeletedLanguage(IWebDriver driver)
        {
            Thread.Sleep(3000);
            IWebElement deletedLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            Assert.That(deletedLanguage.Text != "Italian", "Record hasn't been deleted.");
            return deletedLanguage.Text;
        }

        //Validate the cancel button in Language
        public void CancelAddingLanguage(IWebDriver driver, string language, string level)
        {
            IWebElement addNewLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewLanguage.Click();
            IWebElement addLanguagetext = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addLanguagetext.SendKeys(language);
            Thread.Sleep(1000);
            IWebElement addLanguageLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            addLanguageLevel.SendKeys(level);
            IWebElement cancelLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[2]"));
            cancelLanguage.Click();
        }

        public string CheckFields(IWebDriver driver)
        {
            IWebElement lastLanguageRecord = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));

            return lastLanguageRecord.Text;
        }

        //Add Language contains special characters
        public void AddSpecialCharactersLanguage(IWebDriver driver)
        {
            IWebElement addNewLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewLanguage.Click();
            IWebElement addLanguagetext = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addLanguagetext.SendKeys("Ngr3@3Fr$#et12");
            Thread.Sleep(1000);
            IWebElement addLanguageLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]"));
            addLanguageLevel.Click();
            IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addButton.Click();
            Thread.Sleep(4000);
        }

        public string GetSpecialCharacterLanguage(IWebDriver driver)
        {
            IWebElement SpecialCahrLang = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return SpecialCahrLang.Text;
        }

        public void AddSameLanguage(IWebDriver driver, string language, string level)
        {
            IWebElement addNewLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewLanguage.Click();
            IWebElement addLanguagetext = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addLanguagetext.SendKeys(language);
            Thread.Sleep(1000);
            IWebElement addLanguageLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            addLanguageLevel.SendKeys(level);
            IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addButton.Click();
            Thread.Sleep(3000);
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
            clickAddSkillText.SendKeys("Test Automation");

            IWebElement addSkillLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]"));
            addSkillLevel.Click();

            IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addButton.Click();

            Thread.Sleep(5000);
        }

        //Get newly added skills
        public string GetSkills(IWebDriver driver)
        {
            //IWebElement newSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            IWebElement newSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return newSkill.Text;
        }

        //Addig multiple languages
        public void CreateMultipleSkills(IWebDriver driver, string skill, string level)
        {
            IWebElement clickSkills = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            clickSkills.Click();
            Thread.Sleep(2000);

            IWebElement clickAddNew = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            clickAddNew.Click();

            IWebElement clickAddSkillText = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            clickAddSkillText.SendKeys(skill);

            Thread.Sleep(3000);
            if (level.Equals("Beginner"))
            {
                IWebElement addSkillLevel1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[2]"));
                addSkillLevel1.Click();
            }
            else if (level.Equals("Intermediate"))
            {
                IWebElement addSkillLevel2 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]"));
                addSkillLevel2.Click();
            }
            else
            {
                IWebElement addSkillLevel3 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[4]"));
                addSkillLevel3.Click();
            }


            IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addButton.Click();

            Thread.Sleep(5000);
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

        //Validate the cancel button in Skills
        public void CancelAddingSkill(IWebDriver driver, string skill, string level)
        {
            IWebElement clickSkillTab = driver.FindElement(By.XPath(" //*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            clickSkillTab.Click();
            IWebElement addNewSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewSkill.Click();
            IWebElement addSkilltext = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            addSkilltext.SendKeys(skill);
            Thread.Sleep(1000);
            IWebElement addSkillLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            addSkillLevel.SendKeys(level);
            IWebElement cancelSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[2]"));
            cancelSkill.Click();
        }

        public string CheckFieldsSkill(IWebDriver driver)
        {
            IWebElement lastSkillRecord = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return lastSkillRecord.Text;
        }

        internal void VerifySkillsListHaveNotChanged(IWebDriver driver, String skill, String level)
        {
            IWebElement rowsList = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr"));
            String text1 = rowsList.Text;
            if (text1.Contains(skill) && text1.Contains(level))
            {
                return;
            }
            else
            {
                throw new Exception();
            }
        }    
    }
}
