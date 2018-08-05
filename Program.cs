using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeRecordHelpers; 
using CodeRecordHelpers;
namespace test2
{
        public class Employee
        {
            public Employee(string name)
            {
var mrid = CodeHooks.Instance().OnMethodEnter(@"Program.cs", "Employee", this.GetHashCode(), "21cc3208-40f1-4240-91dc-23a1bf2db911" );
CodeHooks.Instance().SendFieldUpdate(this.GetHashCode(), "CodeVine_name", "raw", "Employee", CodeVine_CodeVine_name, CodeHooks.Now());
CodeHooks.Instance().SendFieldUpdate(this.GetHashCode(), "CodeVine_EmployeesList", "raw", "Employee", CodeVine_CodeVine_EmployeesList, CodeHooks.Now());
CodeHooks.Instance().LocalVarUpdate(mrid, "name", "", name, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 12, CodeHooks.Now(), "");
var mrid = CodeHooks.Instance().OnMethodEnter(@"Program.cs", "Employee", this.GetHashCode(), "2d39135a-22f6-44ed-bda9-685314fe8284" );
CodeHooks.Instance().LocalVarUpdate(mrid, "mrid", "", mrid, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 13, CodeHooks.Now(), "SendFieldUpdate");
CodeHooks.Instance().SendFieldUpdate(this.GetHashCode(), "name", "raw", "Employee", CodeVine_name, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 14, CodeHooks.Now(), "SendFieldUpdate");
CodeHooks.Instance().SendFieldUpdate(this.GetHashCode(), "EmployeesList", "raw", "Employee", CodeVine_EmployeesList, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 15, CodeHooks.Now(), "LocalVarUpdate");
CodeHooks.Instance().LocalVarUpdate(mrid, "name", "", name, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 16, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 12, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 17, CodeHooks.Now(), "");
                this.name = name;
CodeHooks.Instance().LocalVarUpdate(mrid, "name", "", name, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 18, CodeHooks.Now(), "LocalVarUpdate");
CodeHooks.Instance().LocalVarUpdate(mrid, "name", "", name, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 19, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 13, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 20, CodeHooks.Now(), "");
            }
 
            public string CodeVine_CodeVine_name= ""; 
            public List<Employee> Employees
            {
                get
                {
                    return EmployeesList;
                }
            }
 
            public void isEmployeeOf(Employee e)
            {
var mrid = CodeHooks.Instance().OnMethodEnter(@"Program.cs", "isEmployeeOf", this.GetHashCode(), "21cc3208-40f1-4240-91dc-23a1bf2db911" );
CodeHooks.Instance().LocalVarUpdate(mrid, "e", "", e, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 33, CodeHooks.Now(), "");
var mrid = CodeHooks.Instance().OnMethodEnter(@"Program.cs", "isEmployeeOf", this.GetHashCode(), "2d39135a-22f6-44ed-bda9-685314fe8284" );
CodeHooks.Instance().LocalVarUpdate(mrid, "mrid", "", mrid, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 34, CodeHooks.Now(), "LocalVarUpdate");
CodeHooks.Instance().LocalVarUpdate(mrid, "e", "", e, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 35, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 26, CodeHooks.Now(), "Add");
CodeHooks.Instance().LogLineRun(mrid, 36, CodeHooks.Now(), "Add");
                EmployeesList.Add(e);
CodeHooks.Instance().LogLineRun(mrid, 37, CodeHooks.Now(), "SendFieldUpdate");
CodeHooks.Instance().SendFieldUpdate(this.GetHashCode(), "EmployeesList", "raw", "", EmployeesList, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 38, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 27, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 39, CodeHooks.Now(), "");
            }
 
            List<Employee> CodeVine_CodeVine_EmployeesList= new List<Employee>();
 
