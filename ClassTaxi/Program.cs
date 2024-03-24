using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Taxi
{
    public string DriverName { get; set; }
    public bool OnDuty { get; set; }
    public int NumPassenger { get; set; }

    public void TaxiInfo()
    {
        Console.WriteLine("Driver Name: " + DriverName);
        Console.WriteLine("On Duty: " + (OnDuty ? "Yes" : "No"));
        Console.WriteLine("Number of Passenger: " + NumPassenger );
        Console.WriteLine("\n");
    }

    public void PickUpPassenger()
    {
        Console.WriteLine(DriverName + " sedang menjemput penumpang");
    }

    public void DropOffPassenger()
    {
        Console.WriteLine(DriverName + " selesai mengantar penumpang.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // membuat objek Taxi
        Taxi taxi = new Taxi();

        // pengesetan nilai properties
        taxi.DriverName = "5739_Arya Andrean Pratama";
        taxi.OnDuty = true;
        taxi.NumPassenger = 4;

        // pemanggilan method
        taxi.TaxiInfo();
        taxi.PickUpPassenger();
        taxi.DropOffPassenger();

        Console.ReadKey();
    }
}