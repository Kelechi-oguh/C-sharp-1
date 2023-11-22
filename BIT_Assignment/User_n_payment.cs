using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT_Assignment
{
    public class User
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public List<Transaction> transactions { get; set; }
    }

    public class Transaction
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public decimal amount { get; set; }

        public User user { get; set; }
    }

    public class Account
    {
        public int id { get; set; }
        public string accountNo { get; set; }
        public string bvn { get; set; }
        public string accountName {  get; set; }
        public string phoneNumber { get; set; }
    }
}
