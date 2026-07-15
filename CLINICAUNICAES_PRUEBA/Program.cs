class ClinicaUnicaes 
{
    static void Main(string[] args)
    {
        MenuPrincipal();
    }

    static void MenuPrincipal()
    {
        int opcion = 0;
        do
        {
            Console.WriteLine("============================");
            Console.WriteLine("CLINICA MEDICA UNICAES");
            Console.WriteLine("Sistema Administrativo");
            Console.WriteLine("============================");
            Console.WriteLine("1.Adminitracion de Pacientes");
            Console.WriteLine("2.Administracion de Medicos");
            Console.WriteLine("3.Administracion de Consultorios");
            Console.WriteLine("4.Administracion de Citas");
            Console.WriteLine("5.Administracion de Especialidades");
            Console.WriteLine("6.Salir");
            Console.WriteLine();
            Console.WriteLine("Seleccione una opcion:");

            if (int.Parse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        MenuPacientes();
                        break;
                    case 2:
                        MenuMedicos();
                        break;
                    case 3:
                        MenuConsultorios();
                        break;
                    case 4:
                        MenuCitas();
                        break;
                    case 5:
                        MenuEspecialidades();
                        break;
                    case 6:
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                    default:
                        Console.WriteLine("Opcion invalida. Presione Enter para intentar de nuevamente.");
                        Console.WriteLine();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ingrese un numero valido.Presione Enter");
                Console.ReadLine();
                opcion = 0;

                
            }
        } while (opcion != 6);
    }

    //MODULO DE PACIENTES 

    static void MenuPacientes()
    {
        string expediente = "", nombre = "", sexo= "", sangre = "", telefono = "";
        int edad = 0;
        bool registrado = false;

        int opcion = 0;

        do
        {

            Console.WriteLine("=======ADMINISTRACION DE PACIENTES=======");
            Console.WriteLine("1. Registrar paciente");
            Console.WriteLine("2. Consultar paciente");
            Console.WriteLine("3. Mostrar informacion registrada");
            Console.WriteLine("4. Regresar");
            Console.WriteLine("Seleccione una opcion:");

            if (int.TryParse(Console.ReadLine(),out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Registrar Paciente");
                        Console.Write("Numero de expediente: ");
                        expediente = Console.ReadLine();
                        Console.Write("Nombre completo: ");
                        nombre = Console.ReadLine();
                        Console.Write("Edad: ");
                        int.TryParse(Console.ReadLine(), out edad);
                        Console.Write("Sexo: ");
                        sexo = Console.ReadLine();
                        Console.Write("Tipo de sangre: ");
                        sangre = Console.ReadLine();
                        Console.Write("Numero de telefono: ");
                        telefono = Console.ReadLine();
                        registrado= true;
                        Console.WriteLine("Paciente registrado exitosamente.");
                        Console.Readine();
                        break;
                    case 2:

                        Console.Clear();
                        Console.WriteLine("Consultar paciente");
                        Console.Write("Ingrese el numero de expediente del paciente: ");
                       string busqueda = Console.ReadLine();
                        if (registrado && busqueda == expediente)
                        {
                            Console.WriteLine("Paciente encontrado: " + nombre + "Expediente: "+ expediente);
                           
                        }
                        else
                        {
                            Console.WriteLine("Paciente no encontrado o sin registros.");

                        }
                        Console.ReadLine();
                        break;
                        case 3:
                        Console.Clear();
                        Console.WriteLine("Informacion registrada");
                        if (registrado)
                        {
                            Console.WriteLine("Expediente: "+ expediente);
                            Console.WriteLine("Nombre: " + nombre );
                            Console.WriteLine("Edad:  años" + edad);
                            Console.WriteLine("Sexo: " + sexo);
                            Console.WriteLine("Tipo de Sangre: " + sangre);
                            Console.WriteLine("Teléfono:" + telefono);
                        }
            }



        }

    }

    static void MenuMedicos()
    {
    }

    static void MenuConsultorios()
    {
    }
    static void MenuCitas()
    {
    }

    static void MenuEspecialidades()
    {
    }


}
