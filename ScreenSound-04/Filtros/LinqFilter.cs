using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();

        foreach(var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas do gênero: {genero}");

        foreach(var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasPorArtista(List<Musica> musicas, string  artista)
    {
        var musicasPorArtista = musicas.Where(musica => musica.Artista.Contains(artista)).Select(musica => musica).ToList();

        Console.WriteLine($"Exibindo as musicas do artista: {artista}");
        foreach(var musica in musicasPorArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    public static void FiltrarMusicasPorAno(List<Musica> musicas, int ano)
    {
        var musicasPorAno = musicas.Where(musica => musica.Ano == ano).OrderBy(musica => musica.Nome).Select(musica => musica.Nome).Distinct().ToList();

        Console.WriteLine($"Exibindo as musicas lançadas em: {ano}");
        foreach(var musica in musicasPorAno)
        {
            Console.WriteLine(musica);
        }
    }
}
