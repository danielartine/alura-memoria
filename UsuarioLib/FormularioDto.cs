using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuarioLib
{
    public record FormularioDto(string Nome, string Cpf, string Cargo)
    {
        public int Idade { get; set; }
    }
}
