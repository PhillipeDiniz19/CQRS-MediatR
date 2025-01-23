using MediatR;
using PostTeste.Entities;

public class GetParabensByIdQuery : IRequest<Parabens>
{
    public int ParabensId { get; set; }

    public GetParabensByIdQuery(int parabensId)
    {
        ParabensId = parabensId;
    }
}
