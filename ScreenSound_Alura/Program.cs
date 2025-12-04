Banda evom = new Banda("Evom");

Album albumDoVeigh = new Album("Evom");

Musica musica1 = new Musica(evom, "Mônaco Fresstyle")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(evom, "Talvez você precisa de mim")
{
    Duracao = 354,
    Disponivel = false,
};


albumDoVeigh.AdicionarMusica(musica1);
albumDoVeigh.AdicionarMusica(musica2);
evom.AdicionarAlbum(albumDoVeigh);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoVeigh.ExibirMusicasDoAlbum();
evom.ExibirDiscografia();
