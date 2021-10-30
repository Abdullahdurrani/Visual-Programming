using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProps
{
    public class Subject
    {
        private int id;
        private string title;
        private int creditHours;
        private string department;
        private string teacher;

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public int CreditHours { get => creditHours; set => creditHours = value; }
        public string Department { get => department; set => department = value; }
        public string Teacher { get => teacher; set => teacher = value; }
    }
}
