using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class village
    {
        public static int numberOfVillages = 0;
        public village nextvillage;
        public village previousvillage;
        public string villagename;
        public bool isAstrildehere = false;

        public village() { village.numberOfVillages++; }
        class countyside
        {
            public village Maple;
            public village Toronto;
            public village Ajax;


            public void MapInitializer()
            {
                Maple = new village();
                Maple.villagename = "Maple";
                Maple.previousvillage = null;
                Maple.nextvillage = Toronto;
                Toronto = new village();
                Toronto.villagename = "Maple";
                Toronto.previousvillage = Toronto;
                Toronto.nextvillage = Ajax;
                Ajax = new village();
                Ajax.villagename = "Ajax";
                Ajax.previousvillage = null;
                Ajax.nextvillage = Toronto;
            }

        }

    }
}
