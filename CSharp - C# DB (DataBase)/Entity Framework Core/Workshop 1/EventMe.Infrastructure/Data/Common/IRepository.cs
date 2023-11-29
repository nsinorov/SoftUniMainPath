using EventMe.Infrastructure.Data.Contracts;

namespace EventMe.Infrastructure.Data.Common
{
    /// <summary>
    /// Методи за достъп до данни
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        /// Добавяне на елемент в базата данни
        /// </summary>
        /// <typeparam name="T">Тип на елемента</typeparam>
        /// <param name="entity">Елемент</param>
        /// <returns></returns>
        Task AddAsync<T>(T entity) where T : class;

        /// <summary>
        /// Изтриване на елемент от базата данни
        /// </summary>
        /// <typeparam name="T">Тип на елемента</typeparam>
        /// <param name="entity">Елемент</param>
        void Delete<T>(T entity) where T : class, IDeletable;

        /// <summary>
        /// Извличане на всички елементи от таблицата
        /// </summary>
        /// <typeparam name="T">Тип на елементите</typeparam>
        /// <returns></returns>
        IQueryable<T> All<T>() where T : class;

        /// <summary>
        /// Извличане на всички елементи от таблицата, включително изтритите
        /// </summary>
        /// <typeparam name="T">Тип на елементите</typeparam>
        /// <returns></returns>
        IQueryable<T> AllWithDeleted<T>() where T : class, IDeletable;

        // <summary>
        /// Извличане на всички елементи от таблицата само за четене
        /// </summary>
        /// <typeparam name="T">Тип на елементите</typeparam>
        /// <returns></returns>
        IQueryable<T> AllReadonly<T>() where T : class;

        /// <summary>
        /// Извличане на всички елементи от таблицата, включително изтритите, само за четене
        /// </summary>
        /// <typeparam name="T">Тип на елементите</typeparam>
        /// <returns></returns>
        IQueryable<T> AllWithDeletedReadonly<T>() where T : class, IDeletable;

        /// <summary>
        /// Извличане на елемент по идентификатор
        /// </summary>
        /// <typeparam name="T">Тип на елемента</typeparam>
        /// <param name="id">Идентификатор на елемента</param>
        /// <returns></returns>
        Task<T?> GetById<T>(int id) where T : class;

        /// <summary>
        /// Запис на промените в базата данни
        /// </summary>
        /// <returns></returns>
        Task<int> SaveChangesAsync();
    }
}
