namespace SchullerCo.Collab.Dash.SvgIcons
{
    public static class SvgIconHelper
    {
        public static string GetSvgIcon(string icon)
        {
            try
            {
                string result = File.ReadAllText("..\\SchullerCo.Collab.Dash\\wwwroot\\icons\\" + icon + ".svg");
                return result;
            }
            catch (System.Exception ex)
            {
                return null;
            }

        }
    }
}
