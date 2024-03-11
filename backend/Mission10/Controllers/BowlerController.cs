using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission10.Models;

namespace Mission10.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlerRepository _bowlerRepository;

        public BowlerController(IBowlerRepository temp)
        {
            _bowlerRepository = temp;
        }

        [HttpGet]
        public IEnumerable<Bowler> GetBowlersForSelectedTeams()
        {
            var query = from bowler in _bowlerRepository.Bowlers
                        join team in _bowlerRepository.Teams
                        on bowler.TeamId equals team.TeamId
                        where team.TeamName == "Marlins" || team.TeamName == "Sharks"
                        select new Bowler
                        {
                            BowlerId = bowler.BowlerId,
                            BowlerLastName = bowler.BowlerLastName,
                            BowlerFirstName = bowler.BowlerFirstName,
                            BowlerMiddleInit = bowler.BowlerMiddleInit,
                            BowlerAddress = bowler.BowlerAddress,
                            BowlerCity = bowler.BowlerCity,
                            BowlerState = bowler.BowlerState,
                            BowlerZip = bowler.BowlerZip,
                            BowlerPhoneNumber = bowler.BowlerPhoneNumber,
                            Team = new Team
                            {
                                TeamId = team.TeamId,
                                TeamName = team.TeamName,
                            },
                        };

            var bowlerData = query.ToArray();

            return bowlerData;
        }


        //// Apply explicit JSON serialization settings
        //var jsonSettings = new JsonSerializerOptions
        //{
        //    ReferenceHandler = ReferenceHandler.Preserve,
        //    // Add any other settings as needed
        //};

        //var jsonResult = new ContentResult
        //{
        //    Content = JsonSerializer.Serialize(bowlerData, jsonSettings),
        //    ContentType = "application/json",
        //};



    }
}

