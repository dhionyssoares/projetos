using System;


namespace ref_and_out {
    internal class Employee {
        
        public string Name { get; set; }
        public int Id { get; set; }
        public double Salary { get; set; }

        public Employee(string name, int id, double salary) {
            Name = name;
            Id = id;
            Salary = salary;
        }

        public Employee(int id, string? name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void Increase(double percentage) {
            Salary += Salary * percentage/100;
        }

        public override string ToString() {
            return Id + ", " + Name + ", " + Salary.ToString("f2");
        }
    }
}
