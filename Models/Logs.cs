using System;
using System.Collections.Generic;

namespace DexCMS.Base.Models
{
    public partial class Logs
    {
        public int LogId { get; set; }
        public DateTime LogTime { get; set; }
        public int LogType { get; set; }
        public string Message { get; set; }
    }
}
