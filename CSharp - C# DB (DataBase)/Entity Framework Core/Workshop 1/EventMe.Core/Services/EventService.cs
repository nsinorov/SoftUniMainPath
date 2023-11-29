using EventMe.Core.Contracts;
using EventMe.Core.Models;
using EventMe.Infrastructure.Data.Common;
using EventMe.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EventMe.Core.Services
{
    public class EventService : IEventService
    {
        private readonly IRepository eventRepository;

        public EventService(IRepository _eventRepository)
        {
            eventRepository = _eventRepository;
        }

        /// <summary>
        /// Създаване на събитие
        /// </summary>
        /// <param name="model">Модел на събитие</param>
        /// <returns></returns>
        public async Task CreateAsync(EventModel model)
        {
            if (model.Id > 0)
            {
                bool exists = eventRepository.GetById<Event>(model.Id) != null;

                throw new ArgumentException("Събитието вече съществува");
            }

            Event newEvent = new Event()
            {
                Name = model.Name,
                Start = model.Start,
                End = model.End,
                IsActive = true,
                Place = new Address()
                {
                    StreetAddress = model.StreetAddress,
                    TownId = model.TownId
                }
            };

            await eventRepository.AddAsync(newEvent);
            await eventRepository.SaveChangesAsync();
        }

        /// <summary>
        /// Изтриване на събитие
        /// </summary>
        /// <param name="id">Идентификатор на събитие</param>
        /// <returns></returns>
        public async Task DeleteAsync(int id)
        {
            Event? ev = await eventRepository
                .GetById<Event>(id);

            if (ev != null)
            {
                eventRepository.Delete(ev);
                await eventRepository.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Редактиране на събитие
        /// </summary>
        /// <param name="model">Модел на събитие</param>
        /// <returns></returns>
        public async Task EditAsync(EventModel model)
        {
            Event? ev = await eventRepository
                .All<Event>()
                .Include(e => e.Place)
                .ThenInclude(p => p.Town)
                .FirstOrDefaultAsync(e => e.Id == model.Id);

            if (ev == null)
            {
                throw new ArgumentException("Събитието не съществува");
            }

            ev.Name = model.Name;
            ev.Start = model.Start;
            ev.End = model.End;
            ev.Place.StreetAddress = model.StreetAddress;
            ev.Place.TownId = model.TownId;

            await eventRepository.SaveChangesAsync();
        }

        /// <summary>
        /// Извличане на събитие по идентификатор
        /// </summary>
        /// <param name="id">Идентификатор на събитие</param>
        /// <returns></returns>
        public async Task<EventModel> GetByIdAsync(int id)
        {
            Event? ev = await eventRepository
                .AllReadonly<Event>()
                .Include(e => e.Place)
                .ThenInclude(p => p.Town)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (ev == null)
            {
                throw new ArgumentException("Събитието не съществува");
            }

            return new EventModel()
            {
                Id = ev.Id,
                Name = ev.Name,
                Start = ev.Start,
                End = ev.End,
                StreetAddress = ev.Place.StreetAddress,
                TownId = ev.Place.TownId,
                TownName = ev.Place.Town.Name
            };
        }

        /// <summary>
        /// Извличане на всички събития
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<EventModel>> GetAllAsync()
        {
            return await eventRepository
                .AllReadonly<Event>()
                .Select(e => new EventModel()
                {
                    Id = e.Id,
                    Name = e.Name,
                    Start = e.Start,
                    End = e.End,
                    StreetAddress = e.Place.StreetAddress,
                    TownId = e.Place.TownId
                })
                .ToListAsync();
        }

        /// <summary>
        /// Извличане на всички градове
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<TownModel>> GetTownsAsync()
        {
            return await eventRepository
                .AllReadonly<Town>()
                .Select(t => new TownModel()
                {
                    Id = t.Id,
                    Name = t.Name
                })
                .ToListAsync();
        }
    }
}
