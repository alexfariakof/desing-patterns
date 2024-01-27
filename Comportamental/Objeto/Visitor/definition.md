# Visitor (Padrão Comportamental):
Permite definir uma nova operação para um conjunto de classes sem alterar essas classes. 
Ele é útil quando você precisa realizar operações complexas em uma hierarquia de objetos, 
mantendo a separação entre o código da operação e as classes que a recebem.

- Acoplamento: O acoplamento pode ser médio a alto, pois o visitante precisa conhecer as classes específicas a serem visitadas.
- Coesão: Média a alta, dependendo de como as operações de visitação são definidas.

### Implementação 
 - Element (Elemento):
   Define a interface comum para todos os elementos da estrutura.

 - ConcreteElement (Elemento Concreto):
   Implementa a interface Element. São as classes específicas que aceitam visitantes.

 - Visitor (Visitante):
   Declara a interface de visita para cada tipo de ConcreteElement. Contém os métodos Visit correspondentes a cada tipo.

 - ConcreteVisitor (Visitante Concreto):
  Implementa a interface Visitor e fornece a implementação específica para cada tipo de ConcreteElement.
 
 - ObjectStructure (Estrutura de Objetos):
   Mantém uma coleção de objetos a serem visitados.

### SOlID
#### - Princípio Aberto/Fechado (OCP):
  O padrão Visitor é uma boa implementação do OCP, pois permite adicionar novas operações (visitantes) sem modificar as classes existentes.