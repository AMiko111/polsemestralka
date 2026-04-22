namespace UTB.Minute.Contracts.MenuItems;

public record MenuItemResponse(
    int Id,
    DateOnly Date,
    int MealId,
    string MealName,
    decimal MealPrice,
    int AvailablePortions
);

public record CreateMenuItemRequest(
    DateOnly Date,
    int MealId,
    int AvailablePortions
);

public record UpdateMenuItemRequest(
    DateOnly Date,
    int MealId,
    int AvailablePortions
);
