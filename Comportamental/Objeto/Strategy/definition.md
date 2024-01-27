# Strategy (Padrão Comportamental):
Definir uma família de algoritimos encapsular cada uma delas e torná-las intercambiáveis. 
Strategypermite que o algoritimo varie idependentemente dos clientes que o utilizam.

- Acoplamento: Reduz o acoplamento, pois o cliente interage com uma estratégia abstrata.
- Coesão: Alta coesão, pois cada estratégia é independente e focada em uma tarefa específica.

### Implementação 
 - Contexto (Context):
   Mantém uma referência para a estratégia atual e pode alternar entre diferentes estratégias.

 - Estratégia (Strategy):
   Define a interface comum para todas as estratégias concretas. Pode ser uma interface abstrata ou uma classe abstrata.

 - Estratégias Concretas (Concrete Strategies):
   Implementam algoritmos específicos. Cada estratégia é uma classe separada que implementa a interface da estratégia.

### SOlID
#### - Princípio da Responsabilidade Única (SRP):
 - O padrão Strategy ajuda a seguir o SRP, pois cada estratégia (algoritmo) é encapsulada em sua própria classe, 
 permitindo que cada classe tenha uma única razão para mudar.

#### - Princípio Aberto/Fechado (OCP):
 - O padrão Strategy é uma implementação clássica do OCP. Novas estratégias podem ser adicionadas sem modificar o código do cliente, 
 pois as estratégias são encapsuladas em interfaces comuns.No contexto do padrão State, 
 isso significa que cada estado concreto deve ter uma responsabilidade única e específica.