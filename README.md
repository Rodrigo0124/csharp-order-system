# 🛒 Sistema de Pedidos em C#

Projeto desenvolvido como exercício prático do curso **C# COMPLETO Programação Orientada a Objetos + Projetos**, ministrado por Nélio Alves na Udemy.

## 📌 Sobre o projeto

Este é um sistema de pedidos em console onde o usuário pode:

- Cadastrar cliente (nome, email e data de nascimento)
- Definir o status do pedido (usando Enum)
- Adicionar múltiplos produtos ao pedido
- Informar quantidade e preço
- Visualizar um resumo completo do pedido

O projeto foi desenvolvido com foco em praticar os principais conceitos de **Programação Orientada a Objetos (POO)** em C#.

---

## 🚀 Tecnologias utilizadas

- C#
- .NET
- Programação Orientada a Objetos
- Console Application

---

## 🧠 Conceitos aplicados

- ✔️ Classes e Objetos
- ✔️ Encapsulamento
- ✔️ Enum
- ✔️ Listas (`List<T>`)
- ✔️ Validação de dados (input do usuário)
- ✔️ Manipulação de datas (`DateTime`)
- ✔️ Sobrescrita de métodos (`ToString`)
- ✔️ Organização em camadas (Entities)

---

## 📂 Estrutura do projeto
Loja/
│
├── Entities/
│ ├── Cliente.cs
│ ├── Pedido.cs
│ ├── Produto.cs
│ ├── ItemPedido.cs
│ └── Enum/
│ └── OrderStatus.cs
│
└── Program.cs


---

## ▶️ Como executar

1. Clone o repositório:

git clone https://github.com/seu-usuario/csharp-order-system.git


2. Acesse a pasta do projeto:

cd csharp-order-system


3. Execute o projeto:

dotnet run


---

## 💡 Funcionalidades interessantes

- Validação de email com Regex
- Validação de números e preços
- Uso de Enum para status do pedido
- Entrada dinâmica de múltiplos itens
- Resumo final formatado do pedido

---

## 📈 Melhorias futuras

- [ ] Interface gráfica (WinForms ou WPF)
- [ ] Persistência de dados (arquivo ou banco de dados)
- [ ] API REST com ASP.NET
- [ ] Testes automatizados

---

## 👨‍💻 Autor

Desenvolvido por **Rodrigo da Costa**

---

## 📚 Créditos

Projeto baseado nos ensinamentos do professor Nélio Alves (Udemy).
