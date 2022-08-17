using System;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string AnalyzeAccessModifiers(string className)
        {
            Type classType = typeof(Hacker); 
            FieldInfo[] allFields = classType.GetFields(BindingFlags.Instance 
                | BindingFlags.Static | BindingFlags.Public);

            MethodInfo[] allPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
            MethodInfo[] allNonPublicethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            StringBuilder sb = new StringBuilder(); 

            foreach (var field in allFields)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }
            foreach (MethodInfo method in allPublicMethods)
            {
                sb.AppendLine($"{method.Name} have to be public!");
            }
            foreach (MethodInfo method in allNonPublicethods)
            {
                sb.AppendLine($"{method.Name} have to be private");
            }
            return sb.ToString().TrimEnd();
        }
    }
}

