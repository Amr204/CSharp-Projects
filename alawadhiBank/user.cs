namespace alawadhiBank
{
    class user
    {
        private Guid _id;
        private string _name;
        private string _password;

        public Guid Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Password
        {
            get => _password;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Can't be null!");
                _password = value;
            }
        }

        public user() { }

        public user(string name, string password)
        {

            _id = Guid.NewGuid();
            _name = name;
            _password = password;
        }


    }
}