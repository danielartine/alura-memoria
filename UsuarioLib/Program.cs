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

Stopwatch sw = new Stopwatch();

sw.Start();

for (int i = 0; i < 1000000000; i++)
{
    Coordenada coordenada = new Coordenada(123.456, -123.456);
    var latitude = coordenada.Latitude;
    var longitude = coordenada.Longitude;
}

sw.Stop();

Console.WriteLine(sw.Elapsed.TotalMilliseconds);