using System;
using System.Collections.Generic;
using System.Text;

namespace EmployerComparer.Model
{
    class Person
    {
        public int PersonId { get; set; }
        public int EmployerId { get; set; }

        public string FirstName { get; set; }
        public string Email { get; set; }
        public string LastName { get; set; }
        public string Salutation { get; set; }
        public string MobileNumber { get; set; }
        public int? PreferredLanguageId { get; set; }
        public int? PersonStatusId { get; set; }
        public int PersonRoleId { get; set; }
        public Guid UserId { get; set; }



        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }

        public string AuthyId { get; set; }

        public bool IsEmailValidated { get; set; }

        public bool IsMobileValidated { get; set; }

        //public virtual PersonRole PersonRole { get; set; }
        public virtual Employer Employer { get; set; }
        //public virtual PersonStatus PersonStatus { get; set; }
        //public Language PrefferedLanguage { get; set; }
        //public virtual IList<PersonFileInfo> PersonFileInfo { get; set; } = new List<PersonFileInfo>();
        public Guid? ModifiedBy { get; set; }
        public int? PersonStatusChangeId { get; set; }
        //public PersonStatusChange PersonStatusChange { get; set; }
    }
}
