using BankingMicroservice.Banking.Domain.Interfaces;
using BankingMicroservice.Banking.Domain.Models;
using BankingMicroservice.Banking.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankingMicroservice.Banking_Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankingDbContext _ctx;
        public AccountRepository(BankingDbContext context)
        {
            _ctx = context;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _ctx.Accounts;
        }
    }
}
