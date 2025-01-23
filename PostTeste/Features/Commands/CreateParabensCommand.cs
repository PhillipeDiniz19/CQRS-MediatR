using MediatR;
using PostTeste.Entities;

public class CreateParabensCommand : IRequest<Parabens>
{
    public int PostId { get; set; }
    public string UserName { get; set; }

    public CreateParabensCommand(int postId, string userName)
    {
        PostId = postId;
        UserName = userName;
    }
}
