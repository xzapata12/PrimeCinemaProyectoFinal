using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace PrimeCinemaProyecto
{
    internal class Login
    {
       
        struct Usuario
        {
            public string login;
            public string password;
            public string nombreCompleto;
            public string numeroDUI;
            public string direccion;
            public string correoElectronico;
            public string numeroTelefono;
        }

        static void Main(string[] args)
        {
            List<Usuario> usuarios = LeerUsuariosDesdeArchivo();

            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("1. Iniciar sesión");
                Console.WriteLine("2. Salir");
                Console.WriteLine("3. Registrar usuario");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        if (IniciarSesion(usuarios))
                        {
                            Console.WriteLine("Inicio de sesión exitoso.");
                            // Mostrar lista de sucursales
                            Console.WriteLine("\nSeleccione una sucursal:");
                            Console.WriteLine("1. San Salvador");
                            Console.WriteLine("2. Santa Ana");
                            Console.WriteLine("3. San Miguel");
                            Console.WriteLine("4. La Libertad");
                            Console.WriteLine("5. Chalatenango");
                            Console.WriteLine("6. Sonsonate");
                            Console.WriteLine("7. Ahuachapán");
                            Console.WriteLine("8. Usulután");
                            Console.WriteLine("9. La Unión");
                            Console.WriteLine("10. Morazán");

                            // Leer opción seleccionada
                            Console.Write("Opción: ");
                            string opcionSucursal = Console.ReadLine();

                            // Validar opción seleccionada y mostrar mensaje
                            switch (opcionSucursal)
                            {
                                case "1":
                                    Console.WriteLine("\nHa seleccionado la sucursal de San Salvador.");
                                    break;
                                case "2":
                                    Console.WriteLine("\nHa seleccionado la sucursal de Santa Ana.");
                                    break;
                                case "3":
                                    Console.WriteLine("\nHa seleccionado la sucursal de San Miguel.");
                                    break;
                                case "4":
                                    Console.WriteLine("\nHa seleccionado la sucursal de La Libertad.");
                                    break;
                                case "5":
                                    Console.WriteLine("\nHa seleccionado la sucursal de Chalatenango.");
                                    break;
                                case "6":
                                    Console.WriteLine("\nHa seleccionado la sucursal de Sonsonate.");
                                    break;
                                case "7":
                                    Console.WriteLine("\nHa seleccionado la sucursal de Ahuachapán.");
                                    break;
                                case "8":
                                    Console.WriteLine("\nHa seleccionado la sucursal de Usulután.");
                                    break;
                                case "9":
                                    Console.WriteLine("\nHa seleccionado la sucursal de La Unión.");
                                    break;
                                case "10":
                                    Console.WriteLine("\nHa seleccionado la sucursal de Morazán.");
                                    break;
                                default:
                                    Console.WriteLine("\nOpción inválida.");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Credenciales incorrectas.");
                        }
                        break;
                    case "2":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;

                    case "3":
                        Console.WriteLine("Registro de nuevo usuario");
                        Usuario nuevoUsuario = new Usuario();
                        Console.Write("Ingrese su login: ");
                        nuevoUsuario.login = Console.ReadLine();
                        Console.Write("Ingrese su contraseña: ");
                        nuevoUsuario.password = Console.ReadLine();
                        Console.Write("Ingrese su nombre completo: ");
                        nuevoUsuario.nombreCompleto = Console.ReadLine();
                        Console.Write("Ingrese su número de DUI: ");
                        nuevoUsuario.numeroDUI = Console.ReadLine();
                        Console.Write("Ingrese su dirección: ");
                        nuevoUsuario.direccion = Console.ReadLine();
                        Console.Write("Ingrese su correo electrónico: ");
                        nuevoUsuario.correoElectronico = Console.ReadLine();
                        Console.Write("Ingrese su número de teléfono: ");
                        nuevoUsuario.numeroTelefono = Console.ReadLine();
                        usuarios.Add(nuevoUsuario);
                        Console.WriteLine("Usuario registrado exitosamente.");
                        break;


                }
            }

            EscribirUsuariosAArchivo(usuarios);
        }

        static List<Usuario> LeerUsuariosDesdeArchivo()
        {
            List<Usuario> usuarios = new List<Usuario>();
            string[] lineas = File.ReadAllLines("usuarios.txt");

            foreach (string linea in lineas)
            {
                string[] datos = linea.Split(';');
                Usuario usuario = new Usuario();
                usuario.login = datos[0];
                usuario.password = datos[1];
                usuario.nombreCompleto = datos[2];
                usuario.numeroDUI = datos[3];
                usuario.direccion = datos[4];
                usuario.correoElectronico = datos[5];
                usuario.numeroTelefono = datos[6];
                usuarios.Add(usuario);
            }

            return usuarios;
        }

        static void EscribirUsuariosAArchivo(List<Usuario> usuarios)
        {
            List<string> lineas = new List<string>();

            foreach (Usuario usuario in usuarios)
            {
                string linea = $"{usuario.login};{usuario.password};{usuario.nombreCompleto};{usuario.numeroDUI};{usuario.direccion};{usuario.correoElectronico};{usuario.numeroTelefono}";
                lineas.Add(linea);
            }

            File.WriteAllLines("usuarios.txt", lineas);
        }

        static bool IniciarSesion(List<Usuario> usuarios)
        {
            Console.Write("Ingrese su login: ");
            string login = Console.ReadLine();
            Console.Write("Ingrese su contraseña: ");
            string password = Console.ReadLine();

            foreach (Usuario usuario in usuarios)
            {
                if (usuario.login == login && usuario.password == password)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
