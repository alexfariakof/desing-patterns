# Mediator (Padrão Comportamental):

Definir um objeto que encapsula a forma como um conjunto de on=bjetos interaje.
O mediator promove o acoplamento farco ao evitar que os objetos se refiram uns aos outros explicitamente
e permitir variar suas interãções independentemente.

- Acoplamento: Reduz o acoplamento, pois os objetos se comunicam por meio do mediador.
- Coesão: Alta coesão, pois o mediador gerencia a comunicação entre colegas.


### Considerações 
* Utilize este padrão quando é dificil mudar alguma classe porque ela esta firmemente acoplada  a outra classe.
* Quando não se pode reutilizar um componente em um progama diferente porque ele é muito dependente de outros componentes.

### SOlID
O Mediator não aborda diretamente todos os princípios SOLID, mas sua aplicação adequada pode contribuir para a adesão 
a esses princípios, proporcionando um design mais modular, flexível e de fácil manutenção. 

* Princípio da Responsabilidade Única (SRP - Single Responsibility Principle): 
  O Mediator ajuda a separar as responsabilidades de comunicação e coordenação do sistema, concentrando-as em um único objeto (o Mediator). 
  Cada participante (Colega) se concentra em sua própria responsabilidade, delegando a comunicação ao Mediator.

* Princípio do Aberto/Fechado (OCP - Open/Closed Principle): 
  O Mediator pode ser estendido para incluir novos colegas ou alterar a lógica de comunicação entre colegas sem modificar os próprios colegas. 
  Isso mantém o sistema aberto para extensão e fechado para modificação.

* Princípio da Inversão de Dependência (DIP - Dependency Inversion Principle): 
  O Mediator promove a dependência de abstrações (interfaces) em vez de implementações concretas. 
  Colegas dependem da interface do Mediator, reduzindo as dependências diretas entre eles.

