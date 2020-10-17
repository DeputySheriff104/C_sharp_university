using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MyLogicLib.Task7Logic.ReflectionLogic
{
    public class MyReflection
    {
        public static Type[] GetTypesInNamespace(Assembly assembly, string nameSpace)
        {
            return
                assembly.GetTypes()
                    .Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal))
                    .ToArray();
        }

        public static Type[] GetImplementedTypesFromTypeArray(Type[] typeArray)
        {
            return typeArray.Where(type => type.GetInterface("IShape") != null).ToArray();
        }

        public static object RunMethod(
            Type type, string methodName, object[] constructorParams, object[] methodParams)
        {
            return type.GetMethod(methodName)?
                .Invoke(Activator.CreateInstance(type, constructorParams), methodParams);
        }

        public static string ConvertTypeArrayWithMethodsToString(Type[] typeArray)
        {
            string output = "";
            foreach (Type type in typeArray)
            {
                output += "CLASS - " + type.Name + "\n";
                foreach (MethodInfo method in GetMethodsOfType(type))
                {
                    output += " - " + method.Name + "\n";
                }
            }
            return output;
        }

        public static MethodInfo[] GetMethodsOfType(Type type)
        {
            List<MethodInfo> methodsList = new List<MethodInfo>();
            foreach (var method in type.GetMethods()
                .Where((mi)=> mi.DeclaringType != typeof(object)))
            {
                methodsList.Add(method);
            }
            return methodsList.ToArray();
        }

        public static string ConvertMethodsToString(MethodInfo[] methodArray)
        {
            string output = "";
            foreach (MethodInfo method in methodArray)
            {
                output += " - " + method.Name + "\n";
            }
            return output;
        }

        public static string GetStringConstructorParams(ConstructorInfo method)
        {
            string output = "";
            ParameterInfo[] methodParams = method.GetParameters();
            for (int i = 0; i < methodParams.Length; i++)
            {
                output += methodParams[i].ParameterType.Name + " ";
                output += methodParams[i].Name;
                if (i != methodParams.Length - 1)
                {
                    output += ", ";
                }
            }
            return output;
        }
    }

}