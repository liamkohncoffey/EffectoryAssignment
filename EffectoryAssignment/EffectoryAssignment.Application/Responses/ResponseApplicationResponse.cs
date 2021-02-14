using System;
using EffectoryAssignment.SharedKernel.Enums;

namespace EffectoryAssignment.Application.Responses
{
    public class ResponseApplicationResponse
    {
        public long? ResponseId { get; set; }
        public Departments Department { get; set; }
        public ItemType ItemType { get; set; }
        public Guid UserId { get; set; }
    }
}