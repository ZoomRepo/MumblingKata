using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MumblingKata.Tests
{
    public class MumblingKata
    {
        public string Mumble_Letters(string inputString)
        {
            var letters = inputString.ToCharArray();
            var result = "";

            foreach (var letter in letters)
            {
                result += letter.ToString().ToUpper() + "-";
            }

            return result.TrimEnd('-');
        }
    }
}
