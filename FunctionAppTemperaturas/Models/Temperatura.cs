﻿using System;

namespace FunctionAppTemperaturas.Models;

public class Temperatura
{
    public DateTime Data { get; }
    public double Fahrenheit { get; }
    public double Celsius { get; }
    public double Kelvin { get; }

    public Temperatura(double temperaturaFahrenheit)
    {
        Data = DateTime.Now;

        if (temperaturaFahrenheit < -459.67)
        {
            throw new ArgumentException(
                $"Valor de temperatura em Fahrenheit inválido: {temperaturaFahrenheit}");
        }

        Fahrenheit = temperaturaFahrenheit;
        Celsius = Math.Round((temperaturaFahrenheit - 32.0) / 1.8, 2);
        Kelvin = Math.Round(Celsius + 273.15, 2);
    }
}