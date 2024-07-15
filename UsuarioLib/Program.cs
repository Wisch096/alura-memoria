using UsuarioLib;

Usuario usuario = 
    new Usuario(
        "Daniel", 
        "daniel@email.com",
        new List<string>() {"12345678"});

usuario.ExibeTelefones();
usuario.PadronizaTelefones();
usuario.ExibeTelefones();