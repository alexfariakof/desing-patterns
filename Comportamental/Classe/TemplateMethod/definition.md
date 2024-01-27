# Template Method (Padrão Comportamental):

O padrão Template Method é projetado para fornecer um esqueleto de algoritmo na classe abstrata, 
permitindo que subclasses forneçam implementações específicas para etapas individuais. 
Isso ajuda a reduzir o acoplamento, pois o cliente interage principalmente com a classe abstrata, e a coesão é alta, 
pois cada etapa específica é implementada na própria subclasse.

- Acoplamento: Reduz o acoplamento, pois a estrutura geral do algoritmo está definida na classe abstrata, e as etapas específicas podem ser fornecidas por subclasses.
- Coesão: Alta coesão, pois a classe abstrata define a estrutura geral e as subclasses fornecem implementações específicas.

