using System;

class Horario
{
    static void Main()
    {
        
        Console.Write("Hora de início (hh mm): ");
        string[] inicio = Console.ReadLine().Split(' ');
        int horaInicio = int.Parse(inicio[0]);
        int minutoInicio = int.Parse(inicio[1]);

        
        Console.Write("Hora atual (hh mm): ");
        string[] atual = Console.ReadLine().Split(' ');
        int horaAtual = int.Parse(atual[0]);
        int minutoAtual = int.Parse(atual[1]);

        
        int diferenca = (horaAtual * 60 + minutoAtual) - (horaInicio * 60 + minutoInicio);

        
        if (diferenca < 0)
            diferenca += 24 * 60;

        
        int horas = diferenca / 60;
        int minutos = diferenca % 60;

        
        Console.WriteLine($"Hora de início: {horaInicio:D2}:{minutoInicio:D2}");
        Console.WriteLine($"Hora atual: {horaAtual:D2}:{minutoAtual:D2}");
        Console.WriteLine($"Tempo total: {horas}h{minutos}min");
    }
}
