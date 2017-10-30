using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFe.App.Common
{
    public static class Constants
    {
        public static string DfeAppPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments,
                Environment.SpecialFolderOption.Create), "DFeApp");

        public static string SchemasPath = Path.Combine(DfeAppPath, "Schemas");
    }
}
