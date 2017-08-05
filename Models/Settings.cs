using System;
using System.Collections.Generic;

namespace DexCMS.Base.Models
{
    public partial class Settings
    {
        public int SettingId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int SettingDataTypeId { get; set; }
        public int SettingGroupId { get; set; }

        public virtual SettingDataTypes SettingDataType { get; set; }
        public virtual SettingGroups SettingGroup { get; set; }
    }
}
