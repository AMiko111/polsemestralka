namespace UTB.Minute.Contracts.Meals;

public record MealResponse(
    int Id,
    string Name,
    string Description,
    decimal Price,
    bool IsActive
);

public record CreateMealRequest(
    string Name,
    string Description,
    decimal Price
);

public record UpdateMealRequest(
    string Name,
    string Description,
    decimal Price,
    bool IsActive
);
