using EventMe.Core.Models;

namespace EventMe.Core.Contracts
{
    /// <summary>
    /// Услуга за събития
    /// </summary>
    public interface IEventService
    {
        /// <summary>
        /// Създаване на събитие
        /// </summary>
        /// <param name="model">Модел на събитие</param>
        /// <returns></returns>
        Task CreateAsync(EventModel model);

        /// <summary>
        /// Изтриване на събитие
        /// </summary>
        /// <param name="id">Идентификатор на събитие</param>
        /// <returns></returns>
        Task DeleteAsync(int id);

        /// <summary>
        /// Редактиране на събитие
        /// </summary>
        /// <param name="model">Модел на събитие</param>
        /// <returns></returns>
        Task EditAsync(EventModel model);

        /// <summary>
        /// Извличане на събитие по идентификатор
        /// </summary>
        /// <param name="id">Идентификатор на събитие</param>
        /// <returns></returns>
        Task<EventModel> GetByIdAsync(int id);

        /// <summary>
        /// Извличане на всички събития
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<EventModel>> GetAllAsync();

        /// <summary>
        /// Извличане на всички градове
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<TownModel>> GetTownsAsync();
    }
}
