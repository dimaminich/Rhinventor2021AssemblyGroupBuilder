using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace Rhinventor2021AssemblyGroupBuilder
{
    public class Rhinventor2021AssemblyGroupBuilderInfo : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "Rhinventor2021AssemblyGroupBuilder";
            }
        }
        public override Bitmap Icon
        {
            get
            {
                //Return a 24x24 pixel bitmap to represent this GHA library.
                return null;
            }
        }
        public override string Description
        {
            get
            {
                //Return a short string describing the purpose of this GHA library.
                return "";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("2fa25285-43b6-44d3-b699-bff249d9316e");
            }
        }

        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return "";
            }
        }
        public override string AuthorContact
        {
            get
            {
                //Return a string representing your preferred contact details.
                return "";
            }
        }
    }
}
