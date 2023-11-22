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
    }

    public class Payment
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public decimal amount { get; set; }
    }
}
