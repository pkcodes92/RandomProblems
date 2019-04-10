namespace DumpableDemo
{
    using System;

    class Person : IDumpable
    {
        readonly string name;
        public string address;
        public int phone;

        public Person(string name, string address, int phone)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
        }

        public string Name { get; set; }

        public void Dump()
        {
            Console.WriteLine("Person Details: {0}, {1}, {2}", name, address, phone);
        }
    }
}