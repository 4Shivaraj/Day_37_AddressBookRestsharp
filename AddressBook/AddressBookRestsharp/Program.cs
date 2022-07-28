using System;

namespace AddressBookRestSharp
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Address Book Using RestSharp!");
        }
    }
}

/*
 UC-23
Ability to Add Multiple Entries to Address Book JSONServer and sync with Address Book Application Memory 
- Use RESTSharp for REST Api Calls from MSTest Test Code

Standard Output: 
{
  "firstname": "Arun",
  "lastname": "R",
  "phoneNumber": "9577456345",
  "address": "Feroz Shah Kotla",
  "city": "New Delhi",
  "state": "New Delhi",
  "zip": "547677",
  "email": "vs@gmail.com",
  "id": 5
}
{
  "firstname": "Ankitha",
  "lastname": "H",
  "phoneNumber": "9756723456",
  "address": "Chinnaswamy",
  "city": "Bangalore",
  "state": "Karnataka",
  "zip": "435627",
  "email": "yc@gmail.com",
  "id": 6
}
{
  "firstname": "Yash",
  "lastname": "V",
  "phoneNumber": "9954564345",
  "address": "Mohali",
  "city": "Mohali",
  "state": "Punjab",
  "zip": "113425",
  "email": "klr@gmail.com",
  "id": 7
}
 */