namespace Exercise6.Models
{
    public class Dept
    {
        public int Deptno { get; set; }
        public string Dname { get; set; } = string.Empty;
        public string Loc { get; set; } = string.Empty;

        public static IEnumerable<Dept> GetDepts()
        {
            return new List<Dept>
            {
                new Dept { Deptno = 10, Dname = "Sales", Loc = "New York" },
                new Dept { Deptno = 20, Dname = "Development", Loc = "Chicago" },
                new Dept { Deptno = 30, Dname = "HR", Loc = "Los Angeles" },
                new Dept { Deptno = 2137, Dname = "Testing", Loc = "Remote" }
            };
        }
    }
}
