using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SpecFlowTask.Pages;
using SpecFlowTask.Utilities;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowTask.StepDefinitions
{
    [Binding]
    public class LangSkillStepDefinitions : CommonDriver
    {
        [Given(@"I logged into the website successfully and navigate to profile page")]
        public void GivenILoggedIntoTheWebsiteSuccessfullyAndNavigateToProfilePage()
        {
            driver = new ChromeDriver();

            //Login page object initialization and definition
            LoginAndJoinPage loginAndJoinPageObj = new LoginAndJoinPage();
            loginAndJoinPageObj.LoginSteps(driver);
        }

        [When(@"I add New Language to the Languages")]
        public void WhenIAddNewLanguageToTheLanguages()
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();
            lanAndSkillPageObj.CreateLanguage(driver);
        }

        [Then(@"The Language should be added successfully")]
        public void ThenTheLanguageShouldBeAddedSuccessfully()
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();

            string NewLanguage = lanAndSkillPageObj.GetLanguage(driver);
            Assert.That(lanAndSkillPageObj.GetLanguage(driver) == "Italian");
        }

        [When(@"I edit '([^']*)' in the language list")]
        public void WhenIEditInTheLanguageList(string language)
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();
            lanAndSkillPageObj.UpdateLanguage(driver, language);
        }

        [Then(@"'([^']*)' is updated successfully")]
        public void ThenIsUpdatedSuccessfully(string language)
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();
            string Newlanguage = lanAndSkillPageObj.GetEditedLanguage(driver);
        }

        [When(@"I delete a langugae in the language list")]
        public void WhenIDeleteALangugaeInTheLanguageList()
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();
            lanAndSkillPageObj.DeleteLanguage(driver);
        }

        [Then(@"The Language should be deleted")]
        public void ThenTheLanguageShouldBeDeleted()
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();
            lanAndSkillPageObj.GetDeletedLanguage(driver);
        }


        //skills Add modify and delete

        [When(@"I add New Skill to the Skills")]
        public void WhenIAddNewSkillToTheSkills()
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();
            lanAndSkillPageObj.CreateSkill(driver);
        }

        [Then(@"The Skill should be added successfully")]
        public void ThenTheSkillShouldBeAddedSuccessfully()
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();
            string newSkill = lanAndSkillPageObj.GetSkills(driver);
            Assert.That(lanAndSkillPageObj.GetSkills(driver) == "Software Testing");
        }

        [When(@"I edit '([^']*)' in the skills list")]
        public void WhenIEditInTheSkillsList(string level)
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();
            lanAndSkillPageObj.UpdateSkill(driver, level);
        }

        [Then(@"'([^']*)' is updated successfully in skill list")]
        public void ThenIsUpdatedSuccessfullyInSkillList(string skill)
        {
            LanguageAndSkillsPage lanAndSkillPageObj = new LanguageAndSkillsPage();
            string NewSkill = lanAndSkillPageObj.GetEditedLanguage(driver);
        }
    }
}
