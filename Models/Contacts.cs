using System;
using System.Collections.Generic;

namespace DexCMS.Base.Models
{
    public partial class Contacts
    {
        public Contacts()
        {
            VisitedPages = new HashSet<VisitedPages>();
        }

        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public string OtherSubject { get; set; }
        public DateTime SubmitDate { get; set; }
        public string Referrer { get; set; }
        public int ContactTypeId { get; set; }

        public virtual ICollection<VisitedPages> VisitedPages { get; set; }
        public virtual ContactTypes ContactType { get; set; }
    }
}
