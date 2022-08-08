using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class SmartPhone : ICallable, IBrowseble
    {
        private IList<string> phoneNumbes;
        private IList<string> sites;

        public SmartPhone()
        {
            this.phoneNumbes = new List<string>();
            this.sites = new List<string>();
        }
        public string Browse(string url)
        {  
            if(url.Any(x=> Char.IsDigit(x)))
            {
                return "Invalid URL!";
            } 
            else
            {
                return $"Browsing: {url}!";
            }

   }

        public string Call(string number)
        {
            if(!number.All(x=> Char.IsDigit(x)))  
            {
               return "Invalid number!";
            } 
            if(number.Length == 10)
            {
                return $"Calling... {number}";
            } 
            else
            {
                return $"Dialing... {number}";
            }
        }

        public void Run()
        {
            phoneNumbes = Console.ReadLine().Split();
            sites = Console.ReadLine().Split();

            callPhoneNum();
            browseURL();
        }

        private void callPhoneNum()
        {
            foreach (var item in phoneNumbes)
            {
                Console.WriteLine(Call(item));
            }
        }

        private void browseURL()
        {
            foreach (var item in sites)
            {
                Console.WriteLine(Browse(item));
            }
        }
    }
}
