# Strategy (Padr�o Comportamental):
Definir uma fam�lia de algoritimos encapsular cada uma delas e torn�-las intercambi�veis. 
Strategypermite que o algoritimo varie idependentemente dos clientes que o utilizam.

- Acoplamento: Reduz o acoplamento, pois o cliente interage com uma estrat�gia abstrata.
- Coes�o: Alta coes�o, pois cada estrat�gia � independente e focada em uma tarefa espec�fica.

### Implementa��o 
 - Contexto (Context):
   Mant�m uma refer�ncia para a estrat�gia atual e pode alternar entre diferentes estrat�gias.

 - Estrat�gia (Strategy):
   Define a interface comum para todas as estrat�gias concretas. Pode ser uma interface abstrata ou uma classe abstrata.

 - Estrat�gias Concretas (Concrete Strategies):
   Implementam algoritmos espec�ficos. Cada estrat�gia � uma classe separada que implementa a interface da estrat�gia.

### SOlID
#### - Princ�pio da Responsabilidade �nica (SRP):
 - O padr�o Strategy ajuda a seguir o SRP, pois cada estrat�gia (algoritmo) � encapsulada em sua pr�pria classe, 
 permitindo que cada classe tenha uma �nica raz�o para mudar.

#### - Princ�pio Aberto/Fechado (OCP):
 - O padr�o Strategy � uma implementa��o cl�ssica do OCP. Novas estrat�gias podem ser adicionadas sem modificar o c�digo do cliente, 
 pois as estrat�gias s�o encapsuladas em interfaces comuns.No contexto do padr�o State, 
 isso significa que cada estado concreto deve ter uma responsabilidade �nica e espec�fica.