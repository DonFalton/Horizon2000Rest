using Horizon2000Rest.Entity.Models;

namespace Horizon2000Rest.Entity.Interfaces
{
    public interface IScrollingTextRepository
    {
        /// <summary>
        /// Retrieves a ScrollingTextDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the scrolling text.</param>
        /// <returns>The ScrollingTextDbo entity.</returns>
        ScrollingTextDbo Get(int id);

        /// <summary>
        /// Finds a ScrollingTextDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the scrolling text.</param>
        /// <returns>The ScrollingTextDbo entity if found, otherwise null.</returns>
        ScrollingTextDbo Find(int id);

        /// <summary>
        /// Retrieves all ScrollingTextDbo entities.
        /// </summary>
        /// <returns>A list of ScrollingTextDbo entities.</returns>
        List<ScrollingTextDbo> GetAll();

        /// <summary>
        /// Updates an existing ScrollingTextDbo entity.
        /// </summary>
        /// <param name="advert">The ScrollingTextDbo entity to be updated.</param>
        void Update(ScrollingTextDbo advert);

        /// <summary>
        /// Deletes a ScrollingTextDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the scrolling text to be deleted.</param>
        void Delete(int id);

        /// <summary>
        /// Adds a new ScrollingTextDbo entity.
        /// </summary>
        /// <param name="advert">The ScrollingTextDbo entity to be added.</param>
        void Add(ScrollingTextDbo advert);
    }
}
