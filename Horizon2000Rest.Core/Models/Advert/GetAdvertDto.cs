namespace Horizon2000Rest.Entity.Models.Advert
{
    public class GetAdvertDto
    {
        public int Id { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public byte[] Image { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string ImageFileType { get; set; }

    }
}
