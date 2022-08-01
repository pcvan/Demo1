Feature: Verification
OralB application text verifaction
@mytag
Scenario: oralB1
Given load the oralB application
When u click on kid's brushes from dropdown
Then verify the text kid's is diplayed
@mytag1
Scenario Outline: oralB2
Given load the website
When click on search icon on the top right corner
And  type battery in searchbox "<text>"
And select first link
Then verify the text battery is dipalyed
Examples: 
| text    |
| battery |
@mytag
Scenario Outline: oralB3
Given load the web page
When click on floss under shop in footer
Then verify floss picks appearing in the list products
Then take a screen short

