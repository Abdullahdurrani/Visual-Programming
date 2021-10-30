using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProps
{
    public class Teacher
    {
        private int id;
        private string name;
        private string email;
        private string education;
        private string department;
        private string address;
        private string designation;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Education { get => education; set => education = value; }
        public string Department { get => department; set => department = value; }
        public string Address { get => address; set => address = value; }
        public string Designation { get => designation; set => designation = value; }
    }
}
