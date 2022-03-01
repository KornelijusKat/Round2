using System;
using Xunit;
using Feb23;
using System.Collections.Generic;

namespace TestATM
{
    public class UnitTest1
    {
        [Fact]
        public void WrongCardTest()
        {
            //Assign
            string input = "2231g213d";
            //
            var result = ATMInput.CardAccCheck(input);
            //asert
            Assert.False(result);
        }
        [Fact]
        public void ObjectIsItNullCheck()
        {
            string card1 = "bf2cc9aa-9cbc-49b9-8deb-60ed9fbf153e";
            var result = AccountSele.AccountSelector(card1);
            Assert.NotNull(result);

        }
        [Fact]
        public void InputMoneyOverLimit()
        {
            //assign
            var result = MoneyInput.EuroLimit(2000);
            //assert
            Assert.False(result);
        }
        [Fact]
        public void FileReaderIsAddToList()
        {
            var listas = new List<BankAcc>();
            var Filer = new FileReader();
            Filer.ReadFile(listas);
            Assert.NotEmpty(listas);
        }
    }
  
}
