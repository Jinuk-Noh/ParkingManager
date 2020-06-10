using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace 주차관리_프로그램_연습
{
    class DataManager
    {
        public static List<Car> Cars = new List<Car>();
        static DataManager()
        {
            Load();
        }

        public static void Load()
        {

            //public int parkingSpot { get; set; }
            //public string carNumber { get; set; }
            //public string dirverName { get; set; }
            //public string phoneNumber { get; set; }
            //public DateTime parkingTime { get; set; }

            try
            {
                string carinputout = File.ReadAllText(@"./Cars.xml");
                XElement xElement = XElement.Parse(carinputout);
                Cars = (from item in xElement.Descendants("car")
                        select new Car()
                        {
                            parkingSpot = int.Parse(item.Element("parkingSpot").Value),
                            carNumber = item.Element("carNumber").Value,
                            driverName = item.Element("driverName").Value,
                            phoneNumber = item.Element("phoneNumber").Value,
                            parkingTime = item.Element("parkingTime").Value == "" ? new DateTime() : DateTime.Parse(item.Element("parkingTime").Value)
                        }).ToList<Car>();
            }
            catch
            {
                Save1();
                Save();
            }

        }

        public static void Save()
        {
            string carinputout = "";
            carinputout += "<cars>\n";
            foreach (var item in Cars)
            {
                carinputout += "<car>\n";
                carinputout += "<parkingSpot>" + item.parkingSpot + "</parkingSpot>\n";
                carinputout += "<carNumber>" + item.carNumber + "</carNumber>\n";
                carinputout += "<driverName>" + item.driverName + "</driverName>\n";
                carinputout += "<phoneNumber>" + item.phoneNumber + "</phoneNumber>\n";
                carinputout += "<parkingTime>" + item.parkingTime + "</parkingTime>\n";
                carinputout += "</car>\n";
            }
            carinputout += "</cars>";

            File.WriteAllText(@".\Cars.xml", carinputout);
            Load();
        }

        public static void Save1()
        {
            string carinputout = "";
            carinputout += "<cars>\n";
            for (int i = 1; i <= 5; i++)
            {
                carinputout += "<car>\n";
                carinputout += "<parkingSpot>" + i + "</parkingSpot>\n";
                carinputout += "<carNumber></carNumber>\n";
                carinputout += "<driverName></driverName>\n";
                carinputout += "<phoneNumber></phoneNumber>\n";
                carinputout += "<parkingTime></parkingTime>\n";
                carinputout += "</car>\n";
            }
            carinputout += "</cars>";

            using (StreamWriter writer = new StreamWriter(@".\Cars.xml", true))
            {
                writer.WriteLine(carinputout);
            }
            Load();
        }

        public static void addParkingSpot()
        {
            string carinputout = "";
            carinputout += "<cars>\n";
            foreach (var item in Cars)
            {
                carinputout += "<car>\n";
                carinputout += "<parkingSpot>" + item.parkingSpot + "</parkingSpot>\n";
                carinputout += "<carNumber>" + item.carNumber + "</carNumber>\n";
                carinputout += "<driverName>" + item.driverName + "</driverName>\n";
                carinputout += "<phoneNumber>" + item.phoneNumber + "</phoneNumber>\n";
                carinputout += "<parkingTime>" + item.parkingTime + "</parkingTime>\n";
                carinputout += "</car>\n";
            }
            carinputout += "<car>\n";
            carinputout += "<parkingSpot>"+ (Cars.Count+1) +"</parkingSpot>\n";
            carinputout += "<carNumber></carNumber>\n";
            carinputout += "<driverName></driverName>\n";
            carinputout += "<phoneNumber></phoneNumber>\n";
            carinputout += "<parkingTime></parkingTime>\n";
            carinputout += "</car>\n";
            carinputout += "</cars>";

            File.WriteAllText(@".\Cars.xml", carinputout);
            Load();
              
        }

        public static void deleteParkingSpot()
        {
            string carinputout = "";
            carinputout += "<cars>\n";
            for (int i = 1; i < Cars.Count; i++)
            {
                carinputout += "<car>\n";
                carinputout += "<parkingSpot>" + i + "</parkingSpot>\n";
                carinputout += "<carNumber>"+ Cars[i-1].carNumber+"</carNumber>\n";
                carinputout += "<driverName>"+ Cars[i-1].driverName+ "</driverName>\n";
                carinputout += "<phoneNumber>"+ Cars[i-1].phoneNumber+ "</phoneNumber>\n";
                carinputout += "<parkingTime>"+ Cars[i-1].parkingTime+"</parkingTime>\n";
                carinputout += "</car>\n";
            }
            carinputout += "</cars>";

            File.WriteAllText(@".\Cars.xml", carinputout);
            Load();
        }
    }
}
     
