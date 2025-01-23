using MediatR;
using PostTeste.Application.Commands;
using PostTeste.Data;
using PostTeste.Entities;

public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, Post>
{
    private readonly AppDbContext _context;

    public CreatePostCommandHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Post> Handle(CreatePostCommand request, CancellationToken cancellationToken)
    {
        var post = new Post
        {
            Content = request.Content,
            UserId = request.UserId,
            UserName = request.UserName,
            Siglas = request.Siglas,
            DescricaoLotacao = request.DescricaoLotacao,
            Images = request.Images,
            UserPhoto = request.UserPhoto,
            CreatedAt = DateTime.UtcNow,
            IsApproved = false
        };

        _context.Posts.Add(post);
        await _context.SaveChangesAsync(cancellationToken);

        return post;
    }
}
