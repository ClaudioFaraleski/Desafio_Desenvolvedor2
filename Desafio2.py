# Desafio 2 - Verifica se um número está na sequência de Fibonacci
numero = int(input("Informe um número: "))
a, b = 0, 1
pertence = False

while b <= numero:
    if b == numero:
        pertence = True
        break
    a, b = b, a + b

if pertence or numero == 0:
    print(f"O número {numero} pertence à sequência de Fibonacci.")
else:
    print(f"O número {numero} NÃO pertence à sequência de Fibonacci.")
