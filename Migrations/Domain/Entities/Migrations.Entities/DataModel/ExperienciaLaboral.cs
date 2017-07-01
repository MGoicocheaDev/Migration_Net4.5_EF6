using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Migrations.Entities.Enum;

namespace Migrations.Entities.DataModel
{
    public class ExperienciaLaboral
    {
        public long ExperienciaLaboralId { get; set; }
        public long PersonaId { get; set; }
        public Persona Persona { get; set; }
        public string Empresa { get; set; }
        public int ActividadEmpresaId { get; set; }
        public ActividadEmpresa ActividadEmpresa { get; set; }  
        public string Puesto { get; set; }
        public NivelExperiencia NivelExperiencia { get; set; }
        public int PaisId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public Boolean Presente { get; set; }
        public int AreaLaboralId { get; set; }
        public AreaLaboral AreaLaboral { get; set; }
        public string DescripcionResponsabilidad { get; set; }
        public int PersonasACargo { get; set; }


        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; } 
       
    }
}
