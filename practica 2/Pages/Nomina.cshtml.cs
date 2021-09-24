using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace practica_2.Pages
{
    public class NominaModel : PageModel
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string cargo { get; set; }
        public double sueldo { get; set; }


        public NominaModel nomina;

        public double SFS()
        {
            double auxSFS = this.sueldo * 0.0304;

            if (auxSFS >= 4098.53)
            {
                auxSFS = 4098.53;
                return auxSFS;
            }
            else
            {
             return auxSFS;   
            }


        }

        public double AFP()
        {
            double auxAFP = this.sueldo * 0.0287;

            if (auxAFP >= 7738.67)
            {
                auxAFP = 7738.67;
                return auxAFP;
            }
            else
            {

                return auxAFP;
            }


        }

        public double ISR()
        {
            double auxISR = this.sueldo - (AFP() + SFS());
            double excedente = 0;


            if (auxISR >= 34686.00 && auxISR < 52028.00)
            {
                excedente = (auxISR * 12 - 416220.01);
                auxISR = (excedente * 0.15 / 12);
                return auxISR;

            }
            else if (auxISR >= 52028.00 && auxISR <= 72261.00)
            {
                excedente = (auxISR * 12 - 624329.01);
                auxISR = (excedente * 0.2 / 12) + 31216.00;
                return auxISR;

            }
            else if (auxISR >= 72261.00)
            {
                excedente = (auxISR * 12 - 867123.00);
                auxISR = (excedente * 0.25 / 12) + 79776.00;
                return auxISR;

            }
            else
            {

                auxISR = 0;
                return auxISR;

            }


        }



        public void OnGet()
        {
        }
    }
}
