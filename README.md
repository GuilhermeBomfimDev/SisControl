# SisControl - Sistema de Gerenciamento de Estoque

![License](https://img.shields.io/badge/license-MIT-blue.svg)
![Tech Stack](https://img.shields.io/badge/Tech-CSharp%20%7C%20ASP.NET%20Core%20%7C%20MySQL%20%7C%20JavaScript%20%7C%20HTML%20%7C%20CSS-brightgreen)

**SisControl** é uma aplicação desenvolvida para gerenciar o controle de estoque de uma loja, permitindo operações como cadastro de itens, verificação de estoque, login de usuários e atualizações no inventário. Este projeto foi idealizado para otimizar processos e oferecer uma interface intuitiva tanto para o administrador quanto para usuários que acessam o sistema.

## Funcionalidades Principais

- **Autenticação de Usuários:** Sistema de login seguro, com armazenamento de dados criptografados.
- **Cadastro e Atualização de Itens:** Permite o registro e a atualização de dados como nome, quantidade, data de entrada e imagem do item.
- **Armazenamento de Imagem:** Upload de imagem dos produtos que são armazenados de forma eficiente no banco de dados SQL.
- **Monitoramento de Estoque:** Acompanhe a quantidade e data de entrada de cada item.

## Demonstração

- [Acesse a aplicação hospedada no GitHub Pages](https://agaidarji.github.io/SisControl/)
- API Backend hospedada no Azure: Implementada para máxima escalabilidade e segurança

## Tecnologias Utilizadas

- **C# e ASP.NET Core:** Estrutura do backend com rotas de API RESTful, incluindo autenticação e operações CRUD.
- **MySQL:** Banco de dados SQL para armazenamento eficiente dos dados do estoque e informações de usuários.
- **JavaScript (Frontend):** Conexão com API e interações com o usuário.
- **HTML & CSS:** Design da interface de usuário, com componentes responsivos.
- **Azure:** Hospedagem da API e do banco de dados para fácil escalabilidade e acessibilidade.
- **GitHub Pages:** Hospedagem do frontend para garantir disponibilidade e agilidade.

## Estrutura do Projeto

- **Frontend:** Desenvolvido em HTML, CSS e JavaScript.
- **Backend:** API RESTful em C# com ASP.NET Core, conectada a um banco de dados MySQL para persistência dos dados.
- **Banco de Dados:** SQL no Azure, com tabelas para usuários e itens de estoque.
