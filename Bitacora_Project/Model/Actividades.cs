using System;
using System.Collections.Generic;

namespace Bitacora_Project.api.model
{
    public class Actividades
    {
        public int Id {get; set;}
        public string Actividad {get; set;}
        public string Hora_Inicial {get; set;}
        public string Hora_Final {get; set;}

        public DateTime Fecha {get; set;}
        
    }
}