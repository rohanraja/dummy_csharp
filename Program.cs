using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeRecordHelpers; 

namespace test2
{
        public class Employee
        {
            public Employee(string name)
            {
var mrid = CodeHooks.Instance().OnMethodEnter(@"Program.cs", "Employee", this.GetHashCode(), "b9ba1d54-0f4c-4592-83a0-f2b7115c0b0e" );
CodeHooks.Instance().SendFieldUpdate(this.GetHashCode(), "name", "raw", "Employee", CodeVine_name, CodeHooks.Now());
CodeHooks.Instance().SendFieldUpdate(this.GetHashCode(), "EmployeesList", "raw", "Employee", CodeVine_EmployeesList, CodeHooks.Now());
CodeHooks.Instance().LocalVarUpdate(mrid, "name", "", name, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 12, CodeHooks.Now(), "");
                this.name = name;
CodeHooks.Instance().LocalVarUpdate(mrid, "name", "", name, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 13, CodeHooks.Now(), "");
            }
 
            public string CodeVine_name= ""; 
            public List<Employee> Employees
            {
                get
                {
                    return EmployeesList;
                }
            }
 
            public void isEmployeeOf(Employee e)
            {
var mrid = CodeHooks.Instance().OnMethodEnter(@"Program.cs", "isEmployeeOf", this.GetHashCode(), "b9ba1d54-0f4c-4592-83a0-f2b7115c0b0e" );
CodeHooks.Instance().LocalVarUpdate(mrid, "e", "", e, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 26, CodeHooks.Now(), "Add");
                EmployeesList.Add(e);
CodeHooks.Instance().SendFieldUpdate(this.GetHashCode(), "EmployeesList", "raw", "", EmployeesList, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 27, CodeHooks.Now(), "");
            }
 
            List<Employee> CodeVine_EmployeesList= new List<Employee>();
 
            public override string ToString()
            {
var mrid = CodeHooks.Instance().OnMethodEnter(@"Program.cs", "ToString", this.GetHashCode(), "b9ba1d54-0f4c-4592-83a0-f2b7115c0b0e" );
CodeHooks.Instance().LogLineRun(mrid, 33, CodeHooks.Now(), "");
                return name;
CodeHooks.Instance().LogLineRun(mrid, 34, CodeHooks.Now(), "");
            }
                public int CodeVine_ClrInstanceId{
                    get{
                        return this.GetHashCode();
                    }
                }
 
            public string name{get{
                return CodeVine_name;
                }
set{
                CodeHooks.Instance().SendFieldUpdate(this.GetHashCode(), "name", "raw", "Employee", value, CodeHooks.Now());


                CodeVine_name = value;
                }
}
 
            List<Employee> EmployeesList{get{
                return CodeVine_EmployeesList;
                }
set{
                CodeHooks.Instance().SendFieldUpdate(this.GetHashCode(), "EmployeesList", "raw", "Employee", value, CodeHooks.Now());


                CodeVine_EmployeesList = value;
                }
}
        }
 
        public class DepthFirstAlgorithm
        {
            public Employee BuildEmployeeGraph()
            {
var mrid = CodeHooks.Instance().OnMethodEnter(@"Program.cs", "BuildEmployeeGraph", this.GetHashCode(), "b9ba1d54-0f4c-4592-83a0-f2b7115c0b0e" );
CodeHooks.Instance().LogLineRun(mrid, 41, CodeHooks.Now(), "");
                Employee Eva = new Employee("Eva");
CodeHooks.Instance().LocalVarUpdate(mrid, "Eva", "", Eva, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 42, CodeHooks.Now(), "");
                Employee Sophia = new Employee("Sophia");
CodeHooks.Instance().LocalVarUpdate(mrid, "Sophia", "", Sophia, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 43, CodeHooks.Now(), "");
                Employee Brian = new Employee("Brian");
CodeHooks.Instance().LocalVarUpdate(mrid, "Brian", "", Brian, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 44, CodeHooks.Now(), "isEmployeeOf");
                Eva.isEmployeeOf(Sophia);
CodeHooks.Instance().LogLineRun(mrid, 45, CodeHooks.Now(), "isEmployeeOf");
                Eva.isEmployeeOf(Brian);
CodeHooks.Instance().LogLineRun(mrid, 47, CodeHooks.Now(), "");
 
                Employee Lisa = new Employee("Lisa");
CodeHooks.Instance().LocalVarUpdate(mrid, "Lisa", "", Lisa, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 48, CodeHooks.Now(), "");
                Employee Tina = new Employee("Tina");
CodeHooks.Instance().LocalVarUpdate(mrid, "Tina", "", Tina, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 49, CodeHooks.Now(), "");
                Employee John = new Employee("John");
CodeHooks.Instance().LocalVarUpdate(mrid, "John", "", John, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 50, CodeHooks.Now(), "");
                Employee Mike = new Employee("Mike");
CodeHooks.Instance().LocalVarUpdate(mrid, "Mike", "", Mike, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 51, CodeHooks.Now(), "isEmployeeOf");
                Sophia.isEmployeeOf(Lisa);
CodeHooks.Instance().LogLineRun(mrid, 52, CodeHooks.Now(), "isEmployeeOf");
                Sophia.isEmployeeOf(John);
CodeHooks.Instance().LogLineRun(mrid, 53, CodeHooks.Now(), "isEmployeeOf");
                Brian.isEmployeeOf(Tina);
CodeHooks.Instance().LogLineRun(mrid, 54, CodeHooks.Now(), "isEmployeeOf");
                Brian.isEmployeeOf(Mike);
CodeHooks.Instance().LogLineRun(mrid, 56, CodeHooks.Now(), "");
 
                return Eva;
CodeHooks.Instance().LogLineRun(mrid, 57, CodeHooks.Now(), "");
            }
 
