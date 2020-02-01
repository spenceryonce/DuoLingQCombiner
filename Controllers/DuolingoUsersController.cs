using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DuoLingQCombiner.Models;

namespace DuoLingQCombiner.Controllers
{
    public class DuolingoUsersController : Controller
    {
        private readonly WordDataContext _context;
        private static WordDataContext dupContext;

        public DuolingoUsersController(WordDataContext context)
        {
            _context = context;
            dupContext = _context;
        }

        public static void SyncDuolingoUser(DuolingoUser user)
        {
            var ctx = dupContext;
            ctx.Add(user);
            ctx.SaveChanges();
            
        }

        // GET: DuolingoUsers
        public async Task<IActionResult> Index()
        {
            return View(await _context.DuolingoUsers.ToListAsync());
        }

        // GET: DuolingoUsers/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var duolingoUser = await _context.DuolingoUsers
                .FirstOrDefaultAsync(m => m.id == id);
            if (duolingoUser == null)
            {
                return NotFound();
            }

            return View(duolingoUser);
        }

        // GET: DuolingoUsers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DuolingoUsers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,username,email,rupees,created,learning_language")] DuolingoUser duolingoUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(duolingoUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(duolingoUser);
        }

        // GET: DuolingoUsers/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var duolingoUser = await _context.DuolingoUsers.FindAsync(id);
            if (duolingoUser == null)
            {
                return NotFound();
            }
            return View(duolingoUser);
        }

        // POST: DuolingoUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("id,username,email,rupees,created,learning_language")] DuolingoUser duolingoUser)
        {
            if (id != duolingoUser.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(duolingoUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DuolingoUserExists(duolingoUser.id))
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
            return View(duolingoUser);
        }

        // GET: DuolingoUsers/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var duolingoUser = await _context.DuolingoUsers
                .FirstOrDefaultAsync(m => m.id == id);
            if (duolingoUser == null)
            {
                return NotFound();
            }

            return View(duolingoUser);
        }

        // POST: DuolingoUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var duolingoUser = await _context.DuolingoUsers.FindAsync(id);
            _context.DuolingoUsers.Remove(duolingoUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DuolingoUserExists(string id)
        {
            return _context.DuolingoUsers.Any(e => e.id == id);
        }
    }
}
