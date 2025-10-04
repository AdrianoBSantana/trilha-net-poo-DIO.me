# 📱 Modelando Smartphones com POO em C#

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)

## 🎯 Sobre o Projeto

Este projeto é a resolução de um Desafio de Projeto da [Digital Innovation One (DIO)](https://dio.me/), focado em aplicar os pilares da **Programação Orientada a Objetos (POO)** para modelar um sistema de celulares em C# e .NET.

O objetivo era criar uma estrutura de classes que representasse um smartphone de forma abstrata, permitindo que diferentes marcas (como Nokia e iPhone) herdassem suas características comuns, mas implementassem comportamentos específicos, como a instalação de aplicativos.

## 🏛️ Pilares da POO Aplicados

Este desafio foi uma excelente oportunidade para praticar os conceitos fundamentais da POO:

#### 1. Abstração
A classe `Smartphone` foi definida como `abstract`, servindo como um "contrato" ou molde. Ela contém as propriedades e métodos comuns a qualquer smartphone (Número, IMEI, Ligar, etc.), mas não pode ser instanciada diretamente.

#### 2. Herança
As classes `Nokia` e `Iphone` herdam diretamente de `Smartphone`. Isso permite o reuso de código, já que ambas as classes filhas automaticamente possuem todos os membros públicos da classe mãe.

#### 3. Polimorfismo
O método `InstalarAplicativo` é um exemplo claro de polimorfismo. Ele foi declarado como `abstract` na classe `Smartphone` e, em seguida, sobrescrito (`override`) nas classes `Nokia` e `Iphone`. Isso permite que cada marca de celular execute a "ação" de instalar um aplicativo de maneira única, através do mesmo método.

## Diagrama de Classes

O sistema foi modelado com uma classe abstrata e duas classes concretas, conforme o diagrama abaixo:

-   **`Smartphone` (Abstract):** A classe base que define a estrutura de um celular.
-   **`Nokia` (Concreta):** Herda de `Smartphone` e implementa sua própria versão do método `InstalarAplicativo`.
-   **`Iphone` (Concreta):** Herda de `Smartphone` e também possui uma implementação customizada para `InstalarAplicativo`.

<img width="1228" height="692" alt="image" src="https://github.com/user-attachments/assets/83b4aa07-5483-41fe-88d5-00d463b3e4a2" />


## 🛠️ Tecnologias Utilizadas

-   [C#](https://learn.microsoft.com/pt-br/dotnet/csharp/)
-   [.NET](https://dotnet.microsoft.com/)

## 🚀 Como Executar

Para executar este projeto, siga os passos abaixo:

1.  Clone o seu repositório:
    ```bash
    git clone https://github.com/AdrianoBSantana/trilha-net-poo-DIO.me.git
    ```
2.  Navegue até o diretório do projeto:
    ```bash
    cd trilha-net-poo-DIO.me
    ```
3.  Execute a aplicação através do terminal:
    ```bash
    dotnet run
    ```

O `Program.cs` irá instanciar um objeto de cada marca (`Nokia` e `Iphone`) e chamar seus métodos para demonstrar o funcionamento da herança e do polimorfismo.
