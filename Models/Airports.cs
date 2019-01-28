using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace RelativityCapstone.Models
{

    public class Runway
    {
        public int id { get; set; }
        [Required]
        public int airportId { get; set; }
        [ForeignKey("airportId")]
        public Airport airport { get; set; }
        public int headingDeg { get; set; }
        public int beg_lat { get; set; }
        public int beg_lon { get; set; }
        public int end_lat { get; set; }
        public int end_lon { get; set; }
    }
    public class Airport
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
        public string iata_code { get; set; }
        public string name { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public int secheduledService { get; set; }
        public ICollection<Runway> runways { get; set; }
        public ICollection<WeatherForecast> weatherForecasts { get; set; }
        public ICollection<WeatherCurrent> currentWeathers { get; set; }
    }
    public class WeatherForecast
    {
        public int id { get; set; }
        [Required]
        public int airportId { get; set; }
        [ForeignKey("airportId")]
        public Airport airport { get; set; }
        public string type { get; set; }
        public string desc { get; set; }
        public byte[] icon { get; set; }
        public int min_temp { get; set; }
        public int max_temp { get; set; }
        public int humidity { get; set; }
        public int windSpeed { get; set; }
        public int windDeg { get; set; }
        public DateTime time { get; set; }
    }
    public class WeatherCurrent
    {
        public int id { get; set; }
        [Required]
        public int airportId { get; set; }
        [ForeignKey("airportId")]
        public Airport airport { get; set; }
        public string type { get; set; }
        public string desc { get; set; }
        public byte[] icon { get; set; }
        public int temp { get; set; }
        public int humidity { get; set; }
        public int windSpeed { get; set; }
        public int windDeg { get; set; }
        public DateTime time { get; set; }
        
    }


}