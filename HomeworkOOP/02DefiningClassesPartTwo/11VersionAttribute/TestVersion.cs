using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11VersionAttribute
{
    [VersionAttribute("2.11")]

    class TestVersion
    {
        static void Main()
        {
            object[] versionAttributes = typeof(TestVersion).GetCustomAttributes(typeof(VersionAttribute), false);

            Console.WriteLine("Version: {0}", versionAttributes[0]);
        }
    }
}
