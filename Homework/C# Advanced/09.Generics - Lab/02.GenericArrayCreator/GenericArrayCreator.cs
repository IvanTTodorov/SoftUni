using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
namespace GenericArrayCreator
{
    public class StartUp
    { 
         static void Main(string[] args)
            {
                string[] strings = ArrayCreator.Create(5, "Pesho");
                int[] integers = ArrayCreator.Create(10, 33);
            }

        }
    }