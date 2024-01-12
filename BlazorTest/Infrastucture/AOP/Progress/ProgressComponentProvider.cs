using MudBlazor;

namespace BlazorTest.Infrastucture.AOP.Progress
{
    public class ProgressComponentProvider
    {
        public static event Action OnShow;

        public static event Action OnHide;

        public static void Show() => OnShow?.Invoke();

        public static void Hide() => OnHide?.Invoke();
    }
}
