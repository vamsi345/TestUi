namespace SchullerCo.Collab.Dash.Services
{
    public static class ApiClientService
    {



        private static Client ApiClient()
        {
            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true
            };

            string baseUrl = "https://dash.schullerandcompany.eu:4433";
            string errorMessage = string.Empty;


            HttpClient client = new HttpClient(handler);
            Client apiClient = new Client(baseUrl, client);
            return apiClient;
        }

        public static async Task<ICollection<AssetDto>> GetAssets()
        {
            try
            {
                return await ApiClient().AssetsAllAsync();
            }
            catch (ApiException ex)
            {
                return null;
            }

            
        }

        public static async Task<AssetDto> GetAsset(int id)
        {
            try
            {
                return await ApiClient().AssetsGETAsync(id);
            }
            catch (ApiException ex)
            {
                return null;
            }
            
        }

        public static async Task<AssetDto> GetParent(int id)
        {
            try
            {
                AssetDto temp = await ApiClient().AssetsGETAsync(id);
                if (temp.ParentId != null) { return await ApiClient().AssetsGETAsync((int)temp.ParentId); }
                return null;
            }
            catch (ApiException ex)
            {
                return null;
            }


        }

        public static async Task<ICollection<AssetDto>> GetChildren(int id)
        {
            try
            {
                return await ApiClient().ChildrenAsync(id);
            }
            catch (ApiException ex)
            {
                return null;
            }
            
        }
    }
}
