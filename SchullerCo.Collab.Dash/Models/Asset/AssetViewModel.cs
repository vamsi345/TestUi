using SchullerCo.Collab.Dash;

namespace SchullerCo.Collab.Dash.Models.Asset
{
    public class AssetViewModel
    {
        public AssetDto Asset { get; set; }
        public bool IsExpanded { get; set; } = false;
        public List<AssetViewModel> Children { get; set; } = new List<AssetViewModel>();


        public AssetDto GetParentAsset(ICollection<AssetDto> list, AssetDto asset)
        {
            try
            {
                if (asset != null && asset.ParentId != null)
                {
                    return list.Where(a => a.Id == asset.ParentId).FirstOrDefault();
                }
                else return null;
            }
            catch (Exception)
            {

                return null;
            }
            
        }
    }

}
