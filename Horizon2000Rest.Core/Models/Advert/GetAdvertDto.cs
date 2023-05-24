namespace Horizon2000Rest.Core.Models.Advert
{
    /// <summary>
    /// Data transfer object for retrieving an advert.
    /// </summary>
    public class GetAdvertDto
    {
        /// <summary>
        /// Gets or sets the ID of the advert.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the image data of the advert.
        /// </summary>
        public byte[] Image { get; set; }

        /// <summary>
        /// Gets or sets the file type of the advert image.
        /// </summary>
        public string ImageFileType { get; set; }
    }
}
