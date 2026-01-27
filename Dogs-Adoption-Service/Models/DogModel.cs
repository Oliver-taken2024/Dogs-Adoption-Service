namespace Dogs_Adoption_Service.Models
{
    public class DogModel
    {
        // model over all the properties of a dog
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cutness { get; set; }
        
        public string FavFood { get; set; }
        public string FavToy { get; set; }
        public int Temperment { get; set; }
        public bool IsAdopted { get; set; }
    }
}
