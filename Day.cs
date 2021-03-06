﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Day
    {
        public Weather weather;
        public List<Customer> customers;
        int numberOfCustomers;
        Random random;
        public Day()
        {

            random = new Random();
            weather = new Weather();
            customers = new List<Customer>();
            NumberOfGeneratedCustomers();
            GenerateCustomers();
        }

        //Single Responsibility Principle: Each of the below methods perform a single responsibility: 
        //the first method only determines the number of generated customers based on the input weather condition
        //the second method will only create a list of customers based on the input from previous method
        public void NumberOfGeneratedCustomers()
        {
                       
            switch (weather.condition)
            {
                case "Rain":
                    numberOfCustomers = random.Next(30, 61);
                    break;
                case "Hazy":
                    numberOfCustomers = random.Next(45, 76);
                    break;
                case "Overcast":
                    numberOfCustomers = random.Next(60, 91);
                    break;
                case "Sunny":
                    numberOfCustomers = random.Next(75, 106);
                    break;
            }
        }
        public void GenerateCustomers()
        {
          
            for (int i = 0; i < numberOfCustomers; i++)
            {
                Customer customer = new Customer("Customer");
                customers.Add(customer);
            }
        }
    }
}
