namespace RaceCorp.Web.ViewModels.Town
{
    using System.Collections.Generic;

    using RaceCorp.Data.Models;
    using RaceCorp.Services.Mapping;
    using RaceCorp.Web.ViewModels.Race;
    using RaceCorp.Web.ViewModels.Ride;

    public class TownRacesRidesViewModel : TownViewModel, IMapFrom<Town>
    {
        public IEnumerable<RaceIdNameViewModel> Races { get; set; }

        public IEnumerable<RideIdNameViewModel> Rides { get; set; }
    }
}
