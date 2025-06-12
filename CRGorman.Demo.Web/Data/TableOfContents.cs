using CRGorman.Demo.ViewModels;
using System.Threading;

namespace CRGorman.Demo.Web.Data
{
    public class TableOfContents(HttpClient httpClient)
    {
        private List<TableOfContentsDto> ContentsData;

        public List<TableOfContentsDto> MissionList
        {
            get
            {
                if (this.ContentsData == null)
                {
                    try
                    {
                        var jsonResponse = httpClient.GetFromJsonAsync<List<TableOfContentsDto>>($"/mission");
                        jsonResponse.Wait();
                        if (jsonResponse.IsCompletedSuccessfully)
                        {
                            ContentsData = jsonResponse.Result;
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
                return ContentsData;
            }
        }
    }
}
