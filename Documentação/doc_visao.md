# Documento de Visão

## Histórico de Revisões

| Data                |  Versão             |          Descrição  |  Autores            |
| -----------------   | -----------------   | -----------------   | -----------------   |
| 25/06/2023 | 1.0 | Primeira versão | Yuri Thairony Feitosa de Oliveira | 

## 1. Objetivo do projeto

Um sistema no simples onde prestadores de serviços possam divulgar seus trabalhos numa listagem e pessoas interessadas possam visualizar como um catálogo e entrar em contato com o prestador fora da plataforma.

## 2. Descrição do problema

|     |      |
| --- | --- |
| **Problema**            | A dificuldade de encontrar serviços de terceiros na internet. |
| **Afeta**               | Pessoas que querem contratar serviços e prestadores que querem divulgar trabalhos. |  
| **Impacta**             | Pessoas que precisam encontrar determinados serviços e não conhecem outras pessoas que tenham contatos e prestadores de serviços não tem um lugar para divulgar seus serviços. |
| **Solução**             | Um catágolo onde esses prestadores possam divulgar seus serviços e pessoas possam entrar em contato no estilo de lista telefônica.  | 

## 3. Descrição dos usuários 

| Nome                |  Descrição          |   Responsabilidade  |
| -----------------   | -----------------   | -----------------   |
| Administrador | Ator responsável por gerenciar toda a plataforma | Responsável por deletar serviços e criar categorias |
| Prestadores  | Ator cliente do projeto, irá divulgar seus serviços | Criar os serviços | 
| Visitante   | Ator que pode visualizar a plataforma | Visualizar serviços por categoria | 

## 4. Requisitos funcionais

| Código              |  Nome               |          Descrição  |  
| -----------------   | -----------------   | -----------------   | 
|  F01  |  Criar categoria  |  Administrador pode criar uma categoria para ser listada quando o Prestador for criar um serviço. |
|  F02  |  Deletar categoria  |  Administrador pode deletar uma categoria com todos os serviços dela. |
|  F03  |  Atualizar categoria  |  Administrador pode atualizar uma categoria com todos os serviços dela. |
|  F04  |  Listar categoria  |  Prestador ver a lista de categoria ao tentar criar um serviço. |
|  F05  |  Criar serviço  |  Prestador pode criar um serviço. |
|  F06  |  Listar serviço  |  Visitante pode listar os serviços por categoria. |
|  F07  |  Deletar serviço  |  Administrador por deletar serviços criados. |

## 5. Requisitos não-funcionais

| Código              |  Nome               |          Descrição  |  Categoria          |  Classificação      |
| -----------------   | -----------------   | -----------------   | -----------------   | -----------------   |
| NF01 | | | | |

## 6. Regras de negócio

| Código | Nome | Descrição |
| ------------- | ------------- | ------------- |
| RN01 | Criação de serviços | Prestadore só pode criar um serviço usando as categorias disponíveis. |