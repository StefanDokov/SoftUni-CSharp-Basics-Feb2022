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
        public void PrintGettersAndSetters(string className)
        {
            Type classType = Type.GetType(className);

            if (classType == null)
            {
                Console.WriteLine("Class not found!");
                return;
            }

            MethodInfo[] methods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            StringBuilder result = new StringBuilder();

            foreach (var method in methods)
            {
                if (IsGetter(method))
                {
                    result.AppendLine($"{method.Name} will return {method.ReturnType}");
                }
                else if (IsSetter(method))
                {
                    ParameterInfo parameter = method.GetParameters()[0];
                    result.AppendLine($"{method.Name} will set field of {parameter.ParameterType}");
                }
            }

            Console.WriteLine(result.ToString().Trim());
        }

        private bool IsGetter(MethodInfo method)
        {
            return method.Name.StartsWith("get_") && method.GetParameters().Length == 0;
        }

        private bool IsSetter(MethodInfo method)
        {
            return method.Name.StartsWith("set_") && method.GetParameters().Length == 1;
        }
        public void RevealPrivateMethods(string className)
        {
            Type classType = Type.GetType(className);

            if (classType == null)
            {
                Console.WriteLine("Class not found!");
                return;
            }

            StringBuilder result = new StringBuilder();

            result.AppendLine($"All Private Methods of Class: {className}");

            // Get base class
            Type baseType = classType.BaseType;
            result.AppendLine($"Base Class: {baseType.Name}");

            // Get private methods
            MethodInfo[] privateMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
            foreach (var method in privateMethods)
            {
                result.AppendLine(method.Name);
            }

            Console.WriteLine(result.ToString().Trim());
        }

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
