using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AuthorProblem
{
    public class Tracker
    {
        public void PrintMethodsByAuthor(string name)
        {
            Type[] types = Assembly.GetExecutingAssembly().GetTypes();
            foreach (var type in types)
            {
                foreach (MethodInfo method in type.GetMethods
                    (BindingFlags.Instance  
                    | BindingFlags.Public
                    | BindingFlags.NonPublic  
                    | BindingFlags.Static))
                {
                    AuthorAttribute attr = method.GetCustomAttribute<AuthorAttribute>(); 
                    if(attr != null && attr.Name == name)
                    {
                        Console.WriteLine(method.Name);
                    }
                }
                
            }

        }
    }
}
