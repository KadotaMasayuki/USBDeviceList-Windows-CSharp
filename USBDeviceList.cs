using System;
using System.Collections.Generic;
using System.Management;

namespace ConsoleApplication1
{
    class USBDeviceList
    {
        static void Main(string[] args)
        {
            ManagementObjectCollection collection;
            using (var searcher = new ManagementObjectSearcher(@"Select * From Win32_USBHub"))
                collection = searcher.Get();
            foreach (var device in collection)
            {
                Console.WriteLine("Device ID: {0}, PNP Device ID: {1}, Description: {2}",
                    (string)device.GetPropertyValue("DeviceID"),
                    (string)device.GetPropertyValue("PNPDeviceID"),
                    (string)device.GetPropertyValue("Description")
                    );
            }
            collection.Dispose();
            Console.Read();
        }
    }
}
