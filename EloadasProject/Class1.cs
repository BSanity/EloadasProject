﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EloadasProject
{



    public class Eloadas
    {
        
         bool[,] foglalasok;
        public Eloadas(int sorokSzama, int helyekSzama)
        {

            if (!(sorokSzama > 0) || !(helyekSzama > 0))
            {
                throw new ArgumentException(String.Format("A paraméterek nem nagyobbak 0-nál {0}:"));

            }

            this.foglalasok = new bool[sorokSzama, helyekSzama];
        }

        public bool Lefoglal()
        {

            bool vege = false;
            
            for (int i = 0; i < foglalasok.GetLength(0); i++)
                {
                for (int j = 0; j < foglalasok.GetLength(1); j++)
                {
                  if (foglalasok [0,0]!=true && vege==false)
                    {
                        foglalasok[0, 0] = true;
                            vege = true;

                    }
         
                }

            }



            

        

          
            
        }
           
     

    }
    
}
