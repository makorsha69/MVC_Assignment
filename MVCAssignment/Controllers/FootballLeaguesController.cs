using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCAssignment.Models;

namespace MVCAssignment.Controllers
{
    public class FootballLeaguesController : Controller
    {
        private readonly FootballDBContext _context;

        public FootballLeaguesController(FootballDBContext context)
        {
            _context = context;
        }

        // GET: FootballLeagues
        public async Task<IActionResult> Index()
        {
            return View(await _context.FootballLeagues.ToListAsync());
        }

        // GET: FootballLeagues/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var footballLeague = await _context.FootballLeagues
                .FirstOrDefaultAsync(m => m.MatchId == id);
            if (footballLeague == null)
            {
                return NotFound();
            }

            return View(footballLeague);
        }

        // GET: FootballLeagues/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FootballLeagues/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MatchId,TeamName1,TeamName2,Status,WinningTeam,Points")] FootballLeague footballLeague)
        {
            if (ModelState.IsValid)
            {
                _context.Add(footballLeague);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(footballLeague);
        }

        // GET: FootballLeagues/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var footballLeague = await _context.FootballLeagues.FindAsync(id);
            if (footballLeague == null)
            {
                return NotFound();
            }
            return View(footballLeague);
        }

        // POST: FootballLeagues/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MatchId,TeamName1,TeamName2,Status,WinningTeam,Points")] FootballLeague footballLeague)
        {
            if (id != footballLeague.MatchId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(footballLeague);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FootballLeagueExists(footballLeague.MatchId))
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
            return View(footballLeague);
        }

        // GET: FootballLeagues/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var footballLeague = await _context.FootballLeagues
                .FirstOrDefaultAsync(m => m.MatchId == id);
            if (footballLeague == null)
            {
                return NotFound();
            }

            return View(footballLeague);
        }

        // POST: FootballLeagues/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var footballLeague = await _context.FootballLeagues.FindAsync(id);
            _context.FootballLeagues.Remove(footballLeague);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FootballLeagueExists(int id)
        {
            return _context.FootballLeagues.Any(e => e.MatchId == id);
        }
    }
}
