using MediatR;

namespace PostTeste.Application.Commands
{
    public class ApprovePostCommand : IRequest
    {
        public int PostId { get; set; }

        public ApprovePostCommand(int postId)
        {
            PostId = postId;
        }
    }

}
