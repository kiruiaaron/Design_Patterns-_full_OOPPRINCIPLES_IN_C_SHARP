using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.OOPprinciples.Encapsulation
{
    public class BankAccount
    {
        private decimal balance;

        public BankAccount(decimal balance){
            Deposit(balance);

        }

        public decimal GetBalance(){
            return balance;
        }
        
        public void Deposit(decimal amount){
            if (amount <= 0){
                throw new ArgumentException("Deposit amount must be positive");
            }

            this.balance += amount;

        }

        public void withdraw(decimal amount){
            if (amount <= 0){
                throw new ArgumentException("Withdraw amount must be positive");
            }
            if (amount >balance){
                throw new InvalidOperationException("Insufficient balance");
            }

            this.balance -= amount;
        }
    }
}