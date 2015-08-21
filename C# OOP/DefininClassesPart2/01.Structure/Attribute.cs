
namespace _01.Structure
{
    using System;

    [AttributeUsage(AttributeTargets.Class| AttributeTargets.Struct | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method)]

    public class VersionAttribute : System.Attribute
    {
        private int VersionMajor {get; set;}
        public int VersionMinor {get;set;}

        public VersionAttribute(int major, int minor)
        {
            this.VersionMajor = major;
            this.VersionMinor = minor;
        }

        public string Version 
        {
            get
            {
                return string.Format("{0}.{1}", VersionMajor,VersionMinor);
            }
        }
    }
}
