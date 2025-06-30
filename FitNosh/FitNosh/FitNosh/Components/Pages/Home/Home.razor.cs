//using FitNosh.Components.SharedComponents;
using FitNosh.Models;
namespace FitNosh.Components.Pages.Home;


public  partial class Home
{
    public List<FoodCard> GetFoodCardsList;

    protected override async Task OnInitializedAsync()
    {
        
        Task.Delay(1000);
       GetFoodCardsList = new List<FoodCard>
        {
            new Models.FoodCard { Uri = new Uri("https://cdn.mos.cms.futurecdn.net/yBen3cZUaaCnDv6vysDfsi.jpg"), Name = "Grilled Chicken Salad", Price = "₹249" },
            new FoodCard { Uri = new Uri("https://assets.tmecosys.com/image/upload/t_web_rdp_recipe_584x480_1_5x/img/recipe/ras/Assets/1D1F8AE8-0888-45CB-B21B-15377ADC6C9A/Derivates/874a16dd-d1b1-4db0-bc13-fab251938451.jpg"), Name = "Protein Smoothie", Price = "₹199" },
            new FoodCard { Uri = new Uri("https://whatsfordinner.com/wp-content/uploads/2017/02/grilled-chicken-wrap-recipe.jpg"), Name = "Whole Wheat Wrap", Price = "₹179" },
            new FoodCard { Uri = new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQXTm_HGRznSf-l-7mJN9v-PmjMrFdgLZx5jA&s"), Name = "Overnight Oats", Price = "₹149" },
            new FoodCard { Uri = new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTYr9baoQTGMQFyuF-zMoW4Q8r3-CVmx5QBTg&s"), Name = "Meal Prep Bowl", Price = "₹299" },
            new FoodCard { Uri = new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQWbkMT4I3NmivJm8iJyUwW5kaJmP8VCunKBw&s"), Name = "Grilled Chicken Breast", Price = "₹269" },
            new FoodCard { Uri = new Uri("https://images.immediate.co.uk/production/volatile/sites/30/2023/10/TeriyakiTofu-79e1487.jpg?quality=90&resize=556,505"), Name = "Tofu Stir Fry", Price = "₹239" },
            new FoodCard { Uri = new Uri("https://betterfoodguru.com/wp-content/uploads/2022/01/Easy-Kale-and-Quinoa-Salad-scaled.jpg"), Name = "Quinoa Salad", Price = "₹189" },
            new FoodCard { Uri = new Uri("https://eggstory.s3.ap-southeast-1.amazonaws.com/resources/products/product-images/product-2022-07-16-05-13-49.png"), Name = "Boiled Egg Pack", Price = "₹89" },
            new FoodCard { Uri = new Uri("https://cafedelites.com/wp-content/uploads/2017/03/Fruit-Salad-Honey-Lime-Dressing-PICTURES.jpg"), Name = "Fresh Fruit Bowl", Price = "₹129" },
            new FoodCard { Uri = new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTjuImsG1fNRI5inAaBvbr1L1tl3vhTBs0okQ&s"), Name = "Veggie Delight", Price = "₹179" },
            new FoodCard { Uri = new Uri("https://static01.nyt.com/images/2013/04/24/science/26recipehealth/26recipehealth-superJumbo.jpg"), Name = "Whole Grain Pasta", Price = "₹219" },
            new FoodCard { Uri = new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcROcpqPIOiLzj7EPbp8qa7w_4qOhcTao3kzgQ&s"), Name = "Detox Juice", Price = "₹99" },
            new FoodCard { Uri = new Uri("https://images-cdn.ubuy.co.in/672b3895da3cec1a113341fe-gatorade-chocolate-chip-protein-bar-2-8.jpg"), Name = "Protein Bar", Price = "₹69" },
            new FoodCard { Uri = new Uri("https://i0.wp.com/earthygourmet.in/wp-content/uploads/2023/01/Grazing-Cheese-Plater-Cooking-Class-Gurgaon.jpg?fit=800%2C800&ssl=1"), Name = "Fit Platter", Price = "₹329" }
        };
       
    }
}