using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Калькулятор
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class AssemblyInfo
    {
        [assembly: AssemblyTitle("Калькулятор")]
        [assembly: AssemblyDescription("Мой первый калькулятор")]
        [assembly: AssemblyCompany("TUZMAN TEAM")]
        [assembly: AssemblyProduct("KalTuz")]
        [assembly: AssemblyCopyright("Copyright © TUZMAN 2024")]
        [assembly: AssemblyTrademark("KalTuz")]
        [assembly: AssemblyVersion("1.0.0.0")]
        [assembly: AssemblyFileVersion("1.0.0.0")]

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
