namespace Horizon2000Rest.Core.Models.Advert
{
    /// <summary>
    /// Data transfer object for adding an advert.
    /// </summary>
    public class AddAdvertDto
    {
        /// <summary>
        /// Gets or sets the file name of the advert.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the file type of the advert.
        /// </summary>
        public string FileType { get; set; }

        /// <summary>
        /// Gets or sets the image data of the advert.
        /// </summary>
        public string Image { get; set; }
    }
}
