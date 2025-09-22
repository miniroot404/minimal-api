# minimal-api

API mínima em C# (.NET) para demonstrar funcionalidades básicas.  

## 🧐 Visão Geral

O projeto `minimal-api` é uma API simples desenvolvida em .NET / C#, com estrutura mínima para servir endpoints básicos. Ideal para aprendizado, para iniciar novos projetos ou como boilerplate.

## 💡 Funcionalidades

- Endpoints básicos (CRUD ou leitura simples)  
- Projeto organizado em pastas `Api` e `Test`  
- Solução (`.sln`) para gerenciar múltiplos projetos/modules  

## 🛠 Tecnologias Utilizadas

- C#  
- .NET (versão alvo / framework que você estiver usando)  
- Framework de testes (no diretório `Test`) – ex: xUnit, NUnit ou outro  
- Gerenciamento de dependências via NuGet  

## 🚀 Como Rodar / Instalar

Estas instruções vão te permitir rodar o projeto localmente.

```bash
# Clone o repositório
git clone https://github.com/miniroot404/minimal-api.git

# Entre na pasta
cd minimal-api

# Restaure pacotes
dotnet restore

# Compile
dotnet build

# Rode a API
dotnet run --project Api/        # ajustar caso o projeto esteja em outra pasta
