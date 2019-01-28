using System;
using System.Net;
using System.Collections.Generic;
using System.IO;

namespace RelativityCapstone.Brain
{
    public class ImportCSVs
    {
        static void DownloadFiles()
        {

            WebClient wcA = new WebClient();
            WebClient wcR = new WebClient();
            Uri ourairportsAirports = new Uri("http://ourairports.com/data/airports.csv");
            Uri ourairportsRunways = new Uri("http://ourairports.com/data/runways.csv");
            wcA.DownloadFileAsync(ourairportsAirports, "airports.csv");
            wcR.DownloadFileAsync(ourairportsRunways, "runways.csv");
            PrepAirports();

        }
        public static string PrepAirports()
        {
            string airportsForDB = "";
            using (StreamReader readAirport = new StreamReader("airportsForDB.csv"))
            {
                string line;
                
            };
            return airportsForDB;

        }
    }
}