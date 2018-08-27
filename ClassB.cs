using System;
using CodeRecordHelpers;
using CodeRecordHelpers;
namespace TestCSharpProject
{
    public class ClassB
    {
		public string CodeVine_name= "";


        public ClassB(string pName)
        {
var mrid = CodeHooks.Instance().OnMethodEnter(@"ClassB.cs", "ClassB", this.GetHashCode(), "b8663066-dc3d-4011-9d0f-67aceaf1cb89" );
CodeHooks.Instance().SendFieldUpdate(this.GetHashCode(), "name", "raw", "ClassB", CodeVine_name, CodeHooks.Now());
CodeHooks.Instance().LocalVarUpdate(mrid, "pName", "", pName, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 12, CodeHooks.Now(), "");
			name = pName;
CodeHooks.Instance().LogLineRun(mrid, 13, CodeHooks.Now(), "");
        }


		public void MethodB_1()
		{
var mrid = CodeHooks.Instance().OnMethodEnter(@"ClassB.cs", "MethodB_1", this.GetHashCode(), "b8663066-dc3d-4011-9d0f-67aceaf1cb89" );
CodeHooks.Instance().LogLineRun(mrid, 18, CodeHooks.Now(), "");
			name = name + " MODIFIED";
CodeHooks.Instance().LogLineRun(mrid, 19, CodeHooks.Now(), "");
      throw new Exception("Test Exception");
CodeHooks.Instance().LogLineRun(mrid, 21, CodeHooks.Now(), "");

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
                CodeHooks.Instance().SendFieldUpdate(this.GetHashCode(), "name", "raw", "ClassB", value, CodeHooks.Now());


                CodeVine_name = value;
                }
}

    }
}
