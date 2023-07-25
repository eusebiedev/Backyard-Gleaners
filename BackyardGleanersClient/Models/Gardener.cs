using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BackyardGleanersClient.Models;

public class Gardener
{
  public int GardenerId { get; set; }
  public string Name { get; set; }
  public string Description { get; set; } 
  public string Food { get; set; }
  public string Availability {get; set; }
  public string Location { get; set; }
  public string Contact { get; set; }
  public string ProfilePic { get; set; }

  public static List<Gardener> GetGardeners()
  {
    var apiCallTask = ApiHelper.GetAll();
    var result = apiCallTask.Result;

    JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
    List<Gardener> gardenerList = JsonConvert.DeserializeObject<List<Gardener>>(jsonResponse.ToString());

    return gardenerList;
  }
  public static Gardener GetDetails(int id)
  {
    var apiCallTask = ApiHelper.Get(id);
    var result = apiCallTask.Result;

    JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
    Gardener gardener = JsonConvert.DeserializeObject<Gardener>(jsonResponse.ToString());

    return gardener;
  }
  public static void Post(Gardener gardener)
  {
    string jsonGardener = JsonConvert.SerializeObject(gardener);
    ApiHelper.Post(jsonGardener);
  }
  public static void Put(Gardener gardener)
  {
    string jsonGardener = JsonConvert.SerializeObject(gardener);
    ApiHelper.Put(gardener.GardenerId, jsonGardener);
  }
  public static void Delete(int id)
  {
    ApiHelper.Delete(id);
  }
}
