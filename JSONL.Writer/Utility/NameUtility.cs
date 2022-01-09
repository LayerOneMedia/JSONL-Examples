using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONL.Writer.Utility
{
    internal static class NameUtility
    {
        private static readonly Random _random = new Random();
        private static readonly List<string> _firstNames = new List<string>
        {
            "James",
            "John",
            "Robert",
            "Michael",
            "William",
            "David",
            "Richard",
            "Charles",
            "Joseph",
            "Thomas"
        };

        private static readonly List<string> _lastNames = new List<string>
        {
            "Smith",
            "Johnson",
            "Williams",
            "Brown",
            "Jones",
            "Miller",
            "Davis",
            "Garcia",
            "Rodriguez",
            "Wilson"
        };

        public static string GetRandomFirstName()
        {
            return _firstNames.ElementAt(_random.Next(0, _firstNames.Count - 1));
        }

        public static string GetRandomLastName()
        {
            return _lastNames.ElementAt(_random.Next(0, _lastNames.Count - 1));
        }
    }
}
