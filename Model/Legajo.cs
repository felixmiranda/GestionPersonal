using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("Legajo")]
    public class Legajo
    {
        
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        public List<Legajo> Listar()
        {
            var legajos = new List<Legajo>();

            try
            {
                using (var context = new GestionPersonalContext())
                {
                    legajos = context.Legajo.ToList();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return legajos; 
        }

        public Legajo Obtener(int id)
        {
            var legajo = new Legajo();

            try
            {
                using (var context = new GestionPersonalContext())
                {
                    legajo = context.Legajo
                                .Where(x => x.Id == id)
                                .Single();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return legajo;
        }
    }
}
