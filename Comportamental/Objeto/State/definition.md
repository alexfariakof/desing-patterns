# State (Padr�o Comportamental):
Permite a um objeto altertar seu comportamento quando seu estado interno muda. O objeto parecer� ter mudado de classe.

 - Acoplamento: Reduz o acoplamento, pois os contextos interagem com estados por meio de uma interface.
 - Coes�o: Alta coes�o, pois cada estado representa um comportamento espec�fico

### Implementa��o 
- Estado (State): 
  Define a interface comum para todos os estados, garantindo que cada estado tenha responsabilidades claramente definidas.

- Estados Concretos (Concrete States): 
  Cada estado � uma classe separada, concentrando-se apenas em seu comportamento espec�fico.

### SOlID
#### - Aberto/Fechado (OCP):
  O princ�pio Aberto/Fechado preconiza que uma classe deve estar aberta para extens�o, mas fechada para modifica��o. 
  O padr�o State � uma implementa��o cl�ssica desse princ�pio, pois permite que novos estados sejam adicionados 
  sem modificar a classe do contexto.

- Contexto (Context): A classe que mant�m uma inst�ncia do estado atual e delega opera��es a esse estado.

- Estado (State): Define a interface comum para todos os estados concretos. Cada estado concreto implementa essa interface.

- Estados Concretos (Concrete States): Implementam o comportamento espec�fico associado a um determinado estado.

#### - Responsabilidade �nica (SRP):
   O princ�pio da Responsabilidade �nica sugere que uma classe deve ter apenas uma raz�o para mudar. 
   No contexto do padr�o State, isso significa que cada estado concreto deve ter uma responsabilidade �nica e espec�fica.