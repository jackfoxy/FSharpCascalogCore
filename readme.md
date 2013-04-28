Demonstration of problem with code in DLL created as follows:

ikvmc -target:library cascalog-core-1.10.2-SNAPSHOT-standalone.jar hadoop-core-1.1.2.jar commons-logging-1.1.2.jar

Reference the resulting DLL in the FSharp-Cascalog.fsproj

running the project results in the following error:

Unhandled Exception: cascading.flow.planner.PlannerException: could not build flow from assembly: [Unable to find class: cli.System.Int32] 
---> com.esotericsoftware.kryo.KryoException: Unable to find class: cli.System.Int32 
---> java.lang.ClassNotFoundException: cli.System.Int32
   at IKVM.NativeCode.java.lang.Class.forName0(String name, Boolean initialize, ClassLoader loader)
   at java.lang.Class.forName(String name, Boolean initialize, ClassLoader loader, CallerID )
   at com.esotericsoftware.kryo.util.DefaultClassResolver.readName(Input input)
   --- End of inner exception stack trace ---
   at com.esotericsoftware.kryo.util.DefaultClassResolver.readName(Input input)
   at com.esotericsoftware.kryo.util.DefaultClassResolver.readClass(Input input)

   at com.esotericsoftware.kryo.Kryo.readClass(Input input)
   at com.esotericsoftware.kryo.Kryo.readClassAndObject(Input input)
   at com.esotericsoftware.kryo.serializers.DefaultArraySerializers.ObjectArraySerializer.read(Kryo kryo, Input input, Class type)
   at com.esotericsoftware.kryo.serializers.DefaultArraySerializers.ObjectArraySerializer.<bridge>read(Kryo x0, Input x1, Class x2)
   at com.esotericsoftware.kryo.Kryo.readClassAndObject(Input input)
   at cascalog.KryoService.deserialize(Byte[] barr)
   at cascalog.ops.KryoInsert.getTuple()
   at cascalog.ops.KryoInsert.hashCode()
   at java.lang.Object.instancehelper_hashCode(Object this)
   at cascading.pipe.Operator.hashCode()
   at java.lang.Object.instancehelper_hashCode(Object this)
   at java.util.HashMap.hash(Object )
   at java.util.HashMap.put(Object key, Object value)
   at java.util.HashSet.add(Object e)
   at cascading.pipe.SubAssembly.unwind(Pipe[] tails)
   at cascading.pipe.Pipe.collectNames(Pipe[] , Set )
   at cascading.pipe.Pipe.collectNames(Pipe[] , Set )
   at cascading.pipe.Pipe.collectNames(Pipe[] , Set )
   at cascading.pipe.Pipe.names(Pipe[] tails)
   at cascading.flow.planner.FlowPlanner.verifyPipeAssemblyEndPoints(FlowDef flowDef)
   at cascading.flow.planner.FlowPlanner.verifyAssembly(FlowDef flowDef)
   at cascading.flow.hadoop.planner.HadoopPlanner.buildFlow(FlowDef flowDef)
   --- End of inner exception stack trace ---
   at cascading.flow.hadoop.planner.HadoopPlanner.buildFlow(FlowDef flowDef)
   at cascading.flow.FlowConnector.connect(FlowDef flowDef)
   at cascalog.api$compile_flow.doInvoke(Object )
   at clojure.lang.RestFn.applyTo(ISeq args)
   at clojure.core$apply.invoke(Object , Object )
   at cascalog.api$_QMARK__.doInvoke(Object )
   at clojure.lang.RestFn.invoke(Object arg1, Object arg2)
   at clojure.lang.Var.invoke(Object arg1, Object arg2)
   at clojure.lang.AFn.applyToHelper(IFn ifn, ISeq arglist)
   at clojure.lang.Var.applyTo(ISeq arglist)
   at jcascalog.Api.execute(String str, List l1, List l2)
   at jcascalog.Api.execute(List l1, List l2)
   at jcascalog.Api.execute(Object obj1, Object obj2)
   at Program.main(String[] argv) in E:\Documents\Visual Studio 2012\Projects\FSharp-Cascalog - Core\ConsoleApplication1\Program.fs:line 19