using System;
using System.Collections.Generic;
using System.Text;

namespace EmployerComparer.Model
{
    class Employer
    {
        public Employer()
        {
            Person = new HashSet<Person>();
            //EmployerApproval = new HashSet<EmployerApproval>();
            //EmployerNote = new HashSet<EmployerNote>();
        }

        public int EmployerId { get; set; }
        public int CompanyId { get; set; }
        public DateTime DateOfApplication { get; set; }
        public DateTime? LastScheduledBlackoutHappened { get; set; }
        public int EmployerStatusId { get; set; }
        public int? ContactPersonId { get; set; }
        public int? PortfolioId { get; set; }
        public string FlexxCode { get; set; }
        public string Currency { get; set; }
        public bool? IsInBlackOut { get; set; }
        public DateTime? EnrollmentDate { get; set; }


        public virtual Company Company { get; set; }
        public virtual Person ContactPerson { get; set; }
        //public virtual EmployerStatus EmployerStatus { get; set; }
        public virtual ICollection<Person> Person { get; set; }
        //public virtual ICollection<EmployerNote> EmployerNote { get; set; }
        //public virtual ICollection<EmployerApproval> EmployerApproval { get; set; }
        //public virtual EmployerRejectionReason EmployerRejectionReason { get; set; }
    }
}
