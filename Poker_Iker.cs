string pc1 = "";
string pc2 = "";
string pc3 = "";
string pc4 = "";
string pc5 = "";
string nc1 = "";
string nc2 = "";
string nc3 = "";
string nc4 = "";
string nc5 = "";

bool comprobado = false;

Random dadopaloc1 = new Random();
int paloc1 = dadopaloc1.Next(4);

Random dadopaloc2 = new Random();
int paloc2 = dadopaloc2.Next(4);

Random dadopaloc3 = new Random();
int paloc3 = dadopaloc3.Next(4);

Random dadopaloc4 = new Random();
int paloc4 = dadopaloc4.Next(4);

Random dadopaloc5 = new Random();
int paloc5 = dadopaloc5.Next(4);

Random dadonumc1 = new Random();
int num1 = dadonumc1.Next(13);

Random dadonumc2 = new Random();
int num2 = dadonumc2.Next(13);

Random dadonumc3 = new Random();
int num3 = dadonumc3.Next(13);

Random dadonumc4 = new Random();
int num4 = dadonumc4.Next(13);

Random dadonumc5 = new Random();
int num5 = dadonumc5.Next(13);

do
{
    /*Asegurando no cartas repetidas*/
    if (num1 == num2 && paloc1 == paloc2)                               
    {
                Random dadopaloc1 = new Random();
                int paloc1 = dadopaloc1.Next(4);

                Random dadonumc1 = new Random();
                int num1 = dadonumc1.Next(13);
    }
    if (num1 == num3 && paloc1 == paloc3)                               
    {
                Random dadopaloc1 = new Random();
                int paloc1 = dadopaloc1.Next(4);

                Random dadonumc1 = new Random();
                int num1 = dadonumc1.Next(13);
    }
    if (num1 == num4 && paloc1 == paloc4)                               
    {
                Random dadopaloc4 = new Random();
                int paloc4 = dadopaloc4.Next(4);

                Random dadonumc4 = new Random();
                int num4 = dadonumc4.Next(13);
    }
    if (num1 == num5 && paloc1 == paloc5)                               
    {
                Random dadopaloc5 = new Random();
                int paloc5 = dadopaloc5.Next(4);

                Random dadonumc5 = new Random();
                int num5 = dadonumc5.Next(13);
    }
    if (num2 == num3 && paloc2 == paloc3)                               
    {
                Random dadopaloc2 = new Random();
                int paloc2 = dadopaloc2.Next(4);

                Random dadonumc2 = new Random();
                int num2 = dadonumc2.Next(13);
    }
    if (num2 == num4 && paloc2 == paloc4)                               
    {
                Random dadopaloc3 = new Random();
                int paloc3 = dadopaloc3.Next(4);

                Random dadonumc3 = new Random();
                int num3 = dadonumc3.Next(13);
    }
    if (num2 == num5 && paloc2 == paloc5)                               
    {
                Random dadopaloc2 = new Random();
                int paloc2 = dadopaloc2.Next(4);

                Random dadonumc2 = new Random();
                int num2 = dadonumc2.Next(13);
    }
    if (num3 == num4 && paloc3 == paloc4)                               
    {
                Random dadopaloc3 = new Random();
                int paloc3 = dadopaloc3.Next(4);

                Random dadonumc3 = new Random();
                int num3 = dadonumc3.Next(13);
    }
    if (num3 == num5 && paloc3 == paloc5)                               
    {
                Random dadopaloc5 = new Random();
                int paloc5 = dadopaloc5.Next(4);

                Random dadonumc5 = new Random();
                int num5 = dadonumc5.Next(13);
    }
    if (num4 == num5 && paloc4 == paloc5)
    {
                Random dadopaloc4 = new Random();
                int paloc4 = dadopaloc4.Next(4);

                Random dadonumc4 = new Random();
                int num4 = dadonumc4.Next(13);
    }

    /*Asignación de cartas*/
        if (paloc1 == 1)
    {
        pc1 = "Corazones";
    }
    else if (paloc1 == 2)
    {
        pc1 = "Picas";
    }
    else if (paloc1 == 3)
    {
        pc1 = "Treboles";
    }
    else if (paloc1 == 0)
    {
        pc1 = "Diamantes";
    }

    if (paloc2 == 1)
    {
        pc2 = "Corazones";
    }
    else if (paloc2 == 2)
    {
        pc2 = "Picas";
    }
    else if (paloc2 == 3)
    {
        pc2 = "Treboles";
    }
    else if (paloc2 == 0)
    {
        pc2 = "Diamantes";
    }

    if (paloc3 == 1)
    {
        pc3 = "Corazones";
    }
    else if (paloc3 == 2)
    {
        pc3 = "Picas";
    }
    else if (paloc3 == 3)
    {
        pc3 = "Treboles";
    }
    else if (paloc3 == 0)
    {
        pc3 = "Diamantes";
    }

    if (paloc3 == 1)
    {
        pc3 = "Corazones";
    }
    else if (paloc3 == 2)
    {
        pc3 = "Picas";
    }
    else if (paloc3 == 3)
    {
        pc3 = "Treboles";
    }
    else if (paloc3 == 0)
    {
        pc3 = "Diamantes";
    }

    if (paloc4 == 1)
    {
        pc4 = "Corazones";
    }
    else if (paloc4 == 2)
    {
        pc4 = "Picas";
    }
    else if (paloc4 == 3)
    {
        pc4 = "Treboles";
    }
    else if (paloc4 == 0)
    {
        pc4 = "Diamantes";
    }

    if (paloc5 == 1)
    {
        pc5 = "Corazones";
    }
    else if (paloc5 == 2)
    {
        pc5 = "Picas";
    }
    else if (paloc5 == 3)
    {
        pc5 = "Treboles";
    }
    else if (paloc5 == 0)
    {
        pc5 = "Diamantes";
    }

    if (num1 == 1)
    {
        nc1 = "As";
    }
    else if (num1 == 2)
    {
        nc1 = "2";
    }
    else if (num1 == 3)
    {
        nc1 = "3";
    }
    else if (num1 == 4)
    {
        nc1 = "4";
    }
    else if (num1 == 5)
    {
        nc1 = "5";
    }
    else if (num1 == 6)
    {
        nc1 = "6";
    }
    else if (num1 == 7)
    {
        nc1 = "7";
    }
    else if (num1 == 8)
    {
        nc1 = "8";
    }
    else if (num1 == 9)
    {
        nc1 = "9";
    }
    else if (num1 == 10)
    {
        nc1 = "10";
    }
    else if (num1 == 11)
    {
        nc1 = "J";
    }
    else if (num1 == 12)
    {
        nc1 = "Q";
    }
    else if (num1 == 0)
    {
        nc1 = "K";
    }

    if (num2 == 1)
    {
        nc2 = "As";
    }
    else if (num2 == 2)
    {
        nc2 = "2";
    }
    else if (num2 == 3)
    {
        nc2 = "3";
    }
    else if (num2 == 4)
    {
        nc2 = "4";
    }
    else if (num2 == 5)
    {
        nc2 = "5";
    }
    else if (num2 == 6)
    {
        nc2 = "6";
    }
    else if (num2 == 7)
    {
        nc2 = "7";
    }
    else if (num2 == 8)
    {
        nc2 = "8";
    }
    else if (num2 == 9)
    {
        nc2 = "9";
    }
    else if (num2 == 10)
    {
        nc2 = "10";
    }
    else if (num2 == 11)
    {
        nc2 = "J";
    }
    else if (num2 == 12)
    {
        nc2 = "Q";
    }
    else if (num2 == 0)
    {
        nc2 = "K";
    }

    if (num3 == 1)
    {
        nc3 = "As";
    }
    else if (num3 == 2)
    {
        nc3 = "2";
    }
    else if (num3 == 3)
    {
        nc3 = "3";
    }
    else if (num3 == 4)
    {
        nc3 = "4";
    }
    else if (num3 == 5)
    {
        nc3 = "5";
    }
    else if (num3 == 6)
    {
        nc3 = "6";
    }
    else if (num3 == 7)
    {
        nc3 = "7";
    }
    else if (num3 == 8)
    {
        nc3 = "8";
    }
    else if (num3 == 9)
    {
        nc3 = "9";
    }
    else if (num3 == 10)
    {
        nc3 = "10";
    }
    else if (num3 == 11)
    {
        nc3 = "J";
    }
    else if (num3 == 12)
    {
        nc3 = "Q";
    }
    else if (num3 == 0)
    {
        nc3 = "K";
    }

    if (num4 == 1)
    {
        nc4 = "As";
    }
    else if (num4 == 2)
    {
        nc4 = "2";
    }
    else if (num4 == 3)
    {
        nc4 = "3";
    }
    else if (num4 == 4)
    {
        nc4 = "4";
    }
    else if (num4 == 5)
    {
        nc4 = "5";
    }
    else if (num4 == 6)
    {
        nc4 = "6";
    }
    else if (num4 == 7)
    {
        nc4 = "7";
    }
    else if (num4 == 8)
    {
        nc4 = "8";
    }
    else if (num4 == 9)
    {
        nc4 = "9";
    }
    else if (num4 == 10)
    {
        nc4 = "10";
    }
    else if (num4 == 11)
    {
        nc4 = "J";
    }
    else if (num4 == 12)
    {
        nc4 = "Q";
    }
    else if (num4 == 0)
    {
        nc4 = "K";
    }

    if (num5 == 1)
    {
        nc5 = "As";
    }
    else if (num5 == 2)
    {
        nc5 = "2";
    }
    else if (num5 == 3)
    {
        nc5 = "3";
    }
    else if (num5 == 4)
    {
        nc5 = "4";
    }
    else if (num5 == 5)
    {
        nc5 = "5";
    }
    else if (num5 == 6)
    {
        nc5 = "6";
    }
    else if (num5 == 7)
    {
        nc5 = "7";
    }
    else if (num5 == 8)
    {
        nc5 = "8";
    }
    else if (num5 == 9)
    {
        nc5 = "9";
    }
    else if (num5 == 10)
    {
        nc5 = "10";
    }
    else if (num5 == 11)
    {
        nc5 = "J";
    }
    else if (num5 == 12)
    {
        nc5 = "Q";
    }
    else if (num5 == 0)
    {
        nc5 = "K";
    }
}
while (
    // Comparaciones con la carta 1
    (num1 == num2 && paloc1 == paloc2) ||
    (num1 == num3 && paloc1 == paloc3) ||
    (num1 == num4 && paloc1 == paloc4) ||
    (num1 == num5 && paloc1 == paloc5) ||
    // Comparaciones con la carta 2
    (num2 == num3 && paloc2 == paloc3) ||
    (num2 == num4 && paloc2 == paloc4) ||
    (num2 == num5 && paloc2 == paloc5) ||
    // Comparaciones con la carta 3
    (num3 == num4 && paloc3 == paloc4) ||
    (num3 == num5 && paloc3 == paloc5) ||
    // Comparación entre carta 4 y 5
    (num4 == num5 && paloc4 == paloc5)
    );

Console.WriteLine("Tu primera carta es un: "+ nc1 +" de "+ pc1);
Console.WriteLine("Tu segunda carta es un: "+ nc2 +" de "+ pc2);
Console.WriteLine("Tu tercera carta es un: "+ nc3 +" de "+ pc3);
Console.WriteLine("Tu cuarta carta es un: "+ nc4 +" de "+ pc4);
Console.WriteLine("Tu quinta carta es un: "+ nc5 +" de "+ pc5);

if()
{
    
}