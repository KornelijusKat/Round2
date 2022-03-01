using System;


namespace Feb23
{
    class GuidConfirmer
    {
        public static bool IsGuid(string input)
        {
            bool IsValid = Guid.TryParse(input, out _);
            if (IsValid == true)
            {    
                return true;
            }
            Console.WriteLine("Wrong card type, exiting program");
            return false;
        }
    }
}
