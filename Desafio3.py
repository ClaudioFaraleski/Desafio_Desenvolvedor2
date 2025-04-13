# Desafio 3 - Análise de faturamento diário
import json
import os

# Define o caminho do arquivo
caminho_arquivo = os.path.join(os.path.dirname(__file__), "dados", "faturamento.json")

try:
    with open(caminho_arquivo, encoding='utf-8') as f:
        dados = json.load(f)
except FileNotFoundError:
    print(f"Erro: O arquivo {caminho_arquivo} não foi encontrado.")
    exit(1)
except json.JSONDecodeError:
    print("Erro: O arquivo JSON está mal formatado.")
    exit(1)

valores = [dia["valor"] for dia in dados if dia["valor"] > 0]

menor = min(valores)
maior = max(valores)
media = sum(valores) / len(valores)

dias_acima_da_media = len([v for v in valores if v > media])

print(f"Menor valor de faturamento: R${menor:.2f}")
print(f"Maior valor de faturamento: R${maior:.2f}")
print(f"Dias com faturamento acima da média: {dias_acima_da_media}")
