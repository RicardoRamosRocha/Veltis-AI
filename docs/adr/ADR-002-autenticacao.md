# ADR-002 — ASP.NET Identity

**Status:** Aprovado

## Contexto

A plataforma necessita de autenticação segura, gerenciamento de usuários, papéis e permissões.

## Decisão

Utilizar o ASP.NET Identity como solução oficial de autenticação.

## Motivos

* Framework oficial da Microsoft.
* Integração nativa com ASP.NET Core.
* Gerenciamento de usuários e papéis.
* Recuperação de senha.
* Segurança consolidada.
* Suporte contínuo.

## Consequências

### Positivas

* Maior segurança.
* Menor esforço de implementação.
* Fácil integração com JWT no futuro.

### Negativas

* Estrutura de tabelas mais extensa.
