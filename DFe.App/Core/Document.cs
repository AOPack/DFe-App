using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFe.App.Core
{
    public class Document
    {
        public string AccessKey { get; set; }

        public short Mod
        {
            get { return Convert.ToInt16(AccessKey.Substring(20, 2)); }
        }

        public short Serial
        {
            get { return Convert.ToInt16(AccessKey.Substring(22, 3)); }
        }

        public long Number
        {
            get { return Convert.ToInt64(AccessKey.Substring(25, 9)); }
        }

        public decimal Amount { get; set; }

        public string IssuerName { get; set; }

        public string IssuerCnpj { get; set; }
    }
}
