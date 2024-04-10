using ScreenSound_04.Modelos;
using System.Text.Json;
using ScreenSound_04.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasPorArtista(musicas, "Red Hot Chili Peppers");
        //LinqFilter.FiltrarMusicasPorAno(musicas, 2000);
        LinqFilter.ExibirMusicasPorTonalidade(musicas, "C#");

        //var musicasPreferidasDoDio = new MusicasPreferidas("Dio");

        //musicasPreferidasDoDio.AdicionarMusicasFavoritas(musicas[13]);
        //musicasPreferidasDoDio.AdicionarMusicasFavoritas(musicas[7]);
        //musicasPreferidasDoDio.AdicionarMusicasFavoritas(musicas[1990]);
        //musicasPreferidasDoDio.AdicionarMusicasFavoritas(musicas[34]);
        //musicasPreferidasDoDio.AdicionarMusicasFavoritas(musicas[1993]);

        //musicasPreferidasDoDio.ExibirMusicasFavoritas();

        //musicasPreferidasDoDio.GerarArquivoJson();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
    
}