            public override string ToString()
            {
var mrid = CodeHooks.Instance().OnMethodEnter(@"Program.cs", "ToString", this.GetHashCode(), "21cc3208-40f1-4240-91dc-23a1bf2db911" );
CodeHooks.Instance().LogLineRun(mrid, 45, CodeHooks.Now(), "");
var mrid = CodeHooks.Instance().OnMethodEnter(@"Program.cs", "ToString", this.GetHashCode(), "2d39135a-22f6-44ed-bda9-685314fe8284" );
CodeHooks.Instance().LocalVarUpdate(mrid, "mrid", "", mrid, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 46, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 33, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 47, CodeHooks.Now(), "");
                return name;
CodeHooks.Instance().LogLineRun(mrid, 48, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 34, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 49, CodeHooks.Now(), "");
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
}                        public int CodeVine_ClrInstanceId{
                    get{
                        return this.GetHashCode();
                    }
                }
 
            public string CodeVine_name{get{
                return CodeVine_CodeVine_name;
                }
set{
                CodeHooks.Instance().SendFieldUpdate(this.GetHashCode(), "CodeVine_name", "raw", "Employee", value, CodeHooks.Now());


                CodeVine_CodeVine_name = value;
                }
} 
            List<Employee> CodeVine_EmployeesList{get{
                return CodeVine_CodeVine_EmployeesList;
                }
set{
                CodeHooks.Instance().SendFieldUpdate(this.GetHashCode(), "CodeVine_EmployeesList", "raw", "Employee", value, CodeHooks.Now());


                CodeVine_CodeVine_EmployeesList = value;
                }
}}
 
        public class DepthFirstAlgorithm
        {
            public Employee BuildEmployeeGraph()
            {
var mrid = CodeHooks.Instance().OnMethodEnter(@"Program.cs", "BuildEmployeeGraph", this.GetHashCode(), "21cc3208-40f1-4240-91dc-23a1bf2db911" );
CodeHooks.Instance().LogLineRun(mrid, 81, CodeHooks.Now(), "");
var mrid = CodeHooks.Instance().OnMethodEnter(@"Program.cs", "BuildEmployeeGraph", this.GetHashCode(), "2d39135a-22f6-44ed-bda9-685314fe8284" );
CodeHooks.Instance().LocalVarUpdate(mrid, "mrid", "", mrid, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 82, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 41, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 83, CodeHooks.Now(), "");
                Employee Eva = new Employee("Eva");
CodeHooks.Instance().LocalVarUpdate(mrid, "Eva", "", Eva, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 84, CodeHooks.Now(), "LocalVarUpdate");
CodeHooks.Instance().LocalVarUpdate(mrid, "Eva", "", Eva, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 85, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 42, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 86, CodeHooks.Now(), "");
                Employee Sophia = new Employee("Sophia");
CodeHooks.Instance().LocalVarUpdate(mrid, "Sophia", "", Sophia, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 87, CodeHooks.Now(), "LocalVarUpdate");
CodeHooks.Instance().LocalVarUpdate(mrid, "Sophia", "", Sophia, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 88, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 43, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 89, CodeHooks.Now(), "");
                Employee Brian = new Employee("Brian");
CodeHooks.Instance().LocalVarUpdate(mrid, "Brian", "", Brian, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 90, CodeHooks.Now(), "LocalVarUpdate");
CodeHooks.Instance().LocalVarUpdate(mrid, "Brian", "", Brian, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 91, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 44, CodeHooks.Now(), "isEmployeeOf");
CodeHooks.Instance().LogLineRun(mrid, 92, CodeHooks.Now(), "isEmployeeOf");
                Eva.isEmployeeOf(Sophia);
CodeHooks.Instance().LogLineRun(mrid, 93, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 45, CodeHooks.Now(), "isEmployeeOf");
CodeHooks.Instance().LogLineRun(mrid, 94, CodeHooks.Now(), "isEmployeeOf");
                Eva.isEmployeeOf(Brian);
CodeHooks.Instance().LogLineRun(mrid, 95, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 47, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 97, CodeHooks.Now(), "");
 
                Employee Lisa = new Employee("Lisa");
CodeHooks.Instance().LocalVarUpdate(mrid, "Lisa", "", Lisa, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 98, CodeHooks.Now(), "LocalVarUpdate");
CodeHooks.Instance().LocalVarUpdate(mrid, "Lisa", "", Lisa, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 99, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 48, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 100, CodeHooks.Now(), "");
                Employee Tina = new Employee("Tina");
CodeHooks.Instance().LocalVarUpdate(mrid, "Tina", "", Tina, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 101, CodeHooks.Now(), "LocalVarUpdate");
CodeHooks.Instance().LocalVarUpdate(mrid, "Tina", "", Tina, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 102, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 49, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 103, CodeHooks.Now(), "");
                Employee John = new Employee("John");
CodeHooks.Instance().LocalVarUpdate(mrid, "John", "", John, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 104, CodeHooks.Now(), "LocalVarUpdate");
CodeHooks.Instance().LocalVarUpdate(mrid, "John", "", John, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 105, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 50, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 106, CodeHooks.Now(), "");
                Employee Mike = new Employee("Mike");
CodeHooks.Instance().LocalVarUpdate(mrid, "Mike", "", Mike, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 107, CodeHooks.Now(), "LocalVarUpdate");
CodeHooks.Instance().LocalVarUpdate(mrid, "Mike", "", Mike, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 108, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 51, CodeHooks.Now(), "isEmployeeOf");
CodeHooks.Instance().LogLineRun(mrid, 109, CodeHooks.Now(), "isEmployeeOf");
                Sophia.isEmployeeOf(Lisa);
CodeHooks.Instance().LogLineRun(mrid, 110, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 52, CodeHooks.Now(), "isEmployeeOf");
CodeHooks.Instance().LogLineRun(mrid, 111, CodeHooks.Now(), "isEmployeeOf");
                Sophia.isEmployeeOf(John);
CodeHooks.Instance().LogLineRun(mrid, 112, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 53, CodeHooks.Now(), "isEmployeeOf");
CodeHooks.Instance().LogLineRun(mrid, 113, CodeHooks.Now(), "isEmployeeOf");
                Brian.isEmployeeOf(Tina);
CodeHooks.Instance().LogLineRun(mrid, 114, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 54, CodeHooks.Now(), "isEmployeeOf");
CodeHooks.Instance().LogLineRun(mrid, 115, CodeHooks.Now(), "isEmployeeOf");
                Brian.isEmployeeOf(Mike);
CodeHooks.Instance().LogLineRun(mrid, 116, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 56, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 118, CodeHooks.Now(), "");
 
                return Eva;
CodeHooks.Instance().LogLineRun(mrid, 119, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 57, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 120, CodeHooks.Now(), "");
            }
 
