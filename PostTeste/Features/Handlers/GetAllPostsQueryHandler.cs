using MediatR;
using Microsoft.EntityFrameworkCore;
using PostTeste.Data;
using PostTeste.Entities;

public class GetAllPostsQueryHandler : IRequestHandler<GetAllPostsQuery, List<Post>>
{
    private readonly AppDbContext _context;

    public GetAllPostsQueryHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Post>> Handle(GetAllPostsQuery request, CancellationToken cancellationToken)
    {
        return await _context.Posts
            .Include(p => p.Comments)
            .Include(p => p.ParabensList)
            .ToListAsync(cancellationToken);
    }
}
