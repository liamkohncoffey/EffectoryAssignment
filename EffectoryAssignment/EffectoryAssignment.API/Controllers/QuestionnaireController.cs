using System.Threading;
using System.Threading.Tasks;
using EffectoryAssignment.API.Extensions;
using EffectoryAssignment.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EffectoryAssignment.API.Controllers
{
    [ApiController]
    [Route("questionnaire")]
    public class QuestionnaireController : ControllerBase
    {
        private readonly IQuestionnaireService _questionnaireService;

        public QuestionnaireController(IQuestionnaireService questionnaireService)
        {
            _questionnaireService = questionnaireService;
        }
        
        [HttpGet]
        public async Task<IActionResult> test()
        {
            return Ok();
        }
        
        [HttpGet("subject/{subjectId}/question/{questionId}")]
        public async Task<IActionResult> GetQuestionnaireItem(long subjectId, long questionId, CancellationToken cancellationToken)
        {
            var question = await _questionnaireService.GetQuestion(subjectId, questionId, cancellationToken);

            return Ok(question.ToApiResponse());
        }
    }
}