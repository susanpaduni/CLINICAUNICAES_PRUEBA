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

            if (int.TryParse(Console.ReadLine(), out opcion))
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

            if (int.TryParse(Console.ReadLine(), out opcion))
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
                        registrado = true;
                        Console.WriteLine("Paciente registrado exitosamente.");
                        Console.ReadLine();
                        break;
                    case 2:

                        Console.Clear();
                        Console.WriteLine("Consultar paciente");
                        Console.Write("Ingrese el numero de expediente del paciente: ");
                        string busqueda = Console.ReadLine();
                        if (registrado && busqueda == expediente)
                        {
                            Console.WriteLine("Paciente encontrado: " + nombre + "Expediente: " + expediente);

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
                            Console.WriteLine("Expediente: " + expediente);
                            Console.WriteLine("Nombre: " + nombre);
                            Console.WriteLine("Edad:  años" + edad);
                            Console.WriteLine("Sexo: " + sexo);
                            Console.WriteLine("Tipo de Sangre: " + sangre);
                            Console.WriteLine("Teléfono:" + telefono);
                        }
                        else
                        {
                            Console.WriteLine("No hay informacion registrada.");
                        }
                        Console.ReadLine();
                        break;
                }
            }

        } while (opcion != 4);
            

    }
    //MODULO PACIENTES
    static void MenuMedicos()
    {
        string codigoMedico = "", nombreMedico = "", especialidad = "", horario = "";
        int experiencia = 0;
        bool registrado = false;

        int opcion = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("=======ADMINISTRACIÓN DE MÉDICOS=======");
            Console.WriteLine("1. Registrar médico");
            Console.WriteLine("2. Consultar médico");
            Console.WriteLine("3. Mostrar información registrada");
            Console.WriteLine("4. Regresar");
            Console.Write("Seleccione una opción: ");
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Registrar Médico");
                        Console.Write("Código del médico: ");
                        codigoMedico = Console.ReadLine();
                        Console.Write("Nombre completo: ");
                        nombreMedico = Console.ReadLine();
                        Console.Write("Especialidad: ");
                        especialidad = Console.ReadLine();
                        Console.Write("Años de experiencia: ");
                        int.TryParse(Console.ReadLine(), out experiencia);
                        Console.Write("Horario de atención: ");
                        horario = Console.ReadLine();
                        registrado = true;
                        Console.WriteLine("Médico registrado exitosamente.");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Consultar Médico");
                        Console.Write("Ingrese el código del médico: ");
                        string busqueda = Console.ReadLine();
                        if (registrado && busqueda == codigoMedico)
                        {
                            Console.WriteLine("Médico encontrado: " + nombreMedico + " Código: " + codigoMedico);
                        }
                        else
                        {
                            Console.WriteLine("Médico no encontrado o sin registros.");
                        }
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Información registrada");
                        if (registrado)
                        {
                            Console.WriteLine("Código del médico: " + codigoMedico);
                            Console.WriteLine("Nombre: " + nombreMedico);
                            Console.WriteLine("Especialidad: " + especialidad);
                            Console.WriteLine("Años de experiencia: " + experiencia);
                            Console.WriteLine("Horario de atención: " + horario);
                        }
                        else
                        {
                            Console.WriteLine("No hay información registrada.");
                        }
                        Console.ReadLine();
                        break;
                }
            }


        } while (opcion != 4);
    }

    static void MenuConsultorios()
    {
        Console.WriteLine("=======ADMINISTRACION DE CONSULTORIOS=======");
        
        Console.Write("Numero de consultorio: ");
        int numeroConsultorio = int.Parse(Console.ReadLine());
        Console.Write("Piso: ");
        int piso = int.Parse(Console.ReadLine());
        Console.Write("Capacidad de pacientes en espera: ");
        int capacidad = int.Parse(Console.ReadLine());
        Console.Write ("Cantidad de pacientes esperando actualmente: ");
        int esperando = int.Parse(Console.ReadLine());
        Console.Write("Consultorio disponible?: ");
        string disponible = Console.ReadLine();


        int espaciosDisponibles = capacidad - esperando;

        Console.WriteLine("Resumen de consultorio");
        Console.WriteLine("Numero de consultorio:" + numeroConsultorio + "Piso: "+ piso);
        Console.WriteLine("Disponibilidad: "+ disponible);

        if (esperando > capacidad)
        {
            Console.WriteLine("La cantidad de pacientes supera la capacidad de la sala de espera");
            Console.WriteLine("Espacios excedidos:" + Math.Abs(espaciosDisponibles));
        }
        else
        {
            Console.WriteLine("Espacios disponibles: " + espaciosDisponibles);
        }
        Console.WriteLine("Presione Enter para regresar al menu principal.");
        Console.ReadLine();

    }

    //MODULO CITAS
    static void MenuCitas()
    {
        Console.Clear();
        Console.WriteLine("=======ADMINISTRACIÓN DE CITAS MÉDICAS=======");

        Console.Write("Número de cita: ");
        string numCita = int.Parse(Console.ReadLine());
        Console.Write("Nombre del paciente: ");
        string nomPaciente = Console.ReadLine();
        Console.Write("Nombre del médico: ");
        string nomMedico = Console.ReadLine();
        Console.Write("Fecha (DD/MM/AAAA): ");
        string fecha = Console.ReadLine();
        Console.Write("Hora (HH:MM): ");
        string hora = Console.ReadLine();
        Console.Write("Tipo de consulta (General o Especializada): ");
        string tipo = Console.ReadLine();

        if (!string.IsNullOrEmpty(numCita) && !string.IsNullOrEmpty(nomPaciente))
        {
            Console.WriteLine("¡La cita fue registrada!");
            Console.WriteLine("DETALLES DE LA CITA");
            Console.WriteLine($"Cita N°: "+ numCita);
            Console.WriteLine($"Paciente: " +  nomPaciente);
            Console.WriteLine($"Médico: " + nomMedico);
            Console.WriteLine($"Fecha y Hora:" + fecha + "a las " + hora);
            Console.WriteLine($"Tipo: " + tipo);
        }
        else
        {
            Console.WriteLine(" No se pudo registrar la cita. Faltan datos esenciales.");
        }

        Console.WriteLine("Presione Enter para regresar.");
        Console.ReadLine();
    }

    static void MenuEspecialidades()
    {
    }


}
