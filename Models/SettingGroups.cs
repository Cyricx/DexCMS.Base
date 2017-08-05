using System;
using System.Collections.Generic;

namespace DexCMS.Base.Models
{
    public partial class SettingGroups
    {
        public SettingGroups()
        {
            Settings = new HashSet<Settings>();
        }

        public int SettingGroupId { get; set; }
        public string SettingGroupName { get; set; }

        public virtual ICollection<Settings> Settings { get; set; }
    }
}
