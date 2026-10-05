# StreamingFlix

Projeto desenvolvido para a disciplina de Gestão e Qualidade de Software.

O StreamingFlix tem como objetivo implementar regras de negócio relacionadas a planos de streaming e validar seu funcionamento por meio de testes unitários utilizando xUnit.

## 📋 Funcionalidades

O projeto possui as seguintes regras de negócio:

- Classificação do plano de acordo com a quantidade de telas simultâneas.
- Cálculo da mensalidade com desconto de acordo com a quantidade de meses contratados.
- Validação do acesso a conteúdo adulto considerando a idade do usuário e o controle parental.

## 🛠️ Tecnologias utilizadas

- .NET 10
- C#
- xUnit
- Git
- GitHub

## 📁 Estrutura do projeto

```text
StreamingFlix/
│
├── StreamingFlix.App/
│   └── PlanoStreamingService.cs
│
├── StreamingFlix.Tests/
│   └── PlanoStreamingServiceTests.cs
│
├── .gitignore
├── LICENSE
└── README.md