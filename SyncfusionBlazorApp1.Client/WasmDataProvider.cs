
using Syncfusion.Blazor.Popups;
using System.Net.Http.Json;

namespace SyncfusionBlazorApp1.Client;

public class WasmDataProvider : BaseData, IDataProvider
{
    private readonly IHttpClientFactory _clientFactory;

    public WasmDataProvider(IHttpClientFactory clientFactory)
    {
        _clientFactory = clientFactory;
        
    }

    public async Task<List<Data>> GetData()
    {
        using HttpClient client = _clientFactory.CreateClient("Data");
        var data = await client.GetFromJsonAsync<List<Data>>("data.json") ?? [];
        return ManageDataId(data);
    }

    
}

public abstract class BaseData
{
    protected List<Data> ManageDataId(List<Data> datas, string? pid = null)
    {
        List<Data> flatResult = [];
        foreach (var data in datas)
        {
            data.Id= Guid.NewGuid().ToString();
            data.Pid = pid;
            flatResult.Add(data);
            flatResult.AddRange(ManageDataId(data.Children, data.Id));
            data.Children = [];
        }
        return flatResult;
    }
}
