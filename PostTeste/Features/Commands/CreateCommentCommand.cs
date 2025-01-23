using MediatR;
using PostTeste.Entities;

public class CreateCommentCommand : IRequest<Comment>
{
    public int PostId { get; set; }
    public string UserName { get; set; }
    public string Content { get; set; }
    public string UserPhoto { get; set; }
    public string Sigla { get; set; }

    public CreateCommentCommand(int postId, string userName, string content, string userPhoto, string sigla)
    {
        PostId = postId;
        UserName = userName;
        Content = content;
        UserPhoto = userPhoto;
        Sigla = sigla;
    }
}
