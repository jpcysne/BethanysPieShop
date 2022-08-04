namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Pie> AllPies =>
            new List<Pie>
            {
                new Pie { PieId = 1, Name="Strawberry Pie", Price = 15.95M,
                ShortDescription="Lorem Ipsum", LongDescription="Icing carror cake", Category = _categoryRepository.AllCategories.ToList()[0],
                ImageUrl="https://imagesvc.meredithcorp.io/v3/mm/image?q=60&c=sc&poi=face&w=2048&h=1024&url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F401339.jpg",
                InStock=true, IsPieofTheWeek=false, ImageThumbnailUrl="https://tmbidigitalassetsazure.blob.core.windows.net/rms3-prod/attachments/37/1200x1200/Easy-Fresh-Strawberry-Pie_EXPS_TMBBP19_34179_B06_20_3b.jpg" },


                new Pie { PieId = 2, Name="Cheese cake", Price = 18.95M,
                ShortDescription="Lorem Ipsum", LongDescription="Icing carror cake", Category = _categoryRepository.AllCategories.ToList()[0],
                ImageUrl="https://imagesvc.meredithcorp.io/v3/mm/image?q=60&c=sc&poi=face&w=2048&h=1024&url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F401339.jpg",
                InStock=true, IsPieofTheWeek=false, ImageThumbnailUrl="https://tmbidigitalassetsazure.blob.core.windows.net/rms3-prod/attachments/37/1200x1200/Easy-Fresh-Strawberry-Pie_EXPS_TMBBP19_34179_B06_20_3b.jpg" },

                new Pie { PieId = 3, Name="Seasonal pies", Price = 18.95M,
                ShortDescription="Lorem Ipsum", LongDescription="Icing carror cake", Category = _categoryRepository.AllCategories.ToList()[0],
                ImageUrl="https://imagesvc.meredithcorp.io/v3/mm/image?q=60&c=sc&poi=face&w=2048&h=1024&url=https%3A%2F%2Fimages.media-allrecipes.com%2Fuserphotos%2F401339.jpg",
                InStock=true, IsPieofTheWeek=false, ImageThumbnailUrl="https://tmbidigitalassetsazure.blob.core.windows.net/rms3-prod/attachments/37/1200x1200/Easy-Fresh-Strawberry-Pie_EXPS_TMBBP19_34179_B06_20_3b.jpg" }


            };

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return AllPies.Where(p => p.IsPieofTheWeek);
            }
        }

        public Pie? GetPieById(int pieId) => AllPies.FirstOrDefault(p => p.PieId == pieId);

        public IEnumerable<Pie> SearchPies(string searchQuery)
        {
            throw new NotImplementedException();
        }
    }
}
