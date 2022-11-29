Feature: New Item

A short summary of the feature
	@Items
Scenario: To verify the new item Map creation and its info creation
	Given I launch the application and click the file menu.
	When I click the Map from New item menu the item will be created
	And I enter the data for the item Map
	Then I verify the created item Map
	@Item
Scenario: To verify the new item creation and its info creation
	Given I launch the application and click the file menu.
	When I click the Newspaper from New item menu the item will be created
	And I enter the data for the item Newspaper
	Then I verify the created item Newspaper
	@Item	
Scenario: To verify the new item Patent creation and its info creation
	Given I launch the application and click the file menu.
	When I click the Patent from New item menu the item will be created
	And I enter the data for the item Patent
	Then I verify the created item Patent
	@Item
Scenario: To verify the new item Podcast creation and its info creation
	Given I launch the application and click the file menu.
	When I click the Podcast from New item menu the item will be created
	And I enter the data for the item Podcast 
	Then I verify the created item Podcast
	@Item
Scenario:Verifying the user should be able to create a Preprint    
    Given I launch the application and click the file menu
    When I click the Preprint in New item Menu
    And I enter the test Data
    Then I able to see the Preprint creation in the title panel and its info in table pane
	@Item
Scenario: Verifying the user should be able to create a Video Recording
    Given I am on the Zotero Application and click on the Video Recording
    When I enter the data for the item Video Recording
    Then I able to see the item video recording
	@Item
Scenario: Verifying the user should be able to create a TV Broadcast   
	Given I am on the Zotero Application and click on the TV Broadcast
	When I enter data inputs
	Then I need to see the item creation in pane
	@Item
Scenario:Verifing the user should be able to create  Thesis
    Given I am on the Zotero Application and click on the Thesis
    When I able to click the Thesis creation pannel and enter data
    Then I able to see the item created
	@Item
Scenario: To verify the new item Statute creation and its info creation
    Given I am on the Zotero Application and click on the statute   
    When I enter the data for the item Statute 
    Then I verify the created item Statute
	@Item
Scenario: To verify the new item Software creation and its info creation
    Given I am on the Zotero Application and click on the software  
    When I enter the data for the item Software
    Then I verify the created item Software
	@Item
Scenario: Verifing the user should be able to create Radiobroadcast
    Given I am on the Zotero Application and click on the RadioBroadcast
    When I enter the data for the item Radiobroadcast
    Then I verify the created item Radiobroadcast
	@Item
Scenario: Verifying the user should be able to create a Presentation  
    Given I am on the Zotero Application and click on the presentaion
    When I enter the data for the item Radiobroadcast
    Then I verify the created item Radiobroadcast