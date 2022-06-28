Feature: UserServiceTest
As a Developer
I want to add new Tutorial through API
In order to make it available for applications.

    Background:
        Given the Endpoint https://localhost:7070/swagger/index.html is available

    @tutorial-adding
    Scenario: An user is added who is not yet registered
        When a register Request is sent
          | name  | lastname | phone      |email                         | image |password |birthday |
          | Piero | Palomino |  922569385 |  ppalominocalderon@gmail.com | URL   | Password123 | 05/05/2001 |
        Then A Response with Status 200 is received
        And the user is included in the body of the response
          | name  | lastname | phone      |email                         | image |password     |birthday    |
          | Piero | Palomino |  922569385 |  ppalominocalderon@gmail.com | URL   | Password123 | 05/05/2001 |
          
    @tutorial-adding
    Scenario: Add user who is already registered is added
        Given There is already an user with the same email
          | name  | lastname | phone      |email                         | image |password     |birthday    |
          | Piero | Palomino |  922569385 |  ppalominocalderon@gmail.com | URL   | Password123 | 05/05/2001 | 
        When a Post Request is sent
          | name  | lastname | phone      |email                         | image |password     |birthday    |
          | Piero | Palomino |  922569385 |  ppalominocalderon@gmail.com | URL   | Password123 | 05/05/2001 |
        Then A Response with Status 400 is received
        And An Error Message with value "This user already exists." is returned