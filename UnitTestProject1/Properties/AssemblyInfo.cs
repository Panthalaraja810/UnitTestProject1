using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("UnitTestProject1")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("HP")]
[assembly: AssemblyProduct("UnitTestProject1")]
[assembly: AssemblyCopyright("Copyright © HP 2023")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: ComVisible(false)]

[assembly: Guid("096ad7b1-0569-4638-aed8-2dab42aab352")]

// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: Parallelize(Workers = 1, Scope = Microsoft.VisualStudio.TestTools.UnitTesting.ExecutionScope.MethodLevel)]