using Newtonsoft.Json;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.X86;
using System.Text.Json.Serialization;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace BIT_Assignment
{
    public class BIT
    {
        public static void Main(string[] args)
        {   
            // ASSIGNMENT 1 

           
            // Creating a liSt of Payments
            List<Transaction> transactions = new List<Transaction>()
            {
                new Transaction() {id=1, user_id=1, amount=5000},
                new Transaction() {id=2, user_id=2, amount=6000},
                new Transaction() {id=3, user_id=3, amount=7000}
            };

            // Creating a list of Users
            List<User> users = new List<User>()
            {
                new User() {id=1, firstname="kelechi", lastname="Randy", email="randkelz@gmail.com", transactions=transactions.Where(x => x.user_id == 1).ToList()},
                new User() {id=2, firstname="Garther", lastname="Edna", email="ednagarth@gamil.com", transactions=transactions.Where(x => x.user_id == 2).ToList()},
                new User() {id=3, firstname="Solomon", lastname="Parker", email="solo_p@gmail.com", transactions=transactions.Where(x => x.user_id == 3).ToList()}
            };

            //var userPayments = users.Where(x => x.id == 1);

            // Accessing the list
            //Console.WriteLine("ASSIGNMENT 1....\n");
            //foreach (User user in users)
            //{
            //    Console.WriteLine("ID: {0}, Name: {1} {2}, Email: {3} Payments:{4}", user.id, user.firstname, user.lastname, user.email);

            //    foreach (Payment payment in payments)
            //    {
            //        if (payment.user_id == user.id)
            //            Console.WriteLine("Payment ID: {0}, Amount Paid: {1}\n", payment.id, payment.amount);
            //    }
            //}

            var userTransactions = users.Where(x => x.id == 1);
            //var u = new List<User>();



            var json = JsonConvert.SerializeObject(userTransactions, Formatting.Indented);

            Console.WriteLine(json);

            foreach (var user in userTransactions)
            {
                if (user.firstname == "kelechi" || user.lastname == "Randy")
                {
                    Console.WriteLine("First Name : " + user.firstname + " Last Name : " + user.lastname);
                    foreach (var user2 in user.transactions.Where(y=>y.user_id==1))
                    {
                        Console.WriteLine("Amount : " + user2.amount + " UserId : " + user2.user_id);
                    }

                }
            }

            // ASSIGNMENT 2 begins here
            Console.WriteLine("\nSTARTING ASSIGNMENT 2...\n");
            try
            {
                Console.Write("Enter the base length of the triangle: ");
                double tri_base = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the height of the triangle: ");
                double tri_height = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("The Area of the triangle is: {0}", TriangleArea.Area_of_Triangle(tri_base, tri_height));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
