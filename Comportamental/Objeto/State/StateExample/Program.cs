/*
Nesse exemplo, a interface IState define o contrato para os estados, que são implementados pelas classes StateA e StateB. 
A classe Context mantém uma referência para o estado atual e tem um método Request que executa uma ação com base no estado atual. 
Quando o método Handle de um estado é executado, ele realiza uma ação e, em seguida, atualiza o estado atual do contexto. 
O programa de exemplo cria um contexto, define o estado inicial como StateA e executa três ações, alternando entre os estados A e B. 
A saída do programa mostra que a ação correta é executada com base no estado atual do contexto.

Obs: Este exemplo é bem simples, mas na prática, os estados podem ser muito mais complexos e incluir uma série de informações e comportamentos diferentes
*/

using StateExample.State;
Console.WriteLine("Hello, State !\n");


var context = new Context();

// Executa ação do Estado A
context.State = new StateA();
context.Request();

// Executa ação do Estado B
context.Request();

// Executa ação do Estado A novamente
context.Request();

// Executa ação do Estado B novamente
context.Request();

// Executa ação do Estado A novamente
context.Request();

Console.ReadLine();