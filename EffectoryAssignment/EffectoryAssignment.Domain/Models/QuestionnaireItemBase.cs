using EffectoryAssignment.SharedKernel.Enums;

namespace EffectoryAssignment.Domain.Models
{
    public class QuestionnaireItemBase
    {
        public ItemType ItemType { get; set; }
        public Text Texts { get; set; }
        public int OrderNumber { get; set; }
    }
}