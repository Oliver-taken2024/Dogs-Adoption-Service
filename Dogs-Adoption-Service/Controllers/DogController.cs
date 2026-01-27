using Microsoft.AspNetCore.Mvc;
using Dogs_Adoption_Service.Models;

namespace Dogs_Adoption_Service.Controllers
{
    public class DogController : Controller
    {
        //skapa en falsk databas 
        private static List<DogModel> dogs = new List<DogModel>
        {
            new DogModel { Id = 1, Name ="Jake", Cutness= 7, FavFood="Turkey",FavToy="Tennisball",Temperment=4,IsAdopted=false},
            new DogModel { Id = 2, Name ="Mira", Cutness= 10, FavFood="Salami",FavToy="Squeky Toy",Temperment=5,IsAdopted=true},
            new DogModel { Id = 3, Name ="Daisy", Cutness= 6, FavFood="Bones",FavToy="FlipFlops",Temperment=7,IsAdopted=false},
            new DogModel { Id = 4, Name ="Dennis", Cutness= 8, FavFood="Pasta",FavToy="Fetch Stick",Temperment=3,IsAdopted=false},
            new DogModel { Id = 5, Name ="Gustave", Cutness= 9,  FavFood="Liverpaste",FavToy="Plush Squirrel",Temperment=8,IsAdopted=true}
        };

        public IActionResult Index()
        {
            //skikar listan av dogs till view
            return View(dogs);
        }
    }
}
