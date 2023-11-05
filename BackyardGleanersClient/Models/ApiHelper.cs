using RestSharp;
using Microsoft.AspNetCore.Mvc;

namespace BackyardGleanersClient.Models;

public class ApiHelper : ControllerBase
{
  public static async Task<string> GetAll()
  {
    RestClient client = new RestClient("https://localhost:5003");
    RestRequest request = new RestRequest($"api/v2/gardeners", Method.Get);
    RestResponse response = await client.GetAsync(request);
    return response.Content;
  }
  public static async Task<string> Get(int id)
  {
    RestClient client = new RestClient("https://localhost:5003");
    RestRequest request = new RestRequest($"api/v2/gardeners/{id}", Method.Get);
    RestResponse response = await client.GetAsync(request);
    return response.Content;
  }

  public static async void Post(string newGardener)
  {
    RestClient client = new RestClient("https://localhost:5001");
    RestRequest request = new RestRequest($"api/v2/gardeners", Method.Post);
    request.AddHeader("Content-Type", "application/json");
    request.AddJsonBody(newGardener);
    await client.PostAsync(request);
  }

  public static async void Put(int id, string newGardener)
  {
    RestClient client = new RestClient("https://localhost:5001");
    RestRequest request = new RestRequest($"api/v2/gardeners/{id}", Method.Put);
    request.AddHeader("Content-Type", "application/json");
    request.AddJsonBody(newGardener);
    await client.PutAsync(request);
  }
  
  public static async void Delete(int id)
  {
    RestClient client = new RestClient("https://localhost:5001");
    RestRequest request = new RestRequest($"api/v2/gardeners/{id}", Method.Delete);
    request.AddHeader("Content-Type", "application/json");
    await client.DeleteAsync(request);
  }

  // custom api search method
  public static async Task<string> Search(string food, string location)
  {
    RestClient client = new RestClient("https://localhost:5001");
    RestRequest request = new RestRequest($"api/v2/gardeners/Search", Method.Get);
    request.AddParameter("food", food);
    request.AddParameter("location", location);
    RestResponse response = await client.ExecuteAsync(request);
    return response.Content;
  }
}
