namespace Minimal_Api.Dominio.DTOs
{

    internal class LoginDTO
    {
        public string Email { get; set; } = default!;
        public string Senha { get; set; } = default!;
    }
}