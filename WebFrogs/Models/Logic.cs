using System.Collections.Generic;
using System.Linq;
using WebFrogs.Models.Entities;

namespace WebFrogs.Models
{
    public static class Logic
    {
        public static List<Toad> GetToad()
        {
            using (var context = new Context())
            {
                return context.Toads.ToList();
            }
        }
        public static Toad GetToad(int id)
        {
            using (var context = new Context())
            {
                return context.Toads.Find(id);
            }
        }

        public static List<Frog> GetFrog()
        {
            using (var context = new Context())
            {
                return context.Frogs.ToList();
            }
        }

        public static Frog GetFrog(int id)
        {
            using (var context = new Context())
            {
                return context.Frogs.Find(id);
            }
        }
    }
}
