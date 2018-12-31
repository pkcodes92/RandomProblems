namespace JsonParsing
{
    using System;
    using System.Collections.Generic;

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
        }
    }
}