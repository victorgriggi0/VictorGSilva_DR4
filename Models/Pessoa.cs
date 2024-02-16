namespace FirstWebApp.Models
{
    public class Pessoa
    {
        private int id;
        private string name;
        private int age;
        private string cpf;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Cpf { get => cpf; set => cpf = value; }
    }
}
