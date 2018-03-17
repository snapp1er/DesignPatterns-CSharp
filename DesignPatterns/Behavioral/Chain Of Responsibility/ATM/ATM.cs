using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Chain_Of_Responsibility.ATM
{
    class ATM : MoneyGiver
    {
        static void Main(string[] args)
        {
            var atm = new ATM();
            var HundredsGiver = new CustomMoneyGiver(100);
            var TensGiver = new CustomMoneyGiver(10);
            var OnesGiver = new CustomMoneyGiver(1);
            
            atm.Add(HundredsGiver);
            atm.Add(TensGiver);
            atm.Add(OnesGiver);            

            atm.Give(1253);
            /*
            Giving out 12 notes by 100
            Giving out 5 notes by 10
            Giving out 3 notes by 1
            */
        }

    }
}
