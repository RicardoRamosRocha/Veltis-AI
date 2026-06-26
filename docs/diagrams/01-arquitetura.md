# Diagrama 01 – Arquitetura Geral

## Objetivo

Representar a arquitetura completa do Veltis AI Platform.

```text
                    INTERNET
                        │
        ┌───────────────┴───────────────┐
        │                               │
        ▼                               ▼
  ASP.NET MVC                     Flutter App
 (Painel Admin)                  (Aplicativo)
        │                               │
        └───────────────┬───────────────┘
                        │
                        ▼
                VeltisAI.API
                        │
                        ▼
             Application Layer
                        │
                        ▼
                Domain Layer
                        │
                        ▼
           Infrastructure Layer
                        │
          ┌─────────────┴─────────────┐
          ▼                           ▼
     PostgreSQL              Provedores IA
                                  │
        ┌──────────┬─────────┬─────────────┐
        ▼          ▼         ▼             ▼
     OpenAI    Anthropic   Gemini     DeepSeek
```
