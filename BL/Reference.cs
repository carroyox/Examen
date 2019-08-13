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
        public List<String[]> datos()
        {
            List<String[]> retorno = new List<string[]>();
            List<Tbl_DensidadCorporal> lista = new List<Tbl_DensidadCorporal>();

            using (DB_ExamenEntities context = new DB_ExamenEntities())
            {
                lista = context.Tbl_DensidadCorporal.Select(x => x).ToList();

            }

            foreach (Tbl_DensidadCorporal tabla in lista)
            {
                String[] datos = new string[17];
                datos[0] = tabla.Nombre_Paciente;
                datos[1] = tabla.Genero.ToString();
                datos[2] = tabla.Edad.ToString();
                datos[3] = tabla.Peso.ToString("0.##Kg");
                datos[4] = tabla.Talla.ToString("0.##mts");
                datos[5] = tabla.Triceps.ToString("0.##mm");
                datos[6] = tabla.Biceps.ToString("0.##mm");
                datos[7] = tabla.Pecho.ToString("0.##mm");
                datos[8] = tabla.Axila.ToString("0.##mm");
                datos[9] = tabla.Subescapular.ToString("0.##mm");
                datos[10] = tabla.Suprailíaco.ToString("0.##mm");
                datos[11] = tabla.Abdomen.ToString("0.##mm");
                datos[12] = tabla.Muslo.ToString("0.##mm");
                datos[13] = tabla.Pantorrilla.ToString("0.##mm");
                datos[14] = tabla.Fecha_Medicion.ToString();
                datos[15] = tabla.Resultado_YUHASZ.ToString("0.###");
                datos[16] = tabla.Resultado_JacksonPollock.ToString("0.###");
                retorno.Add(datos);
             
            }
            return retorno;

        }
        
        public void Save(string nombre, float[] medidas, int edad, char genero, DateTime fecha)
        {
            using (DB_ExamenEntities context = new DB_ExamenEntities())
            {
                var tupla = new Tbl_DensidadCorporal()
                {
                    
                    Nombre_Paciente = nombre,
                    Genero = genero.ToString(),
                    Edad = (byte)edad,
                    Peso = medidas[0],
                    Talla = medidas[1],
                    Triceps = medidas[2],
                    Biceps = medidas[3],
                    Pecho = medidas[4],
                    Axila = medidas[5],
                    Subescapular = medidas[6],
                    Suprailíaco = medidas[7],
                    Abdomen = medidas[8],
                    Muslo = medidas[9],
                    Pantorrilla = medidas[10],
                    Fecha_Medicion = fecha,
                    Resultado_YUHASZ = Yuhasz(medidas, genero),
                    Resultado_JacksonPollock = Jackson_Pollock(medidas, genero, edad)
                };

                context.Tbl_DensidadCorporal.Add(tupla);
                context.SaveChanges();


            }
        }

        private double Yuhasz(float[] pliegues, char Gen)
        {
            double Porcentaje_graso = 0;
            float SumPliegues = 0;

            for (int i = 5; i <= pliegues.Length; i++)
            {
                SumPliegues = SumPliegues + pliegues[i - 1];

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

        private double Jackson_Pollock(float[] pliegues, char Gen, int edad)
        {
            double Densidad_Corporal = 0;
            float SumPliegues = 0;
            switch (Gen)
            {
                case 'M':
                    SumPliegues = pliegues[4] + pliegues[8] + pliegues[9];
                    Densidad_Corporal = 1.1093800 - (0.0008267 * SumPliegues) + (0.0000016 * (Math.Pow(SumPliegues, 2))) - (0.0002574 * edad);
                    break;
                case 'F':
                    SumPliegues = pliegues[2] + pliegues[7] + pliegues[9];
                    Densidad_Corporal = 1.0994921 - (0.0009929 * SumPliegues) + (0.0000023 * (Math.Pow(SumPliegues, 2))) - (0.0001392 * edad);
                    break;

            }


            return Densidad_Corporal;
        }



    }
}
