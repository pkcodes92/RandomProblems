using System;

namespace ValidatingIPAddress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an IP address to validate: ");
            string inputString = Console.ReadLine();

            bool isValid = IsIPv4Address(inputString);

            Console.WriteLine($"Is the IP Address: {inputString} valid? {isValid}");

            Console.ReadKey(); 
        }

        static bool IsIPv4Address(string inputString)
        {
            string temp = "0123456789";
            string[] ip = inputString.Split('.');

            if (ip.Length != 4)
            {
                return false;
            }

            for (int i = 0; i < 4; i++)
            {
                if (ip[i].Length == 0 || ip[i].Length > 3)
                {
                    return false;
                }
                else
                {
                    int a = 0;
                    for (int j = 0; j < ip[i].Length; j++)
                    {
                        if (temp.IndexOf(ip[i][j]) >= 0)
                        {
                            a = a * 10 + int.Parse(ip[i][j].ToString());
                        }
                        else
                        {
                            return false;
                        }
                    }

                    if (a > 255)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}