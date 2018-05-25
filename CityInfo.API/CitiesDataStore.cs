using System;
using System.Collections.Generic;
using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities;
        public CitiesDataStore()
        {
            Cities = new List<CityDto>(){
                new CityDto(){
                    id = 1,
                    Name = "New York City",
                    Description = "The one with Big Park",
                    PointOfInterest = new List<PointOfInterestDto>(){
                        new PointOfInterestDto(){
                            id = 1,
                            Name = "Central Park",
                            Description = "Most visited Park"
                        },
                        new PointOfInterestDto(){
                            id = 2,
                            Name = "Empire State Building",
                            Description = "A 102 Skyscrapper"
                        }
                    }
                },
                new CityDto(){
                    id = 2,
                    Name = "Antwerp",
                    Description = "The one with cathedral that was never finished",
                    PointOfInterest = new List<PointOfInterestDto>(){

                        new PointOfInterestDto(){
                            id = 1,
                            Name = "Central Park",
                            Description = "Most visited Park"
                        },
                        new PointOfInterestDto(){
                            id = 2,
                            Name = "Empire State Building",
                            Description = "A 102 Skyscrapper"
                        }
                    }
                },
                new CityDto(){
                    id = 3,
                    Name = "Pairs",
                    Description = "The one with Effiel Tower",
                    PointOfInterest = new List<PointOfInterestDto>(){

                        new PointOfInterestDto(){
                            id = 1,
                            Name = "Central Park",
                            Description = "Most visited Park"
                        },
                        new PointOfInterestDto(){
                            id = 2,
                            Name = "Empire State Building",
                            Description = "A 102 Skyscrapper"
                        }
                    }
                 }
            };
        }      
    }
}
