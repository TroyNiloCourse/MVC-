using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockPieRepository: IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Pie> AllPies =>
            new List<Pie>
            {
                new Pie{PieId =1, Name="Straberry Pie", Price=15.95M, ShortDescription="Lorem Ipsum", LongDescription="Lorem Ipsum"},
                new Pie{PieId =2, Name="Chesse Cake", Price=18.95M, ShortDescription="Lorem Ipsum", LongDescription="Lorem Ipsum"},
                new Pie{PieId =3, Name="Rhubarb Pie", Price=15.95M, ShortDescription="Lorem Ipsum", LongDescription="Lorem Ipsum"},
                new Pie{PieId =4, Name="Pumpkin Pie", Price=12.95M, ShortDescription="Lorem Ipsum", LongDescription="Lorem Ipsum" }

            };
        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieId == pieId);

        }
    }
}
