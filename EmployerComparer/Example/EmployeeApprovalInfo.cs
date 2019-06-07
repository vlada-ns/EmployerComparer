using System;
using System.Collections.Generic;
using System.Text;

namespace EmployerComparer.Example
{
    class EmployeeApprovalInfo
    {
        // <summary>
        /// Represent new Employee object that is in Approval process
        /// </summary>
        //public EmployeeProfile ChangedEmployeeProfile { get; set; }


        /// <summary>
        /// Draft, PendingHRApproval, PendingFinanceApproval, Rejected, ToApproved
        /// </summary>
        //public EmployeeApprovalStatusEnum ApprovalStatus { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public ICollection<PropertyChange> Changes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public EmployeeApprovalInfo()
        {
            Changes = new List<PropertyChange>();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class PropertyChange
    {
        /// <summary>
        /// 
        /// </summary>
        public String PropertyName { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public dynamic PropertyOriginalValue { get; set; }

    }
}
