# State (Padrão Comportamental):
Permite a um objeto altertar seu comportamento quando seu estado interno muda. O objeto parecerá ter mudado de classe.

 - Acoplamento: Reduz o acoplamento, pois os contextos interagem com estados por meio de uma interface.
 - Coesão: Alta coesão, pois cada estado representa um comportamento específico

### Implementação 
- Estado (State): 
  Define a interface comum para todos os estados, garantindo que cada estado tenha responsabilidades claramente definidas.

- Estados Concretos (Concrete States): 
  Cada estado é uma classe separada, concentrando-se apenas em seu comportamento específico.

### SOlID
#### - Aberto/Fechado (OCP):
  O princípio Aberto/Fechado preconiza que uma classe deve estar aberta para extensão, mas fechada para modificação. 
  O padrão State é uma implementação clássica desse princípio, pois permite que novos estados sejam adicionados 
  sem modificar a classe do contexto.

- Contexto (Context): A classe que mantém uma instância do estado atual e delega operações a esse estado.

- Estado (State): Define a interface comum para todos os estados concretos. Cada estado concreto implementa essa interface.

- Estados Concretos (Concrete States): Implementam o comportamento específico associado a um determinado estado.

#### - Responsabilidade Única (SRP):
   O princípio da Responsabilidade Única sugere que uma classe deve ter apenas uma razão para mudar. 
   No contexto do padrão State, isso significa que cada estado concreto deve ter uma responsabilidade única e específica.