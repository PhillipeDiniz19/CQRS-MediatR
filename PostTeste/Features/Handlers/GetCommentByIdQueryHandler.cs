using MediatR;
using PostTeste.Data;
using PostTeste.Entities;

namespace PostTeste.Application.Handlers
{
    public class GetCommentByIdQueryHandler : IRequestHandler<GetCommentByIdQuery, Comment>
    {
        private readonly AppDbContext _context;

        public GetCommentByIdQueryHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Comment> Handle(GetCommentByIdQuery request, CancellationToken cancellationToken)
        {
            return await _context.Comments.FindAsync(request.CommentId); 
        }
    }
}