Feature: Testing API endpoints

    As a tester
    I want to verify the status code with two included properties of an API endpoint

  Scenario: Verify status code of API endpoint
    Given I have the API endpoint "https://api.agify.io/?name=meelad"
    When I send a GET request
    Then the response status code should be 200
