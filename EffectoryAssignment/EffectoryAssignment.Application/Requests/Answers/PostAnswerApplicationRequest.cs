using EffectoryAssignment.SharedKernel.Enums;

namespace EffectoryAssignment.Application.Requests.Answers
{
    public class PostAnswerApplicationRequest
    {
        public Departments Department { get; set; }
        public long SubjectId { get; set; }
        public long QuestionId { get; set; }
        public long AnswersId { get; set; }
    }
}