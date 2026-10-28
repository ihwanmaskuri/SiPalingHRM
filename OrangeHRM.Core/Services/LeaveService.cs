using OrangeHRM.Data;
using OrangeHRM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrangeHRM.Core.Services
{
    public class LeaveService : ILeaveService
    {
        private readonly OrangeHRMContext _context;

        public LeaveService()
        {
            _context = new OrangeHRMContext();
        }

        public IEnumerable<LeaveRequest> GetEmployeeLeaveRequests(int empNumber)
        {
            return _context.LeaveRequests
                .Where(r => r.EmployeeNumber == empNumber)
                .OrderByDescending(r => r.DateApplied)
                .ToList();
        }

        public void SubmitLeaveRequest(LeaveRequest request)
        {
            request.DateApplied = DateTime.Now;
            _context.LeaveRequests.Add(request);
            _context.SaveChanges();
        }

        public void CancelLeaveRequest(int requestId)
        {
            var request = _context.LeaveRequests.Find(requestId);
            if (request != null)
            {
                // In OrangeHRM, we usually update status of individual leave days
                var days = _context.Leaves.Where(l => l.LeaveRequestId == requestId);
                foreach (var day in days)
                {
                    day.Status = 0; // Cancelled
                }
                _context.SaveChanges();
            }
        }

        public IEnumerable<LeaveType> GetActiveLeaveTypes()
        {
            return _context.LeaveTypes.Where(t => !t.IsDeleted).ToList();
        }
    }
}
