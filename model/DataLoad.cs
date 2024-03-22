using System.Text.Json;


public static class DataLoad
{

  public static List<Cidade> Cidades()
  {
    return Load<Cidade>("\\data\\cities.json");
  }

  public static List<Estado> Estados()
  {
    return Load<Estado>("\\data\\states.json");
  }

  public static List<Paises> Paises()
  {
    return Load<Paises>("\\data\\countries.json");
  }

  private static List<T> Load<T>(string path)
  {
    var json = File.ReadAllText(Directory.GetCurrentDirectory() + path);
    return JsonSerializer.Deserialize<List<T>>(json);
  }
}