namespace MumblingKata.Tests
{
    public class MumblingKata
    {
        public string Mumble_Letters(string inputString)
        {
            if (inputString.Length == 0); return "Error, please enter a string";

            var letters = inputString.ToCharArray();
            var result = "";
            int i = 0;
            foreach (var letter in letters)
            {
                result += letter.ToString().ToUpper();
                for (int j=1; j <= i; j++)
                {
                    result += letter.ToString().ToLower();
                }
                result += "-";
                i++;
            }
            
            return result.TrimEnd('-');
        }
    }
}

