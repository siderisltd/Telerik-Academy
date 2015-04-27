namespace Coordinates
{
    using System;
    using System.Linq;

    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct |
     System.AttributeTargets.Enum | System.AttributeTargets.Interface |
     System.AttributeTargets.Method, AllowMultiple = true)]

    public class VersionAttribute : System.Attribute
    {
        public string Name { get; private set; }
        public string Version { get; private set; }

        public VersionAttribute(string name, string version)
        {
            this.Name = name;
            this.Version = version;
        }
    }
}
