using SyncfusionBlazorApp1.Client;
using System.Text.Json;

namespace SyncfusionBlazorApp1;

public class DataProvider : BaseData, IDataProvider
{
    private readonly Task<string> Data;

    public DataProvider(IWebHostEnvironment environment)
    {
        Data = File.ReadAllTextAsync(Path.Combine(environment.WebRootPath, "data.json"));
    }
    public async Task<List<Data>> GetData()
    {
        var data = JsonSerializer.Deserialize<List<Data>>(await Data) ?? [];
        return ManageDataId(data);
    }
}
