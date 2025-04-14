namespace FireArmsInventoryManagementSystem.Authorization
{
    /// <summary>
    /// Each item corresponds to a specific action or capability in the system.
    /// A role can have multiple permissions, and a user can have multiple roles.
    /// </summary>
    public enum Permission
    {
        // Common “system-wide” or admin tasks
        ManageUsers,
        ConfigureSystemSettings,
        OverseeSecurity,

        // Inventory permissions
        ViewInventory,
        EditInventory,
        UpdateStockLevels,
        ProcessShipments,
        TrackWarehouseLocations,

        // Orders and sales
        CreateSalesOrders,
        ProcessSalesOrders,
        ApproveOrders,
        AccessCustomerHistory,

        // Reports and data
        GenerateReports,
        AccessFinancialData,

        // Supplier/Vendor tasks
        SubmitRestockRequests,
        ViewOwnSuppliedInventory,
        TrackDeliveryStatus,

        // Auditor tasks
        ViewInventoryLogs,
        ReviewUserActivity,
        GenerateComplianceReports,

        // … extend as necessary …
    }
}