            public Employee Search(Employee root, string nameToSearchFor)
            {
var mrid = CodeHooks.Instance().OnMethodEnter(@"Program.cs", "Search", this.GetHashCode(), "21cc3208-40f1-4240-91dc-23a1bf2db911" );
CodeHooks.Instance().LocalVarUpdate(mrid, "root", "", root, CodeHooks.Now());
CodeHooks.Instance().LocalVarUpdate(mrid, "nameToSearchFor", "", nameToSearchFor, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 124, CodeHooks.Now(), "");
var mrid = CodeHooks.Instance().OnMethodEnter(@"Program.cs", "Search", this.GetHashCode(), "2d39135a-22f6-44ed-bda9-685314fe8284" );
CodeHooks.Instance().LocalVarUpdate(mrid, "mrid", "", mrid, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 125, CodeHooks.Now(), "LocalVarUpdate");
CodeHooks.Instance().LocalVarUpdate(mrid, "root", "", root, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 126, CodeHooks.Now(), "LocalVarUpdate");
CodeHooks.Instance().LocalVarUpdate(mrid, "nameToSearchFor", "", nameToSearchFor, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 127, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 61, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 128, CodeHooks.Now(), "");
                if (nameToSearchFor == root.name)
{CodeHooks.Instance().LogLineRun(mrid, 129, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 62, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 130, CodeHooks.Now(), "");
                    return root;
CodeHooks.Instance().LogLineRun(mrid, 131, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 63, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 132, CodeHooks.Now(), "");
}CodeHooks.Instance().LogLineRun(mrid, 132, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 64, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 134, CodeHooks.Now(), "");
 
                Employee personFound = null;
CodeHooks.Instance().LocalVarUpdate(mrid, "personFound", "", personFound, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 135, CodeHooks.Now(), "LocalVarUpdate");
CodeHooks.Instance().LocalVarUpdate(mrid, "personFound", "", personFound, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 136, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 65, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 137, CodeHooks.Now(), "");
                for (int i = 0; i < root.Employees.Count; i++)
                {
CodeHooks.Instance().LocalVarUpdate(mrid, "i", "", i, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 139, CodeHooks.Now(), "LocalVarUpdate");
CodeHooks.Instance().LocalVarUpdate(mrid, "i", "", i, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 140, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 67, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 141, CodeHooks.Now(), "");
                    personFound = Search(root.Employees[i], nameToSearchFor);
CodeHooks.Instance().LocalVarUpdate(mrid, "personFound", "", personFound, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 142, CodeHooks.Now(), "LocalVarUpdate");
CodeHooks.Instance().LocalVarUpdate(mrid, "personFound", "", personFound, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 143, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 68, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 144, CodeHooks.Now(), "");
                    if (personFound != null)
{CodeHooks.Instance().LogLineRun(mrid, 145, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 69, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 146, CodeHooks.Now(), "");
                        break;
CodeHooks.Instance().LogLineRun(mrid, 147, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 70, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 148, CodeHooks.Now(), "");
}CodeHooks.Instance().LogLineRun(mrid, 148, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 70, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 149, CodeHooks.Now(), "");
                }
CodeHooks.Instance().LogLineRun(mrid, 150, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 71, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 151, CodeHooks.Now(), "");
                return personFound;
CodeHooks.Instance().LogLineRun(mrid, 152, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 72, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 153, CodeHooks.Now(), "");
            }
 
