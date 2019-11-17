using System.Collections.Generic;

namespace Bitacora_Project.api.model
{
    public class Category
    {
        public int Id {get; set;}
        public string CategoryName {get; set;}
        public string Description {get; set;}

        public ICollection<Actividades> Categoria {get; set;}
    }
}