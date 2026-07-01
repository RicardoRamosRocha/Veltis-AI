using VeltisAI.Application.AI.DTOs;

namespace VeltisAI.Application.AI.Contracts;

public interface IAIProvider
{
    string ProviderName { get; }

    Task<ChatResponse> ChatAsync(
        ChatRequest request,
        CancellationToken cancellationToken = default);
}