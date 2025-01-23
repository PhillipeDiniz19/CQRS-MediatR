using MediatR;
using PostTeste.Entities;

public class GetAllPostsQuery : IRequest<List<Post>>
{
}
