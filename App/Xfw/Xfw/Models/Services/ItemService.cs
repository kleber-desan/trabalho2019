using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xfw.Models;



namespace Xfw.Models.Services
{
    public interface IItemService

    {
        Task<List<Item>> GetAll();


    }
    public sealed class ItemService : IItemService
    {
        public async Task<List<Item>> GetAll()
        {
            await Task.Delay(2000);
            return new List<Item>
            
            {
                Item.Create("Cebolinha","","https://img.elo7.com.br/product/zoom/2135A33/roupa-cebolinha-monica.jpg"),
                Item.Create("Magali","","https://img.elo7.com.br/product/original/25A423E/painel-magali-3x2-5-painel-magali.jpg"),
                Item.Create("cascao","","https://upload.wikimedia.org/wikipedia/pt/3/35/Cascao.png"),
                Item.Create("Loco","",""),

            };
            
        }
    }
}
