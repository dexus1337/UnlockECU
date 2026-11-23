using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UnlockECU
{
    public class Parameter
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public string DataType { get; set; }
        [IgnoreDataMember]
        public int AccessLevel = -1;
    }
}
