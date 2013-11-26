using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuropeanVatChecker
{
    public class EuropeanStateInfo
    {
        public string ShortCode { get; internal set; }
        public EuropeanState State { get; internal set; }
        public string ValidationPattern { get; internal set; }
    }
}
