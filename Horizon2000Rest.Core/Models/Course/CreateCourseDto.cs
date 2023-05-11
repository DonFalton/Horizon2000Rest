namespace Horizon2000Rest.Entity.Models.Course
{
    public class CreateCourseDto : BaseCourseDto
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string Image { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string ImageFileName { get; set; }

    }
}
