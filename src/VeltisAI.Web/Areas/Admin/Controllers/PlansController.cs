using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VeltisAI.Domain.Entities;
using VeltisAI.Infrastructure.Data;

namespace VeltisAI.Web.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize(Roles = "Admin")]
public class PlansController : Controller
{
    private readonly AppDbContext _context;

    public PlansController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var plans = await _context.Plans
            .OrderBy(x => x.Name)
            .ToListAsync();

        return View(plans);
    }

    public async Task<IActionResult> Details(Guid? id)
    {
        if (id is null)
            return NotFound();

        var plan = await _context.Plans
            .FirstOrDefaultAsync(x => x.Id == id);

        if (plan is null)
            return NotFound();

        return View(plan);
    }

    public IActionResult Create()
    {
        return View(new Plan());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(
        [Bind("Name,Description,MonthlyPrice,CreditsIncluded,MaxUsers,MaxTokensPerMonth,Active")]
        Plan plan)
    {
        if (!ModelState.IsValid)
            return View(plan);

        plan.Id = Guid.NewGuid();
        plan.CreatedAt = DateTime.UtcNow;

        _context.Plans.Add(plan);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Edit(Guid? id)
    {
        if (id is null)
            return NotFound();

        var plan = await _context.Plans.FindAsync(id);

        if (plan is null)
            return NotFound();

        return View(plan);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(
        Guid id,
        [Bind("Id,Name,Description,MonthlyPrice,CreditsIncluded,MaxUsers,MaxTokensPerMonth,Active,CreatedAt")]
        Plan plan)
    {
        if (id != plan.Id)
            return NotFound();

        if (!ModelState.IsValid)
            return View(plan);

        try
        {
            _context.Plans.Update(plan);
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!PlanExists(plan.Id))
                return NotFound();

            throw;
        }

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(Guid? id)
    {
        if (id is null)
            return NotFound();

        var plan = await _context.Plans
            .FirstOrDefaultAsync(x => x.Id == id);

        if (plan is null)
            return NotFound();

        return View(plan);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(Guid id)
    {
        var plan = await _context.Plans.FindAsync(id);

        if (plan is not null)
        {
            _context.Plans.Remove(plan);
            await _context.SaveChangesAsync();
        }

        return RedirectToAction(nameof(Index));
    }

    private bool PlanExists(Guid id)
    {
        return _context.Plans.Any(x => x.Id == id);
    }
}