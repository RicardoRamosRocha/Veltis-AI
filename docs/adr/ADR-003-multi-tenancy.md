# ADR-003 — Estratégia Multi-Tenant

**Status:** Aprovado

## Contexto

O Veltis AI Platform atenderá diversas empresas utilizando a mesma aplicação.

## Decisão

Adotar Multi-Tenant com banco de dados compartilhado e isolamento lógico por Company.

## Motivos

* Redução de custos.
* Facilidade de manutenção.
* Escalabilidade.
* Administração centralizada.

## Consequências

Cada entidade de negócio possuirá referência para Company.

Isso garantirá isolamento dos dados entre empresas.
