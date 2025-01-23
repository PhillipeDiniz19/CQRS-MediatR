using MediatR;
using PostTeste.Application.Commands;
using PostTeste.Data;
using PostTeste.Entities;
using PostTeste.Application.Exceptions;

public class ApprovePostCommandHandler : IRequestHandler<ApprovePostCommand>
{
    private readonly AppDbContext _context;

    public ApprovePostCommandHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(ApprovePostCommand request, CancellationToken cancellationToken)
    {
        var post = await _context.Posts.FindAsync(request.PostId);
        if (post == null)
        {
            throw new NotFoundException(nameof(Post), request.PostId);
        }

        post.IsApproved = true;
        await _context.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}
