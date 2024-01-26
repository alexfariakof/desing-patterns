using Facade;
using Facade.APIs;

const string cpf = "963852741";
const string cnh = "147258369";


ScoreClientFacade facade = new();
var Score = facade.Score(cpf, cnh);

Console.WriteLine($"O Score do cliente é {Score}.");

void Example_Coupling_To_Solve_With_Facade()
{
    /* Implementação com acoplamento A ser resolvido */
    DetranAPI detranAPI = new();
    SerasaAPI serasaAPI = new();
    ReceitaFederalAPI receitaFederalAPI = new();

    var isValidCNH = detranAPI.IsValidCNH(cnh);
    var scoreSerasa = serasaAPI.Score(cpf);
    var isActiveCPF = receitaFederalAPI.IsActiveCPF(cpf);

    var Score = scoreSerasa * 1.0;
    var scrore20p = scoreSerasa * 0.2;
    var scrore30p = scoreSerasa * 0.3;

    if (!isValidCNH)
    Score = (Score - scrore20p);

    if (!isActiveCPF)
    Score = (Score - scrore30p);

    Console.WriteLine($"O Score do cliente é {Score}.");
}