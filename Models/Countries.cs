using System;
using System.Collections.Generic;

namespace DexCMS.Base.Models
{
    public partial class Countries
    {
        public Countries()
        {
            States = new HashSet<States>();
        }

        public int CountryId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<States> States { get; set; }
    }
}
