using BuberBreakfast.Models;

namespace BuberBreakfast.Services.Breakfasts;

public class BreakfastService : IBreakfastService
{
    private readonly Dictionary<Guid, Breakfast> breakfasts = new Dictionary<Guid, Breakfast>();

    public void CreateBreakfast(Breakfast breakfast)
    {
        breakfasts.Add(breakfast.Id, breakfast);
    }

    public void DeleteBreakfast(Guid id)
    {
        breakfasts.Remove(id);
    }

    public Breakfast GetBreakfast(Guid id)
    {
        return breakfasts[id];
    }

    public void UpsertBreakfast(Breakfast breakfast)
    {
        breakfasts[breakfast.Id] = breakfast;
    }
}