using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
       public string StealFieldInfo(string investigatedClass, params string[] requestedFields)
        {
            Type classType = Type.GetType(investigatedClass);
            FieldInfo[] classFields = classType.GetFields 
                (BindingFlags.Public  
                |BindingFlags.NonPublic 
                | BindingFlags.Static 
                | BindingFlags.Instance); 
             StringBuilder sb = new StringBuilder(); 

            Object classInstance = Activator.CreateInstance(classType, new object[] { });

            sb.AppendLine($"Class under investigation: {investigatedClass}");

            foreach (FieldInfo field in classFields.Where(f => requestedFields.Contains(f.Name)))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }
            return sb.ToString().Trim();
        }
    }
}
