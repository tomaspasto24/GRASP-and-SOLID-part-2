using System;


namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Se cumple con el principio SRP y Expert al crear una nueva clase responsable de printear una receta en consola,
    /// en caso de en un futuro cambiar la salida de printeo de la receta, solo se debería cambiar la clase ConsolePrinter.
    /// /// </summary>
    public class ConsolePrinter
    {
        public static void Print(Recipe receta)
        {
            Console.WriteLine($"Receta de {receta.FinalProduct.Description}");
            foreach(Step paso in receta.GetSteps())
            {
                Console.WriteLine($"{paso.Quantity} de '{paso.Input.Description}' " +
                $"usando '{paso.Equipment.Description}' durante {paso.Time}");
            }
        }
    }
}


