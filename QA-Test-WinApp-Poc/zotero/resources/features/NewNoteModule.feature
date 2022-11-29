Feature: NewNoteModule

A short summary of the feature

@NewNoteModule 
Scenario: Verify whether the user should able to Create a New Note. 
	Given As a User i launch Zotero Application and click NewNote in FileMenu.
	When I enter the text in Zotero Note Editor.
	And I check the all buttons functionality present in zotero note editor.
	And I click the More Option.
	Then I verify the Edit Seperete Window.
