using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrations.Entities.DataModel
{
    public class Formacion
    {
        public long FormacionId { get; set; }
        public long PersonaId { get; set; }
        public Persona Persona { get; set; }
        public byte TipoFormacion { get; set; }
        public string Descripcion { get; set; }
        public string Institucion { get; set; }
        public byte MesInicio { get; set; }
        public byte AnioInicio { get; set; }
    }
}
