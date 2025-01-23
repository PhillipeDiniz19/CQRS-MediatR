using MediatR;
using PostTeste.Entities;
using System.Collections.Generic;

namespace PostTeste.Application.Commands
{
    public class CreatePostCommand : IRequest<Post>
    {
        public string Content { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Siglas { get; set; }
        public string DescricaoLotacao { get; set; }
        public string Images { get; set; }
        public string UserPhoto { get; set; }

        public CreatePostCommand(string content, string userId, string userName, string siglas, string descricaoLotacao, string images, string userPhoto)
        {
            Content = content;
            UserId = userId;
            UserName = userName;
            Siglas = siglas;
            DescricaoLotacao = descricaoLotacao;
            Images = images;
            UserPhoto = userPhoto;
        }
    }
}
