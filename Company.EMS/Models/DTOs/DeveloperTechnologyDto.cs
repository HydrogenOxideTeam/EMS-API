namespace Company.EMS.Models.DTOs;

public record DeveloperTechnologyDto
{
    public int Id { get; init; }
    public int DeveloperId { get; init; } 
    //public Developer Developer {get;init;}
    public int TechnologyId { get; init; } 
    //public Technology Technology {get;init;}
}