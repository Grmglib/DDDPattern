namespace DDDPattern.Contracts.Authentication
{
    public record AuthenticationRequest(Guid id,string FirstName, string LastName, string Email, string Token);
}
