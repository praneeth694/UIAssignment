Feature: Feature1

A short summary of the feature

@tag1
Scenario: This is a test to login to Labcorp and validate a Job Posting
	Given I go to LabCorp.com
	Then I click on Careers
	Then I search for a QA Job and Verify the Job details "Test Automation Engineer"
	Then I switch to the job posting and verify details
	Then I click on Home Page