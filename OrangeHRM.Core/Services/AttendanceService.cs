using OrangeHRM.Data;
using OrangeHRM.Entities;
using System;
using System.Linq;

namespace OrangeHRM.Core.Services
{
    public class AttendanceService : IAttendanceService
    {
        private readonly OrangeHRMContext _context;

        public AttendanceService()
        {
            _context = new OrangeHRMContext();
        }

        public AttendanceRecord GetLatestRecord(int empNumber)
        {
            return _context.AttendanceRecords
                .Where(a => a.EmployeeNumber == empNumber)
                .OrderByDescending(a => a.PunchInUtcTime)
                .FirstOrDefault();
        }

        public void PunchIn(int empNumber, string note)
        {
            var record = new AttendanceRecord
            {
                EmployeeNumber = empNumber,
                PunchInUtcTime = DateTime.UtcNow,
                PunchInNote = note,
                State = "PUNCHED IN"
            };
            _context.AttendanceRecords.Add(record);
            _context.SaveChanges();
        }

        public void PunchOut(int empNumber, string note)
        {
            var record = GetLatestRecord(empNumber);
            if (record != null && record.State == "PUNCHED IN")
            {
                record.PunchOutUtcTime = DateTime.UtcNow;
                record.PunchOutNote = note;
                record.State = "PUNCHED OUT";
                _context.SaveChanges();
            }
        }
    }
}
