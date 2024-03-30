using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RegularExpression
{
    public class Regexs
    {
        public void Pincode()
        {
            string pincode = "516173";
            Regex regex = new Regex(@"^[1-9]\d{5}$");
            if (regex.IsMatch(pincode))
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("Inavalid");
            }
        }
        public void Email()
        {
            string email = "abc.xyz@bl.co.in";
            Regex regex = new Regex(@"^\w+.\w+@\w+.[A-Za-z]{2,}.[A-Za-z]{2,}$");
            if (regex.IsMatch(email))
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("Inavalid");
            }
        }
        public void Password()
        {
            string password = "Krishna@123";
            Regex regex = new Regex(@"^[\w+\W\d]{8,}$");
            if (regex.IsMatch(password))
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("Inavalid");
            }
        }
        public void Phno()
        {
            string phno = "91 9959515107";
            Regex regex = new Regex(@"^91\s[1-9]\d{9}$");
            if (regex.IsMatch(phno))
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("Inavalid");
            }
        }
        public void Name()
        {
            string name = "Kavitha Pasala";
            Regex regex = new Regex(@"^[A-Z][A-za-z]{2,}\s[A-Z][A-za-z]{2,}$");
            if (regex.IsMatch(name))
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("Inavalid");
            }
        }
        public void HexCode()
        {
            string hex = "#fb985c";
            Regex regex = new Regex("^[#]{1}([a-fA-F0-9]{6}|[a-fA-F0-9]{3})$");
            if (regex.IsMatch(hex))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Inavalid");
            }
        }
        public void Removes()
        {
            string input = " \t Hello World! \n ";
            string pattern = @"^[\t\n\s]+|[\s\t\n]+$"; 
            string result = Regex.Replace(input, pattern, "");
            Console.WriteLine("orginal string:"+input);
            Console.WriteLine("trimmed string:"+result);
            Console.WriteLine("Hello");
        }
        public void Count()
        {
            string text = "This is a sample text. It contains sample words, and it is meant to demonstrate word counting using regular expressions.";

            string[] words = Regex.Split(text.ToLower(), @"\W+");

            Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

            foreach (string word in words)
            {
                wordFrequency[word] = wordFrequency.ContainsKey(word) ? wordFrequency[word] + 1 : 1;
            }
         
            Console.WriteLine("Word frequencies:");
            foreach (KeyValuePair<string, int> pair in wordFrequency)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
        public void Average()
        {
            string text = "Hello World";
            string[] words = Regex.Split(text,@"\W");
            int totalLength = 0;
            foreach (string word in words)
            {
                totalLength += word.Length;
                Console.WriteLine(word);
            }
            double averageLength = (double) totalLength / words.Count();
            Console.WriteLine(averageLength);
        }
        public void Palindrome()
        {
            string text = "A man, a plan, a canal, Panama!";
            string result = Regex.Replace(text.ToLower(),@"\W","");
            Console.WriteLine(result);
            string reverse = string.Concat(result.Reverse());
            Console.WriteLine(reverse);
            bool res = result.Equals(reverse);
            Console.WriteLine(res);
        }
        public void Format()
        {
            string input = "2023-03-19";
            Regex regex = new Regex("^\\d{4}-\\d{2}-\\d{2}$");
            if (regex.IsMatch(input))
            {
                Console.WriteLine("Valid");
            }
            else
            {

                Console.WriteLine("Invalid");
            }

        }
        public void CDuplicate()
        {
            string text = "Hellooo, how are you?";
            string pattern = @"(.)\1+";
            MatchCollection matches = Regex.Matches(text, pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine($"Consecutive duplicate characters found: {match.Value}");
            }
        }
        public void Wcount()
        {
            string inputString = "This is a sample string with some words";
            string[] words = Regex.Split(inputString.ToLower(),@"\W");
            int wcount = 0;
            foreach (string word in words)
            {
                wcount += 1;
            }
            Console.WriteLine(wcount);
        }
    }
}
