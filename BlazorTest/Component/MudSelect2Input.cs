using MudBlazor;

namespace BlazorTest.Component
{
    public class MudSelect2Input<T> : MudSelect<T>
    {
        public override ValueTask FocusAsync()
        {
            return new ValueTask();
        }
    }
}
