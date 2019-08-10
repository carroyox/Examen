using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
    public class Reference
    {

        public double Yuhasz(float[] pliegues, char Gen)
        {
            double Porcentaje_graso = 0;
            float SumPliegues = 0;

            foreach (float f in pliegues)
            {
                SumPliegues = SumPliegues + f;
            }
            switch (Gen)
            {
                case 'F':
                    Porcentaje_graso = 4.56 * (SumPliegues * 0.143);
                    break;
                case 'M':
                    Porcentaje_graso = 3.64 * (SumPliegues * 0.097);
                    break;

            }


            return Porcentaje_graso;
        }

        public double Jackson_Pollock(float[] pliegues, char Gen, int edad)
        {
            double Densidad_Corporal = 0;
            float SumPliegues = pliegues[0] + pliegues[1] + pliegues[2];

            switch (Gen)
            {
                case 'M':
                    Densidad_Corporal = 1.1093800 - (0.0008267 * SumPliegues) + (0.0000016 * (Math.Pow(SumPliegues, 2))) - (0.0002574 * edad);
                    break;
                case 'F':
                    Densidad_Corporal = 1.0994921 - (0.0009929 * SumPliegues) + (0.0000023 * (Math.Pow(SumPliegues, 2))) - (0.0001392 * edad);
                    break;

            }


            return Densidad_Corporal;
        }

        public List<Tbl_DensidadCorporal> datos() {

            List<Tbl_DensidadCorporal> lista = new List<Tbl_DensidadCorporal>();

            using (DB_ExamenEntities context = new DB_ExamenEntities()) {
                var datos =context.Tbl_DensidadCorporal.Select(x => new {/* pendiente de revisar*/}).ToList();

            }

            return lista;

        }







    }
}
