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
 UC-22
Ability to Read Entries of Address Book from JSONServer
- Use RESTSharp for REST Api Calls from MSTest Test Code
- Update Address Book Memory of the Data retrieved from JSON Server

   Standard Output: 
Id: 1	FullName: Shivaraj Gowda	PhoneNo: 	Address: Basaveshwarnagar	City: Bangalore	State: Karnataka	Zip: 560079	Email: 4shivaraj.gowda@gmail.com
Id: 2	FullName: Cheluvesha Bettaswamy	PhoneNo: 	Address: Chinnaswamy	City: Bangalore	State: Karnataka	Zip: 354676	Email: cb97@gmail.com
Id: 3	FullName: Hema Latha	PhoneNo: 	Address: Chidambaram	City: Chennai	State: Tamil Nadu	Zip: 998765	Email: hema@gmail.com
Id: 4	FullName: Deepak Kumar	PhoneNo: 	Address: Eden Gardens	City: Kolkata	State: West Bengal	Zip: 115654	Email: DeepakKumar09@gmail.com
 */