namespace UTB.Minute.Contracts.Orders;

public record OrderResponse(
    int Id,
    int MenuItemId,
    string MealName,
    DateOnly MenuItemDate,
    string StudentId,
    string Status,
    DateTime CreatedAt
);

public record CreateOrderRequest(
    int MenuItemId,
    string StudentId
);

public record UpdateOrderStatusRequest(
    string Status
);
