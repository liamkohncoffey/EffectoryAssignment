using EffectoryAssignment.SharedKernel.Enums;

namespace EffectoryAssignment.Application.Responses
{
    public class QuestionnaireItemBaseApplicationResponse
    {
        public ItemType ItemType { get; set; }
        public TextApplicationResponse Texts { get; set; }
        public int OrderNumber { get; set; }
    }
}