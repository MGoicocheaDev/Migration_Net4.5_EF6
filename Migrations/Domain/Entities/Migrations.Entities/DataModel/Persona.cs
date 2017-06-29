using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Migrations.Entities.Enum;

namespace Migrations.Entities.DataModel
{
    public class Persona
    {
        public long PersonaId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public byte EstadoCivil { get; set; }
        public Genero Genero { get; set; }
        public int PaisId { get; set; }
        public Pais Pais { get; set; }
        public long DomicilioId { get; set; }
        public Domicilio Domicilio { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
