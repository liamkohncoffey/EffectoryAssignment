using EffectoryAssignment.SharedKernel.Enums;

namespace EffectoryAssignment.Application.Requests
{
    public class QuestionnaireItemBaseApplicationResponse
    {
        public ItemType ItemType { get; set; }
        public TextApplicationResponse Texts { get; set; }
        public int OrderNumber { get; set; }
    }
}