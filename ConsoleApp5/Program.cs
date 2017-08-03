using System;

namespace ConsoleApp5
{
    class Configuration
    {
        private static Configuration _instance;
        //Constructor privado para evitar que alguien cree otra instancia de la clase
        private Configuration()
        {
            //Atributos
        }

        //El getter crea la insrtancia si no existe, finalmente se devuelve la instancia
        public static Configuration Instance
        {
            get
            {
                if(null == _instance)
                {
                    _instance = new Configuration();
                }
                return _instance;
            }
        }
    }
}