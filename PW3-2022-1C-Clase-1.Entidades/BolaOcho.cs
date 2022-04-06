using System;
using PW3_2022_1C_Clase_1.Entidades;


namespace PW3_2022_1C_Clase_1.Entidades
{
    public static class BolaOcho
    {
        public static string getRespuesta() {

            string[] array = new string[20];

            array[0] = "Es cierto.";
            array[1] = "Es decididamente así.";
            array[2] = "Sin lugar a dudas.";
            array[3] = "Sí, definitivamente.";
            array[4] = "Puedes confiar en ello.";
            array[5] = "Como yo lo veo, sí.";
            array[6] = "Lo más probable.";
            array[7] = "Perspectiva buena.";
            array[8] = "Sí.";
            array[9] = "Las señales apuntan a que sí.";
            array[10] = "Respuesta confusa, vuelve a intentarlo.";
            array[11] = "Vuelve a preguntar más tarde.";
            array[12] = "Mejor no decirte ahora.";
            array[13] = "No se puede predecir ahora.";
            array[14] = "Concéntrate y vuelve a preguntar.";
            array[15] = "No cuentes con ello.";
            array[16] = "Mi respuesta es no.";
            array[17] = "Mis fuentes dicen que no.";
            array[18] = "Las perspectivas no son muy buenas.";
            array[19] = "Muy dudoso.";

            Random r = new Random();
            

            return array[r.Next(0, 20)];
        }
    }
}