using Horizon2000.DataManagement.Models.Schedule;

namespace Horizon2000.Rest.Models.Request.Schedule
{
    public class UpdateScheduleRequest : BaseRequest
    {
        public UpdateScheduleDto Schedule { get; set; }
    }
}