using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV01
{
    internal class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Salary { get; set; }
        public Employee(int id, string name, decimal? salary)
        {
            Id = Id;
            Name = name;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"Id={Id} , Name is {Name} , Salary = {Salary}";
        }
        public override bool Equals(object? obj)
        {
            Employee? other = (Employee?)obj;

            if (other == null) return false;
            return this.Id == other.Id && this.Name == other.Name && this.Salary == other.Salary;
        }
        public override int GetHashCode()
        {


            return HashCode.Combine(this.Id.GetHashCode(), this.Name?.GetHashCode() ?? default(int), this.Salary.GetHashCode());


        }

        public int CompareTo(object? obj)
        {
            Employee? CompareEmployee = (Employee?)obj;
            if (this.Salary > CompareEmployee?.Salary)
                return 1;
            else if (this.Salary < CompareEmployee?.Salary)
                return -1;
            else
            {
                return 0;
            }

        }

        public int CompareTo(Employee? CompareEmployee)
        {
            if (this.Salary > CompareEmployee?.Salary)
                return 1;
            else if (this.Salary < CompareEmployee?.Salary)
                return -1;
            else
            {
                return 0;
            }
        }
    }
}