            public void Traverse(Employee root)
            {
var mrid = CodeHooks.Instance().OnMethodEnter(@"Program.cs", "Traverse", this.GetHashCode(), "21cc3208-40f1-4240-91dc-23a1bf2db911" );
CodeHooks.Instance().LocalVarUpdate(mrid, "root", "", root, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 157, CodeHooks.Now(), "");
var mrid = CodeHooks.Instance().OnMethodEnter(@"Program.cs", "Traverse", this.GetHashCode(), "2d39135a-22f6-44ed-bda9-685314fe8284" );
CodeHooks.Instance().LocalVarUpdate(mrid, "mrid", "", mrid, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 158, CodeHooks.Now(), "LocalVarUpdate");
CodeHooks.Instance().LocalVarUpdate(mrid, "root", "", root, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 159, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 76, CodeHooks.Now(), "WriteLine");
CodeHooks.Instance().LogLineRun(mrid, 160, CodeHooks.Now(), "WriteLine");
                Console.WriteLine(root.name);
CodeHooks.Instance().LogLineRun(mrid, 161, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 77, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 162, CodeHooks.Now(), "");
                for (int i = 0; i < root.Employees.Count; i++)
                {
CodeHooks.Instance().LocalVarUpdate(mrid, "i", "", i, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 164, CodeHooks.Now(), "LocalVarUpdate");
CodeHooks.Instance().LocalVarUpdate(mrid, "i", "", i, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 165, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 79, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 166, CodeHooks.Now(), "");
                    Traverse(root.Employees[i]);
CodeHooks.Instance().LogLineRun(mrid, 167, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 80, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 168, CodeHooks.Now(), "");
                }
CodeHooks.Instance().LogLineRun(mrid, 169, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 81, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 170, CodeHooks.Now(), "");
            }
                public int CodeVine_ClrInstanceId{
                    get{
                        return this.GetHashCode();
                    }
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
var mrid = CodeHooks.Instance().OnMethodEnter(@"Program.cs", "Main", -1, "21cc3208-40f1-4240-91dc-23a1bf2db911" );
CodeHooks.Instance().LocalVarUpdate(mrid, "args", "", args, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 183, CodeHooks.Now(), "");
var mrid = CodeHooks.Instance().OnMethodEnter(@"Program.cs", "Main", -1, "2d39135a-22f6-44ed-bda9-685314fe8284" );
CodeHooks.Instance().LocalVarUpdate(mrid, "mrid", "", mrid, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 184, CodeHooks.Now(), "LocalVarUpdate");
CodeHooks.Instance().LocalVarUpdate(mrid, "args", "", args, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 185, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 89, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 186, CodeHooks.Now(), "");
            DepthFirstAlgorithm b = new DepthFirstAlgorithm();
CodeHooks.Instance().LocalVarUpdate(mrid, "b", "", b, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 187, CodeHooks.Now(), "LocalVarUpdate");
CodeHooks.Instance().LocalVarUpdate(mrid, "b", "", b, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 188, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 90, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 189, CodeHooks.Now(), "");
            Employee root = b.BuildEmployeeGraph();
CodeHooks.Instance().LocalVarUpdate(mrid, "root", "", root, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 190, CodeHooks.Now(), "LocalVarUpdate");
CodeHooks.Instance().LocalVarUpdate(mrid, "root", "", root, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 191, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 91, CodeHooks.Now(), "WriteLine");
CodeHooks.Instance().LogLineRun(mrid, 192, CodeHooks.Now(), "WriteLine");
            Console.WriteLine("Traverse Graph\n------");
CodeHooks.Instance().LogLineRun(mrid, 193, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 92, CodeHooks.Now(), "Traverse");
CodeHooks.Instance().LogLineRun(mrid, 194, CodeHooks.Now(), "Traverse");
            b.Traverse(root);
CodeHooks.Instance().LogLineRun(mrid, 195, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 94, CodeHooks.Now(), "WriteLine");
CodeHooks.Instance().LogLineRun(mrid, 197, CodeHooks.Now(), "WriteLine");
 
            Console.WriteLine("\nSearch in Graph\n------");
CodeHooks.Instance().LogLineRun(mrid, 198, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 95, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 199, CodeHooks.Now(), "");
            Employee e = b.Search(root, "Eva");
CodeHooks.Instance().LocalVarUpdate(mrid, "e", "", e, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 200, CodeHooks.Now(), "LocalVarUpdate");
CodeHooks.Instance().LocalVarUpdate(mrid, "e", "", e, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 201, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 96, CodeHooks.Now(), "WriteLine");
CodeHooks.Instance().LogLineRun(mrid, 202, CodeHooks.Now(), "WriteLine");
            Console.WriteLine(e == null ? "Employee not found" : e.name);
CodeHooks.Instance().LogLineRun(mrid, 203, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 97, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 204, CodeHooks.Now(), "");
            e = b.Search(root, "Brian");
CodeHooks.Instance().LocalVarUpdate(mrid, "e", "", e, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 205, CodeHooks.Now(), "LocalVarUpdate");
CodeHooks.Instance().LocalVarUpdate(mrid, "e", "", e, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 206, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 98, CodeHooks.Now(), "WriteLine");
CodeHooks.Instance().LogLineRun(mrid, 207, CodeHooks.Now(), "WriteLine");
            Console.WriteLine(e == null ? "Employee not found" : e.name);
CodeHooks.Instance().LogLineRun(mrid, 208, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 99, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 209, CodeHooks.Now(), "");
            e = b.Search(root, "Soni");
CodeHooks.Instance().LocalVarUpdate(mrid, "e", "", e, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 210, CodeHooks.Now(), "LocalVarUpdate");
CodeHooks.Instance().LocalVarUpdate(mrid, "e", "", e, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 211, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 100, CodeHooks.Now(), "WriteLine");
CodeHooks.Instance().LogLineRun(mrid, 212, CodeHooks.Now(), "WriteLine");
            Console.WriteLine(e == null ? "Employee not found" : e.name);
CodeHooks.Instance().LogLineRun(mrid, 213, CodeHooks.Now(), "LogLineRun");
CodeHooks.Instance().LogLineRun(mrid, 101, CodeHooks.Now(), "");
CodeHooks.Instance().LogLineRun(mrid, 214, CodeHooks.Now(), "");
        }
                public int CodeVine_ClrInstanceId{
                    get{
                        return this.GetHashCode();
                    }
                }
                public int CodeVine_ClrInstanceId{
                    get{
                        return this.GetHashCode();
                    }
                }
    }
}
