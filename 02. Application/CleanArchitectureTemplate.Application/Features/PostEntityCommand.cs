using MediatR;

namespace CleanArchitectureTemplate.Application.Features
{
    public class PostEntityCommand : IRequest<bool>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
