using Horizon2000Rest.Core.Interfaces;
using Horizon2000Rest.Entity.Data;
using Horizon2000Rest.Entity.Interfaces;
using Horizon2000Rest.Entity.Models;

namespace Horizon2000Rest.Core.Workers
{
    /// <summary>
    /// Implementation of the IScheduleWorker interface for managing schedules operations.
    /// </summary>
    public class ScheduleWorker : IScheduleWorker
    {
        private readonly DataContext _dataContext;
        private readonly IScheduleRepository _scheduleRepository;

        public ScheduleWorker(DataContext dataContext, IScheduleRepository scheduleRepository)
        {
            _dataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
            _scheduleRepository = scheduleRepository ?? throw new ArgumentNullException(nameof(scheduleRepository));
        }

        /// <inheritdoc/>
        public List<ScheduleDbo> GetAllSchedules()
        {
            return _scheduleRepository.GetAll();
        }

        /// <inheritdoc/>
        public ScheduleDbo GetSchedule(int id)
        {
            return _scheduleRepository.Get(id);
        }

        /// <inheritdoc/>
        public void AddSchedule(ScheduleDbo schedule)
        {
            _scheduleRepository.Add(schedule);
            _dataContext.SaveChanges();
        }

        /// <inheritdoc/>
        public void UpdateSchedule(ScheduleDbo schedule)
        {
            _scheduleRepository.Update(schedule);
            _dataContext.SaveChanges();
        }
    }
}
