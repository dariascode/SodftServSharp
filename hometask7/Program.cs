using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
           
            ReadPhoneBookFromFile("phones.txt", phoneBook);

            
            WritePhoneNumbersToFile("Phones.txt", phoneBook);

            
            Console.Write("enter name: ");
            string searchName = Console.ReadLine();
            string phoneNumber = FindPhoneNumberByName(searchName, phoneBook);
            Console.WriteLine($"phone number for {searchName} is {phoneNumber}");
            
          
            Dictionary<string, string> updatedPhoneBook = ChangePhoneFormats(phoneBook);

           
            WritePhoneBookToFile("New.txt", updatedPhoneBook);
        }

        static void ReadPhoneBookFromFile(string filePath, Dictionary<string, string> phoneBook)
        {
            string readFile = @"C:\Univer\WP\hometask7\phones.txt";
            try
            {
                using (StreamReader reader = new StreamReader(readFile, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 2)
                        {
                            string name = parts[0].Trim();
                            string phoneNumber = parts[1].Trim();
                            phoneBook[name] = phoneNumber;
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File '{filePath}' not found.");
            }
        }

        static void WritePhoneNumbersToFile(string filePath, Dictionary<string, string> phoneBook)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(@"C:\Univer\WP\hometask7\Phones(2).txt"))
                {
                    foreach (string phoneNumber in phoneBook.Values)
                    {
                        writer.WriteLine(phoneNumber);
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine($"Error writing to file '{filePath}'.");
            }
        }

        static string FindPhoneNumberByName(string name, Dictionary<string, string> phoneBook)
        {
            if (phoneBook.TryGetValue(name, out string phoneNumber))
            {
                return phoneNumber;
            }
            else
            {
                return "Phone number not found.";
            }
        }

        static Dictionary<string, string> ChangePhoneFormats(Dictionary<string, string> phoneBook)
        {
            Dictionary<string, string> updatedPhoneBook = new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> entry in phoneBook)
            {
                string name = entry.Key;
                string phoneNumber = entry.Value;
                if (phoneNumber.StartsWith("80") && phoneNumber.Length == 11)
                {
                    phoneNumber = "+380" + phoneNumber.Substring(2);
                }
                updatedPhoneBook[name] = phoneNumber;
            }
            return updatedPhoneBook;
        }

        static void WritePhoneBookToFile(string filePath, Dictionary<string, string> phoneBook)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(@"C:\Univer\WP\hometask7\New.txt"))
                {
                    foreach (KeyValuePair<string, string> entry in phoneBook)
                    {
                        writer.WriteLine($"{entry.Key}, {entry.Value}");
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine($"Error writing to file '{filePath}'.");
            }
        }
    }
}
    

