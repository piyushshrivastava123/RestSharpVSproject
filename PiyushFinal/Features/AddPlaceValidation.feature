Feature: Validating AddPlace API's Features
	

Scenario: Verify if place is being added successfully using AddPlace API

	Given Add Place payload with body
	| name   | phone_number  | address           | language |
	| Piyush | +919833621113 | R-16, Rishi Nagar | Hindi    |	
	When Perform POST operation for "/maps/api/place/add/json"
	Then The API Call got success with status code OK
	And "scope" in response is "APP"
