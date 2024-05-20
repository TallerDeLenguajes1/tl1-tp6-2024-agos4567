// See https://aka.ms/new-console-template for more information



Console.WriteLine("Hello, World!");
// int a;
// int b;
// a=10;
// b=a;
// Console.WriteLine("valor de a:"+a);
// Console.WriteLine("valor de b:"+b);


int opcion;

do
{
    

    Console.WriteLine("Ingrese el primer numero: ");


    int a = Convert.ToInt32(Console.ReadLine());  // convierte lo que ingreso por teclado a entero?


      Console.WriteLine("Ingrese el segundo numero: ");


     int b = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Elija una opcion: ");

        Console.WriteLine("1/ -Sumar-  2/ -Restar  3/-Multiplicar ");

     
     opcion=Convert.ToInt32(Console.ReadLine());

           switch (opcion)
    {
        case 1: 
            Console.WriteLine(a+b);
            break;
        case 2: 
            Console.WriteLine(a-b);
            break;
        case 3: 
            Console.WriteLine(a*b);
            break;
        case 4: 
            if(b == 0){
                Console.WriteLine("No es posible dividir en 0.");
            }else{
                Console.WriteLine(a/b);
            }
            break;
        default:

        Console.WriteLine("Opcion invalida.");
        Console.ReadLine();
        break;

      
    }



  Console.WriteLine("Desea realizar otra operacion (1.SI / 0.NO):");
    opcion = Convert.ToInt32(Console.ReadLine());  // convierte lo que ingreso por teclado a entero lo guarda en opcion para analiza si sale del do while o sigue preguntando?



} while (opcion !=0);


