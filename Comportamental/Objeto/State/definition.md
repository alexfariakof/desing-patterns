# Observer (Padrão Comportamental):
Definir uam dependência um para muitos entre objetos, de maneira 
que quando um objeto muda de estado todos os seus dependentes são notificados e artualizados automaticamente.

- Acoplamento: Reduz o acoplamento, pois os observadores reagem a mudanças no sujeito.
- Coesão: Média a alta, dependendo de como os observadores são projetados.

### Implementação 
- IObserver (Interface do Observador): 
  Define a interface comum que os observadores implementam. Isso permite que o sujeito se comunique com qualquer observador, independentemente da implementação específica.

- ISubject (Interface do Sujeito): 
  Define a interface comum que o sujeito implementa. Isso permite que os observadores se registrem e sejam notificados, sem conhecerem a implementação específica do sujeito.

### SOlID
 #### - Responsabilidade Única (SRP):
   O princípio da Responsabilidade Única diz que uma classe deve ter apenas uma razão para mudar. 
   No contexto do padrão Observer, isso significa que a classe que está sendo observada (sujeito) e as classes 
   que estão observando (observadores) devem ter responsabilidades bem definidas.
 - Sujeito (Subject): 
   Responsável por manter o estado e notificar observadores sobre mudanças. Ele deve se concentrar na gestão do estado.

 - Observador (Observer): Responsável por reagir a mudanças no sujeito. Ele deve se concentrar na lógica relacionada à reação às mudanças.

 #### - Inversão de Dependência (DIP):
   O princípio da Inversão de Dependência sugere que as classes devem depender de abstrações 
   e não de implementações concretas. No padrão Observer, isso se traduz no fato de que tanto o sujeito 
   quanto os observadores dependem de uma abstração comum (a interface do observador) 
   em vez de dependerem diretamente uns dos outros.o reduz o acoplamento entre o Originator e o Memento, 
   seguindo o princípio da inversão de dependência.