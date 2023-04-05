using Horizon2000.DataManagement.Models.Schedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Horizon2000.Rest.Models.Response.Schedule
{
    public class GetScheduleResponse : BaseResponseSO
    {
        public GetScheduleDto Schedule { get; set; }
    }
}