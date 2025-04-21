# Sistema de Geração de Extratos para Companhia de Teatro 🎭

Este é um projeto pessoal com o objetivo de exercitar boas práticas de arquitetura, refatoração de código legado e implementação de novas funcionalidades em um sistema backend. A aplicação foi desenvolvida em **C#**, com foco em extensibilidade, testabilidade e escalabilidade.

## 🔍 Contexto

O sistema simula um cenário real de uma companhia de teatro que precisa gerar **extratos detalhados de cobrança** para seus clientes, com base nas apresentações realizadas.

Cada apresentação é associada a um **gênero teatral** (como tragédia, comédia, etc.), e a cobrança é calculada conforme o número de linhas da peça e o tamanho da plateia. O sistema também calcula **créditos de fidelidade** como parte do extrato.

## 🛠️ O que foi feito

- ✅ Refatoração total do código original, tornando-o mais limpo, modular e testável  
- ✅ Implementação de arquitetura limpa (Clean Architecture), aplicando princípios SOLID e padrões de projeto  
- ✅ Suporte adicionado ao novo gênero **histórico**, com regras de cálculo combinadas dos demais  
- ✅ Geração de extratos tanto em **formato texto** quanto em **formato XML**  
- ✅ Cobertura de testes com **testes unitários**, validando a lógica de negócio  

## ✨ Funcionalidades Extras

Para tornar o projeto mais robusto e próximo de um ambiente real, também foram incluídas as seguintes funcionalidades:

- ✅ **API REST** para geração de extratos e consulta de dados  
- ✅ Documentação automática com **Swagger**  
- ✅ **Persistência de dados** com banco de dados relacional  
- ✅ Processamento **assíncrono via fila**, com geração automática de arquivos XML em diretório de saída  

## 📦 Tecnologias Utilizadas

- C# (.NET 8)  
- ASP.NET Core  
- Entity Framework Core  
- PostgreSQL  
- Swagger / Swashbuckle  

## ⚙️ Como Executar

```bash
# Restaurar os pacotes
dotnet restore

# Rodar a aplicação
dotnet run --project src/TheaterApp.API
