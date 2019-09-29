using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourStore.Data.interfaces;
using YourStore.Data.Models;

namespace YourStore.Data.mocks
{
    public class MockClothRepository : IClothRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Clothes> Clothes
        {
            get
            {
                return new List<Clothes>
                {
                    new Clothes {
                        Name = "American",
                        Price = 7.95M,
                        ShortDescription = "The best choice for you",
                        LongDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "https://gdurl.com/rlUi",
                        InStock = true,
                        IsPreferredCloth = true,
                        ImageThumbnailUrl = "https://gdurl.com/nlYS"
                    },
                    new Clothes {
                        Name = "Smoking ",
                        Price = 12.95M,
                        ShortDescription = "The best Smoking",
                        LongDescription= "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                        Category =  _categoryRepository.Categories.First(),
                        ImageUrl = "https://gdurl.com/Nkeo",
                        InStock = true,
                        IsPreferredCloth = false,
                        ImageThumbnailUrl = "https://gdurl.com/Mrgk"
                    },
                    new Clothes {
                        Name = "New style ",
                        Price = 16.75M,
                        ShortDescription = "A very elegant style",
                        LongDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                        Category =  _categoryRepository.Categories.First(),
                        ImageUrl = "https://gdurl.com/KzhP",
                        InStock = true,
                        IsPreferredCloth = false,
                        ImageThumbnailUrl = "https://gdurl.com/cgBe"
                    },
                    new Clothes
                    {
                        Name = "Mexican t-shirt",
                        Price = 17.95M,
                        ShortDescription = "A material made in mexico city",
                        LongDescription ="Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                        Category = _categoryRepository.Categories.Last(),
                        ImageUrl = "https://gdurl.com/Utun",
                        InStock = true,
                        IsPreferredCloth = false,
                        ImageThumbnailUrl = "https://gdurl.com/FGzrI"
                    }
                };
            }
        }



        public IEnumerable<Clothes> PreferredClothes { get; }

        public Clothes GetClothesById(int clothId)
        {
            throw new NotImplementedException();
        }
    }
}

