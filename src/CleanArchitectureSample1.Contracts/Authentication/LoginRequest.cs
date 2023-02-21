namespace CleanArchitectureSample1.Contracts.Authentication;

public record LoginRequest(
    string Email,
    string Password
);