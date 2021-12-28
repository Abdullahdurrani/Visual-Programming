using EFCoreCodeFirst.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirst.Models.DataManager
{
    public class EmployeeManager : IDataRepository<Employee>
    {
        private readonly EmployeeContext _context;

        public EmployeeManager(EmployeeContext context)
        {
            _context = context;
        }

        public void Add(Employee entity)
        {
            // tracks the entity to be added in the database
            _context.Employees.Add(entity);
            // saves all changes which are tracked above
            _context.SaveChanges();
        }

        public void Delete(Employee entity)
        {
            _context.Employees.Remove(entity);
            _context.SaveChanges();
        }

        public Employee Get(long id)
        {
            // returns the employee which matches the id passed as parameter
            return _context.Employees.FirstOrDefault(e => e.EmployeeId == id);
        }

        public IEnumerable<Employee> GetAll()
        {
            // context is database which contains Employees table and we are returning the list of employees
            return _context.Employees.ToList();
        }

        // entiy is from database, employee is what we fill and pass to databae
        public void Update(Employee entity, Employee employee)
        {
            entity.FirstName = employee.FirstName;
            entity.LastName = employee.LastName;
            entity.Email = employee.Email;
            entity.PhoneNumber = employee.PhoneNumber;
            entity.DateofBirth = employee.DateofBirth;

            _context.SaveChanges();
        }
    }
}
