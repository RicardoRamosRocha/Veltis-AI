# ADR-001 — Arquitetura em Camadas

**Status:** Aprovado

## Contexto

O Orizon AI Platform será um sistema SaaS de médio e grande porte, com diversos módulos e possibilidade de crescimento contínuo.

Era necessário definir uma arquitetura que favorecesse manutenção, escalabilidade e organização do código.

## Decisão

Foi adotada uma arquitetura em camadas composta por:

* Domain
* Application
* Infrastructure
* Web
* API

## Consequências

### Positivas

* Baixo acoplamento.
* Alta organização.
* Facilidade de testes.
* Evolução independente das camadas.
* Maior reutilização de código.

### Negativas

* Estrutura inicial mais complexa.
* Maior quantidade de projetos na solução.

## Alternativas avaliadas

* Projeto único (Monólito simples)
* Clean Architecture completa
* Arquitetura Hexagonal

A arquitetura em camadas foi escolhida por equilibrar simplicidade e escalabilidade para a fase atual do projeto.
