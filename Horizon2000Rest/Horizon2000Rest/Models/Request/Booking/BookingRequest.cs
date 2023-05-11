using Horizon2000.DataManagement.Models.Student;

namespace Horizon2000.Rest.Models.Request.Booking
{
    public class BookingRequest : BaseRequest
    {

        public StudentDto Student { get; set; }

        public int CourseId { get; set; }
    }
}