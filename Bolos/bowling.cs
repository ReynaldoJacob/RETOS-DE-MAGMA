using System;
using System.Collections.Generic;
using System.Text;

namespace Bolos
{
    class bowling
    {
        public int[] tiros = new int[21];
        public int[] cuadro = new int[10];
        public int contadorDeTiros = 0;
        public int marcador=0;
        public int IniciodelJuego=0;
        public int contadorDeCasillas = 0;


        //METODO PARA VERIFICAR QUE EL TIRO SEA SPARE;
        public bool spare(int cuadroindex, bool resultado)
        {

            if (tiros[cuadroindex] + tiros[cuadroindex + 1] == 10)
            {
                return true;
            }
            else
            {
                resultado = false;
            }

            return resultado;
        }
        //METODO PARA VERIFICIAR SI SE DERRIBARON LOS PINOS AL PRIMER TIRO
        public bool chuza(int cuadroindex)
        {
            return tiros[cuadroindex] == 10;
        }

        //METODO PARA CALCULAR EL PUNTAJE

        public void puntaje()
        {
            for (int cuadro2 = 0; cuadro2 < 10; cuadro2++)
            {
                //SE COMPRUEBA QU EL CICLO ESTE EN LA NOVENA REPTECIÓN, ESTO PARA VERIFICAR EL ULTIMO TIRO
                if (cuadro2 ==9)
                {   //SE CALCULA QUE EL PRIMER TIRO HAYA SIDO UNA CHUZA
                    if (tiros[IniciodelJuego] == 10)
                    {
                        marcador += 10 + tiros[IniciodelJuego+1]+ tiros[IniciodelJuego + 2];
                        IniciodelJuego += 2;
                        casillas(marcador);
                    }
                    //EN CASO DE QUE EN AMBAS CASILLAS SUME LA CANTIDAD DE 10 PROCEDE A SUMARSE EL TERCER TIRO BONUS
                    else if (tiros[IniciodelJuego] + tiros[IniciodelJuego + 1] == 10)
                    {
                        marcador += 10 + tiros[IniciodelJuego + 2];
                        IniciodelJuego += 2;
                        casillas(marcador);
                    }
                    //FINALMENTE SI LOS PRIMERO DOS TIROS DE LA DECIMA RONDA, SON 10, SE SUMAN LAS DOS CHUZAS MAS EL TERCER TIRO; 
                    else if (tiros[IniciodelJuego] == 10 && tiros[IniciodelJuego + 1] == 10)
                    {
                        marcador += 20 + tiros[IniciodelJuego + 2];
                        IniciodelJuego += 2;
                       
                        casillas(marcador);
                    }else if(tiros[IniciodelJuego]!=10 && tiros[IniciodelJuego+1]!=10)
                    {
                        marcador += tiros[IniciodelJuego] + tiros[IniciodelJuego + 1];
                        casillas(marcador);
                    }
                }

                else //SI LA POSICION ES MENOR A 9 ENTONCES COMENZARA EL PROCESO NORMAL DEL JUEGO
                {
                    if (chuza(IniciodelJuego))
                    {

                        //SE VERIFICA QUE SEAN TRES CHUZAS SEGUIDAS
                        if (tiros[IniciodelJuego + 2] == 10 && tiros[IniciodelJuego + 4] == 10)
                        {
                            marcador += 30;
                            IniciodelJuego += 2;
                            casillas(marcador);
                        }//SE VERIFICA QUE SEA DOBLE CHUZA 
                        else if (tiros[IniciodelJuego] == 10 && tiros[IniciodelJuego + 2] == 10 && tiros[IniciodelJuego + 3] == 10)
                        {
                            marcador += 30;
                            IniciodelJuego += 2;
                            casillas(marcador);
                        }//SE VERIFICA EL SPARE ENTRE LAS CHUZAS
                        else if (tiros[IniciodelJuego + 2] == 10 && tiros[IniciodelJuego + 4] != 10)
                        {
                            marcador += 20 + tiros[IniciodelJuego + 4];
                            IniciodelJuego += 2;

                            casillas(marcador);

                        } //DESPUES DE QUE NO SE CUMPLE TODAS LAS INSTRUCCIONES ANTERIORES PROCEDE A SUMAR UNA CHUZA NORMAL
                        else if (chuza(IniciodelJuego))
                        {
                            marcador += 10 + tiros[IniciodelJuego + 2] + tiros[IniciodelJuego + 3];
                            IniciodelJuego += 2;
                            casillas(marcador);
                        }
                      
                    }// SI NO CUMPLE CON LA PRIMERA CONDICION DEL PRIMER IF SE PASA A LA SIGUIENTE INSTRUCCION DONDE SER VERIFICA QUE SEA SPARE O TIROS NORMALES
                    else if (spare(IniciodelJuego, true))
                    {


                        marcador += 10 + tiros[IniciodelJuego + 2];
                        IniciodelJuego += 2;
                        casillas(marcador);
                    }
                    else
                    {

                             marcador += tiros[IniciodelJuego] + tiros[IniciodelJuego + 1];
                             IniciodelJuego += 2;
                             casillas(marcador);

                    }

                }
            }
         
        }

  
        public void mostrar()
        {
            Console.WriteLine("El marcador final es de:{0}", IniciodelJuego);
        }

    
       
        public void tiro(int[] pinos)
        {
            int j = 1;
            Console.WriteLine("TIROS");
            for (int i = 0; i < pinos.Length; i++)
            {
                tiros[contadorDeTiros++] = pinos[i];
                Console.WriteLine("tiro "+j+"={0}", tiros[i]);
                j++;
               
            }
          

        }
        // SE AUMENTAN  EL VECTOR DEL CUADRO
        public void casillas(int puntos)
        {


            cuadro[contadorDeCasillas] = puntos;
            contadorDeCasillas++;

         
        }
        //MUESTRA LAS CASILLAS
        public void mostrarcasillas()
        {
            int j = 1;
            Console.WriteLine("RONDAS");
            for(int i=0; i<10; i++)
            {
               
                Console.WriteLine("Marcador Ronda" + j+ "= {0}", cuadro[i]);
                j++;
            }
        }
        public void mostrarmarcador()
        {
                Console.WriteLine("");
                Console.WriteLine("Marcador Final= {0}",marcador );
            
        }

     


}

 }
            

            
        




               

            
    

    

