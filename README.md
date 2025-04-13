# README.md

# Desafio de Programação

Este projeto contém soluções para uma série de desafios de programação. Cada desafio é implementado em uma classe separada, e o código está organizado em um diretório de forma a facilitar a navegação e a execução.

## Estrutura do Projeto

```
coding-challenges
├── src
│   ├── Questao_1
│   │   └── SumCalculator.cs
│   ├── Questao_2
│   │   └── FibonacciChecker.cs
│   ├── Questao_3
│   │   ├── BillingAnalyzer.cs
│   │   └── data
│   │       └── billing.json
│   ├── Questao_4
│   │   └── DistributorPercentage.cs
│   ├── Questao_5
│   │   └── StringInverter.cs
│   └── Program.cs
├── tests
│   ├── Questao1Tests.cs
│   ├── Questao2Tests.cs
│   ├── Questao3Tests.cs
│   ├── Questao4Tests.cs
│   └── Questao5Tests.cs
├── coding-challenges.csproj
└── README.md
```

## Instruções para Execução

1. **Clone o repositório:**
   ```bash
   git clone <URL_DO_REPOSITORIO>
   cd coding-challenges
   ```

2. **Restaure as dependências:**
   ```bash
   dotnet restore
   ```

3. **Execute o projeto:**
   ```bash
   dotnet run
   ```

4. **Execute os testes:**
   ```bash
   dotnet test
   ```

## Descrição dos Desafios

1. **Soma de Números:** Implementa a lógica para calcular a soma dos números de 1 até um índice definido.
2. **Verificação de Fibonacci:** Verifica se um número pertence à sequência de Fibonacci.
3. **Análise de Faturamento:** Calcula o menor e o maior faturamento diário, além de contar os dias com faturamento acima da média mensal.
4. **Cálculo de Percentual:** Calcula o percentual de representação de cada estado no faturamento total da distribuidora.
5. **Inversão de String:** Inverte os caracteres de uma string sem usar funções prontas.

## Contribuições

Sinta-se à vontade para contribuir com melhorias ou correções. Para isso, crie um fork do repositório, faça suas alterações e envie um pull request.

