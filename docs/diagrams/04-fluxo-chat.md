# Diagrama 04 – Fluxo do Chat IA

## Objetivo

Representar o fluxo de envio de mensagens entre o usuário, a plataforma e o provedor de Inteligência Artificial.

```text
Usuário
   │
   ▼
Interface do Chat
   │
   ▼
OrizonAI.Web / OrizonAI.API
   │
   ▼
ChatService
   │
   ▼
Validação de créditos
   │
   ▼
Seleciona Provedor e Modelo
   │
   ▼
AIProvider Adapter
   │
   ▼
Provedor de IA
   │
   ▼
Resposta da IA
   │
   ▼
Registrar Mensagem
   │
   ▼
Registrar Consumo
   │
   ▼
Atualizar Créditos
   │
   ▼
Exibir resposta ao usuário