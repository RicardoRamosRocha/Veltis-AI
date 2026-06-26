
---

## `docs/diagrams/06-deploy.md`

```md
# Diagrama 06 – Fluxo de Deploy

## Objetivo

Representar a estratégia inicial de publicação do Veltis AI Platform.

```text
Desenvolvedor
   │
   ▼
Git Commit
   │
   ▼
Git Push
   │
   ▼
GitHub
   │
   ▼
Pipeline CI/CD
   │
   ▼
Build
   │
   ▼
Testes
   │
   ▼
Publicação
   │
   ▼
Servidor Linux / Docker
   │
   ▼
Aplicação ASP.NET Core
   │
   ▼
PostgreSQL