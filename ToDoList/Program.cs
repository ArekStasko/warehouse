﻿using System;
using System.Collections.Generic;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Options optionsInitializer = new Options();
            optionsInitializer.initializeOptions();

            int selectedOption = optionsInitializer.getOptions();


            switch (selectedOption)
            {
                case 1:
                    Console.WriteLine(selectedOption);
                    break;
                case 2:
                    Console.WriteLine(selectedOption);
                    break;
                case 3:
                    Console.WriteLine(selectedOption);
                    break;
            }
        }
    }
}
