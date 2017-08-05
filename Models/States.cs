using System;
using System.Collections.Generic;

namespace DexCMS.Base.Models
{
    public partial class States
    {
        public States()
        {
        }

        public int StateId { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public string Abbreviation { get; set; }

        public virtual Countries Country { get; set; }
    }
}
