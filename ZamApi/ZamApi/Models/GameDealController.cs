using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;
using System.Text.Json;

namespace ZamApi.Models
{
    public class GameDealController : Controller
    {

        [Route("api/getgame/{id}")]
        public async Task<string> getGame(string id)
        {
           if (id == "1")
            {
                GameDeal gameDeal = new GameDeal()
                {

                    title = "FirstGameDeal",
                    salePrice = "11",
                    normalPrice = "24",


                };
                return JsonSerializer.Serialize(gameDeal);
 
            }
            else
            {
                GameDeal gameDeal = new GameDeal()
                {

                    title = "TwoGameDeal",
                    salePrice = "21",
                    normalPrice = "32",


                };
                return JsonSerializer.Serialize(gameDeal);

            }

        }
    }
}
