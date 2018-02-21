using System;

namespace CarClassLibrary
{
    public class clsMaintenance
    {
        public bool Active { get; set; }
        public int Cost { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public bool Repair { get; set; }

        public bool Valid(string Description,string Cost, string MntDate)
        {
            bool OK = true;
            if (Description == "")
            {
                OK = false;
            }
            return OK;
        }

     
    }
}