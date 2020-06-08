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

       private const int MAIN_MENU_EXIT_OPTION = 9;
        private const int GO_BACK_OPTION = 9;
        List<int> menuMicroOptions = new List<int>(new int[] {1, 2, 3, 4, 5, 9});
        
        //List<int> comida = new List<int>(new int[] {1, 2, 3, 4, 9});

       // private bool isDoorClosed = true;
        //private string idk;

        private void DisplayWelcomeMessage() {
            System.Console.WriteLine("\nHola, soy un Microondas :D \n ----------------M E N U -------------");
            System.Console.WriteLine();
        } 

        private void DisplayMenuMicro() {
            System.Console.WriteLine("1) Abrir la puerta");
            System.Console.WriteLine("2) Ingresar comida");
            System.Console.WriteLine("3) Cerrar puerta");
            System.Console.WriteLine("4) Boton START");
            System.Console.WriteLine("5) Comprobar comida calentada");
            System.Console.WriteLine();
            System.Console.WriteLine("9) Salir");
        } 

        //fuente: confia en TacoPlox 
        private int RequestOption(List<int> validOptions) {
            int userInputAsInt = 0;
            bool isUserInputValid = false;

            //Mientras no haya una respuesta válida...
            while(!isUserInputValid) {
                System.Console.WriteLine("Selecciona una opción:");
                string userInput = System.Console.ReadLine();


                try {
                    userInputAsInt = Convert.ToInt32(userInput);
                    isUserInputValid = validOptions.Contains(userInputAsInt);
                } catch (System.Exception) {
                    isUserInputValid = false;
                }


                if (!isUserInputValid)
                {
                    System.Console.WriteLine("La opción seleccionada no es válida.");
                }
            }

            return userInputAsInt;
        }

        
        
        private void DisplaySelectComidaMessage() {
            System.Console.WriteLine("Que deseas calentar?\n");
        }

        private void DisplayComidaOptions() {
            System.Console.WriteLine("1) Una rebanada de pizza de hace una semana");
            System.Console.WriteLine("2) Un atun");
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
