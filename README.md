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

## Capturas de Tela

- **Tela de Login:** Interface de autenticação de usuário com validação de credenciais.
- **Main Page:** Tela principal para consulta, realização do pedido e cadastro de novos itens.

## Aprendizados e Habilidades Demonstradas
Este projeto reflete a experiência com desenvolvimento backend em C# e a integração completa entre frontend e backend, mostrando competências em:

- Autenticação Segura e Gerenciamento de Sessões
- Configuração de CORS e Integração entre Frontend e Backend
- Hospedagem de API e Banco de Dados na Nuvem
- Boas Práticas de Segurança e Estruturação de API REST

## Próximos Passos

- **Histórico de pedidos:** Histórico de pedidos para controle dos administradores
- **Recuperação de senhas:** Função para recuperar e alterar senhas
- **Notificações e Alertas:** Implementar notificações para alertar sobre baixa quantidade em estoque e confirmação de pedido.
- **Relatórios Personalizados:** Exportação de relatórios de estoque.

## Contribuição

Sinta-se à vontade para fazer um fork do projeto e contribuir! Todos os tipos de contribuições são bem-vindos. Se tiver sugestões, por favor, abra um issue para discussão.
