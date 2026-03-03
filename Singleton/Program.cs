using SingletonSpace;
using System.Runtime.CompilerServices;

RuntimeHelpers.RunClassConstructor(typeof(StadiumProxy).TypeHandle);
RuntimeHelpers.RunClassConstructor(typeof(StadiumServer).TypeHandle);

Singleton.SetClaseActiva("proxy");

var s = Singleton.Instance();

System.Console.WriteLine(s.StadiumUtility());