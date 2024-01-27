# Visitor (Padr�o Comportamental):
Permite definir uma nova opera��o para um conjunto de classes sem alterar essas classes. 
Ele � �til quando voc� precisa realizar opera��es complexas em uma hierarquia de objetos, 
mantendo a separa��o entre o c�digo da opera��o e as classes que a recebem.

- Acoplamento: O acoplamento pode ser m�dio a alto, pois o visitante precisa conhecer as classes espec�ficas a serem visitadas.
- Coes�o: M�dia a alta, dependendo de como as opera��es de visita��o s�o definidas.

### Implementa��o 
 - Element (Elemento):
   Define a interface comum para todos os elementos da estrutura.

 - ConcreteElement (Elemento Concreto):
   Implementa a interface Element. S�o as classes espec�ficas que aceitam visitantes.

 - Visitor (Visitante):
   Declara a interface de visita para cada tipo de ConcreteElement. Cont�m os m�todos Visit correspondentes a cada tipo.

 - ConcreteVisitor (Visitante Concreto):
  Implementa a interface Visitor e fornece a implementa��o espec�fica para cada tipo de ConcreteElement.
 
 - ObjectStructure (Estrutura de Objetos):
   Mant�m uma cole��o de objetos a serem visitados.

### SOlID
#### - Princ�pio Aberto/Fechado (OCP):
  O padr�o Visitor � uma boa implementa��o do OCP, pois permite adicionar novas opera��es (visitantes) sem modificar as classes existentes.