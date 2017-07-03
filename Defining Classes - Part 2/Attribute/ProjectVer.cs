namespace ProjectVersion
{
    using System;

    [AttributeUsage(AttributeTargets.All)]

    public class ProjectVer : Attribute
    {
        public double Version { get; set; }

        public ProjectVer(double version)
        {
            this.Version = version;
        }
    }
}
