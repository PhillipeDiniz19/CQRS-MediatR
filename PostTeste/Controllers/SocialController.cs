using MediatR;
using Microsoft.AspNetCore.Mvc;
using PostTeste.Application.Commands;


namespace PostTeste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SocialController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // Endpoint para criar um post
        [HttpPost("post")]
        public async Task<IActionResult> CreatePost([FromBody] CreatePostCommand command)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var post = await _mediator.Send(command);
            return Ok(post);
        }


        // Endpoint para criar um comentário
        [HttpPost("comment")]
        public async Task<IActionResult> CreateComment([FromBody] CreateCommentCommand command)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var comment = await _mediator.Send(command);
            return Ok(comment);
        }


        // Endpoint para criar uma reação de "Parabéns"
        [HttpPost("parabens")]
        public async Task<IActionResult> CreateParabens([FromBody] CreateParabensCommand command)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var parabens = await _mediator.Send(command);
            return Ok();
        }

        [HttpGet("posts")]
        public async Task<IActionResult> GetAllPosts()
        {
            var posts = await _mediator.Send(new GetAllPostsQuery());
            if(posts == null)
            {
                return NotFound();
            }
            return Ok(posts);
        }


        // Endpoint atualizar/aprovar post
        [HttpPut("post/{id}/approve")]
        public async Task<IActionResult> ApprovePost(int id)
        {
            var command = new ApprovePostCommand(id);
            await _mediator.Send(command);
            return NoContent();
        }


        // Endpoint para obter todos os posts aprovados.
        [HttpDelete("post/{id}")]
        public async Task<IActionResult> DeletePost(int id)
        {
            var command = new DeletePostCommand(id);
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
