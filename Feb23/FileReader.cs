using System;
using System.Collections.Generic;


namespace Feb23
{
    public class FileReader
    {
        
        public void ReadFile(List<BankAcc> Users) 
        {
            System.IO.StreamReader file =
              new System.IO.StreamReader(@"C:\Users\Kornelijus\Desktop\RepoLand\Round2\Feb23\BankStuff.CSV.txt");
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(',');
                Users.Add( new BankAcc(new Guid(words[0]),words[1],Convert.ToDecimal(words[2])));
            }
            file.Close();

        }
    }
}
