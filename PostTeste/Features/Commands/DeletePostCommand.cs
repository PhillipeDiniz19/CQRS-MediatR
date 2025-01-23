using MediatR;

namespace PostTeste.Application.Commands
{
    public class DeletePostCommand : IRequest
    {
        public int PostId { get; set; }

        public DeletePostCommand(int postId)
        {
            PostId = postId;
        }
    }

}
