using System;

namespace SharpVendas
{
    internal class DllImportAttribute : Attribute
    {
        public DllImportAttribute(string v, string EntryPoint)
        {
            this.EntryPoint = EntryPoint;
        }

        public string EntryPoint { get; set; }
    }
}