using System.Threading;
using System.Threading.Tasks;
using EffectoryAssignment.API.Extensions;
using EffectoryAssignment.Application.Interfaces;
using EffectoryAssignment.Definition.Requests;
using Microsoft.AspNetCore.Mvc;

namespace EffectoryAssignment.API.Controllers
{
    [ApiController]
    [Route("subjects/{subjectId}/questions/{questionsId}/answers/{answersId}/response")]
    public class ResponseController : ControllerBase
    {
        private readonly IResponseService _responseService;

        public ResponseController(IResponseService responseService)
        {
            _responseService = responseService;
        }
        
        [HttpPost]
        public async Task<IActionResult> AddResponse(long subjectId, long questionsId, long answersId, [FromBody] PostResponseRequest request, CancellationToken cancellationToken)
        {
            var answer = await _responseService.AddResponse(request.ToApplicationRequest(subjectId, questionsId, answersId), cancellationToken);

            return Ok(answer);
        }
    }
}