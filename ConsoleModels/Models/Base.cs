using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleModels.Models
{
    public interface IBase 
    {
        public string LicenseID { get; set; }
        public byte[] Timestamp { get; set; }
    }
   
    public class Base : IBase
    {
        public string LicenseID { get; set; }
        public byte[] Timestamp { get; set; }
    }
}
