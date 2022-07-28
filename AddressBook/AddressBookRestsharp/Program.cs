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
 UC-24
Ability to Update Entry in Address Book JSONServer and sync with Address Book Application Memory 
- Use RESTSharp for REST Api Calls from MSTest Test Code

Standard Output: 
{
  "firstname": "Yash",
  "lastname": "V",
  "phoneNo": "7858070934",
  "address": "FC Real Madrid",
  "city": "Madrid",
  "state": "Spain",
  "zip": "535678",
  "email": "yash7@gmail.com",
  "id": 7
}
 */