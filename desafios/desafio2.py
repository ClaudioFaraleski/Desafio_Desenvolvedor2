def verifica_fibonacci(numero):
    if numero < 0:
        return False
    
    a, b = 0, 1
    while b < numero:
        a, b = b, a + b
    
    return b == numero or numero == 0

def main():
    numero = int(input("Digite um número para verificar: "))
    if verifica_fibonacci(numero):
        print(f"O número {numero} pertence à sequência de Fibonacci")
    else:
        print(f"O número {numero} NÃO pertence à sequência de Fibonacci")

if __name__ == "__main__":
    main()
