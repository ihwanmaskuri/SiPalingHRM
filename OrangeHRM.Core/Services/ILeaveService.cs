using OrangeHRM.Entities;
using System.Collections.Generic;

namespace OrangeHRM.Core.Services
{
    public interface ILeaveService
    {
        IEnumerable<LeaveRequest> GetEmployeeLeaveRequests(int empNumber);
        void SubmitLeaveRequest(LeaveRequest request);
        void CancelLeaveRequest(int requestId);
        IEnumerable<LeaveType> GetActiveLeaveTypes();
    }
}
