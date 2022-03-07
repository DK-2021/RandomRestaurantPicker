using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace MyDataModels
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
            using (var response = await client.SendAsync(request))
            {

                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Debug.WriteLine(body);
                try
                {
                    var data = JsonConvert.DeserializeObject<MyDataModels.Generated.Rootobject>(body);
                    //1. create a blank list of resterautns
                    List<MyDataModels.Generated.Rootobject> restaurantList = new List<Generated.Rootobject>();
                    //2. loop on data.daytum
                    foreach(var rest in data.data)
                    {
                        
                    }
                    //3. foreach data.ddytum create a new resteraunt and populate details from they daytum
                    //4. put into list
                    //5. save list into database using resterautns.AddRange
                    
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }


        }
    }

}