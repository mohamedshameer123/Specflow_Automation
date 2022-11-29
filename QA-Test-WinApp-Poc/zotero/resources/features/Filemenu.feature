Feature: Filemenu

A short summary of the feature

@filemenu
Scenario: Verify the File menu options
	Given As a User i launch Zotero Application and click Import in FileMenu
	When I click on close the import window
	Then The import window should close
