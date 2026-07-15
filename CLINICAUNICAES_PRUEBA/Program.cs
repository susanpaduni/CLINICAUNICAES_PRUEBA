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
}
