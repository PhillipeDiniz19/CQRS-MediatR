using MediatR;
using PostTeste.Data;
using PostTeste.Entities;

namespace PostTeste.Application.Handlers
{
    public class GetParabensByIdQueryHandler : IRequestHandler<GetParabensByIdQuery, Parabens>
    {
        private readonly AppDbContext _context;

        public GetParabensByIdQueryHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Parabens> Handle(GetParabensByIdQuery request, CancellationToken cancellationToken)
        {
            return await _context.Parabens.FindAsync(request.ParabensId);
        }
    }
}