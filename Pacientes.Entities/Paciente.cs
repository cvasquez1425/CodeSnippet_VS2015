using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacientes.Entities
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Ailment> Ailments       { get; set; }
        public ICollection<Medication> Medications { get; set; }
    }

    public class Medication
    {
        public int medicationId { get; set; }
        public string Name      { get; set; }
        public int Doses        { get; set; }
    }

    public class Ailment
    {
        public int ailmentId { get; set; }
        public string Name   { get; set; }
    }
}
