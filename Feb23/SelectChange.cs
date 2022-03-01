
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Feb23
{
    class SelectChange
    {
        public static void LineChanger(BankAcc User)
        {
            var CardList = new List<BankAcc>();
            var Bunk = new FileReader();
            Bunk.ReadFile(CardList);
            var linechange = CardList.SingleOrDefault(X => X.CardDetail == User.CardDetail);
            linechange.Money = User.Money;
            File.WriteAllLines(@"C:\Users\Kornelijus\Desktop\RepoLand\Round2\Feb23\BankStuff.CSV.txt", CardList.Select(X => X.ToString()));
        }
    }
}
