
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BVLONGLesson10.Models;

public class BvlongsController : Controller
{
    private readonly BVLONGlesson10Context _context;

    public BvlongsController(BVLONGlesson10Context context)
    {
        _context = context;
    }

    // GET: BVLONGS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Bvlongs.ToListAsync());
    }

    // GET: BVLONGS/Details/5
    public async Task<IActionResult> Details(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var bvlong = await _context.Bvlongs
            .FirstOrDefaultAsync(m => m.Id == id);
        if (bvlong == null)
        {
            return NotFound();
        }

        return View(bvlong);
    }

    // GET: BVLONGS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: BVLONGS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,BvlongUsername,BvlongPassword,BvlongFullName,BvlongEmail,BvlongPhone,BvlongStatus")] Bvlong bvlong)
    {
        if (ModelState.IsValid)
        {
            _context.Add(bvlong);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(bvlong);
    }

    // GET: BVLONGS/Edit/5
    public async Task<IActionResult> Edit(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var bvlong = await _context.Bvlongs.FindAsync(id);
        if (bvlong == null)
        {
            return NotFound();
        }
        return View(bvlong);
    }

    // POST: BVLONGS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(long? id, [Bind("Id,BvlongUsername,BvlongPassword,BvlongFullName,BvlongEmail,BvlongPhone,BvlongStatus")] Bvlong bvlong)
    {
        if (id != bvlong.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(bvlong);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BvlongExists(bvlong.Id))
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
        return View(bvlong);
    }

    // GET: BVLONGS/Delete/5
    public async Task<IActionResult> Delete(long? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var bvlong = await _context.Bvlongs
            .FirstOrDefaultAsync(m => m.Id == id);
        if (bvlong == null)
        {
            return NotFound();
        }

        return View(bvlong);
    }

    // POST: BVLONGS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(long? id)
    {
        var bvlong = await _context.Bvlongs.FindAsync(id);
        if (bvlong != null)
        {
            _context.Bvlongs.Remove(bvlong);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool BvlongExists(long? id)
    {
        return _context.Bvlongs.Any(e => e.Id == id);
    }
}
