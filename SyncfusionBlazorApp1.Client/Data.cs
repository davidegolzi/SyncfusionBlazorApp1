using System.Text.Json;

namespace SyncfusionBlazorApp1.Client;
public class Data
{
    public string? Id { get; set; }
    public string? Pid { get; set; }
    public string? City { get; set; }
    public string? CompleteName { get; set; }
    public string? CountryCodeISO3166Alpha2 { get; set; }
    public int GoogleMapsZoom { get; set; }
    public string? IsoDescription { get; set; }
    public float Latitude { get; set; }
    public float Longitude { get; set; }
    public string? Name { get; set; }
    public string? ParentUid { get; set; }
    public string? Slug { get; set; }
    public string? TimeZone { get; set; }
    public string? Uid { get; set; }
    public List<Data> Children { get; set; } = [];
    public bool ShouldHasChildren { get; set; }
}

