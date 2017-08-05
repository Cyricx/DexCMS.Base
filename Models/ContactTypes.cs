using System;
using System.Collections.Generic;

namespace DexCMS.Base.Models
{
    public partial class ContactTypes
    {
        public ContactTypes()
        {
            Contacts = new HashSet<Contacts>();
        }

        public int ContactTypeId { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Contacts> Contacts { get; set; }
    }
}
