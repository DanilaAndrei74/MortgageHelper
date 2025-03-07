using BusinessLogic.Services;

namespace Application.Client.Services
{
    public class AppState
    {
        public readonly MortgageService Mortgage;

        public AppState(MortgageService mortgage)
        {
            Mortgage = mortgage;
        }

        public event Action? OnChange;

        public void Initialize()
        {
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
