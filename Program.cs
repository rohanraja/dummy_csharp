using System;
using CodeRecordHelpers;
namespace TestCSharpProject
{
    class Program
    {
        static void Main(string[] args)
        {
var mrid = CodeHooks.Instance().OnMethodEnter(@"Program.cs", "Main", -1, "b8663066-dc3d-4011-9d0f-67aceaf1cb89" );
CodeHooks.Instance().LocalVarUpdate(mrid, "args", "", args, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 8, CodeHooks.Now(), "");
			ClassA classA = new ClassA();
CodeHooks.Instance().LocalVarUpdate(mrid, "classA", "", classA, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 9, CodeHooks.Now(), "WriteLine");
			Console.WriteLine("FROM MAIN: " + classA.GetHashCode());
CodeHooks.Instance().LogLineRun(mrid, 10, CodeHooks.Now(), "");
			int cnt = classA.GetCount();
CodeHooks.Instance().LocalVarUpdate(mrid, "cnt", "", cnt, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 11, CodeHooks.Now(), "WriteLine");
			Console.WriteLine("Count is: " + cnt.ToString());
CodeHooks.Instance().LogLineRun(mrid, 12, CodeHooks.Now(), "MethodA_1");
			classA.MethodA_1();
CodeHooks.Instance().LogLineRun(mrid, 13, CodeHooks.Now(), "");
			cnt = classA.GetCount();
CodeHooks.Instance().LocalVarUpdate(mrid, "cnt", "", cnt, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 14, CodeHooks.Now(), "WriteLine");
			Console.WriteLine("Count is: " + cnt.ToString());
CodeHooks.Instance().LogLineRun(mrid, 15, CodeHooks.Now(), "");
        }
                public int CodeVine_ClrInstanceId{
                    get{
                        return this.GetHashCode();
                    }
                }
    }
}
