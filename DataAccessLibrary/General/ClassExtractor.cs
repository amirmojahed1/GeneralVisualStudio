using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.General
{
    public static class ClassExtractor
    {
        public static string[] GetModelClassNames(string assemblyPath, string modelsNamespace)
        {
            if (!File.Exists(assemblyPath))
                throw new FileNotFoundException("Assembly not found at: " + assemblyPath);

            var assembly = Assembly.LoadFrom(assemblyPath);

            var modelTypes = assembly.GetTypes()
                .Where(t => t.IsClass && t.Namespace == modelsNamespace)
                .Select(t => t.Name)
                .ToArray();

            return modelTypes;
        }
    }
}
