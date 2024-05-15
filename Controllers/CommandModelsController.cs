using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BLOC3ProjetReservationJO.Data;
using BLOC3ProjetReservationJO.Models;

namespace BLOC3ProjetReservationJO.Controllers
{
    public class CommandModelsController : Controller
    {
        private readonly BLOC3ProjetReservationJOContext _context;

        public CommandModelsController(BLOC3ProjetReservationJOContext context)
        {
            _context = context;
        }

        // GET: CommandModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.CommandModel.ToListAsync());
        }

        // GET: CommandModels/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commandModel = await _context.CommandModel
                .FirstOrDefaultAsync(m => m.CommandId == id);
            if (commandModel == null)
            {
                return NotFound();
            }

            return View(commandModel);
        }

        // GET: CommandModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CommandModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CommandId,CommandDate,PaymentKey,UserKey,TicketKey")] CommandModel commandModel)
        {
            if (ModelState.IsValid)
            {
                commandModel.CommandId = Guid.NewGuid();
                _context.Add(commandModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(commandModel);
        }

        // GET: CommandModels/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commandModel = await _context.CommandModel.FindAsync(id);
            if (commandModel == null)
            {
                return NotFound();
            }
            return View(commandModel);
        }

        // POST: CommandModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CommandId,CommandDate,PaymentKey,UserKey,TicketKey")] CommandModel commandModel)
        {
            if (id != commandModel.CommandId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(commandModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CommandModelExists(commandModel.CommandId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(commandModel);
        }

        // GET: CommandModels/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commandModel = await _context.CommandModel
                .FirstOrDefaultAsync(m => m.CommandId == id);
            if (commandModel == null)
            {
                return NotFound();
            }

            return View(commandModel);
        }

        // POST: CommandModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var commandModel = await _context.CommandModel.FindAsync(id);
            if (commandModel != null)
            {
                _context.CommandModel.Remove(commandModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CommandModelExists(Guid id)
        {
            return _context.CommandModel.Any(e => e.CommandId == id);
        }
    }
}
