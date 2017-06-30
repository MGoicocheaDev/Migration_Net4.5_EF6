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
        public byte TipoFormacionId { get; set; }
        public TipoFormacion TipoFormacion { get; set; }
        public byte EstadoFormacionId { get; set; }
        public EstadoFormacion EstadoFormacion { get; set; }
        public string Titulo { get; set; }
        public int AreaEstudioId { get; set; }
        public AreaEstudio AreaEstudio { get; set; }
        public string Institucion { get; set; }
        public byte MesInicio { get; set; }
        public byte AnioInicio { get; set; }
        public byte MesFin { get; set; }
        public byte AnioFin { get; set; }
        public Boolean Actual { get; set; }
        public Decimal Promedio { get; set; }

        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
