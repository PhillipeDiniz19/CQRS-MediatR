using MediatR;
using PostTeste.Data;
using PostTeste.Entities;

public class CreateParabensCommandHandler : IRequestHandler<CreateParabensCommand, Parabens>
{
    private readonly AppDbContext _context;

    public CreateParabensCommandHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Parabens> Handle(CreateParabensCommand request, CancellationToken cancellationToken)
    {
        var parabens = new Parabens
        {
            PostId = request.PostId,
            UserName = request.UserName
        };

        _context.Parabens.Add(parabens);
        await _context.SaveChangesAsync(cancellationToken);

        return parabens;
    }
}
