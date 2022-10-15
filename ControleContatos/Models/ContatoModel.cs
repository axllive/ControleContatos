using System;
using System.ComponentModel.DataAnnotations;

namespace ControleContatos.Models
{
    public class ContatoModel
    {
        [Key]
        public Int64 cpf { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
    }
}
