 Console.WriteLine("-- Peso Ideal --");

        
        Console.Write("Qual a sua altura em metros? ");
        double altura = Convert.ToDouble(Console.ReadLine());

      
        Console.Write("Qual o seu sexo?");
        string sexo = Console.ReadLine().ToUpper(); 

        double bompeso;

    
        if (sexo == "M")
        {
            bompeso = (72.7 * altura) - 58.0;
            Console.WriteLine("peso ideal para ele:" + bompeso.ToString("F2"));
        }
        else if (sexo == "F") 
        {
            bompeso = (62.1 * altura) - 44.7;
            Console.WriteLine("peso ideal para ela:"  + bompeso.ToString("F2"));
        }
        else
        {
            Console.WriteLine("Sexo inválido. Por favor, insira 'M' para Masculino ou 'F' para Feminino.");
            return;
        }
