using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProps
{
    public class User
    {
        private int id;
        private string firstName;
        private string lastName;
        private string email;
        private string password;
        private int accessLevel;
        private string address;
        private string phoneNumber;
        private int salary;
        private int age;
        private float balance;
        private string city;
        private int orders;
        private string department;
        private string position;

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public int AccessLevel { get => accessLevel; set => accessLevel = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public int Salary { get => salary; set => salary = value; }
        public int Age { get => age; set => age = value; }
        public float Balance { get => balance; set => balance = value; }
        public string City { get => city; set => city = value; }
        public int Orders { get => orders; set => orders = value; }
        public string Department { get => department; set => department = value; }
        public string Position { get => position; set => position = value; }
    }
}
