namespace xoxoxo
{
    public struct Credentials
    {
        public Credentials(string username, string password, string website)
        {
            Username = username;
            Password = password;
            Website = website;
        }

        public string Username { get; }

        public string Password { get; }

        public string Website { get; }
    }
}