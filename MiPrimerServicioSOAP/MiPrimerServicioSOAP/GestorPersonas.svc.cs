using System;

namespace MiPrimerServicioSOAP
{
    public class GestorPersonas : IGestorPersonas
    {
        public Persona GetPersona(string dni)
        {
            return new Persona
            {
                Dni = dni,
                Nombre = "Juan",
                Apellido = "Pérez"
            };
        }
    }
}
