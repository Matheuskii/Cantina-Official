# 🍔 Cantina-Official

Sistema de gerenciamento de cantina desenvolvido em **C# com Windows
Forms**, com foco em controle de pedidos, fluxo de cozinha e balcão.

## 🚀 Funcionalidades

-   **Tela de Vendas (Caixa)**
    -   Exibe cardápio com produtos cadastrados.\
    -   Permite adicionar/remover itens no carrinho.\
    -   Calcula automaticamente o total da compra.\
    -   Suporte a múltiplos métodos de pagamento: Dinheiro, Débito,
        Crédito, PIX, VA e VR.\
    -   Gera a **comanda do cliente** após finalizar o pedido.\
    -   Envia pedidos para a **Cozinha** (produtos preparados) e para o
        **Balcão** (produtos prontos).
-   **Tela da Cozinha**
    -   Lista pedidos que precisam ser preparados.\
    -   Permite avançar o **status do pedido**:
        `A Fazer → Em Preparo → Entregue`.\
    -   Envia automaticamente pedidos prontos para o **Balcão**.
-   **Tela do Balcão**
    -   Exibe os pedidos finalizados pela cozinha.\
    -   Mostra detalhes dos itens do pedido e valor total.\
    -   Controle de status: `A Fazer → Em Preparo → Pronto → Entregue`.\
    -   Permite retirar pedidos da fila após a entrega ao cliente.
-   **Tela de Chamada**
    -   Mostra os pedidos aguardando retirada.\
    -   Atualiza dinamicamente os pedidos em atendimento.

## 🖼️ Telas do Sistema

-   **Vendas / Caixa**\
-   **Cozinha**\
-   **Balcão**\
-   **Chamada**



## 🛠️ Tecnologias Utilizadas

-   Linguagem: **C#**
-   Framework: **.NET Windows Forms**
-   Organização de código com **Classes de Modelos** (`Produto`,
    `Pedido`, `ItemPedido`, `StatusPedido`)\
-   Armazenamento em memória via `BancoDePedidos`

## 📂 Estrutura do Projeto

-   `Tela de Vendas` → interface para registrar pedidos e pagamentos.\
-   `TelaCozinha` → gerenciamento do fluxo de preparo.\
-   `Tela_do_balcao` → controle de pedidos prontos para retirada.\
-   `TelaChamada` → exibição de pedidos para os clientes.\
-   `Models/` → contém entidades principais como `Produto`, `Pedido` e
    `ItemPedido`.\
-   `BancoDePedidos/` → responsável pelo armazenamento dos pedidos em
    listas internas.

## ▶️ Como Executar

1.  Clone este repositório:

    ``` bash
    git clone https://github.com/Matheuskii/Cantina-Official.git
    ```

2.  Abra o projeto no **Visual Studio**.\

3.  Compile e execute (`F5`).\

4.  Navegue entre as telas para simular pedidos e o fluxo da cantina.

## 📌 Próximos Passos (Sugestões)

-   Implementar **persistência em banco de dados** (SQL Server, MySQL ou
    SQLite).\
-   Criar **relatórios de vendas** e estatísticas.\
-   Melhorar design das telas com componentes mais modernos.\
-   Adicionar login para usuários (cozinha, caixa, balcão,
    administrador).

## 👨‍💻 Autor

Projeto desenvolvido por [Matheus Melo](https://github.com/Matheuskii).
