﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Edit_Details
{
    public class CreateContacts
    {
        public static List<PersonalDetails> Person = new List<PersonalDetails>();
        public static void PersonInformations()
        {
            PersonalDetails contacts = new PersonalDetails();
            Console.Write("Enter First Name:   ");
            contacts.firstName = Console.ReadLine();
            Console.Write("Enter Last Name:   ");
            contacts.lastName = Console.ReadLine();
            Console.Write("Enter Address:   ");
            contacts.address = Console.ReadLine();
            Console.Write("Enter City Name:   ");
            contacts.city = Console.ReadLine();
            Console.Write("Enter State Name:   ");
            contacts.state = Console.ReadLine();
            Console.Write("Enter ZipCode:   ");
            contacts.zipcode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Phone Number:   ");
            contacts.phonenumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Email Id:   ");
            contacts.email = Console.ReadLine();
            Person.Add(contacts);
        }
        public static void DisplayHelp()
        {
            Console.Clear();
            Console.WriteLine("Enter only Available Commands are :");
            Console.WriteLine("add => \tAdds a person to address book");
            Console.WriteLine("edit => \tEdit a person to address book by first name");
            Console.WriteLine("remove => \tRemoves a person from address book");
            Console.WriteLine("list => \tLists out all people in the address book");
            Console.WriteLine("Press \tAny key to continue");
            Console.WriteLine("\n");
        }
        public static void PrintPerson(PersonalDetails contact)
        {
            Console.WriteLine("First Name: " + contact.firstName);
            Console.WriteLine("Last Name: " + contact.lastName);
            Console.WriteLine("Address : " + contact.address);
            Console.WriteLine("State : " + contact.state);
            Console.WriteLine("Zip Code : " + contact.zipcode);
            Console.WriteLine("Phone Number: " + contact.phonenumber);
            Console.WriteLine("Email Id : " + contact.email);
            Console.WriteLine("-------------------------------------------");
        }
        public static void EditOfDetails()
        {
            Console.WriteLine("Enter First Name: ");
            string name = Console.ReadLine();
            foreach (var data in Person)
            {
                if (Person.Contains(data))
                {
                    if (data.firstName == name)
                    {
                        Console.WriteLine("To edit contacts enter\n 1.FirstName\n 2.LastName\n 3.Address\n 4.City\n 5.State\n 6.Zipcode\n 7.PhoneNumber\n");
                        int option = Convert.ToInt32(Console.ReadLine());

                        switch (option)
                        {
                            case 1:
                                Console.WriteLine("Enter New First Name : ");
                                string firstName = Console.ReadLine();
                                data.firstName = firstName;
                                break;
                            case 2:
                                Console.WriteLine("Enter New Last Name : ");
                                string lastName = Console.ReadLine();
                                data.lastName = lastName;
                                break;
                            case 3:
                                Console.WriteLine("Enter New Address : ");
                                string address = Console.ReadLine();
                                data.address = address;
                                break;
                            case 4:
                                Console.WriteLine("Enter City : ");
                                string city = Console.ReadLine();
                                data.city = city;
                                break;
                            case 5:
                                Console.WriteLine("Enter New State : ");
                                string state = Console.ReadLine();
                                data.state = state;
                                break;
                            case 6:
                                Console.WriteLine("Enter New Zip Code : ");
                                int zipCode = Convert.ToInt32(Console.ReadLine());
                                data.zipcode = zipCode;                             
                                break;
                            case 7:
                                Console.WriteLine("Enter New Phone Number : ");
                                int phonenumber = Convert.ToInt32(Console.ReadLine());
                                data.phonenumber = phonenumber;
                                break;
                            default:
                                Console.WriteLine("Select Valid option ");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Name does not match");
                    }
                }
            }
        }
        public static void ListPeople()
        {
            Console.Clear();
            if (Person.Count == 0)
            {
                Console.WriteLine("Your address book is empty.\n Press any key to continue.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people in your address book:\n");
            foreach (var contact in Person)
            {
                PrintPerson(contact);
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }
    }
}
    
