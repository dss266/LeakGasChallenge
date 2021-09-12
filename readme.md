# Challenge - LeakGas  - 2TDST

![](https://i.imgur.com/Dwa0Yer.jpg)

### Grupo Hopp
**Davi Santos Souza** RM86327
**Lucas Cavalcanti de Paula** RM84420
**Matheus Oliveira Trindade** RM85252
**Pablo André Nunes de Oliveira** RM86328
**Ruan Barros Araújo** RM84584

##Objetivo e escopo

A empresa Plusoft nos apresentou os diversos segmentos onde atua com seus sistemas de CRM e decidimos desenvolver uma solução que fosse impactar o segmento de seguros residenciais. Uma das coberturas comuns em apólices de seguros residenciais é a de danos causados por vazamentos de gás, tais como possíveis explosões; casos que vem aumentando significativamente devido à falta de eficiência dos órgãos fiscalizadores.

Torna-se imprescindível o cuidado e monitoramento destes sistemas devido não só aos riscos de explosões como também os riscos de intoxicação, visto que não é possível confiar apenas no olfato, pois diferentes tipos de gases podem ser utilizados e alguns são difíceis de detectar devido à ausência de cheiro; entretanto ao observar no cotidiano da população vemos que a maioria é negligente quanto a sistemas de prevenções.

Dessa forma queremos trazer um sistema de fácil manuseio, baixo custo e altamente escalável visando a utilização em condomínios residenciais aumentando a sua segurança e a conscientização da população quanto aos procedimentos e riscos.
Iremos desenvolver uma aplicação que possui como premissa o monitoramento de ambientes visando a detecção de gases e a sinalização de usuários em diferentes níveis. Será possível realizar a consulta da situação do local em tempo real por meio de um aplicativo verificando se o local possui a presença de gases nocivos e mesmo na ausência de monitoramento do usuário ele receberá notificações informando do risco, e também todos os usuários que estiverem conectados ao dispositivo.

Após a sinalização dos usuários com os procedimentos de segurança que devem ser realizados nos casos de vazamento de gás, o aplicativo irá acionar um dispositivo que interrompe a emissão do gás e também a energia das tomadas do local, buscando minimizar a possibilidade de faíscas que podem resultar em uma explosão.
Ao acessar a plataforma o usuário poderá ser vinculado a múltiplas localidades e pode acessar cada uma delas para verificar o monitoramento assim como também as informações de histórico de cada uma verificando o número de incidentes e filtrando por períodos.

## Arquitetura da Solução e Funções do Backend

![](https://i.imgur.com/EmLBPno.jpg)

Por meio das análises realizadas pelo grupo chegamos à arquitetura da solução acima, onde iremos utilizar a biblioteca javascript React Native e o framework bootstrap para desenvolver a interface mobile com o usuário, a seleção da tecnologia foi realizada com base na compatibilidade tanto com sistemas android quanto iOS.
Além de realizarmos um painel administrativo/dashboard web utilizando de HTML, CSS, Javascript e o framework .net Core com a linguagem C# para consumir os dados recebidos via integração com API por meio de requisições HTTP (JSON). Essa interface será utilizada apenas pelo usuário administrador para fazer o acompanhamento de dados de forma visual e simplificada.
Nossos web services serão desenvolvidos utilizando o framework .Net Core na linguagem C# utilizando o padrão REST visando a comunicação por meio de JSON’s tanto com a interface Web Java quanto com o Node Red; armazenando as informações em um banco de dados Oracle. 
Nosso backend terá como funcionalidades as funções básicas (CRUD) de usuários e condomínios, tem também como função realizar o registro de ocorrências de vazamento e enviando essa resposta para o usuário com as informações necessárias para atuação, mantendo todo um histórico de ocorrências e solicitações.


## Endpoints

######  Condominio
|Nome   |Path   | Verbo |Ação   |
| ------------ | ------------ | ------------ | ------------ |
|Index   |/Condominio   |GET   | Listar todos os condomínios  |
|Show   |/Condominio/:id   |GET   | Mostrar dados de um condomínio  |

###### Ocorrência Vazamento
|Nome   |Path   | Verbo |Ação   |
| ------------ | ------------ | ------------ | ------------ |
|Create   |/ocorrencia/vazamento   |POST   | Criar ou atualizar ocorrencia de vazamento |

###### Ocorrência
|Nome   |Path   | Verbo |Ação   |
| ------------ | ------------ | ------------ | ------------ |
|Index   |/ocorrencia   |GET   | Listar todas as ocorrências  |
|Show   |/ocorrencia/:id   |GET   | Mostrar dados de uma ocorrência  |

###### Usuário
|Nome   |Path   | Verbo |Ação   |
| ------------ | ------------ | ------------ | ------------ |
|Index   |/usuario   |GET   | Listar todos os usuários  |
|Create   |/usuario   |POST   | Criar um novo usuário|
|Show   |/usuario/:id   |GET   | Mostrar dados de um usuário  |
|Update   |/usuario/:id   |PUT   | Atualizar um usuário|
|Delete   |/usuario/:id   |DELETE   | Apaga um usuário


