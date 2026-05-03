using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto2026.Models


{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }
        [DataType(DataType.Password)]
        public string senha { get; set; }

        public TipoUsuario Perfil { get; set; }
    }

    public enum TipoUsuario
    {
        Admin,
        UsuarioComum
    }
}
