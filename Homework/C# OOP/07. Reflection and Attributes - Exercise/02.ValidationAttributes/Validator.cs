using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(Object obj)
        {
            PropertyInfo[] properties = obj.GetType().GetProperties(); 

            foreach(var propertyInfo in properties)
            {
                var attributes = propertyInfo.GetCustomAttributes()
                    .Where(t => t.GetType().IsSubclassOf(typeof(MyValidationAttribute)))
                    .ToArray(); 

                foreach (MyValidationAttribute item in attributes)
                {
                    bool isValid = item.IsValid(propertyInfo.GetValue(obj));
                    if(!isValid)
                    {
                        return false; 
                    }
                }
                
            }
            return true; 
        }
    }
}
