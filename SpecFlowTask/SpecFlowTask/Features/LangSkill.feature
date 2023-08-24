Feature: LangSkill

As a user 
I would be able to add delete the languages and skills I know
So that the people seeking for skills and languages can look at what details I hold.

Scenario: Add new Language to Languages 
	Given I logged into the website successfully and navigate to profile page
	When  I add New Language to the Languages
	Then The Language should be added successfully


Scenario Outline: Edit existing language
	Given I logged into the website successfully and navigate to profile page
	When I edit '<Language>' in the language list
	Then '<Language>' is updated successfully

Examples: 
| Language |
| Italian  |
| French   | 

Scenario: Delete exisiting language
Given I logged into the website successfully and navigate to profile page
When I delete a langugae in the language list
Then The Language should be deleted


Scenario: Add new Skill to Skills 
Given I logged into the website successfully and navigate to profile page
When  I add New Skill to the Skills
Then The Skill should be added successfully

Scenario Outline: Edit existing Skill
	Given I logged into the website successfully and navigate to profile page
	When I edit '<Skill>' in the skills list
	Then '<Skill>' is updated successfully in skill list

Examples: 
| Skill |
| Software Testing |
| Automation Testing | 