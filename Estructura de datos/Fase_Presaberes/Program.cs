
namespace Fase_Presaberes
{
    class Program
    {
       
       static void Menu(){
        // Muestra el menu de Opciones y datos de la aplicacion.
        string menuHead = string.Format("{0}{0}:::: Bienvenido a Mascotas Spa Inc. ::::{0}", Environment.NewLine);
        string menuInfo = string.Format("{0}{0} Dev: Juan M. Rodríguez Lanza{0} App: Descuentos Mascotas Spa Inc. 2022{0}-Estructura de Datos UNAD 2022 II-{0}", Environment.NewLine); 
        string menuOptions = string.Format("{0}{0}Seleccione las opciones que requiere:{0}{0}1. Ingresar al aplicativo.{0}2. Salir. {0}", Environment.NewLine);   
    
        Console.Write(menuHead + menuInfo + menuOptions + Environment.NewLine);

        Console.Write("Opción: ");
        int option = Convert.ToInt16(Console.ReadLine());
        switch (option)
        {
            case 1: 
            Console.WriteLine("-----------------------------------------------", Environment.NewLine);
            // Sigue al siguiente Metodo
            break;
            case 2: 
            Environment.Exit(0);
            break;
        }
       }

        static bool Credenciales(){
            //Recibe las credenciales y las compara.
            string menuHead = string.Format("{0}:::: Credenciales ::::{0}", Environment.NewLine);

            Console.Write(menuHead);
            Console.Write(">> Por favor escriba su contraseña: ");
            var Pass = Console.ReadLine();
            
            if (Pass == "123")

            {
                return true;
            }
            else{

                Console.WriteLine("Contraseña incorrecta.");
                Console.WriteLine("Intentelo de nuevo...");
                return false;       
            }

        }

        static string[] Registro(){
            //Registra la informacion del cliente y lo retorna en el arreglo Datos.
            string Header = string.Format("{0}{0}:::: Registro ::::{0}{0}>> Ingrese los datos del cliente:{0}{0}", Environment.NewLine);
            string InputNameOwner = string.Format("Nombre del propietario: ");
            string InputNamePet = string.Format("Nombre de la mascota: ");
            string InputEstrato= string.Format("Estrato socioeconómico: ");

            var NameOwner = "";
            var NamePet = "";
            var Estrato = "";

            Console.Write(Header);
            Console.Write(InputNameOwner);
            NameOwner = Console.ReadLine();
            Console.Write(InputNamePet);
            NamePet = Console.ReadLine();
            Console.Write(InputEstrato);
            Estrato = Console.ReadLine();
            string[] Datos = { NameOwner, NamePet, Estrato };
            return Datos;
        }

        static int Servicio(){
        //Define el precio por cada servicio.
        string ServiceHead = string.Format("{0}{0}:::: Servicio Por Adquirir ::::{0}{0}", Environment.NewLine);
        string ServiceOptions = string.Format("{0}{0}1. Baño y corte $45.000 – %Desc.{0}2. Baño, corte y vacuna antigarrapatas, $80.000 – %Desc.{0}3. Baño, corte, Vacunas antigarrapatas y Antiparásitos $100.000 – %Desc.", Environment.NewLine); 
        string SelectService = string.Format("{0}>>Seleccione el servicio: ", Environment.NewLine);
        Console.Write(ServiceHead + ServiceOptions + SelectService);
        int ServiceOption = Convert.ToInt16(Console.ReadLine());
        int Precio = 0;
        switch(ServiceOption){
            case 1: Precio = 45000;
                    break;
            case 2: Precio = 80000;
                    break;
            case 3: Precio = 100000;
                    break;
        }
        
        return Precio;

        }

        static double PrecioTotal(string Estrato, int Precio){
            //Define el Precio total del servicio con las variables Estrato de Registro() y Precio de Servicio().
            //Devuelve Total, que se refiere al precio total del Servicio.
            double Total = 0;
            int estrato = Convert.ToInt16(Estrato);

            switch (estrato)
            {
                case 1: 
                case 2:
                    Total = Precio - (Precio * 0.15);
                    break;
                case 3: 
                case 4:
                    Total = Precio - (Precio * 0.10); 
                    break;
                case >=5: 
                    Total = Precio - (Precio * 0.05);
                    break;
            }
            
            return Total;

        }

        static void ImprimirRecibo(string NameOwner, string NamePet, string Estrato, double Total){
            //Imprime el recibo de la compra en pantalla.
            string PrintHeader = string.Format("{0}{0}:::: Recibo del Servicio ::::{0}{0}", Environment.NewLine);
            string PrintNameOwner = string.Format("Nombre del propietario: {1}{0}", Environment.NewLine, NameOwner);
            string PrintNamePet = string.Format("Nombre de la mascota: {1}{0}", Environment.NewLine, NamePet);
            string PrintEstrato= string.Format("Estrato socioeconómico: {1}{0}", Environment.NewLine, Estrato);

            string PrintTotal= string.Format("Total a pagar: ${1}{0}", Environment.NewLine, Total);
            string PrintFooter= string.Format(">>Gracias por elegirnos<<{0}{0}",Environment.NewLine);
            
            Console.Write(PrintHeader + PrintNameOwner + PrintNamePet + PrintEstrato + PrintTotal + PrintFooter);
        }
        static void Main(string[] args)
        {
            //Inicia el menu de la Aplicacion.
            Menu();
            //Crea bucle mientras el metodo Credendiales sea falso.
            while(Credenciales() == false)
            {
                Credenciales();
            }
            // Arreglo que contiene los datos de registro:
            // [0]: Nombre del Propietario.
            // [1]: Nombre de la mascota.
            // [2]: Estrato Socio Economico. 
            string[] Registros = (Registro());
            //llama los metodos para determetrminar el precio del servicio.
            double TotalServicio = PrecioTotal(Registros[2], Servicio());
            ImprimirRecibo(Registros[0], Registros[1], Registros[2], TotalServicio);
            

        }
    }
}