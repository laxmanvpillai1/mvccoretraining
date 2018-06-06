using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
	public class MockPieRepository: IPieRepository
    {

		private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

              
		public IEnumerable<Pie> Pies {
			get{
				return new List<Pie>
				{
					new Pie{PieId=1, Name="Strawberry Pie", Price=15.95M, ShortDescription="Strawberry Pie", LongDescription="", },
					new Pie{PieId=2, Name="Cheese Cake", Price=18.95M, ShortDescription="Cheese Cake", LongDescription="", },
					new Pie{PieId=3, Name="Rhubarb Pie", Price=15.95M, ShortDescription="Rhubarb Pie", LongDescription="", },
					new Pie{PieId=1, Name="Pumpkin Pie", Price=12.95M, ShortDescription="Pumpkin Pie", LongDescription="", }
                 
				};
			}
		}

		public IEnumerable<Pie> PiesOfTheWeek { get; }

		public Pie GetPieById(int pieId)
		{
			throw new NotImplementedException();
		}
	}
}
