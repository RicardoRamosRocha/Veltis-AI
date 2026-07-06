using Microsoft.EntityFrameworkCore;
using VeltisAI.Application.Interfaces.Repositories;
using VeltisAI.Domain.Entities;
using VeltisAI.Infrastructure.Data;

namespace VeltisAI.Infrastructure.Repositories;

public class AIProviderRepository : IAIProviderRepository
{
    private readonly AppDbContext _context;

    public AIProviderRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<AIProvider>> GetAllAsync()
    {
        return await _context.AIProviders
            .OrderBy(x => x.Priority)
            .ThenBy(x => x.DisplayName)
            .ToListAsync();
    }

    public async Task<AIProvider?> GetByIdAsync(Guid id)
    {
        return await _context.AIProviders
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task AddAsync(AIProvider provider)
    {
        await _context.AIProviders.AddAsync(provider);
    }

    public Task UpdateAsync(AIProvider provider)
    {
        _context.AIProviders.Update(provider);
        return Task.CompletedTask;
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);

        if (entity is not null)
            _context.AIProviders.Remove(entity);
    }

    public async Task<bool> ExistsAsync(Guid id)
    {
        return await _context.AIProviders
            .AnyAsync(x => x.Id == id);
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}