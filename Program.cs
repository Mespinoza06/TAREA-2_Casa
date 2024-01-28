// See https://aka.ms/new-console-template for more information


int opc=0;
string cedula = "";
string nombre = "";
int tipoEmpleado = 0;
int horasLab = 0;
float precioHora = 0;
float salarioOr = 0;
float aumento = 0;
float salarioBruto = 0;
float salarioNeto = 0;
float deduccion = 0;
string empleado = "";
int i = 0;
int cantOper = 0;
int cantTec = 0;
int cantPro = 0;
float salariosOp = 0;
float salariosTec = 0;
float salariosPro = 0;



do
{
    Console.WriteLine("Digite el numero de cedula");
    cedula=Console.ReadLine();   
    Console.WriteLine("Digite el nombre del Empleado ");
    nombre= Console.ReadLine();
    Console.WriteLine("Digite la cantidad de horas laboradas");
    horasLab = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite el precio de la hora");
    precioHora=int.Parse(Console.ReadLine());

    do
    {

        Console.WriteLine("Digite el codigo de tipo de empleado");
        Console.WriteLine("1- Operario");
        Console.WriteLine("2- Tecnico");
        Console.WriteLine("3- Profesional");
        tipoEmpleado = int.Parse(Console.ReadLine());
        if (tipoEmpleado == 1)
        {
            salarioOr = horasLab * precioHora;
            aumento = (float)(salarioOr * 0.15);
            salarioBruto = salarioOr + aumento;
            empleado = "Operario";
            cantOper = cantOper + 1;
            i = 0;
            deduccion = (float)((salarioBruto / 100) * 9.17);
            salarioNeto = salarioBruto - deduccion;
            salariosOp = salariosOp + salarioNeto;

        }
        else if (tipoEmpleado == 2)
        {
            salarioOr = horasLab * precioHora;
            aumento = (float)(salarioOr * 0.10);
            salarioBruto = salarioOr + aumento;
            empleado = "Tecnico";
            cantTec=cantTec + 1;
            i = 0;
            deduccion = (float)((salarioBruto / 100) * 9.17);
            salarioNeto = salarioBruto - deduccion;
            salariosTec = salariosTec + salarioNeto;

        }
        else if (tipoEmpleado == 3)
        {
            salarioOr = horasLab * precioHora;
            aumento = (float)(salarioOr * 0.05);
            salarioBruto = salarioOr + aumento;
            empleado = "Profesional";
            cantPro=cantPro + 1;
            i = 0;
            deduccion = (float)((salarioBruto / 100) * 9.17);
            salarioNeto = salarioBruto - deduccion;
            salariosPro = salariosPro + salarioNeto;
        }
        else if(tipoEmpleado < 1 || tipoEmpleado >3 )
        {
            Console.WriteLine("Valor invalido intente de nuevo");
            i = 1;
        }
             
    } while (i!=0);

   


    Console.WriteLine("Cedula: "+ cedula);
    Console.WriteLine("Nombre del Empleado: {0}", nombre);
    Console.WriteLine("Tipo de Empleado: {0}", empleado);
    Console.WriteLine("El salario por hora es: {0}", precioHora);
    Console.WriteLine("La cantidad de Horas e: {0}", horasLab);
    Console.WriteLine("El Salario ordinario es: {0}", salarioOr);
    Console.WriteLine("El aumento es de: {0}", aumento);
    Console.WriteLine("El salario Bruto es de: {0}", salarioBruto);
    Console.WriteLine("La deduccion de la CCSS es: {0}", deduccion);
    Console.WriteLine("El salario Neto es de: {0}", salarioNeto);


    Console.WriteLine("Desea ingresar otro Empleado");
    Console.WriteLine("Digite 1 para continuar o 2 para salir");
    opc=int.Parse(Console.ReadLine());


} while (opc!=2);

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("La cantidad de empleados tipo operacios es de: "+cantOper);
Console.WriteLine("El acumulado para salario Neto para Operadores es: "+salariosOp);
Console.WriteLine("El Promedio de salarios netos para Operarios es: "+(salariosOp/cantOper));

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("La cantidad de empleados tipo tecnicos es de: " + cantTec);
Console.WriteLine("El acumulado para salario Neto para tecnicos es: " + salariosTec);
Console.WriteLine("El Promedio de salarios netos para tecnicos es: " + (salariosTec / cantTec));

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("La cantidad de empleados tipo profesionales es de: " + cantPro);
Console.WriteLine("El acumulado para salario Neto para profesionales es: " + salariosPro);
Console.WriteLine("El Promedio de salarios netos para profesionales es: " + (salariosPro / cantPro));