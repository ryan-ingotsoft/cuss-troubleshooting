// See https://aka.ms/new-console-template for more information

using Symend.Client.Customer.Api;
using Symend.Client.Customer.Model;

CustomerTrailApi cussTrail = new CustomerTrailApi("http://localhost:5000/customer/");
cussTrail.Configuration.DefaultHeaders.Add("xSymOrganizationId", "9f7bf606-bcca-4903-b339-b88f579512fe");
var result = await 
        cussTrail.GetCustomerEventsByAccountKeyAsync(
            Guid.NewGuid(), 
            "TEST-ACCOUNTKEY", 
            new GetCustomerEventsByAccountKeySearchParameterParameter(), 
            new GuidPagedMetadata{Limit = 1} 
        );

Console.Write($"Result: " + result.ToJson());