            public Employee Search(Employee root, string nameToSearchFor)
            {
var mrid = CodeHooks.Instance().OnMethodEnter(@"Program.cs", "Search", this.GetHashCode(), "b9ba1d54-0f4c-4592-83a0-f2b7115c0b0e" );
CodeHooks.Instance().LocalVarUpdate(mrid, "root", "", root, CodeHooks.Now());
CodeHooks.Instance().LocalVarUpdate(mrid, "nameToSearchFor", "", nameToSearchFor, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 61, CodeHooks.Now(), "");
                if (nameToSearchFor == root.name)
{CodeHooks.Instance().LogLineRun(mrid, 62, CodeHooks.Now(), "");
                    return root;
CodeHooks.Instance().LogLineRun(mrid, 63, CodeHooks.Now(), "");
}CodeHooks.Instance().LogLineRun(mrid, 64, CodeHooks.Now(), "");
 
                Employee personFound = null;
CodeHooks.Instance().LocalVarUpdate(mrid, "personFound", "", personFound, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 65, CodeHooks.Now(), "");
                for (int i = 0; i < root.Employees.Count; i++)
                {
CodeHooks.Instance().LocalVarUpdate(mrid, "i", "", i, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 67, CodeHooks.Now(), "");
                    personFound = Search(root.Employees[i], nameToSearchFor);
CodeHooks.Instance().LocalVarUpdate(mrid, "personFound", "", personFound, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 68, CodeHooks.Now(), "");
                    if (personFound != null)
{CodeHooks.Instance().LogLineRun(mrid, 69, CodeHooks.Now(), "");
                        break;
CodeHooks.Instance().LogLineRun(mrid, 70, CodeHooks.Now(), "");
}CodeHooks.Instance().LogLineRun(mrid, 70, CodeHooks.Now(), "");
                }
CodeHooks.Instance().LogLineRun(mrid, 71, CodeHooks.Now(), "");
                return personFound;
CodeHooks.Instance().LogLineRun(mrid, 72, CodeHooks.Now(), "");
            }
 
            public void Traverse(Employee root)
            {
var mrid = CodeHooks.Instance().OnMethodEnter(@"Program.cs", "Traverse", this.GetHashCode(), "b9ba1d54-0f4c-4592-83a0-f2b7115c0b0e" );
CodeHooks.Instance().LocalVarUpdate(mrid, "root", "", root, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 76, CodeHooks.Now(), "WriteLine");
                Console.WriteLine(root.name);
CodeHooks.Instance().LogLineRun(mrid, 77, CodeHooks.Now(), "");
                for (int i = 0; i < root.Employees.Count; i++)
                {
CodeHooks.Instance().LocalVarUpdate(mrid, "i", "", i, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 79, CodeHooks.Now(), "");
                    Traverse(root.Employees[i]);
CodeHooks.Instance().LogLineRun(mrid, 80, CodeHooks.Now(), "");
                }
CodeHooks.Instance().LogLineRun(mrid, 81, CodeHooks.Now(), "");
            }
                public int CodeVine_ClrInstanceId{
                    get{
                        return this.GetHashCode();
                    }
                }
        }

    class Program
    {
 
        static void Main(string[] args)
        {
var mrid = CodeHooks.Instance().OnMethodEnter(@"Program.cs", "Main", -1, "b9ba1d54-0f4c-4592-83a0-f2b7115c0b0e" );
CodeHooks.Instance().LocalVarUpdate(mrid, "args", "", args, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 89, CodeHooks.Now(), "");
            DepthFirstAlgorithm b = new DepthFirstAlgorithm();
CodeHooks.Instance().LocalVarUpdate(mrid, "b", "", b, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 90, CodeHooks.Now(), "");
            Employee root = b.BuildEmployeeGraph();
CodeHooks.Instance().LocalVarUpdate(mrid, "root", "", root, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 91, CodeHooks.Now(), "WriteLine");
            Console.WriteLine("Traverse Graph\n------");
CodeHooks.Instance().LogLineRun(mrid, 92, CodeHooks.Now(), "Traverse");
            b.Traverse(root);
CodeHooks.Instance().LogLineRun(mrid, 94, CodeHooks.Now(), "WriteLine");
 
            Console.WriteLine("\nSearch in Graph\n------");
CodeHooks.Instance().LogLineRun(mrid, 95, CodeHooks.Now(), "");
            Employee e = b.Search(root, "Eva");
CodeHooks.Instance().LocalVarUpdate(mrid, "e", "", e, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 96, CodeHooks.Now(), "WriteLine");
            Console.WriteLine(e == null ? "Employee not found" : e.name);
CodeHooks.Instance().LogLineRun(mrid, 97, CodeHooks.Now(), "");
            e = b.Search(root, "Brian");
CodeHooks.Instance().LocalVarUpdate(mrid, "e", "", e, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 98, CodeHooks.Now(), "WriteLine");
            Console.WriteLine(e == null ? "Employee not found" : e.name);
CodeHooks.Instance().LogLineRun(mrid, 99, CodeHooks.Now(), "");
            e = b.Search(root, "Soni");
CodeHooks.Instance().LocalVarUpdate(mrid, "e", "", e, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 100, CodeHooks.Now(), "WriteLine");
            Console.WriteLine(e == null ? "Employee not found" : e.name);
CodeHooks.Instance().LogLineRun(mrid, 101, CodeHooks.Now(), "");
        }
                public int CodeVine_ClrInstanceId{
                    get{
                        return this.GetHashCode();
                    }
                }
    }
}
