using Horizon2000Rest.Entity.Data;
using Horizon2000Rest.Entity.Interfaces;
using Horizon2000Rest.Entity.Models;

namespace Horizon2000REST.Entity.Repositories
{
    /// <inheritdoc/>
    /// <seealso cref="IScrollingTextRepository"/>
    /// <summary>
    /// Repository class for managing scrolling texts.
    /// </summary>
    public class ScrollingTextRepository : IScrollingTextRepository
    {
        /// <summary>
        /// Database context.
        /// </summary>
        private readonly DataContext _dataContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrollingTextRepository"/> class.
        /// </summary>
        /// <param name="horizonContext">The database context.</param>
        public ScrollingTextRepository(DataContext horizonContext)
        {
            _dataContext = horizonContext;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Retrieves a ScrollingTextDbo object by its ID.
        /// </summary>
        /// <param name="id">The ID of the scrolling text to retrieve.</param>
        /// <returns>The retrieved ScrollingTextDbo object.</returns>
        public ScrollingTextDbo Get(int id)
        {
            return _dataContext.ScrollingTexts.FirstOrDefault(x => x.ID == id) ??
                throw new ArgumentNullException("ScrollingText not found");
        }

        /// <inheritdoc/>
        /// <summary>
        /// Finds a ScrollingTextDbo object by its ID.
        /// </summary>
        /// <param name="id">The ID of the scrolling text to find.</param>
        /// <returns>The found ScrollingTextDbo object, or null if not found.</returns>
        public ScrollingTextDbo Find(int id) =>
            _dataContext.ScrollingTexts.FirstOrDefault(x => x.ID == id);

        /// <inheritdoc/>
        /// <summary>
        /// Retrieves all active ScrollingTextDbo objects.
        /// </summary>
        /// <returns>A list of active ScrollingTextDbo objects.</returns>
        public List<ScrollingTextDbo> GetAll() =>
            _dataContext.ScrollingTexts
                .Where(x => x.IsActive)
                .ToList();

        /// <inheritdoc/>
        /// <summary>
        /// Updates a ScrollingTextDbo object.
        /// </summary>
        /// <param name="scrollingText">The ScrollingTextDbo object to update.</param>
        public void Update(ScrollingTextDbo scrollingText)
        {
            _dataContext.Update(scrollingText);
        }

        /// <inheritdoc/>
        /// <summary>
        /// Deletes a ScrollingTextDbo object by setting IsActive to false.
        /// </summary>
        /// <param name="id">The ID of the scrolling text to delete.</param>
        public void Delete(int id)
        {
            var scrollingText = Get(id);
            scrollingText.IsActive = false;

            Update(scrollingText);
        }

        /// <inheritdoc/>
        /// <summary>
        /// Adds a new ScrollingTextDbo object.
        /// </summary>
        /// <param name="scrollingText">The ScrollingTextDbo object to add.</param>
        public void Add(ScrollingTextDbo scrollingText)
        {
            _dataContext.ScrollingTexts.Add(scrollingText);
        }
    }
}
