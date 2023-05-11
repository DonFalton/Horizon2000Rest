namespace Horizon2000Rest.Entity.Models.Course
{
    public class BaseCourseDto
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string Name { get; set; }

        public int NormalHour { get; set; }
        public decimal NormalPrice { get; set; }
        public int RapidHour { get; set; }
        public decimal RapidPrice { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string Description { get; set; }

        public int ParentCourseId { get; set; }
    }
}
