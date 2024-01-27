# Memento (Padrão Comportamental):

Sem violar o encapsulamento, capturar e externalizar um estado interno de um objeto, de maneita 
que o objeto possa ser restaurado para esse estado mais tarde.

- Acoplamento: Pode variar dependendo da implementação, mas geralmente é médio.
- Coesão: Média a alta, pois o cuidador e o memento estão relacionados.

### O padrão ConcreteMemento é usado para capturar e armazenar o estado interno de um objeto sem violar o encapsulamento. Isso permite que o objeto seja restaurado posteriormente para o seu estado anterior. 
#### Para implementar o padrão ConcreteMemento, precisamos de três classes:
* A classe Originator, que é a classe cujo estado desejamos salvar e restaurar.
* A classe ConcreteMemento, que é uma classe auxiliar que armazena o estado interno do Originator.
* A classe Caretaker, que é responsável por armazenar e gerenciar os objetos ConcreteMemento.


### Considerações 
 
 - Vantagens:
   Esse padrão fornece uma maneira de implementar a captura de estado, sem expor a estrutura interna do objeto.  

 - Desvangages:
   Consumo excessivo de memória  
   obs.: 
	Uma possivél opção para solução do alto consumo de memória seria implementar cuidadores "Caretaker" para destruir objetos obsoletos.
	Implementar em conjunto com o Caretaker o padrão flyweight possibilitando o compartilhamento dos objetos 

### SOlID
- Princípio da Responsabilidade Única (SRP): O padrão Memento ajuda a manter a responsabilidade única ao separar as 
  preocupações de captura de estado e gestão de estado. O Originator é responsável por seu estado interno, o Memento cuida da 
  representação externa desse estado e o Caretaker gerencia os Mementos.

- Princípio do Aberto/Fechado (OCP): O Memento permite que novos estados e versões do Originator sejam adicionados 
  sem modificar o próprio Originator. Isso mantém o sistema aberto para extensão.

- Princípio da Inversão de Dependência (DIP): O Originator depende da interface do Memento, não de implementações concretas. 
  Isso reduz o acoplamento entre o Originator e o Memento, seguindo o princípio da inversão de dependência.