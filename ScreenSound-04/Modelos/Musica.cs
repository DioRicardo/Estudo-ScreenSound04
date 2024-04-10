using System.Text.Json.Serialization;

namespace ScreenSound_04.Modelos;

internal class Musica
{
    string[] tonalidades = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
    
    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    [JsonPropertyName("artist")]
    public string Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    [JsonPropertyName("year")]
    public string AnoString { get; set; }

    public int Ano
    {
        get
        {
            return int.Parse(AnoString);
        }
    }

    [JsonPropertyName("key")]
    public int TomInt { get; set; }

    public string Tom
    {
        get
        {
            return tonalidades[TomInt];    
        }
    }

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista: {Artista}.");
        Console.WriteLine($"Música: {Nome}.");
        Console.WriteLine($"Duração em segundos: {Duracao / 1000}.");
        Console.WriteLine($"Gênero musical: {Genero}.");
        Console.WriteLine($"Ano de Lançamento: {Ano}.");
        Console.WriteLine($"Tonalidade: {Tom}.");
    }
}
