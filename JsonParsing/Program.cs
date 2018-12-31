namespace JsonParsing
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;

    class RequiredResourceAccess
    {
        public string ResourceAppId { get; set; }

        public List<ResourceAccess> ResourceAccess { get; set; }
    }

    class ResourceAccess
    {
        public string Id { get; set; }
        public string Type { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Reading the file into a string
            var inputJsonText = File.ReadAllText(@"D:\\GitHub\\RandomProblems\\Test.json");

            if (inputJsonText != null)
            {
                Console.WriteLine("Input JSON text detected"); 
            }

            using (StreamReader file = File.OpenText(@"D:\\GitHub\\RandomProblems\\Test.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                RequiredResourceAccess requiredResourceAccess = (RequiredResourceAccess)serializer.Deserialize(file, typeof(RequiredResourceAccess));

                Console.WriteLine(requiredResourceAccess);
            }
        }
    }
}