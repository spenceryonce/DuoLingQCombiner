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
    public class WordListsController : Controller
    {
        private readonly WordDataContext _context;

        public WordListsController(WordDataContext context)
        {
            _context = context;
        }

        // GET: WordLists
        public async Task<IActionResult> Index()
        {
            return View(await _context.WordLists.ToListAsync());
        }

        // GET: WordLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wordList = await _context.WordLists
                .FirstOrDefaultAsync(m => m.Id == id);
            if (wordList == null)
            {
                return NotFound();
            }

            return View(wordList);
        }

        // GET: WordLists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WordLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Language,LastUpdated")] WordList wordList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(wordList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(wordList);
        }

        // GET: WordLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wordList = await _context.WordLists.FindAsync(id);
            if (wordList == null)
            {
                return NotFound();
            }
            return View(wordList);
        }

        // POST: WordLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Language,LastUpdated")] WordList wordList)
        {
            if (id != wordList.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wordList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WordListExists(wordList.Id))
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
            return View(wordList);
        }

        // GET: WordLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wordList = await _context.WordLists
                .FirstOrDefaultAsync(m => m.Id == id);
            if (wordList == null)
            {
                return NotFound();
            }

            return View(wordList);
        }

        // POST: WordLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var wordList = await _context.WordLists.FindAsync(id);
            _context.WordLists.Remove(wordList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WordListExists(int id)
        {
            return _context.WordLists.Any(e => e.Id == id);
        }
    }
}
