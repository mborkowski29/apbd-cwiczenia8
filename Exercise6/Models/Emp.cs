namespace Exercise6.Models
{
    public class Emp
    {
        public int Empno { get; set; }
        public string Ename { get; set; } = string.Empty;
        public string Job { get; set; } = string.Empty;
        public int Salary { get; set; }
        public DateTime? HireDate { get; set; }
        public int? Deptno { get; set; }
        public Emp? Mgr { get; set; }

        public override string ToString()
        {
            return $"{Ename} ({Empno})";
        }
        public static IEnumerable<Emp> GetEmps()
        {
            var emp1 = new Emp { Empno = 100, Ename = "Marcin Marcinowski", Job = "Manager", Salary = 6000, HireDate = DateTime.Parse("2020-01-01"), Deptno = 10 };
            var emp2 = new Emp { Empno = 101, Ename = "Anna Malewska", Job = "Developer", Salary = 7000, HireDate = DateTime.Parse("2020-02-01"), Deptno = 20, Mgr = emp1 };
            var emp3 = new Emp { Empno = 102, Ename = "Jan Kowalski", Job = "Developer", Salary = 5000, HireDate = DateTime.Parse("2020-03-01"), Deptno = 30, Mgr = emp1 };
            var emp4 = new Emp { Empno = 103, Ename = "Piotr Nowak", Job = "Developer", Salary = 3000, HireDate = DateTime.Parse("2020-04-01"), Deptno = 20, Mgr = emp2 };

            emp1.Mgr = null;
            emp2.Mgr = emp1;
            emp3.Mgr = emp1;
            emp4.Mgr = emp2;

            return new List<Emp> { emp1, emp2, emp3, emp4 };
        }
    }
}
