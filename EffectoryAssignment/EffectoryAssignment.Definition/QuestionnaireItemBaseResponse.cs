using EffectoryAssignment.SharedKernel.Enums;

namespace EffectoryAssignment.Definition
{
    public class QuestionnaireItemBaseResponse
    {
        public ItemType ItemType { get; set; }
        public TextResponse Texts { get; set; }
        public int OrderNumber { get; set; }
    }
}