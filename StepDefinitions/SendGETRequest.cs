using TechTalk.SpecFlow;
using RestSharp;
using NUnit.Framework;

[Binding]
public class APITestSteps
{
    private RestClient client;
    private RestResponse response;
    private RestRequest request;

    [Given(@"I have the API endpoint ""(.*)""")]
    public void GivenIHaveTheAPIEndpoint(string endpoint)
    {
        client = new RestClient("https://api.agify.io/?name=meelad");
        request = new RestRequest(endpoint, Method.Get);
    }

    [When(@"I send a GET request")]
    public void WhenISendAGETRequest()
    {
        response = client.Execute(request);
    }

    [Then(@"the response status code should be 200")]
    public void ThenTheResponseStatusShouldBe()
    {
        var responseBody = response.Content;
        Assert.AreEqual(200, (int)response.StatusCode);
        Assert.IsTrue(responseBody.Contains("count"));
        Assert.IsTrue(responseBody.Contains("age"));
    }


}
