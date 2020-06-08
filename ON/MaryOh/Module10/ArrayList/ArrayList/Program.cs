﻿using System;
using System.Collections;

namespace Arraylist
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Create Array List using built in library
            ArrayList myArrList = new ArrayList();

            // Add values to Array List using Add() method
            myArrList.Add(10);
            myArrList.Add(11.5);
            myArrList.Add("This is a string");

            // Add values to Array List using AddRange() method
            myArrList.AddRange(new ArrayList() { 20, 17.7, "This is another string" });

            // Print each value in the array list using foreach() method
            foreach(var value in myArrList)
            {
                Console.WriteLine(value);
            }
        }
    }
}
