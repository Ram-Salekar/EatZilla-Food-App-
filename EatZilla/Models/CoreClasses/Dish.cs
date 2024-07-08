using System.ComponentModel.DataAnnotations;

namespace EatZilla.Models.CoreClasses
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }
        [Required]
        public string Name { get; set; }

        public byte[] image { get; set; }
        [Required]
        public int price {  get; set; }
        public Dish()
        {
            
        }
        public Dish(int DisId,string name,int price)
        {
            this.DishId = DisId;
            this.Name = name;
            this.price = price;
        }
        public Dish(int DisId, string name, int price, byte[]img)
        {
            this.DishId = DisId;
            this.Name = name;
            this.price = price;
            this.image = img;
        }
    }
}
