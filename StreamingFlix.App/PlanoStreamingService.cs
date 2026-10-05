namespace StreamingFlix.App;

public class PlanoStreamingService
{
    public string ObterClassificacaoPorQualidade(int telasSimultaneas)
    {
        if (telasSimultaneas < 1)
        {
            throw new ArgumentOutOfRangeException(
                nameof(telasSimultaneas),
                "O número de telas simultâneas deve ser no mínimo 1.");
        }

        if (telasSimultaneas == 1)
        {
            return "BÁSICO";
        }

        if (telasSimultaneas >= 4)
        {
            return "PREMIUM";
        }

        return "PADRÃO";
    }

    public int CalcularMensalidadeComDesconto(int valorBase, int mesesContratados)
    {
        int percentualDesconto = mesesContratados switch
        {
            >= 12 => 20,
            >= 6 => 10,
            _ => 0
        };

        return valorBase * (100 - percentualDesconto) / 100;
    }

    public bool PodeAcessarConteudoAdulto(int idade, bool controleParentalAtivo)
    {
        return idade >= 18 && !controleParentalAtivo;
    }
}