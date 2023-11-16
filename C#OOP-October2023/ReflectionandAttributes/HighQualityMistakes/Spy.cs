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
        public void AnalyzeAccessModifiers(string className)
        {
            Type classType = Type.GetType(className);

            if (classType == null)
            {
                Console.WriteLine("Class not found!");
                return;
            }

            StringBuilder result = new StringBuilder();

            // Analyze fields
            FieldInfo[] fields = classType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            foreach (var field in fields)
            {
                if (field.IsPrivate)
                {
                    result.AppendLine($"{field.Name} must be private!");
                }
            }

            // Analyze getters
            MethodInfo[] getters = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.GetProperty);
            foreach (var getter in getters)
            {
                if (getter.IsPublic)
                {
                    result.AppendLine($"{getter.Name} have to be public!");
                }
            }

            // Analyze setters
            MethodInfo[] setters = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.SetProperty);
            foreach (var setter in setters)
            {
                if (setter.IsPrivate)
                {
                    result.AppendLine($"{setter.Name} have to be private!");
                }
            }

            Console.WriteLine(result.ToString().Trim());
        }

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
