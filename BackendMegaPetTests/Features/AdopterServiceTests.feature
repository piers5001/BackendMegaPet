Feature: AdopterServiceTest
As a Developer
I want to add new Tutorial through API
In order to make it available for applications.

    Background:
        Given the Endpoint https://localhost:7070/swagger/index.html is available

    @tutorial-adding
    Scenario: An adopter is added who is not yet registered
        When a register Request is sent
          | name  | lastname | gender |age | status |description   |
          | Piero | Palomino |  Maculino |  25       |   Soltero  |  Soy un chico amante de los animales|
        Then A Response with Status 200 is received
        And the adopter is included in the body of the response
          | name  | lastname | gender    |age  | status    |description                           |
          | Piero | Palomino |  Maculino |  25 |   Soltero |  Soy un chico amante de los animales |
          
    @tutorial-adding
    Scenario: Add adopter who is already registered is added
        Given There is already an adopter with the same name
          | name  | lastname | gender    |age        | status    |description                           |
          | Piero | Palomino |  Maculino |  25       |   Soltero |  Soy un chico amante de los animales |
          When a Post Request is sent
            | name  | lastname | gender    |age  | status    |description                           |
            | Piero | Palomino |  Maculino |  25 |   Soltero |  Soy un chico amante de los animales |
        Then A Response with Status 400 is received
        And An Error Message with value "This adopter already exists." is returned