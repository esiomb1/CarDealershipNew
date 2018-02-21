using System;
namespace CarClassLibrary
{
    public class clsCustomer
    {
        public clsCustomer()
        {
        }

        public bool Active { get;  set; }
        public string Address { get;  set; }
        public int CustomerID { get;  set; }
        public DateTime DateAdded { get;  set; }
        public string EmailAddress { get;  set; }
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public string PhoneNumber { get;  set; }
        public string PostCode { get;  set; }

        public bool Valid(string SomeCustomer)
        {
            //boolean flag to indictate that all is ok();
            Boolean OK = true;
            //if the name of the county is blank
            if (SomeCustomer == "")
            {
                //flag an error
                OK = false;
            }

            //if the name of the customer is more than 50 characters
            if (SomeCustomer.Length > 50)
            {
                //flag an error
                OK = false;
            }
            return OK;
        }
    }
}