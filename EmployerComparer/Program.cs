using EmployerComparer.Model;
using KellermanSoftware.CompareNetObjects;
using System;

namespace EmployerComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Create a couple objects to compare
            Company company1 = new Company(){
                CompanyId = 1,
                Name = "Levi9",
                EmployerTypeId = 1,
                Industry = "Informacione tehnologije",
                Address = "Trifkovicev trg 6, 21000 Novi Sad, Serbia",
                CityId = 1,
                VatNumber = "1234567890",
                LandLineNumber = "+381(0) 21 215 55 04",
                CompanyWebsite = "www.levi9.com",
                NumberOfEmployees = 1000,
                SalaryPayDayInMonth = 1,
                BankInfoId = 91,
                ProbationPeriodInMonths = 6
            };

            Company company2 = new Company()
            {
                CompanyId = 2,
                Name = "Levi9",
                EmployerTypeId = 1,
                Industry = "Informacione tehnologije",
                Address = "Zorza Klemansoa br 19, 11000 Beograd, Serbia",
                CityId = 2,
                VatNumber = "1234567890",
                LandLineNumber = "+381 21 2155513",
                CompanyWebsite = "www.levi9.com",
                NumberOfEmployees = 1000,
                SalaryPayDayInMonth = 1,
                BankInfoId = 91,
                ProbationPeriodInMonths = 6
            };

            Person person1 = new Person() {
                PersonId = 1,
                EmployerId = 1,
                FirstName = "Jan",
                Email = "j.dolinaj@levi9.com",
                LastName = "Dolinaj",
                Salutation = "Mr",
                MobileNumber = "",
                PreferredLanguageId = 1,
                PersonStatusId = 1,
                PersonRoleId = 2,
                UserId = Guid.NewGuid(),
                ValidFrom = DateTime.Now,
                ValidTo = DateTime.Now.AddYears(1),
                AuthyId = "2",
                IsEmailValidated = true,
                IsMobileValidated = true,
                ModifiedBy = null,
                PersonStatusChangeId = null
            };

            Person person2 = new Person()
            {
                PersonId = 2,
                EmployerId = 1,
                FirstName = "Pien",
                Email = "p.oosterman@levi9.com",
                LastName = "Oosterman",
                Salutation = "Mrs",
                MobileNumber = "",
                PreferredLanguageId = 1,
                PersonStatusId = 1,
                PersonRoleId = 1,
                UserId = Guid.NewGuid(),
                ValidFrom = DateTime.Now,
                ValidTo = DateTime.Now.AddYears(2),
                AuthyId = "1",
                IsEmailValidated = true,
                IsMobileValidated = true,
                ModifiedBy = null,
                PersonStatusChangeId = null
            };

            Employer employer1 = new Employer() {
                EmployerId = 1,
                CompanyId = 1,
                DateOfApplication = DateTime.Now,
                LastScheduledBlackoutHappened = null,
                EmployerStatusId = 1,
                ContactPersonId = 1,
                PortfolioId = 1,
                FlexxCode = "FlexxCode 1",
                Currency = "rsd",
                IsInBlackOut = false,
                EnrollmentDate = DateTime.Now,
            };

            Employer employer2 = new Employer()
            {
                EmployerId = 2,
                CompanyId = 2,
                DateOfApplication = DateTime.Now,
                LastScheduledBlackoutHappened = null,
                EmployerStatusId = 1,
                ContactPersonId = 2,
                PortfolioId = 2,
                FlexxCode = "FlexxCode 1",
                Currency = "Euro",
                IsInBlackOut = false,
                EnrollmentDate = DateTime.Now,
            };

            employer1.Company = company1;
            employer1.ContactPerson = person1;
            employer1.Person.Add(person1);

            employer2.Company = company2;
            employer2.ContactPerson = person2;
            employer2.Person.Add(person2);

            //This is the comparison class
            CompareLogic compareLogic = new CompareLogic();

            // explanation --> https://github.com/GregFinzer/Compare-Net-Objects/wiki/Getting-Started#important
            compareLogic.Config.MaxDifferences = 999;

            ComparisonResult result = compareLogic.Compare(employer1, employer2);

            if (!result.AreEqual)
                Console.WriteLine(result.DifferencesString);

            Console.ReadKey();
        }
    }
}
