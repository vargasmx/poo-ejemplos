using System;

namespace Persona
{
    class Program
    {
        public static void Main(string[] args)
        {
            Persona[] personas;
            personas = new Persona[8];
            string temp;
            
            for(int i = 0; i < 8; i++)
            {
                personas[i] = new Persona();
                Console.WriteLine("Escriba el nombre de la persona:");
                temp = Console.ReadLine();
                personas[i].setNombre(temp);
                Console.WriteLine("Escriba el primer apellido de la persona:");
                temp = Console.ReadLine();
                personas[i].setPrimerApellido(temp);
            }            
            
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("El nombre de la persona {1} es: {0}",
                        personas[i],
                        (i+1) //2
                    );
            }
            
        }            
    }
    
    class Persona
    {
        // Inicia sección Atributos
        private string _nombre;
        private string _primerApellido;
        // Termina seccción Atributos
        // Inicia sección Metodos
        
        // Inicia seccion Metodos de Encapsulamiento
        public void setNombre(string valor){
            _nombre = valor;
        }  
        public string getNombre()
        {
            return _nombre;
        } 
        
        public void setPrimerApellido(string valor){
            _primerApellido = valor;
        }     
        public string getPrimerApellido(){
            return _primerApellido;
        }           
        // Termina seccion Metodos de Encapsulamiento
        public override string ToString(){
            return _primerApellido + " " + _nombre;
        }
        // Termina seccion Metodos
    }    
}