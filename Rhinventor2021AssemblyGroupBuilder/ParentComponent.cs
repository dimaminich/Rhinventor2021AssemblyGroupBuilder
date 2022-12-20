using System.Collections.Generic;
using System.IO;

namespace Rhinventor2021AssemblyGroupBuilder
{
    class ParentComponent
    {
        public string compRootFolderPath { get; set; }
        public string compLabel { get; set; }
        public Rhino.Geometry.Plane compPlane { get; set; }
        public List<ChildComponent> childComponents { get; set; }
        public List<Dictionary<string, object>> compiPropertyData { get; set; }


        public string createDirectory()
        {
            if (System.IO.Directory.Exists(compRootFolderPath)) throw new IOException("Folder aready exist");
            System.IO.Directory.CreateDirectory(compRootFolderPath);
            return compRootFolderPath;
        }
    }
}
