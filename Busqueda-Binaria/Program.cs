namespace Busqueda_Binaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Ingresa el numero a buscar");
            int numeroBuscar = int.Parse(Console.ReadLine());
            int[] listaNumeros = new int[7];
            for(int i = 0; i < 7; i++)
            {
                Console.WriteLine("Ingresa el valor el elemento" +(i+1));
                listaNumeros[i]= int.Parse(Console.ReadLine());
            }
            //Busqueda 
            int n=listaNumeros.Length;
            //Inferior
            int inf = 0;
            //Centro o Medio
            int centro = 0;
            //Superior
            int sup = n - 1;
            bool Bandera = false;
            while(inf <= sup)
            {
                centro = (sup + inf) / 2;
                if (listaNumeros[centro] == numeroBuscar)
                {
                    Bandera = true;
                    break;
                }
                else if(numeroBuscar < listaNumeros[centro])
                {
                    sup = centro - 1;

                }
                else
                {
                    inf = centro + 1;
                }
            }
            if (Bandera == true)
            {
                Console.WriteLine("Felicidades el numero "+numeroBuscar+"Estaba en la posicion"+(centro+1));
            }
            else
            {
                Console.WriteLine("El numero"+numeroBuscar+ "no se encuentra en el arreglo ");
            }
            Console.Read();
        }
    }
}