using System;

namespace Full_GRASP_And_SOLID.Library
{
    public class CalcularCostos
    {
        public static double Calcular (Step steps)
        {
            double insumos = steps.Input.UnitCost * (steps.Quantity / 1000);
            double tiempo = steps.Time;
            tiempo = tiempo / 3600;
            double equipamiento = steps.Equipment.HourlyCost * tiempo;
            double subtotal = insumos + equipamiento;
            return subtotal;
        }
        /*Utilicé SRP para resolver este problema porque independicé el cálculo de los costos en una nueva clase*/
    }
}