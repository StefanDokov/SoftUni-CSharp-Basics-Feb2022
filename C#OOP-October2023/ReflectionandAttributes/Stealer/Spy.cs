using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Stealer
{
    public class Spy
    {
        public void StealFieldInfo(string className, string[] fieldsToInvestigate)
        {
            Type classType = Type.GetType(className);

            if (classType == null)
            {
                Console.WriteLine("Class not found!");
                return;
            }

            Console.WriteLine($"Class under investigation: {className}");

            StringBuilder result = new StringBuilder();

            foreach (var fieldName in fieldsToInvestigate)
            {
                FieldInfo field = classType.GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

                if (field != null)
                {
                    object value = field.GetValue(Activator.CreateInstance(classType));
                    result.AppendLine($"{fieldName} = {value}");
                }
                else
                {
                    result.AppendLine($"{fieldName} = Not found");
                }
            }

            Console.WriteLine(result.ToString().Trim());
        }
    }
}
