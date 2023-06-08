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
        /// <returns>The list of ScheduleDbo objects representing the schedules.</returns>
        List<ScheduleDbo> GetAllSchedules();

        /// <summary>
        /// Retrieves a schedule by ID.
        /// </summary>
        /// <param name="id">The ID of the schedule.</param>
        /// <returns>The ScheduleDbo object representing the schedule.</returns>
        ScheduleDbo GetSchedule(int id);

        /// <summary>
        /// Adds a new schedule.
        /// </summary>
        /// <param name="schedule">The ScheduleDbo object containing the schedule data.</param>
        void AddSchedule(ScheduleDbo schedule);

        /// <summary>
        /// Updates an existing schedule.
        /// </summary>
        /// <param name="schedule">The ScheduleDbo object containing the updated schedule data.</param>
        void UpdateSchedule(ScheduleDbo schedule);
    }
}
