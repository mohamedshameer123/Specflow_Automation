Feature: PrePrint

A short summary of the feature

@PrePrint
Scenario:Verifying the user should be able to create a Preprint    
    Given I launch the application and click the file menu
    When I click the Preprint in New item menu
    And I enter the test data
    Then I able to see the Preprint creation in the title panel and its info in tablepane

