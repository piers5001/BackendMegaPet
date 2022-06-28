using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BackendMegaPetTests.Steps;

[Binding]
public sealed class AdopterServiceStepDefinition
{
    // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

    private readonly ScenarioContext _scenarioContext;

    public AdopterServiceStepDefinition(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [Given("the first number is (.*)")]
    public void GivenTheFirstNumberIs(int number)
    {
        //TODO: implement arrange (precondition) logic
        // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata 
        // To use the multiline text or the table argument of the scenario,
        // additional string/Table parameters can be defined on the step definition
        // method. 

        _scenarioContext.Pending();
    }

    [Given("the second number is (.*)")]
    public void GivenTheSecondNumberIs(int number)
    {
        //TODO: implement arrange (precondition) logic
        // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata 
        // To use the multiline text or the table argument of the scenario,
        // additional string/Table parameters can be defined on the step definition
        // method. 

        _scenarioContext.Pending();
    }

    [When("the two numbers are added")]
    public void WhenTheTwoNumbersAreAdded()
    {
        //TODO: implement act (action) logic

        _scenarioContext.Pending();
    }

    [Then("the result should be (.*)")]
    public void ThenTheResultShouldBe(int result)
    {
        //TODO: implement assert (verification) logic

        _scenarioContext.Pending();
    }

    [When(@"a register Request is sent")]
    public void WhenARegisterRequestIsSent(Table table)
    {
        ScenarioContext.StepIsPending();
    }

    [Then(@"the adopter is included in the body of the response")]
    public void ThenTheAdopterIsIncludedInTheBodyOfTheResponse(Table table)
    {
        ScenarioContext.StepIsPending();
    }

    [Given(@"There is already an adopter with the same name")]
    public void GivenThereIsAlreadyAnAdopterWithTheSameName(Table table)
    {
        ScenarioContext.StepIsPending();
    }
}