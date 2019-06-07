using System;
using System.Collections.Generic;
using System.Text;

namespace EmployerComparer.Model
{
    class Company
    {
        public Company()
        {
            //CompanyBank = new HashSet<CompanyBank>();
            Employer = new HashSet<Employer>();
            //TradeLicence = new HashSet<TradeLicence>();
        }

        public int CompanyId { get; set; }
        public string Name { get; set; }
        public int EmployerTypeId { get; set; }
        public string Industry { get; set; }
        public string Address { get; set; }

        public int CityId { get; set; }
        public string VatNumber { get; set; }
        public string LandLineNumber { get; set; }
        public string CompanyWebsite { get; set; }
        public int? NumberOfEmployees { get; set; }
        public int? SalaryPayDayInMonth { get; set; }
        public int? BankInfoId { get; set; }
        public int? ProbationPeriodInMonths { get; set; }

        //public virtual City City { get; set; }
        //public virtual ICollection<CompanyBank> CompanyBank { get; set; }
        public virtual ICollection<Employer> Employer { get; set; }
        //public virtual ICollection<TradeLicence> TradeLicence { get; set; }
    }
}
