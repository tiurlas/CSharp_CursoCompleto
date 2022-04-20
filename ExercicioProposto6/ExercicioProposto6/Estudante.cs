namespace Course
{
    class Estudante
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Estudante(string name, string email)
        {
            Nome = name;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
