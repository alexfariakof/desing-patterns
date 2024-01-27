# Mediator (Padr�o Comportamental):

Definir um objeto que encapsula a forma como um conjunto de on=bjetos interaje.
O mediator promove o acoplamento farco ao evitar que os objetos se refiram uns aos outros explicitamente
e permitir variar suas inter���es independentemente.

- Acoplamento: Reduz o acoplamento, pois os objetos se comunicam por meio do mediador.
- Coes�o: Alta coes�o, pois o mediador gerencia a comunica��o entre colegas.


### Considera��es 
* Utilize este padr�o quando � dificil mudar alguma classe porque ela esta firmemente acoplada  a outra classe.
* Quando n�o se pode reutilizar um componente em um progama diferente porque ele � muito dependente de outros componentes.

### SOlID
O Mediator n�o aborda diretamente todos os princ�pios SOLID, mas sua aplica��o adequada pode contribuir para a ades�o 
a esses princ�pios, proporcionando um design mais modular, flex�vel e de f�cil manuten��o. 

* Princ�pio da Responsabilidade �nica (SRP - Single Responsibility Principle): 
  O Mediator ajuda a separar as responsabilidades de comunica��o e coordena��o do sistema, concentrando-as em um �nico objeto (o Mediator). 
  Cada participante (Colega) se concentra em sua pr�pria responsabilidade, delegando a comunica��o ao Mediator.

* Princ�pio do Aberto/Fechado (OCP - Open/Closed Principle): 
  O Mediator pode ser estendido para incluir novos colegas ou alterar a l�gica de comunica��o entre colegas sem modificar os pr�prios colegas. 
  Isso mant�m o sistema aberto para extens�o e fechado para modifica��o.

* Princ�pio da Invers�o de Depend�ncia (DIP - Dependency Inversion Principle): 
  O Mediator promove a depend�ncia de abstra��es (interfaces) em vez de implementa��es concretas. 
  Colegas dependem da interface do Mediator, reduzindo as depend�ncias diretas entre eles.

