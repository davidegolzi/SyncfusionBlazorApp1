using Microsoft.AspNetCore.Components;

namespace SyncfusionBlazorApp1.Client.Pages;
public partial class DropdownTreeFeatures
{
    [Inject] IDataProvider DataProvider { get; set; } = default!;
    List<Data> _categories = [];
    protected override async Task OnInitializedAsync()
    {
        _categories = await DataProvider.GetData();
    }
}
