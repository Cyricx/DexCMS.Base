using System;
using System.Collections.Generic;

namespace DexCMS.Base.Models
{
    public partial class SettingDataTypes
    {
        public SettingDataTypes()
        {
            Settings = new HashSet<Settings>();
        }

        public int SettingDataTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Settings> Settings { get; set; }
    }
}
