using MudBlazor;
using Rougamo;
using Rougamo.Context;

namespace BlazorTest.Infrastucture.AOP.Progress
{
    public class Progress : MoAttribute
    {
        private int _onExitTimeoutDelay;

        public Progress(int onExitTimeoutDelay = 0)
        {
            _onExitTimeoutDelay = onExitTimeoutDelay;
        }

        public override void OnEntry(MethodContext context)
        {
            ProgressComponentProvider.Show();
        }

        public override async void OnExit(MethodContext context)
        {
            try
            {
                await Task.Delay(_onExitTimeoutDelay);
                ProgressComponentProvider.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception In Progress Attribute: {ex}");
            }
        }
    }
}
