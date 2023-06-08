using Horizon2000Rest.Entity.Models;
using System.Collections.Generic;

namespace Horizon2000Rest.Core.Interfaces
{
    /// <summary>
    /// Interface for managing schedules.
    /// </summary>
    public interface IScheduleWorker
    {
        /// <summary>
        /// Retrieves all schedules.
        /// </summary>
        /// <returns>The list of schedules.</returns>
        List<ScheduleDbo> GetAllSchedules();

        /// <summary>
        /// Retrieves a schedule by ID.
        /// </summary>
        /// <param name="id">The ID of the schedule.</param>
        /// <returns>The schedule.</returns>
        ScheduleDbo GetSchedule(int id);
        void AddSchedule(ScheduleDbo schedule);
        void UpdateSchedule(ScheduleDbo schedule);
    }
}