# Memento (Padr�o Comportamental):

Sem violar o encapsulamento, capturar e externalizar um estado interno de um objeto, de maneita 
que o objeto possa ser restaurado para esse estado mais tarde.

### O padr�o ConcreteMemento � usado para capturar e armazenar o estado interno de um objeto sem violar o encapsulamento. Isso permite que o objeto seja restaurado posteriormente para o seu estado anterior. 
#### Para implementar o padr�o ConcreteMemento, precisamos de tr�s classes:
* A classe Originator, que � a classe cujo estado desejamos salvar e restaurar.
* A classe ConcreteMemento, que � uma classe auxiliar que armazena o estado interno do Originator.
* A classe Caretaker, que � respons�vel por armazenar e gerenciar os objetos ConcreteMemento.


- Acoplamento: Pode variar dependendo da implementa��o, mas geralmente � m�dio.
- Coes�o: M�dia a alta, pois o cuidador e o memento est�o relacionados.

### Considera��es 
* Utilize este padr�o quando � dificil mudar alguma classe porque ela esta firmemente acoplada  a outra classe.
* Quando n�o se pode reutilizar um componente em um progama diferente porque ele � muito dependente de outros componentes.

### SOlID
- Princ�pio da Responsabilidade �nica (SRP): O padr�o Memento ajuda a manter a responsabilidade �nica ao separar as 
  preocupa��es de captura de estado e gest�o de estado. O Originator � respons�vel por seu estado interno, o Memento cuida da 
  representa��o externa desse estado e o Caretaker gerencia os Mementos.

- Princ�pio do Aberto/Fechado (OCP): O Memento permite que novos estados e vers�es do Originator sejam adicionados 
  sem modificar o pr�prio Originator. Isso mant�m o sistema aberto para extens�o.

- Princ�pio da Invers�o de Depend�ncia (DIP): O Originator depende da interface do Memento, n�o de implementa��es concretas. 
  Isso reduz o acoplamento entre o Originator e o Memento, seguindo o princ�pio da invers�o de depend�ncia.