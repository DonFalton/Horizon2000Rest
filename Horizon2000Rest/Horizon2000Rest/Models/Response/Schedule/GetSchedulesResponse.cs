using Horizon2000.DataManagement.Models.Schedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Horizon2000.Rest.Models.Response.Schedule
{
    public class GetSchedulesResponse : BaseResponseSO
    {
        public List<GetScheduleDto> Schedules { get; set; }
    }
}