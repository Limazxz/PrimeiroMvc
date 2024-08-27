namespace PrimeiroMvc.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int RM { get; set; }

        //Modificar o metodo contrutor
        //Inserir os dados que vieram por parametros no método contrutor bos atributos da Classe

        public Aluno(int Id, string Nome, string Email, int RM)
        {
            this.AlunoId = Id;
            this.Nome = Nome;
            this.Email = Email;
            this.RM = RM;
        }
    }
}
