using EventMe.Core.Constants;
using EventMe.Core.Contracts;
using EventMe.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EventMe.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventService eventService;

        private readonly ILogger logger;

        public EventController(
            IEventService _eventService,
            ILogger<EventController> _logger)
        {
            eventService = _eventService;
            logger = _logger;
        }

        public async Task<IActionResult> Index()
        {
            var model = await eventService.GetAllAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new EventModel();
            ViewBag.Towns = await GetTownsAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(EventModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await eventService.CreateAsync(model);

                    return RedirectToAction(nameof(Index));
                }
                catch (ArgumentException ex)
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "Error creating event");
                    ModelState.AddModelError(string.Empty, UserMessageConstants.UnknownError);
                }
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await eventService.GetByIdAsync(id);
            ViewBag.Towns = await GetTownsAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EventModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await eventService.EditAsync(model);

                    return RedirectToAction(nameof(Index));
                }
                catch (ArgumentException ex)
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "Error editing event");
                    ModelState.AddModelError(string.Empty, UserMessageConstants.UnknownError);
                }
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await eventService.DeleteAsync(id);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Delete failed");
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var model = await eventService.GetByIdAsync(id);

            return View(model);
        }

        private async Task<IEnumerable<SelectListItem>> GetTownsAsync()
        {
            var towns = await eventService.GetTownsAsync();

            return towns
                .Select(t => new SelectListItem(t.Name, t.Id.ToString()));
        }
    }
}
