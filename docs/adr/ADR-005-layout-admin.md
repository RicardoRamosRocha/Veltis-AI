# ADR-005 — Painel Administrativo em ASP.NET Core MVC

**Status:** Aprovado

## Contexto

O sistema necessita de um painel administrativo robusto, rápido e de fácil manutenção.

## Decisão

Desenvolver o painel administrativo utilizando ASP.NET Core MVC.

## Motivos

* Integração nativa com o backend.
* Alto desempenho.
* Facilidade de desenvolvimento.
* Reutilização da autenticação e da camada de aplicação.
* Excelente suporte a Bootstrap.

## Futuro

O aplicativo Flutter consumirá exclusivamente a API REST, mantendo o painel administrativo independente e otimizado para uso em navegadores.
