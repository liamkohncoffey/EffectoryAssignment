using System.Threading;
using System.Threading.Tasks;
using EffectoryAssignment.API.Extensions;
using EffectoryAssignment.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EffectoryAssignment.API.Controllers
{
    [ApiController]
    [Route("subjects/{subjectId}/questions/{questionsId}/answers")]
    public class AnswersController : ControllerBase
    {
        private readonly IAnswersService _answersService;

        public AnswersController(IAnswersService answersService)
        {
            _answersService = answersService;
        }
        
        [HttpGet("{answersId}")]
        public async Task<IActionResult> GetAnswer(long subjectId, long questionsId, long answersId, CancellationToken cancellationToken)
        {
            var answer = await _answersService.GetAnswer(subjectId, questionsId, answersId, cancellationToken);

            return Ok(answer.ToAnswerResponse());
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAnswers(long subjectId, long questionsId, CancellationToken cancellationToken)
        {
            var answers = await _answersService.GetAnswers(subjectId, questionsId, cancellationToken);

            return Ok(answers.ToApiResponse());
        }
    }
}