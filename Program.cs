//Notas (Deus me ajude para não estar chovendo na saida)

Console.Clear();

        double EscadaC;
        double AnguloGr;
        double AnguloRa;
        double Altura;

Console.WriteLine("Insira o omprimento da escada:");
    EscadaC = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Insira o Angulo em graus da posição da escada:");
    AnguloGr = Convert.ToDouble(Console.ReadLine()!);

    AnguloRa = Math.PI * AnguloGr / 180;
    Altura = EscadaC * Math.Sin(AnguloRa);

Console.WriteLine($"Uma escada de {EscadaC} a {AnguloGr}° alcança {Altura}");