using System;
using OrangeHRM.Entities;

namespace OrangeHRM.Core.Services
{
    public interface IAttendanceService
    {
        AttendanceRecord GetLatestRecord(int empNumber);
        void PunchIn(int empNumber, string note);
        void PunchOut(int empNumber, string note);
    }
}
