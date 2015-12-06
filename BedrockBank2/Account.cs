﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedrockBank
{
    class Account 
    {
        /// <summary>
        /// This class provides 
        /// definition for a 
        /// Bedrock accoutnt
        /// </summary

        #region Variables
            ///<summary>
            ///shared memory for storing
            ///the last account number
            ///</summary>
        private static int lastAccountNumber = 0;

        #endregion


        #region Properties
        /// <summary>
        /// Name of the account holder
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Account number for the account
        /// </summary>
        public int AccountNumber { get; set; }
        /// <summary>
        /// Balance in the account
        /// </summary>
        public decimal Balance { get; set; }
        #endregion

        #region Constructors

        public Account()
        {
            //lastAccountNumber = lastAccountNumber + 1;
            Account = ++lastAccountNumber
        }
        #endregion

        #region Methods
        /// <summary>
        /// Deposit money into your account
        /// </summary>
        /// <param name="amount">Money to deposit</param>
        /// <returns>New balance</returns>
        public decimal Deposit(decimal amount)
        {
            //Balance = Balance + amount;
            Balance += amount;
            return Balance;
        }

        public decimal withdraw(decimal am)
        {
            Balance -= amount;
            return Balance;
        }
        #endregion
    }
