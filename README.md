# Gestão de Condomínios — Fase 1  
Projeto de Programação Orientada a Objetos (LESI – IPCA)  
Autor: Rodrigo Lopes Ferreira — 13/11/2025

## 📌 Descrição Geral
Este projeto tem como objetivo desenvolver um sistema simples para a gestão de condomínios, permitindo a representação de entidades fundamentais como condóminos, frações, documentos, reuniões, quotas, pagamentos e despesas.

Nesta Fase 1 foi realizada:
- Identificação das classes principais do sistema  
- Definição dos atributos essenciais  
- Propriedades (get/set)  
- Construtores  
- Métodos base (placeholders, retorno 0)  
- Uso de herança (classe abstrata `Pessoa`)  
- Enumerações para categorização (métodos de pagamento, tipos de documentos)  
- Estruturação do código segundo o modelo fornecido pelo docente  

Não há ainda implementação lógica — apenas estrutura.

---

## 🏗️ Estrutura das Classes (Fase 1)

### **Pessoa (abstract)**
Classe base para representar qualquer pessoa no sistema.  
Atributos: nome, nif, contacto.  
Método abstrato: `IdentificarPessoa()`.

### **Condomino**
Representa um proprietário de uma fração.  
Herda de `Pessoa`.  
Inclui: morada de notificação, fração, piso, permilagem.

### **Fraccao**
Representa uma fração do edifício.  
Inclui: identificação, área e proprietário.

### **Condominio**
Representa um condomínio.  
Inclui: nome, localização, data de construção e lista de proprietários.

### **Permilagem**
Guarda os valores (fração e total do edifício) necessários ao cálculo da permilagem.

### **Quota**
Representa uma quota mensal (valor, mês, ano).

### **Pagamento**
Regista um pagamento de quota.  
Usa o enum `MetodoPagamento`.

### **Despesa**
Regista uma despesa do condomínio (descrição, valor, data).

### **Reuniao**
Representa uma reunião, com data, local e ordem de trabalhos.

### **Documento**
Representa documentos associados ao condomínio, como atas, contratos, comunicações, etc.  
Usa o enum `TipoDocumento`.

---

## 📚 Estruturas Usadas
- Classes simples com atributos privados e propriedades públicas  
- Herança (Pessoa → Condomino)  
- Enumerações (`MetodoPagamento`, `TipoDocumento`)  
- Arrays para armazenar coleções (ex.: `Condomino[]`)  
- Métodos placeholder (retornam 0), como pedido para a Fase 1  

---

## 🧩 Funcionalidades previstas para Fases futuras
- Cálculo real da permilagem  
- Registo e validação de pagamentos  
- Gestão das quotas e despesas  
- Listagem de proprietários e frações  
- Gestão completa de reuniões e documentos  
- Possível evolução para coleções dinâmicas (listas)  
- Persistência de dados  

---

## 📅 Estado da Fase 1
✔ Todas as classes identificadas  
✔ Estrutura de atributos, propriedades e construtores concluída  
✔ Enumerações implementadas  
✔ Métodos essenciais criados (placeholders)  
✔ Documentação XML incluída  
✔ Cumprimento dos requisitos da Fase 1  

---

## 📎 Notas Finais
A arquitetura foi desenvolvida tendo em conta:
- a simplicidade exigida para a Fase 1  
- o estilo do repositório base recomendado pelo docente  
- coerência entre todas as classes  
- facilidade de evolução para as fases seguintes  

O código está preparado para receber a lógica na Fase 2.

---
