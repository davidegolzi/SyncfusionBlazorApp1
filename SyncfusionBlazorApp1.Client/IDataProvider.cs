namespace SyncfusionBlazorApp1.Client;

public interface IDataProvider
{
    Task<List<Data>> GetData();
}
