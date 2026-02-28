using System.Data;

namespace InterfejsPrototyp
{
    public class SharedStateService
    {

        public int UserId { get; private set; }
        public string UserName { get; private set; } = string.Empty;
        public bool IsLoggedIn => UserId > 0;

        public event Action? OnChange;

        public void Login(int id, string name)
        {
            UserId = id;
            UserName = name;

            NotifyStateChanged();
        }

        public void Logout()
        {
            UserId = 0;
            UserName = string.Empty;
            NotifyStateChanged();
        }
        private void NotifyStateChanged() => OnChange?.Invoke();

    }
}

