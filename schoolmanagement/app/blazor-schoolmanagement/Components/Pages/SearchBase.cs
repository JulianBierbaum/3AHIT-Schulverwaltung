namespace blazor_schoolmanagement.Components.Pages;

using Microsoft.AspNetCore.Components;

public class SearchBase : ComponentBase {
    public int currentCount = 0;

    public void IncrementCount() {
        currentCount++;
    }
}