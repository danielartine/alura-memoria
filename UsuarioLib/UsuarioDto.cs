namespace UsuarioLib;

public record UsuarioDto
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public List<string> Telefones { get; set; }

    public virtual bool Equals(UsuarioDto? outroDto)
    {
        if(this.Nome == outroDto.Nome && this.Email == outroDto.Email)
        {
            return true;
        }
        return false;
    }
}