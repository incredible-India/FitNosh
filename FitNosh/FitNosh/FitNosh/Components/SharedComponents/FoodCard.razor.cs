using Microsoft.AspNetCore.Components;
using FitNosh.Models;
namespace FitNosh.Components.SharedComponents;

public partial class FoodCard
{
    [Parameter]
    public List<FitNosh.Models.FoodCard> FoodCardList { get; set; }
}