using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Proxy.Bank_Account
{
    class BankAccountClient
    {
        interface IBankAccount
        {
            void Take(int sum);
            void Put(int sum);
            int Balance();
        }

        class BankAccount : IBankAccount
        {
            private int balance;

            public BankAccount(int sum)
            {
                balance = sum;
            }
            public BankAccount() : this(0) { }

            public int Balance()
            {
                Console.WriteLine("Current balance: {0}", balance);
                return balance;
            }

            public void Put(int sum)
            {
                Console.WriteLine("Putting: {0}", sum);
                balance += sum;
            }

            public void Take(int sum)
            {
                Console.WriteLine("Taking: {0}", sum);
                balance -= sum;
            }
        }

        class SafeBankAccount : IBankAccount
        {
            IBankAccount account;

            public SafeBankAccount(int sum)
            {
                account = new BankAccount(sum);
            }
            public SafeBankAccount() : this(0) { }

            public int Balance()
            {
                return account.Balance();
            }

            public void Put(int sum)
            {
                // No negative numbers here
                if (sum >= 0)
                    account.Put(sum);
                else
                    throw new Exception($"Trying to put negative sum onto account : {sum}");
            }

            public void Take(int sum)
            {
                if(sum > 0 )
                {
                    if ( Balance() >= sum)
                    {
                        account.Take(sum);
                    }
                    else
                    {
                        throw new Exception($"You cannot afford this : {sum}");
                    }
                }
                else
                {
                    throw new Exception($"Trying to take negative sum o zero from account : {sum}");
                }
            }
        }

        public static void Main(string[] args)
        {
            IBankAccount acc = new SafeBankAccount();
            acc.Put(100);
            try
            {
                acc.Put(-1000);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            acc.Take(70);
            try
            {
                acc.Take(70);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            /*
            Putting: 100
            Trying to put negative sum onto account : -1000
            Current balance: 100
            Taking: 70
            Current balance: 30
            You cannot afford this : 70
            */
        }
    }
}
