using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleEstacionamento.Models
{
    [Table("Veiculo")]
    public class Veiculo
    {
        [Key]
        [Column("codigo_veiculo")]
        public int CodigoVei { get; set; }

        [Column("placa_veiculo")]
        public string PlacaVei { get; set; }
    }
}
