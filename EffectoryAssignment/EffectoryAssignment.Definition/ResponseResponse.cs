using System;
using EffectoryAssignment.SharedKernel.Enums;

namespace EffectoryAssignment.Definition
{
    public class ResponseResponse
    {
        public long? ResponseId { get; set; }
        public Departments Department { get; set; }
        public ItemType ItemType { get; set; }
        public Guid UserId { get; set; }
    }
}