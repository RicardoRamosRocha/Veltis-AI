using Microsoft.EntityFrameworkCore;
using VeltisAI.Application.Interfaces.Repositories;
using VeltisAI.Domain.Entities;
using VeltisAI.Infrastructure.Data;

namespace VeltisAI.Infrastructure.Repositories;

public class PlanRepository : IPlanRepository
{
    private readonly AppDbContext _context;

    public PlanRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Plan>> GetAllAsync()
    {
        return await _context.Plans
            .OrderBy(x => x.Name)
            .ToListAsync();
    }

    public async Task<Plan?> GetByIdAsync(Guid id)
    {
        return await _context.Plans
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task AddAsync(Plan plan)
    {
        await _context.Plans.AddAsync(plan);
    }

    public Task UpdateAsync(Plan plan)
    {
        _context.Plans.Update(plan);
        return Task.CompletedTask;
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);

        if (entity != null)
            _context.Plans.Remove(entity);
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}