using System.Diagnostics;
using UsuarioLib;

//Usuario usuario = 
//    new Usuario(
//        "Daniel", 
//        "daniel@email.com",
//        new List<string>() {"12345678"});

////12345678
//usuario.ExibeTelefones();

////efetuar a padronização
//usuario.PadronizaTelefones();

////912345678
//usuario.ExibeTelefones();

//Stopwatch sw = new Stopwatch();

//sw.Start();

//for (int i = 0; i < 1000000000; i++)
//{
//    Coordenada coordenada = new Coordenada(123.456, -123.456);
//    var latitude = coordenada.Latitude;
//    var longitude = coordenada.Longitude;
//}

//sw.Stop();

//Console.WriteLine(sw.Elapsed.TotalMilliseconds);

//FormularioDto dto = new FormularioDto("Daniel", "11111111111", "Programador") { Idade = 99 };
//dto.Idade = 100;
//dto.Idade = 200;

//Console.WriteLine($" Valor do nome: {dto.Nome}");

//Console.WriteLine($" Valor do nome: {dto.Nome}");


//FormularioDto dto2 = new FormularioDto();
//dto2.Nome = "Daniel";
//dto2.Idade = 100;
//dto2.Cargo = "Programador";
//dto2.Cpf = "11111111112";

//Console.WriteLine(dto == dto2);

//UsuarioDto dto1 = new UsuarioDto();
//dto1.Nome = "Daniel";
//dto1.Email = "daniel@email.com";
//dto1.Telefones = new List<string>();

//UsuarioDto dto2 = new UsuarioDto();
//dto2.Nome = "Daniel2";
//dto2.Email = "daniel@email.com";
//dto2.Telefones = new List<string>();

//Console.WriteLine(dto1 == dto2);


//FormularioDto dto1 = new FormularioDto("Daniel", "11111111111", "Programador", 100);
//FormularioDto dto2 = new FormularioDto("Daniel", "11111111111", "Programador", 100);

//Console.WriteLine(dto1 == dto2);

//Stopwatch sw = new Stopwatch();

//sw.Start();

//for (int i = 0; i < 1000000000; i++)
//{
//    Coordenada coordenada = new Coordenada(123.456, -123.456);
//    var latitude = coordenada.Latitude;
//    var longitude = coordenada.Longitude;
//}

//sw.Stop();

//Console.WriteLine(sw.Elapsed.TotalMilliseconds);


//sw.Restart();

//for (int i = 0; i < 1000000000; i++)
//{
//    FormularioDto dto = new FormularioDto("Daniel", "11111111111", "Programador", 100);
//    var idade = dto.Idade;
//    var nome = dto.Nome;
//}

//sw.Stop();

//Console.WriteLine(sw.Elapsed.TotalMilliseconds);

//FormularioDto dto = new FormularioDto("Daniel", "11111111111", "Programador", 100);
//dto.Nome = "Outro nome";

Stopwatch sw = new Stopwatch();

sw.Start();

for (int i = 0; i < 1000000000; i++)
{
    FormularioDtoClass dto = new FormularioDtoClass("Daniel", "11111111111", "Programador", 100);
    dto.GetHashCode();
}

sw.Stop();

Console.WriteLine($"Tempo class: {sw.Elapsed.TotalMilliseconds}");


sw.Restart();

for (int i = 0; i < 1000000000; i++)
{
    FormularioDtoRecord dto = new FormularioDtoRecord("Daniel", "11111111111", "Programador", 100);
    dto.GetHashCode();
}

sw.Stop();

Console.WriteLine($"Tempo record: {sw.Elapsed.TotalMilliseconds}");

sw.Restart();

for (int i = 0; i < 1000000000; i++)
{
    FormularioDtoStruct dto = new FormularioDtoStruct("Daniel", "11111111111", "Programador", 100);
    dto.GetHashCode();
}

sw.Stop();

Console.WriteLine($"Tempo struct: {sw.Elapsed.TotalMilliseconds}");

sw.Restart();

for (int i = 0; i < 1000000000; i++)
{
    FormularioDtoRecordStruct dto = new FormularioDtoRecordStruct("Daniel", "11111111111", "Programador", 100);
    dto.GetHashCode();
}

sw.Stop();

Console.WriteLine($"Tempo record struct: {sw.Elapsed.TotalMilliseconds}");

