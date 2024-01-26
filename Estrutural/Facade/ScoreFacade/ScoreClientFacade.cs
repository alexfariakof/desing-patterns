using Facade.APIs;

namespace Facade;

public class ScoreClientFacade
{
    DetranAPI detranAPI = new();
    SerasaAPI serasaAPI = new();
    ReceitaFederalAPI receitaFederalAPI = new();
    public double Score(string cpf, string cnh)
    {
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


        return Score;
    }
}
