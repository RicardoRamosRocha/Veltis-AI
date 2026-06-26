# Guia de Contribuição

Obrigado por contribuir com o Veltis AI Platform.

## Objetivo

Garantir que todo o desenvolvimento siga um padrão único de organização, arquitetura e qualidade.

---

# Tecnologias

* ASP.NET Core 8
* Entity Framework Core
* PostgreSQL
* Bootstrap 5
* C#

---

# Estrutura

```text
src/
docs/
database/
tests/
```

---

# Convenções

## Código

* Classes em inglês.
* Métodos em inglês.
* Banco em inglês.
* Interface em português (PT-BR).

---

## Commits

Utilizar Commits Semânticos.

Exemplos:

```text
feat: add customers module
feat: add plans module
fix: login validation
refactor: improve dashboard
docs: update architecture
style: improve sidebar
```

---

## Branches

```text
main
develop

feature/*
hotfix/*
release/*
```

---

## Pull Requests

Todo Pull Request deverá:

* Compilar sem erros.
* Manter a documentação atualizada.
* Seguir o padrão arquitetural.
* Possuir descrição clara.

---

# Arquitetura

O projeto segue arquitetura em camadas.

Nenhuma camada poderá acessar diretamente outra camada não permitida.

Fluxo:

```text
Web/API
 ↓
Application
 ↓
Domain
 ↓
Infrastructure
```

---

# Documentação

Sempre que uma funcionalidade for adicionada:

* Atualizar o Backlog.
* Atualizar o Roadmap (quando necessário).
* Atualizar a documentação correspondente.

---

# Qualidade

Todo código deverá priorizar:

* Legibilidade.
* Simplicidade.
* Reutilização.
* Testabilidade.
* Segurança.
