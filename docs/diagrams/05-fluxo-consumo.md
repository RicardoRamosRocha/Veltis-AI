
---

## `docs/diagrams/05-fluxo-consumo.md`

```md
# Diagrama 05 – Fluxo de Consumo de Créditos

## Objetivo

Representar como o sistema controla tokens, custos e créditos consumidos durante o uso da IA.

```text
Mensagem enviada
   │
   ▼
Calcular tokens de entrada
   │
   ▼
Enviar para provedor IA
   │
   ▼
Receber resposta
   │
   ▼
Calcular tokens de saída
   │
   ▼
Calcular custo total
   │
   ▼
Verificar saldo de créditos
   │
   ▼
Debitar créditos
   │
   ▼
Registrar Usage
   │
   ▼
Registrar CreditMovement
   │
   ▼
Atualizar saldo do cliente/empresa