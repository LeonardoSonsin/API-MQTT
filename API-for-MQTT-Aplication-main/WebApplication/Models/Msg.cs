using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Msg
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="obrigatório")]
        public string TextoMsg { get; set; }
    }
}
