using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMDbApiLib;
using IMDbApiLib.Models;

namespace LocadoraClassic.API
{
    public class ImdbApi
    {
        private ApiLib apiLib = new ApiLib("k_d267kift");
        public async Task<SearchData> GetTitles(string Title)
        {
            
            return await apiLib.SearchAsync(Title);
        }
        public async Task<TitleData> GetTitle(string Id)
        {
            return await apiLib.TitleAsync(Id,Language.pt_BR,Trailer:true);
        }
       
    }
}
