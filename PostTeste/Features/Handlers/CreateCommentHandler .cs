using MediatR;
using PostTeste.Data;
using PostTeste.Entities;

public class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommand, Comment>
{
    private readonly AppDbContext _context;

    public CreateCommentCommandHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Comment> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
    {
        var comment = new Comment
        {
            PostId = request.PostId,
            UserName = request.UserName,
            Content = request.Content,
            UserPhoto = request.UserPhoto,
            Sigla = request.Sigla,
            CreatedAt = DateTime.UtcNow
        };

        _context.Comments.Add(comment);
        await _context.SaveChangesAsync(cancellationToken);

        return comment;
    }
}
