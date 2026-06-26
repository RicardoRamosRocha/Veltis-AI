# ADR-004 — Integração com Múltiplos Provedores de IA

**Status:** Aprovado

## Contexto

O mercado de Inteligência Artificial evolui rapidamente, com novos modelos e provedores surgindo com frequência.

## Decisão

A plataforma será construída para suportar múltiplos provedores de IA por meio de uma camada de abstração.

## Provedores iniciais

* OpenAI
* Anthropic
* Google Gemini
* Grok
* DeepSeek
* Azure OpenAI
* OpenRouter

## Consequências

A adição de novos provedores exigirá apenas a implementação de novos adaptadores, sem impacto nos módulos de negócio.
