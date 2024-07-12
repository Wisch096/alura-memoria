using UsuarioLib;

Usuario usuario = 
    new Usuario(
        "Daniel", 
        "daniel@email.com",
        new List<string>() {"12345678"});

Usuario usuario2 =
    new Usuario(
        "Luis",
        "luis@email.com",
        new List<string>() { "87654321" });

usuario.ExibeTelefones();
usuario.PadronizaTelefones();
usuario.ExibeTelefones();