using System;
using System.Collections.Generic;


namespace Microondas
{
    class Microondas
    {
            /* 
            
            Simular un microondas utilizando principios de programación orientada a objetos.
Se deben utilizar las siguientes clases / objetos:
Microondas (Microwave)
Contenedor (Container)
Comida (Food)
El microondas deberá contar con métodos para representar las acciones que son posibles
 al interactuar con el; ej. AbrirPuerta().
Incluir un menú para realizar las acciones del microondas, y para seleccionar la comida a utilizar.
Las comidas pueden ser opciones fijas (ej. 3 opciones pre-configuradas), siempre y cuando permitan
 probar casos de error y casos de éxito.
Si se intenta realizar una acción incorrecta, como por ejemplo introducir comida sin abrir la puerta,
 debe arrojar excepciones apropiadas con un mensaje significativo.
El contenedor puede o no ser apto para microondas, y por tanto se debe arrojar una excepción según sea necesario.
Funcionalidad adicional (completamente opcional)
Que un contenedor pueda tener o no un cubierto

            */
        //List<int> comida = new List<int>(new int[] {1, 2, 3, 4, 9});

        Contenedor comida = null;
        private bool isDoorClosed = true;
       

        private void AbrirPuerta() {
            bool isDoorClosed = false;
        }
        
        private void DisplaySelectComidaMessage() {
            System.Console.WriteLine("Que deseas calentar?\n");
        }

        private void DisplayComidaOptions() {
            System.Console.WriteLine("1) Una rebanada de pizza de hace una semana");
            System.Console.WriteLine("2) Un atun");
        }
        private void IngresarComida(Contenedor contenedor) {
                System.Console.WriteLine("Comida ingresada");
                //Revisar si hay un contenedor (si no está vacío) ya dentro del microondas
            //null => no hay nada adentro

            if (this.comida != null)
            {
                //Estado actual incorrecto - InvalidOperationException
                //Argumento inválido - ArgumentException
                throw new InvalidOperationException("existe comida adentro");
            }

                //Microondas.Add(contenedor);
        }
        private void CerrarPuerta() {
            bool isDoorClosed = true;
        }
        private void Start() {

        }
        private void ComprobarComida() {

        }

        public void MicroDisplay() { 
            int selectedOption = 0;


            while (selectedOption != MAIN_MENU_EXIT_OPTION) {
                 DisplayWelcomeMessage();

                DisplayMenuMicro();

                selectedOption = RequestOption(menuMicroOptions);

                switch (selectedOption)
                {
                    case 1: //
                    AbrirPuerta();
                        break;
                    case 2: //  
                    IngresarComida();
                        break;
                    case 3: //  
                    CerrarPuerta();
                        break;
                    case 4: // 
                    Start();
                        break;
                    case 5: // 
                    ComprobarComida();
                        break;
                    case 9: // Salir
                    //Exit();
                    selectedOption = MAIN_MENU_EXIT_OPTION;
                        break;
                        
                    // default:
                }
            }
        }

        
     
    }
}
