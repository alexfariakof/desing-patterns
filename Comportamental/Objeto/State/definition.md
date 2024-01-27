# Observer (Padr�o Comportamental):
Definir uam depend�ncia um para muitos entre objetos, de maneira 
que quando um objeto muda de estado todos os seus dependentes s�o notificados e artualizados automaticamente.

- Acoplamento: Reduz o acoplamento, pois os observadores reagem a mudan�as no sujeito.
- Coes�o: M�dia a alta, dependendo de como os observadores s�o projetados.

### Implementa��o 
- IObserver (Interface do Observador): 
  Define a interface comum que os observadores implementam. Isso permite que o sujeito se comunique com qualquer observador, independentemente da implementa��o espec�fica.

- ISubject (Interface do Sujeito): 
  Define a interface comum que o sujeito implementa. Isso permite que os observadores se registrem e sejam notificados, sem conhecerem a implementa��o espec�fica do sujeito.

### SOlID
 #### - Responsabilidade �nica (SRP):
   O princ�pio da Responsabilidade �nica diz que uma classe deve ter apenas uma raz�o para mudar. 
   No contexto do padr�o Observer, isso significa que a classe que est� sendo observada (sujeito) e as classes 
   que est�o observando (observadores) devem ter responsabilidades bem definidas.
 - Sujeito (Subject): 
   Respons�vel por manter o estado e notificar observadores sobre mudan�as. Ele deve se concentrar na gest�o do estado.

 - Observador (Observer): Respons�vel por reagir a mudan�as no sujeito. Ele deve se concentrar na l�gica relacionada � rea��o �s mudan�as.

 #### - Invers�o de Depend�ncia (DIP):
   O princ�pio da Invers�o de Depend�ncia sugere que as classes devem depender de abstra��es 
   e n�o de implementa��es concretas. No padr�o Observer, isso se traduz no fato de que tanto o sujeito 
   quanto os observadores dependem de uma abstra��o comum (a interface do observador) 
   em vez de dependerem diretamente uns dos outros.o reduz o acoplamento entre o Originator e o Memento, 
   seguindo o princ�pio da invers�o de depend�ncia.