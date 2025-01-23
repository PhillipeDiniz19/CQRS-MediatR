using MediatR;
using PostTeste.Entities;

public class GetCommentByIdQuery : IRequest<Comment>
{
    public int CommentId { get; set; }

    public GetCommentByIdQuery(int commentId)
    {
        CommentId = commentId;
    }
}
