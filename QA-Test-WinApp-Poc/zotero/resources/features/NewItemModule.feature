Feature: NewItemModule

A short summary of the feature

@NewItemArtwork 
Scenario: To verify the NewItemModule feature (Artwork)
	Given As a User i launch the zotero application and click file button in zotero homepage.
	When i click the new item .
	And i create a new artwork and enter the data
	Then I verify created artwork.

