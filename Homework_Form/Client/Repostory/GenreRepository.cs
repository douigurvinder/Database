using Homework_Form.Client.Htpp;
using Homework_Form.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework_Form.Client.Repostory
{
    public class GenreRepository : IGenreRepository
    {
        private string url = "api/genres";
        private readonly IHtppService htppService;
        public GenreRepository(IHtppService htppService)
        {
            this.htppService = htppService;
        }

        public async Task CreateInfo(Class1 class1) 
        {
            var response = await htppService.Post(url, class1);
            if (!response.Success) 
            {
                throw new ApplicationException(await response.GetBody());
            
            }
        }




    }
}
