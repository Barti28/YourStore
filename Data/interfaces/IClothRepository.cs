using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourStore.Data.Models;

namespace YourStore.Data.interfaces
{
   public interface IClothRepository
    {
       IEnumerable<Clothes> Clothes { get;}
       IEnumerable<Clothes> PreferredClothes { get;}

       Clothes GetClothesById(int clothId);

    }
}
