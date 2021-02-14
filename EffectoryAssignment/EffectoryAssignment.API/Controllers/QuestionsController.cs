using System.Threading;
using System.Threading.Tasks;
using EffectoryAssignment.API.Extensions;
using EffectoryAssignment.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EffectoryAssignment.API.Controllers
{
    [ApiController]
    [Route("subjects/{subjectId}/questions")]
    public class QuestionsController : ControllerBase
    {
        private readonly IQuestionsService _questionsService;

        public QuestionsController(IQuestionsService questionsService)
        {
            _questionsService = questionsService;
        }
        
        [HttpGet("{questionId}")]
        public async Task<IActionResult> GetQuestion(long subjectId, long questionId, CancellationToken cancellationToken)
        {
            var question = await _questionsService.GetQuestion(subjectId, questionId, cancellationToken);

            return Ok(question.ToApiResponse());
        }
        
        [HttpGet]
        public async Task<IActionResult> GetQuestions(long subjectId, CancellationToken cancellationToken)
        {
            var questions = await _questionsService.GetQuestions(subjectId, cancellationToken);

            return Ok(questions.ToApiResponse());
        }
    }
}