Feature: PetServiceTest
As a Developer
I want to add new Tutorial through API
In order to make it available for applications.

    Background:
        Given the Endpoint https://localhost:7070/swagger/index.html is available

    @tutorial-adding
    Scenario: Add a new pet with a single image
        When a Post Request is sent
          | name  | Description                                                           | image   |recuedTime   | category    |inventoryStatus          |rating |
          | Tyson | Tyson is a very happy dog who was rescued and is looking for a family |   URL   |  25         |    BABY     |        AVAILABLE        |   5    |
        Then A Response with Status 200 is received
        And a Tutorial Resource is included in Response Body
          | name  | Description                                                           | image |recuedTime |category |inventoryStatus   |rating |
          | Tyson | Tyson is a very happy dog who was rescued and is looking for a family |   URL |  25       |    BABY |        AVAILABLE |   5   |

    @tutorial-adding
    Scenario: Add a pet with existing Imgage
        Given There is already a pet with the same image
          | name  | Description                                                           | image |recuedTime |category |inventoryStatus   |rating |
          | Tyson | Tyson is a very happy dog who was rescued and is looking for a family |   URL |  25       |    BABY |        AVAILABLE |   5   |
        When a Post Request is sent
          | name  | Description                                                           | image |recuedTime |category |inventoryStatus   |rating |
          | Tyson | Tyson is a very happy dog who was rescued and is looking for a family |   URL |  25       |    BABY |        AVAILABLE |   5   |
        Then A Response with Status 400 is received
        And An Error Message with value "Pet image already exists." is returned