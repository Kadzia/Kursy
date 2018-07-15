using System.Data.Entity;

namespace EF
{
    public class Contex : DbContext
    {
        public Contex() : base("Klaudia_kurs")
        {
        }
    }
}
