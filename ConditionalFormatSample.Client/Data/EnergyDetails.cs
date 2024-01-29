using System.Collections.Generic;

namespace ConditionalFormatSample
{
    public class EnergyDetails
    {
        public string Sector { get; set; }
        public int PowerUnits { get; set; }
        public double Revenue { get; set; }
        public string EnergyType { get; set; }
        public string EnergySource { get; set; }
        public string Year { get; set; }
        public string Quarter { get; set; }
        public string HalfYear { get; set; }

        public static List<EnergyDetails> GetEnergyDetails()
        {
            List<EnergyDetails> energyDetails = new List<EnergyDetails>();
            {
                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 46, Revenue = 43, Year = "FY 2015", Quarter = "Q1 FY 2015", HalfYear = "H1 FY 2015" });
                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 30, Revenue = 29, Year = "FY 2015", Quarter = "Q1 FY 2015", HalfYear = "H1 FY 2015" });
                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 125, Revenue = 96, Year = "FY 2015", Quarter = "Q1 FY 2015", HalfYear = "H1 FY 2015" });
                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 215, Revenue = 123, Year = "FY 2015", Quarter = "Q2 FY 2015", HalfYear = "H1 FY 2015" });
                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 263, Revenue = 125, Year = "FY 2015", Quarter = "Q2 FY 2015", HalfYear = "H1 FY 2015" });
                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 61, Revenue = 50, Year = "FY 2015", Quarter = "Q2 FY 2015", HalfYear = "H1 FY 2015" });
                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 20, Revenue = 31, Year = "FY 2015", Quarter = "Q3 FY 2015", HalfYear = "H2 FY 2015" });
                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 133, Revenue = 110, Year = "FY 2015", Quarter = "Q3 FY 2015", HalfYear = "H2 FY 2015" });
                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 33, Revenue = 65, Year = "FY 2015", Quarter = "Q3 FY 2015", HalfYear = "H2 FY 2015" });
                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 37, Revenue = 20, Year = "FY 2015", Quarter = "Q4 FY 2015", HalfYear = "H2 FY 2015" });
                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 109, Revenue = 96, Year = "FY 2015", Quarter = "Q4 FY 2015", HalfYear = "H2 FY 2015" });
                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 266, Revenue = 139, Year = "FY 2015", Quarter = "Q4 FY 2015", HalfYear = "H2 FY 2015" });
                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 257, Revenue = 143, Year = "FY 2016", Quarter = "Q1 FY 2016", HalfYear = "H1 FY 2016" });
                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 79, Revenue = 53, Year = "FY 2016", Quarter = "Q1 FY 2016", HalfYear = "H1 FY 2016" });
                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 28, Revenue = 48, Year = "FY 2016", Quarter = "Q1 FY 2016", HalfYear = "H1 FY 2016" });
                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 128, Revenue = 117, Year = "FY 2016", Quarter = "Q2 FY 2016", HalfYear = "H1 FY 2016" });
                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 68, Revenue = 48, Year = "FY 2016", Quarter = "Q2 FY 2016", HalfYear = "H1 FY 2016" });
                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 26, Revenue = 32, Year = "FY 2016", Quarter = "Q2 FY 2016", HalfYear = "H1 FY 2016" });
                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 141, Revenue = 98, Year = "FY 2016", Quarter = "Q3 FY 2016", HalfYear = "H2 FY 2016" });
                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 281, Revenue = 134, Year = "FY 2016", Quarter = "Q3 FY 2016", HalfYear = "H2 FY 2016" });
                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 228, Revenue = 107, Year = "FY 2016", Quarter = "Q3 FY 2016", HalfYear = "H2 FY 2016" });
                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 73, Revenue = 49, Year = "FY 2016", Quarter = "Q4 FY 2016", HalfYear = "H2 FY 2016" });
                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 19, Revenue = 44, Year = "FY 2016", Quarter = "Q4 FY 2016", HalfYear = "H2 FY 2016" });
                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 149, Revenue = 82, Year = "FY 2016", Quarter = "Q4 FY 2016", HalfYear = "H2 FY 2016" });
                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 47, Revenue = 58, Year = "FY 2017", Quarter = "Q1 FY 2017", HalfYear = "H1 FY 2017" });
                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 25, Revenue = 40, Year = "FY 2017", Quarter = "Q1 FY 2017", HalfYear = "H1 FY 2017" });
                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 127, Revenue = 93, Year = "FY 2017", Quarter = "Q1 FY 2017", HalfYear = "H1 FY 2017" });
                

                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 216, Revenue = 124, Year = "FY 2017", Quarter = "Q2 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 267, Revenue = 100, Year = "FY 2017", Quarter = "Q2 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 52, Revenue = 65, Year = "FY 2017", Quarter = "Q2 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 39, Revenue = 33, Year = "FY 2017", Quarter = "Q3 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 142, Revenue = 97, Year = "FY 2017", Quarter = "Q3 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 53, Revenue = 49, Year = "FY 2017", Quarter = "Q3 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 23, Revenue = 44, Year = "FY 2017", Quarter = "Q4 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 113, Revenue = 106, Year = "FY 2017", Quarter = "Q4 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 270, Revenue = 101, Year = "FY 2017", Quarter = "Q4 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 284, Revenue = 105, Year = "FY 2018", Quarter = "Q1 FY 2018", HalfYear = "H1 FY 2018" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 62, Revenue = 43, Year = "FY 2018", Quarter = "Q1 FY 2018", HalfYear = "H1 FY 2018" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 32, Revenue = 26, Year = "FY 2015", Quarter = "Q1 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 133, Revenue = 83, Year = "FY 2015", Quarter = "Q1 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 51, Revenue = 65, Year = "FY 2015", Quarter = "Q1 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 13, Revenue = 25, Year = "FY 2015", Quarter = "Q2 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 139, Revenue = 101, Year = "FY 2015", Quarter = "Q2 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 297, Revenue = 130, Year = "FY 2015", Quarter = "Q2 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 236, Revenue = 119, Year = "FY 2015", Quarter = "Q3 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 57, Revenue = 66, Year = "FY 2015", Quarter = "Q3 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 16, Revenue = 27, Year = "FY 2015", Quarter = "Q3 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 110, Revenue = 93, Year = "FY 2015", Quarter = "Q4 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 55, Revenue = 49, Year = "FY 2015", Quarter = "Q4 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 32, Revenue = 39, Year = "FY 2015", Quarter = "Q4 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 128, Revenue = 120, Year = "FY 2016", Quarter = "Q1 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 290, Revenue = 128, Year = "FY 2016", Quarter = "Q1 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 201, Revenue = 105, Year = "FY 2016", Quarter = "Q1 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 55, Revenue = 46, Year = "FY 2016", Quarter = "Q2 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 20, Revenue = 37, Year = "FY 2016", Quarter = "Q2 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 122, Revenue = 118, Year = "FY 2016", Quarter = "Q2 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 69, Revenue = 54, Year = "FY 2016", Quarter = "Q3 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 21, Revenue = 41, Year = "FY 2016", Quarter = "Q3 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 140, Revenue = 83, Year = "FY 2016", Quarter = "Q3 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 239, Revenue = 121, Year = "FY 2016", Quarter = "Q4 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 283, Revenue = 127, Year = "FY 2016", Quarter = "Q4 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 80, Revenue = 40, Year = "FY 2016", Quarter = "Q4 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 33, Revenue = 40, Year = "FY 2017", Quarter = "Q1 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 120, Revenue = 81, Year = "FY 2017", Quarter = "Q1 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 41, Revenue = 69, Year = "FY 2017", Quarter = "Q1 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 14, Revenue = 21, Year = "FY 2017", Quarter = "Q2 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 144, Revenue = 93, Year = "FY 2017", Quarter = "Q2 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 294, Revenue = 146, Year = "FY 2017", Quarter = "Q2 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 217, Revenue = 103, Year = "FY 2017", Quarter = "Q3 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 49, Revenue = 44, Year = "FY 2017", Quarter = "Q3 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 36, Revenue = 21, Year = "FY 2017", Quarter = "Q3 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 118, Revenue = 115, Year = "FY 2017", Quarter = "Q4 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 56, Revenue = 41, Year = "FY 2017", Quarter = "Q4 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 17, Revenue = 36, Year = "FY 2017", Quarter = "Q4 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 140, Revenue = 81, Year = "FY 2018", Quarter = "Q1 FY 2018", HalfYear = "H1 FY 2018" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 274, Revenue = 109, Year = "FY 2018", Quarter = "Q1 FY 2018", HalfYear = "H1 FY 2018" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 284, Revenue = 145, Year = "FY 2015", Quarter = "Q1 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 40, Revenue = 49, Year = "FY 2015", Quarter = "Q1 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 12, Revenue = 28, Year = "FY 2015", Quarter = "Q1 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 150, Revenue = 115, Year = "FY 2015", Quarter = "Q2 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 73, Revenue = 64, Year = "FY 2015", Quarter = "Q2 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 23, Revenue = 47, Year = "FY 2015", Quarter = "Q2 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 102, Revenue = 112, Year = "FY 2015", Quarter = "Q3 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 252, Revenue = 112, Year = "FY 2015", Quarter = "Q3 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 222, Revenue = 131, Year = "FY 2015", Quarter = "Q3 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 52, Revenue = 46, Year = "FY 2015", Quarter = "Q4 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 35, Revenue = 30, Year = "FY 2015", Quarter = "Q4 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 104, Revenue = 101, Year = "FY 2015", Quarter = "Q4 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 46, Revenue = 40, Year = "FY 2016", Quarter = "Q1 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 19, Revenue = 31, Year = "FY 2016", Quarter = "Q1 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 118, Revenue = 89, Year = "FY 2016", Quarter = "Q1 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 227, Revenue = 130, Year = "FY 2016", Quarter = "Q2 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 226, Revenue = 144, Year = "FY 2016", Quarter = "Q2 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 40, Revenue = 52, Year = "FY 2016", Quarter = "Q2 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 19, Revenue = 40, Year = "FY 2016", Quarter = "Q3 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 127, Revenue = 91, Year = "FY 2016", Quarter = "Q3 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 70, Revenue = 66, Year = "FY 2016", Quarter = "Q3 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 36, Revenue = 21, Year = "FY 2016", Quarter = "Q4 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 144, Revenue = 85, Year = "FY 2016", Quarter = "Q4 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 212, Revenue = 130, Year = "FY 2016", Quarter = "Q4 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 210, Revenue = 110, Year = "FY 2017", Quarter = "Q1 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 72, Revenue = 56, Year = "FY 2017", Quarter = "Q1 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 13, Revenue = 47, Year = "FY 2017", Quarter = "Q1 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 139, Revenue = 98, Year = "FY 2017", Quarter = "Q2 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 59, Revenue = 54, Year = "FY 2017", Quarter = "Q2 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 26, Revenue = 21, Year = "FY 2017", Quarter = "Q2 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 120, Revenue = 97, Year = "FY 2017", Quarter = "Q3 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 299, Revenue = 124, Year = "FY 2017", Quarter = "Q3 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 240, Revenue = 110, Year = "FY 2017", Quarter = "Q3 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 71, Revenue = 61, Year = "FY 2017", Quarter = "Q4 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 40, Revenue = 33, Year = "FY 2017", Quarter = "Q4 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 134, Revenue = 111, Year = "FY 2017", Quarter = "Q4 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 33, Revenue = 50, Year = "FY 2018", Quarter = "Q1 FY 2018", HalfYear = "H1 FY 2018" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 18, Revenue = 25, Year = "FY 2018", Quarter = "Q1 FY 2018", HalfYear = "H1 FY 2018" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 139, Revenue = 85, Year = "FY 2015", Quarter = "Q1 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 217, Revenue = 141, Year = "FY 2015", Quarter = "Q1 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 252, Revenue = 101, Year = "FY 2015", Quarter = "Q1 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 31, Revenue = 42, Year = "FY 2015", Quarter = "Q2 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 15, Revenue = 27, Year = "FY 2015", Quarter = "Q2 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 117, Revenue = 112, Year = "FY 2015", Quarter = "Q2 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 34, Revenue = 40, Year = "FY 2015", Quarter = "Q3 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 10, Revenue = 43, Year = "FY 2015", Quarter = "Q3 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 110, Revenue = 83, Year = "FY 2015", Quarter = "Q3 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 212, Revenue = 137, Year = "FY 2015", Quarter = "Q4 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 222, Revenue = 126, Year = "FY 2015", Quarter = "Q4 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 75, Revenue = 49, Year = "FY 2015", Quarter = "Q4 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 31, Revenue = 37, Year = "FY 2016", Quarter = "Q1 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 105, Revenue = 98, Year = "FY 2016", Quarter = "Q1 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 72, Revenue = 45, Year = "FY 2016", Quarter = "Q1 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 20, Revenue = 45, Year = "FY 2016", Quarter = "Q2 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 143, Revenue = 92, Year = "FY 2016", Quarter = "Q2 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 272, Revenue = 128, Year = "FY 2016", Quarter = "Q2 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 208, Revenue = 136, Year = "FY 2016", Quarter = "Q3 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 48, Revenue = 46, Year = "FY 2016", Quarter = "Q3 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 22, Revenue = 27, Year = "FY 2016", Quarter = "Q3 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 150, Revenue = 100, Year = "FY 2016", Quarter = "Q4 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 60, Revenue = 43, Year = "FY 2016", Quarter = "Q4 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 15, Revenue = 27, Year = "FY 2016", Quarter = "Q4 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 107, Revenue = 97, Year = "FY 2017", Quarter = "Q1 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 204, Revenue = 136, Year = "FY 2017", Quarter = "Q1 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 210, Revenue = 111, Year = "FY 2017", Quarter = "Q1 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 65, Revenue = 47, Year = "FY 2017", Quarter = "Q2 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 26, Revenue = 45, Year = "FY 2017", Quarter = "Q2 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 112, Revenue = 115, Year = "FY 2017", Quarter = "Q2 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 54, Revenue = 66, Year = "FY 2017", Quarter = "Q3 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 31, Revenue = 36, Year = "FY 2017", Quarter = "Q3 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 120, Revenue = 112, Year = "FY 2017", Quarter = "Q3 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 261, Revenue = 149, Year = "FY 2017", Quarter = "Q4 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 226, Revenue = 124, Year = "FY 2017", Quarter = "Q4 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 72, Revenue = 63, Year = "FY 2017", Quarter = "Q4 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 35, Revenue = 33, Year = "FY 2018", Quarter = "Q1 FY 2018", HalfYear = "H1 FY 2018" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 144, Revenue = 118, Year = "FY 2018", Quarter = "Q1 FY 2018", HalfYear = "H1 FY 2018" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 293, Revenue = 118, Year = "FY 2015", Quarter = "Q1 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 237, Revenue = 110, Year = "FY 2015", Quarter = "Q1 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 36, Revenue = 50, Year = "FY 2015", Quarter = "Q1 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 20, Revenue = 36, Year = "FY 2015", Quarter = "Q2 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 120, Revenue = 95, Year = "FY 2015", Quarter = "Q2 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 46, Revenue = 59, Year = "FY 2015", Quarter = "Q2 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 31, Revenue = 33, Year = "FY 2015", Quarter = "Q3 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 147, Revenue = 96, Year = "FY 2015", Quarter = "Q3 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 230, Revenue = 100, Year = "FY 2015", Quarter = "Q3 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 236, Revenue = 104, Year = "FY 2015", Quarter = "Q4 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 60, Revenue = 57, Year = "FY 2015", Quarter = "Q4 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 33, Revenue = 41, Year = "FY 2015", Quarter = "Q4 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 140, Revenue = 105, Year = "FY 2016", Quarter = "Q1 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 31, Revenue = 55, Year = "FY 2016", Quarter = "Q1 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 20, Revenue = 30, Year = "FY 2016", Quarter = "Q1 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 117, Revenue = 106, Year = "FY 2016", Quarter = "Q2 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 259, Revenue = 127, Year = "FY 2016", Quarter = "Q2 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 294, Revenue = 126, Year = "FY 2016", Quarter = "Q2 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 51, Revenue = 63, Year = "FY 2016", Quarter = "Q3 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 21, Revenue = 45, Year = "FY 2016", Quarter = "Q3 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 102, Revenue = 108, Year = "FY 2016", Quarter = "Q3 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 77, Revenue = 64, Year = "FY 2016", Quarter = "Q4 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 29, Revenue = 26, Year = "FY 2016", Quarter = "Q4 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 140, Revenue = 88, Year = "FY 2016", Quarter = "Q4 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 244, Revenue = 144, Year = "FY 2017", Quarter = "Q1 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 213, Revenue = 127, Year = "FY 2017", Quarter = "Q1 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 69, Revenue = 40, Year = "FY 2017", Quarter = "Q1 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 30, Revenue = 33, Year = "FY 2017", Quarter = "Q2 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 116, Revenue = 103, Year = "FY 2017", Quarter = "Q2 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 79, Revenue = 47, Year = "FY 2017", Quarter = "Q2 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 29, Revenue = 37, Year = "FY 2017", Quarter = "Q3 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 116, Revenue = 96, Year = "FY 2017", Quarter = "Q3 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 295, Revenue = 108, Year = "FY 2017", Quarter = "Q3 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 225, Revenue = 127, Year = "FY 2017", Quarter = "Q4 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 35, Revenue = 57, Year = "FY 2017", Quarter = "Q4 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 37, Revenue = 49, Year = "FY 2017", Quarter = "Q4 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 138, Revenue = 118, Year = "FY 2018", Quarter = "Q1 FY 2018", HalfYear = "H1 FY 2018" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 80, Revenue = 47, Year = "FY 2018", Quarter = "Q1 FY 2018", HalfYear = "H1 FY 2018" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 22, Revenue = 42, Year = "FY 2015", Quarter = "Q1 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 131, Revenue = 91, Year = "FY 2015", Quarter = "Q1 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 240, Revenue = 115, Year = "FY 2015", Quarter = "Q1 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 275, Revenue = 109, Year = "FY 2015", Quarter = "Q2 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 46, Revenue = 42, Year = "FY 2015", Quarter = "Q2 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 40, Revenue = 43, Year = "FY 2015", Quarter = "Q2 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 112, Revenue = 105, Year = "FY 2015", Quarter = "Q3 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 35, Revenue = 40, Year = "FY 2015", Quarter = "Q3 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 22, Revenue = 31, Year = "FY 2015", Quarter = "Q3 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 119, Revenue = 87, Year = "FY 2015", Quarter = "Q4 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 298, Revenue = 148, Year = "FY 2015", Quarter = "Q4 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 200, Revenue = 107, Year = "FY 2015", Quarter = "Q4 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 30, Revenue = 42, Year = "FY 2016", Quarter = "Q1 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 22, Revenue = 49, Year = "FY 2016", Quarter = "Q1 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 148, Revenue = 88, Year = "FY 2016", Quarter = "Q1 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 37, Revenue = 49, Year = "FY 2016", Quarter = "Q2 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 23, Revenue = 29, Year = "FY 2016", Quarter = "Q2 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 130, Revenue = 102, Year = "FY 2016", Quarter = "Q2 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 281, Revenue = 129, Year = "FY 2016", Quarter = "Q3 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 228, Revenue = 113, Year = "FY 2016", Quarter = "Q3 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 80, Revenue = 60, Year = "FY 2016", Quarter = "Q3 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 39, Revenue = 27, Year = "FY 2016", Quarter = "Q4 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 119, Revenue = 93, Year = "FY 2016", Quarter = "Q4 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 42, Revenue = 46, Year = "FY 2016", Quarter = "Q4 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 18, Revenue = 37, Year = "FY 2017", Quarter = "Q1 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 126, Revenue = 96, Year = "FY 2017", Quarter = "Q1 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 222, Revenue = 150, Year = "FY 2017", Quarter = "Q1 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 228, Revenue = 105, Year = "FY 2017", Quarter = "Q2 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 54, Revenue = 49, Year = "FY 2017", Quarter = "Q2 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 16, Revenue = 33, Year = "FY 2017", Quarter = "Q2 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 145, Revenue = 110, Year = "FY 2017", Quarter = "Q3 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 35, Revenue = 41, Year = "FY 2017", Quarter = "Q3 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 16, Revenue = 38, Year = "FY 2017", Quarter = "Q3 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 118, Revenue = 114, Year = "FY 2017", Quarter = "Q4 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 241, Revenue = 110, Year = "FY 2017", Quarter = "Q4 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 281, Revenue = 136, Year = "FY 2017", Quarter = "Q4 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 50, Revenue = 66, Year = "FY 2018", Quarter = "Q1 FY 2018", HalfYear = "H1 FY 2018" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 23, Revenue = 26, Year = "FY 2018", Quarter = "Q1 FY 2018", HalfYear = "H1 FY 2018" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 129, Revenue = 98, Year = "FY 2015", Quarter = "Q1 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 78, Revenue = 53, Year = "FY 2015", Quarter = "Q1 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 28, Revenue = 31, Year = "FY 2015", Quarter = "Q1 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 147, Revenue = 120, Year = "FY 2015", Quarter = "Q2 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 240, Revenue = 100, Year = "FY 2015", Quarter = "Q2 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 232, Revenue = 116, Year = "FY 2015", Quarter = "Q2 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 33, Revenue = 49, Year = "FY 2015", Quarter = "Q3 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 18, Revenue = 36, Year = "FY 2015", Quarter = "Q3 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 114, Revenue = 113, Year = "FY 2015", Quarter = "Q3 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 52, Revenue = 63, Year = "FY 2015", Quarter = "Q4 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 31, Revenue = 25, Year = "FY 2015", Quarter = "Q4 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 129, Revenue = 88, Year = "FY 2015", Quarter = "Q4 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 263, Revenue = 111, Year = "FY 2016", Quarter = "Q1 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 241, Revenue = 105, Year = "FY 2016", Quarter = "Q1 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 55, Revenue = 60, Year = "FY 2016", Quarter = "Q1 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 13, Revenue = 30, Year = "FY 2016", Quarter = "Q2 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 134, Revenue = 107, Year = "FY 2016", Quarter = "Q2 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Hydro-electric", PowerUnits = 33, Revenue = 69, Year = "FY 2016", Quarter = "Q2 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Geo-thermal", PowerUnits = 20, Revenue = 31, Year = "FY 2016", Quarter = "Q3 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Free Energy", EnergySource = "Solar", PowerUnits = 146, Revenue = 109, Year = "FY 2016", Quarter = "Q3 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Free Energy", EnergySource = "Wind", PowerUnits = 241, Revenue = 107, Year = "FY 2016", Quarter = "Q3 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Wood", PowerUnits = 10, Revenue = 30, Year = "FY 2016", Quarter = "Q4 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Wastage", PowerUnits = 38, Revenue = 65, Year = "FY 2016", Quarter = "Q4 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Ethanol Fuel", PowerUnits = 6, Revenue = 24, Year = "FY 2016", Quarter = "Q4 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Bio-diesel", PowerUnits = 72, Revenue = 86, Year = "FY 2017", Quarter = "Q1 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Wastage", PowerUnits = 13, Revenue = 20, Year = "FY 2017", Quarter = "Q2 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Ethanol Fuel", PowerUnits = 34, Revenue = 54, Year = "FY 2017", Quarter = "Q2 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Bio-diesel", PowerUnits = 5, Revenue = 20, Year = "FY 2017", Quarter = "Q2 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Wood", PowerUnits = 12, Revenue = 26, Year = "FY 2017", Quarter = "Q3 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Wastage", PowerUnits = 48, Revenue = 57, Year = "FY 2017", Quarter = "Q3 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Ethanol Fuel", PowerUnits = 8, Revenue = 29, Year = "FY 2017", Quarter = "Q4 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Bio-diesel", PowerUnits = 61, Revenue = 97, Year = "FY 2017", Quarter = "Q4 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Wastage", PowerUnits = 19, Revenue = 29, Year = "FY 2018", Quarter = "Q1 FY 2018", HalfYear = "H1 FY 2018" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Ethanol Fuel", PowerUnits = 40, Revenue = 47, Year = "FY 2015", Quarter = "Q1 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Bio-diesel", PowerUnits = 7, Revenue = 27, Year = "FY 2015", Quarter = "Q1 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Wood", PowerUnits = 20, Revenue = 24, Year = "FY 2015", Quarter = "Q2 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Wastage", PowerUnits = 45, Revenue = 42, Year = "FY 2015", Quarter = "Q2 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Ethanol Fuel", PowerUnits = 4, Revenue = 25, Year = "FY 2015", Quarter = "Q2 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Bio-diesel", PowerUnits = 72, Revenue = 82, Year = "FY 2015", Quarter = "Q3 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Wastage", PowerUnits = 19, Revenue = 29, Year = "FY 2015", Quarter = "Q4 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Ethanol Fuel", PowerUnits = 32, Revenue = 42, Year = "FY 2015", Quarter = "Q4 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Bio-diesel", PowerUnits = 5, Revenue = 20, Year = "FY 2015", Quarter = "Q4 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Wood", PowerUnits = 20, Revenue = 25, Year = "FY 2016", Quarter = "Q1 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Wastage", PowerUnits = 43, Revenue = 66, Year = "FY 2016", Quarter = "Q1 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Ethanol Fuel", PowerUnits = 8, Revenue = 26, Year = "FY 2016", Quarter = "Q2 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Bio-diesel", PowerUnits = 86, Revenue = 87, Year = "FY 2016", Quarter = "Q2 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Wastage", PowerUnits = 16, Revenue = 22, Year = "FY 2016", Quarter = "Q3 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Ethanol Fuel", PowerUnits = 43, Revenue = 54, Year = "FY 2016", Quarter = "Q3 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Bio-diesel", PowerUnits = 6, Revenue = 22, Year = "FY 2016", Quarter = "Q4 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Wood", PowerUnits = 15, Revenue = 20, Year = "FY 2016", Quarter = "Q4 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Wastage", PowerUnits = 40, Revenue = 55, Year = "FY 2017", Quarter = "Q1 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Ethanol Fuel", PowerUnits = 3, Revenue = 24, Year = "FY 2017", Quarter = "Q1 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Bio-diesel", PowerUnits = 60, Revenue = 87, Year = "FY 2017", Quarter = "Q1 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Wastage", PowerUnits = 12, Revenue = 29, Year = "FY 2017", Quarter = "Q2 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Ethanol Fuel", PowerUnits = 37, Revenue = 50, Year = "FY 2017", Quarter = "Q3 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Bio-diesel", PowerUnits = 3, Revenue = 20, Year = "FY 2017", Quarter = "Q3 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Wood", PowerUnits = 17, Revenue = 21, Year = "FY 2017", Quarter = "Q4 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Wastage", PowerUnits = 38, Revenue = 53, Year = "FY 2017", Quarter = "Q4 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Ethanol Fuel", PowerUnits = 8, Revenue = 27, Year = "FY 2017", Quarter = "Q4 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Bio-diesel", PowerUnits = 88, Revenue = 92, Year = "FY 2018", Quarter = "Q1 FY 2018", HalfYear = "H1 FY 2018" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Wastage", PowerUnits = 14, Revenue = 22, Year = "FY 2015", Quarter = "Q1 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Ethanol Fuel", PowerUnits = 31, Revenue = 69, Year = "FY 2015", Quarter = "Q1 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Bio-diesel", PowerUnits = 2, Revenue = 22, Year = "FY 2015", Quarter = "Q2 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Wood", PowerUnits = 16, Revenue = 29, Year = "FY 2015", Quarter = "Q2 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Wastage", PowerUnits = 35, Revenue = 54, Year = "FY 2015", Quarter = "Q3 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Ethanol Fuel", PowerUnits = 7, Revenue = 24, Year = "FY 2015", Quarter = "Q3 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Bio-diesel", PowerUnits = 79, Revenue = 82, Year = "FY 2015", Quarter = "Q3 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Wastage", PowerUnits = 10, Revenue = 29, Year = "FY 2015", Quarter = "Q4 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Ethanol Fuel", PowerUnits = 50, Revenue = 65, Year = "FY 2016", Quarter = "Q1 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Bio-diesel", PowerUnits = 5, Revenue = 25, Year = "FY 2016", Quarter = "Q1 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Wood", PowerUnits = 17, Revenue = 28, Year = "FY 2016", Quarter = "Q2 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Wastage", PowerUnits = 46, Revenue = 54, Year = "FY 2016", Quarter = "Q2 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Ethanol Fuel", PowerUnits = 7, Revenue = 27, Year = "FY 2016", Quarter = "Q2 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Bio-diesel", PowerUnits = 63, Revenue = 84, Year = "FY 2016", Quarter = "Q3 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Wastage", PowerUnits = 19, Revenue = 28, Year = "FY 2016", Quarter = "Q4 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Ethanol Fuel", PowerUnits = 47, Revenue = 52, Year = "FY 2016", Quarter = "Q4 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Bio-diesel", PowerUnits = 8, Revenue = 23, Year = "FY 2016", Quarter = "Q4 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Wood", PowerUnits = 20, Revenue = 28, Year = "FY 2017", Quarter = "Q1 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Wastage", PowerUnits = 40, Revenue = 55, Year = "FY 2017", Quarter = "Q1 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Ethanol Fuel", PowerUnits = 7, Revenue = 27, Year = "FY 2017", Quarter = "Q2 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Bio-diesel", PowerUnits = 67, Revenue = 88, Year = "FY 2017", Quarter = "Q2 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Wastage", PowerUnits = 20, Revenue = 29, Year = "FY 2017", Quarter = "Q3 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Ethanol Fuel", PowerUnits = 38, Revenue = 61, Year = "FY 2017", Quarter = "Q3 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Bio-diesel", PowerUnits = 7, Revenue = 21, Year = "FY 2017", Quarter = "Q4 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Wood", PowerUnits = 11, Revenue = 26, Year = "FY 2017", Quarter = "Q4 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Wastage", PowerUnits = 36, Revenue = 60, Year = "FY 2018", Quarter = "Q1 FY 2018", HalfYear = "H1 FY 2018" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Ethanol Fuel", PowerUnits = 2, Revenue = 24, Year = "FY 2018", Quarter = "Q1 FY 2018", HalfYear = "H1 FY 2018" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Bio-diesel", PowerUnits = 83, Revenue = 90, Year = "FY 2015", Quarter = "Q1 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Wastage", PowerUnits = 11, Revenue = 27, Year = "FY 2015", Quarter = "Q2 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Ethanol Fuel", PowerUnits = 49, Revenue = 42, Year = "FY 2015", Quarter = "Q2 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Bio-diesel", PowerUnits = 7, Revenue = 28, Year = "FY 2015", Quarter = "Q2 FY 2015", HalfYear = "H1 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Wood", PowerUnits = 13, Revenue = 25, Year = "FY 2015", Quarter = "Q3 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Wastage", PowerUnits = 30, Revenue = 49, Year = "FY 2015", Quarter = "Q3 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Ethanol Fuel", PowerUnits = 4, Revenue = 26, Year = "FY 2015", Quarter = "Q4 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Bio-diesel", PowerUnits = 76, Revenue = 87, Year = "FY 2015", Quarter = "Q4 FY 2015", HalfYear = "H2 FY 2015" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Wastage", PowerUnits = 19, Revenue = 27, Year = "FY 2016", Quarter = "Q1 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Ethanol Fuel", PowerUnits = 45, Revenue = 55, Year = "FY 2016", Quarter = "Q1 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Bio-diesel", PowerUnits = 1, Revenue = 23, Year = "FY 2016", Quarter = "Q2 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Wood", PowerUnits = 20, Revenue = 23, Year = "FY 2016", Quarter = "Q2 FY 2016", HalfYear = "H1 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Wastage", PowerUnits = 34, Revenue = 51, Year = "FY 2016", Quarter = "Q3 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Ethanol Fuel", PowerUnits = 3, Revenue = 28, Year = "FY 2016", Quarter = "Q3 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Bio-diesel", PowerUnits = 85, Revenue = 80, Year = "FY 2016", Quarter = "Q3 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Wastage", PowerUnits = 20, Revenue = 22, Year = "FY 2016", Quarter = "Q4 FY 2016", HalfYear = "H2 FY 2016" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Ethanol Fuel", PowerUnits = 40, Revenue = 51, Year = "FY 2017", Quarter = "Q1 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Bio-diesel", PowerUnits = 7, Revenue = 25, Year = "FY 2017", Quarter = "Q1 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Wood", PowerUnits = 15, Revenue = 21, Year = "FY 2017", Quarter = "Q2 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Wastage", PowerUnits = 36, Revenue = 41, Year = "FY 2017", Quarter = "Q2 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Ethanol Fuel", PowerUnits = 1, Revenue = 27, Year = "FY 2017", Quarter = "Q2 FY 2017", HalfYear = "H1 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Bio-diesel", PowerUnits = 79, Revenue = 93, Year = "FY 2017", Quarter = "Q3 FY 2017", HalfYear = "H2 FY 2017" });


                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Wastage", PowerUnits = 11, Revenue = 28, Year = "FY 2017", Quarter = "Q4 FY 2017", HalfYear = "H2 FY 2017" });
                energyDetails.Add(new EnergyDetails { Sector = "Public Sector", EnergyType = "Biomass", EnergySource = "Ethanol Fuel", PowerUnits = 41, Revenue = 51, Year = "FY 2017", Quarter = "Q4 FY 2017", HalfYear = "H2 FY 2017" });
                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Bio-diesel", PowerUnits = 8, Revenue = 28, Year = "FY 2017", Quarter = "Q4 FY 2017", HalfYear = "H2 FY 2017" });
                energyDetails.Add(new EnergyDetails { Sector = "Private Sector", EnergyType = "Biomass", EnergySource = "Wood", PowerUnits = 20, Revenue = 23, Year = "FY 2018", Quarter = "Q1 FY 2018", HalfYear = "H1 FY 2018" });

                return energyDetails;
            }
        }
    }
}
