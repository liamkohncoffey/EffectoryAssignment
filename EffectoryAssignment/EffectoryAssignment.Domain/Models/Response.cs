using System;
using EffectoryAssignment.SharedKernel.Enums;

namespace EffectoryAssignment.Domain.Models
{
    public class Response
    {
        public Response(Departments department, Guid userId)
        {
            Random rnd = new Random();
            ResponseId = rnd.Next(0, int.MaxValue);
            Department = department;
            ItemType = ItemType.Response;
            UserId = userId;
        }
        
        public long? ResponseId { get; set; }
        public Departments Department { get; set; }
        public Guid UserId { get; set; }
        public ItemType ItemType { get; set; }
    }
}