
namespace SchullerCo.Collab.Dash.Models
{
    public class AssetDtoExtension : AssetDto
    {
        public AssetDto? AssetDto { get; set; }

        public ICollection<AssetDto>? AssetDtos { get; set; }
        public bool HasChildren { get; set; }

        public ICollection<AssetDtoExt> AssetDtoExts { get; set; }
    }

    public class AssetDtoExt : AssetDto
    {
        public bool HasChildren { get; set; }
    }
}
