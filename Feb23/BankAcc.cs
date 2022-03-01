using System;


namespace Feb23
{
    public class BankAcc 
    {
        public Guid CardDetail { get; set; }
        public  string Password { get; set; }
        public  decimal Money { get; set; }

        public BankAcc(Guid cardDetail, string password, decimal money)
        {
            CardDetail = cardDetail;
            Password = password;
            Money = money;
        }
        public BankAcc()
        {
        }
        public override string ToString()
        {
            return $"{CardDetail},{Password},{Money} ";
        }
    }
}
