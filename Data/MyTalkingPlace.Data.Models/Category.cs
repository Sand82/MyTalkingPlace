namespace MyTalkingPlace.Data.Models
{
    using MyTalkingPlace.Data.Common.Models;

    public class Category : BaseModel<int>
    {
        public string Name { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }
    }
}
