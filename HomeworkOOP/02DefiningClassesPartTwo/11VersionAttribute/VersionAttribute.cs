//11.Create a [Version] attribute that can be applied to structures, classes, interfaces, 
//enumerations and methods and holds a version in the format major.minor (e.g. 2.11). 
//Apply the version attribute to a sample class and display its version at runtime.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11VersionAttribute
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class |
        AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Enum)]

    class VersionAttribute : System.Attribute
    {
        public string Version { get; private set; }

        public VersionAttribute(string version)
        {
            this.Version = version;
        }

        public override string ToString()
        {
            return this.Version;
        }
    }
}