using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProps
{
    public class Student
    {
        private int id;
        private string name;
        private string email;
        private string degree;
        private string department;
        private string address;
        private float cgpa;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Degree { get => degree; set => degree = value; }
        public string Department { get => department; set => department = value; }
        public string Address { get => address; set => address = value; }
        public float CGPA { get => cgpa; set => cgpa = value; }
    }
}
