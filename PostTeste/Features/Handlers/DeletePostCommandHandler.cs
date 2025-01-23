using MediatR;
using PostTeste.Application.Commands;
using PostTeste.Application.Exceptions;
using PostTeste.Data;
using PostTeste.Entities;

public class DeletePostCommandHandler : IRequestHandler<DeletePostCommand>
{
    private readonly AppDbContext _context;

    public DeletePostCommandHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(DeletePostCommand request, CancellationToken cancellationToken)
    {
        var post = await _context.Posts.FindAsync(request.PostId);
        if (post == null)
        {
            throw new NotFoundException(nameof(Post), request.PostId);
        }

        _context.Posts.Remove(post);
        await _context.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}
