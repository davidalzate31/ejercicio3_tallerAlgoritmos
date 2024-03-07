using System;

class Program
{
    static void Main(string[] args)
    {
        // Definir el sueldo base y el porcentaje de comisión
        double sueldoBase = 1000;
        double porcentajeComision = 0.10;

        // Ventas del mes
        double[] ventas = { 2000, 1500, 2500 };

        // Calcular comisiones por cada venta y sumarlas
        double totalComisiones = 0;
        foreach (double venta in ventas)
        {
            double comision = venta * porcentajeComision;
            totalComisiones += comision;
        }

        // Calcular el total mensual (sueldo base + comisiones)
        double totalMensual = sueldoBase + totalComisiones;

        // Mostrar resultados
        Console.WriteLine("Total de comisiones por las ventas en el mes: $" + totalComisiones);
        Console.WriteLine("Total recibido en el mes: $" + totalMensual);
    }
}