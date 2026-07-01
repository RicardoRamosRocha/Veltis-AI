using VeltisAI.Application.AI.Contracts;

namespace VeltisAI.Application.AI.Factories;

public interface IProviderFactory
{
    IAIProvider GetProvider(string providerName);
}