Feature: Filemenu

A short summary of the feature

@filemenu
Scenario: Verify the File menu options
	Given As a User i launch Zotero Application and click Import in FileMenu
	When I click on close the import window
	Then The import window should close

@Sample1234
	Scenario:S1-Sample
	Given As a User i launch Zotero Application and click Import in FileMenu
	Then I Get Root


