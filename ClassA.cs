using System;
using System.Collections.Generic;
using CodeRecordHelpers;

namespace TestCSharpProject
{
    public class ClassA
    {
		public ClassB CodeVine_clsB; 
		public int CodeVine_count= 0;

		public ClassA()
        {
var mrid = CodeHooks.Instance().OnMethodEnter(@"ClassA.cs", "ClassA", this.GetHashCode(), "b8663066-dc3d-4011-9d0f-67aceaf1cb89" );
CodeHooks.Instance().SendFieldUpdate(this.GetHashCode(), "clsB", "raw", "ClassA", CodeVine_clsB, CodeHooks.Now());
CodeHooks.Instance().SendFieldUpdate(this.GetHashCode(), "count", "raw", "ClassA", CodeVine_count, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 13, CodeHooks.Now(), "");
			clsB = new ClassB("teststr");
CodeHooks.Instance().LogLineRun(mrid, 14, CodeHooks.Now(), "");
        }


		public void MethodA_1()
        {
var mrid = CodeHooks.Instance().OnMethodEnter(@"ClassA.cs", "MethodA_1", this.GetHashCode(), "b8663066-dc3d-4011-9d0f-67aceaf1cb89" );
CodeHooks.Instance().LogLineRun(mrid, 19, CodeHooks.Now(), "MethodB_1");
			clsB.MethodB_1();
CodeHooks.Instance().SendFieldUpdate(this.GetHashCode(), "clsB", "raw", "", clsB, CodeHooks.Now());
CodeHooks.Instance().LogLineRun(mrid, 20, CodeHooks.Now(), "");
			count = 22;
CodeHooks.Instance().LogLineRun(mrid, 21, CodeHooks.Now(), "");
        }

        public int GetCount()
		{
var mrid = CodeHooks.Instance().OnMethodEnter(@"ClassA.cs", "GetCount", this.GetHashCode(), "b8663066-dc3d-4011-9d0f-67aceaf1cb89" );
CodeHooks.Instance().LogLineRun(mrid, 25, CodeHooks.Now(), "");
			return count;
CodeHooks.Instance().LogLineRun(mrid, 27, CodeHooks.Now(), "");

		}
                public int CodeVine_ClrInstanceId{
                    get{
                        return this.GetHashCode();
                    }
                }

public ClassB clsB{get{
                return CodeVine_clsB;
                }
set{
                CodeHooks.Instance().SendFieldUpdate(this.GetHashCode(), "clsB", "raw", "ClassA", value, CodeHooks.Now());


                CodeVine_clsB = value;
                }
}

public int count{get{
                return CodeVine_count;
                }
set{
                CodeHooks.Instance().SendFieldUpdate(this.GetHashCode(), "count", "raw", "ClassA", value, CodeHooks.Now());


                CodeVine_count = value;
                }
}


    }
}
