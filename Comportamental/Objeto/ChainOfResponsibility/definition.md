﻿# Chain of Responsibility (Padrão Comportamental):

Evitar o acoplamento do remetente de uam solicitação ao seu receptor, 
ao dar a mais de um objeto a oportunidade de tratar a solicitação.
Encadear is ibjetos receptores, passando o a solicitalçao 
ao longo da cadeia até que um objeto a trate.


### Cenarios 
  - E-Commmerce
     Encontrar uma transportadora para enviar produtos 
     Possuem limitações de veículos e quantidde de carga, vagas, se executa a rota para envio dos produtos 
  - API para determinar cotação do dollar no diaria
    Em caso de a consulta aprensentar "problemas específicos" propoagar para proxima...


- Acoplamento: Reduz o acoplamento, pois permite que vários objetos tratem uma solicitação.
- Coesão: Cada manipulador tem uma responsabilidade clara, mas a coesão pode ser média.