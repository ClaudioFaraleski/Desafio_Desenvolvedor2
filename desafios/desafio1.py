def calcular_soma():
    INDICE = 13
    SOMA = 0
    K = 0
    
    while K < INDICE:
        K = K + 1
        SOMA = SOMA + K
    
    return SOMA

if __name__ == "__main__":
    resultado = calcular_soma()
    print(f"O valor final da SOMA é: {resultado}")  # Resultado será 91
