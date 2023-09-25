Feature: LangSkill

As a user 
I would be able to add delete the languages and skills I know
So that the people seeking for skills and languages can look at what details I hold.

Scenario: Add new Language to Languages 
	Given I logged into the website successfully and navigate to profile page
	When  I add New Language to the Languages
	Then The Language should be added successfully


Scenario: Add multiple Language to Languages 
	Given I logged into the website successfully and navigate to profile page
	When  I add multiple '<Languages>' and '<Level>' to the Languages
	Then  I am able to see up to four languages in the list

Examples: 
| Languages | Level   |
| French    |  Basic  |
| Italian  |  Conversational |
| Spanish  |  Fluent |

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


Scenario: Add multiple Skill to Skills 
	Given I logged into the website successfully and navigate to profile page
	When  I add multiple '<Skills>' and '<Level>' to the Skills
	Then  I am able to see all the '<Skills>' and '<Level>' in the list

Examples: 
| Skills | Level   |
| Automation   |  Beginner  |
| Software Engineering  |  Intermediate |
| Critical Thinking  |  Expert |

Scenario Outline: Edit existing Skill
	Given I logged into the website successfully and navigate to profile page
	When I edit '<Skill>' in the skills list
	Then '<Skill>' is updated successfully in skill list

Examples: 
| Skill |
| Software Automation |

Scenario Outline: Cancel when adding new Language
	Given I logged into the website successfully and navigate to profile page
	When  I click add new '<Language>' and '<Level>' and I click cancel button
	Then I am able to see existing previously added languages

Examples: 
| Language | Level   |
| English  |  Basic  |

Scenario Outline: Cancel when adding new Skill
	Given I logged into the website successfully and navigate to profile page
	When  I click add new '<Skill>' and '<Level>' and I click cancel button in skill section
	Then I am able to see existing previously added skills

Examples: 
| Skill | Level  |
| Testing  |  Expert |

Scenario Outline: Add special characters and numbers when adding a language
	Given I logged into the website successfully and navigate to profile page
	When  I click add new to enter Language and Level contain special characters
	Then I am able to see existing previously added special character languages

Scenario Outline: Add same language to the language list
	Given I logged into the website successfully and navigate to profile page
	When  I add same '<Language>' and '<Level>' to the Languages
	Then  I am not able to see prevoisly added language in the list

Examples: 
| Language | Level   |
| Italian  |  Basic  |