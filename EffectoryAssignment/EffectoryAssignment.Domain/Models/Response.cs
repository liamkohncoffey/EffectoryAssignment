using System;
using EffectoryAssignment.SharedKernel.Enums;

namespace EffectoryAssignment.Domain.Models
{
    public class Response
    {
        public Response(Departments department)
        {
            Random rnd = new Random();
            ResponseId = rnd.Next(0, int.MaxValue);
            Department = department;
            ItemType = ItemType.Response;
        }
        
        public long? ResponseId { get; set; }
        public Departments Department { get; set; }
        
        public ItemType ItemType { get; set; }
    }
}