# Desafio 5 - Inverter string sem usar funções prontas
texto = input("Digite uma string: ")
invertida = ""

for i in range(len(texto) - 1, -1, -1):
    invertida += texto[i]

print("String invertida:", invertida)
