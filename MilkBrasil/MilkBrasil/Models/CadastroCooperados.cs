using SQLite;
using System;

namespace MilkBrasil.Models
{
   public class CadastroCooperados
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Razao { get; set; }
        public string Nome { get; set; }
        public int Cnpj { get; set; }
        public DateTime Fundacao { get; set; }
        public string Endereco { get; set; }
        public int Telefone { get; set; }
        public int Celular { get; set; }
        public string Atividade { get; set; }
        public int Envolvidos { get; set; }
        public string Representante { get; set; }

    }
}
