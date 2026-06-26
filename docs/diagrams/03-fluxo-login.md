# Diagrama 03 – Fluxo de Autenticação

```text
Usuário
   │
   ▼
Tela de Login
   │
   ▼
AccountController
   │
   ▼
ASP.NET Identity
   │
Senha válida?
   │
 ┌─┴────────────┐
 │              │
 ▼              ▼
Sim            Não
 │              │
 ▼              ▼
Dashboard    Mensagem de erro
```
