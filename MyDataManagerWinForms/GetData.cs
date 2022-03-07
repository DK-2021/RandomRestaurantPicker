using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using DataLibrary;
using MyDataModels;

namespace MyDataManagerWinForms
{
    public class GetData
    {
        public async Task GetDataAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://travel-advisor.p.rapidapi.com/restaurants/list?location_id=60742&restaurant_tagcategory=10591&restaurant_tagcategory_standalone=10591&currency=USD&lunit=km&limit=30&open_now=false&lang=en_US"),
                Headers =
    {
        { "x-rapidapi-host", "travel-advisor.p.rapidapi.com" },
        { "x-rapidapi-key", "3dd283b73amshe8582db180b1963p157daejsn717ed3e069f5" },
    },
            };

            var body = string.Empty;
            using (var response = await client.SendAsync(request))
            {

                response.EnsureSuccessStatusCode();
                body = await response.Content.ReadAsStringAsync();
                Debug.WriteLine(body);
            }
            try
            {
                var theirData = JsonConvert.DeserializeObject<MyDataModels.Generated.Rootobject>(body);
                using (var db = new DataDbContext(MainForm._optionsBuilder.Options))
                {
                    var theCuisine = db.Cuisines.SingleOrDefault(x => x.Type == "Unassigned");
                    var theConvenience = db.Conveniences.SingleOrDefault(x => x.Type == "Unassigned");
                    var allRest = db.Restaurants.Select(x => x.Name).ToList();

                    //1. create a blank list of resterautns
                    List<Restaurant> ourResty = new List<Restaurant>();
                    //2. loop on data.daytum
                    foreach (var item in theirData.data)
                    {
                        if(item.name == null)
                        {
                            continue;
                        }
                        var exists = allRest.Contains(item.name);
                        if (exists)
                        {
                            continue;
                        }
                        var price = item.price;


                        Restaurant localRest = new Restaurant();
                        localRest.Name = item.name;
                        localRest.Price = (int)Price.unknown;
                        if (price != null)
                        {
                            var index = price.LastIndexOf("$");
                            //price $15 - $60
                            // $150 - $6000
                            var amount = price.Substring(index + 1, price.Length - index - 1);
                            var success = int.TryParse(amount, out int actualPrice);
                            if (success)
                            {
                                localRest.Price = actualPrice >= 70 ? (int)Price.high : actualPrice >= 15 ? (int)Price.medium : (int)Price.low;
                            }

                        }
                        //localRest.Price = item.Price;
                        localRest.ConvenienceId = theConvenience?.Id ?? 4;
                        localRest.CuisineId = theCuisine?.Id ?? 6;
                        ourResty.Add(localRest);
                    }
                    //3. foreach data.ddytum create a new resteraunt and populate details from they daytum
                    //4. put into list
                    //5. save list into database using resterautns.AddRange
                    db.Restaurants.AddRange(ourResty); 
                    db.SaveChanges();

                }





            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            Debug.WriteLine("done");
        }


    }
}

