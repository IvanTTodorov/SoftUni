using System;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        
        public string RevealPrivateMethods(string className)
        {
            Type classType = typeof(Hacker); 
 
            MethodInfo[] allNonPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"All Private Methods of Class: {className}");
            sb.AppendLine($"Base Class: {classType.BaseType.Name}");

            foreach (MethodInfo method in allNonPublicMethods)
            {
                sb.AppendLine(method.Name); 
            }
            return sb.ToString().TrimEnd();
        }
    }
}

