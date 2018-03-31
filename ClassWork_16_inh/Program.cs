using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_16_inh
{

    //public class Human<T>
    //{
    //    public T MyProperty { get; set; }
    //}

    //abstract class Oven
    //{
    //    public abstract void Heat();

    //    public void Print()
    //    {
    //        Console.WriteLine("Abstract");
    //    }
    //}

    //class GasOven : Oven
    //{
    //    public override void Heat()
    //    {
    //        Console.WriteLine("Gas");
    //    }
    // }

    //class ElectricOven : Oven
    //{
    //    public override void Heat()
    //    {
    //        Console.WriteLine("Electric");
    //    }
    //}

    //public abstract class DbSet<T> where T: class
    //{
    //    public bool Create(T entity)
    //    {
    //        Console.WriteLine("was created");
    //        return true;
    //    }

    //    public bool Update(T entity)
    //    {
    //        Console.WriteLine("was updated");
    //        return true;
    //    }

    //    public T Read(T entity)
    //    {
    //        return null;
    //    }

    //    public bool Delete(T entity)
    //    {
    //        Console.WriteLine("was deleted");
    //        return true;
    //    }
    //}
    
    public abstract class BaseRepository<T> where T: class
    {
        public bool Create(T entity)
        {
            Console.WriteLine("was created");
            return true;
        }

        public bool Update(T entity)
        {
            Console.WriteLine("was updated");
            return true;
        }

        public T Read(T entity)
        {
            return null;
        }

        public bool Delete(T entity)
        {
            Console.WriteLine("was deleted");
            return true;
        }
    }

    class FoodRepository: BaseRepository<Food>
    {

    }

    class Food
    {
        public decimal Price { get; set; }
        public string Name { get; set; }
        public List<Ingredient> ingredients { get; set; }
    }

    class Ingredient
    {
        public string Name { get; set; }
        public double Proteins { get; set; }
        public double Fats { get; set; }
    }

    class Drinks
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class DrinksRepository: BaseRepository<Drinks>
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Food food = new Food();
            food.Name = "Caesar";
            food.Price = 153;
            food.ingredients = new List<Ingredient>();
            food.ingredients.Add(new Ingredient { Fats = 15.3, Name = "Meat", Proteins = 15.6 });
            food.ingredients.Add(new Ingredient { Fats = 0, Name = "Bread", Proteins = 0 });
            
            BaseRepository<Food> foodRepository = new FoodRepository();
            foodRepository.Create(food);

            Drinks drink = new Drinks { Name = "Beer", Price = 10 };

            BaseRepository<Drinks> drinksRepository = new DrinksRepository();
            drinksRepository.Create(drink);
        }
    }
}
