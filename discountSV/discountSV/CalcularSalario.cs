using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discountSV
{
    class CalcularSalario
    {
        function calcularSalario()
        {
            var sueldo = document.calculo.ingreso.value;
            var sbruto = sueldo - (Math.round(sueldo * 0.725 * 10) / 100) - (Math.round(sueldo * 0.03 * 100) / 100);
            var afp = Math.round(sueldo * 0.725 * 10) / 100;
            var iss = Math.round(sueldo * 0.03 * 100) / 100;
            var cf1 = 17.67;
            var cf2 = 60.00;
            var cf3 = 288.57;
            var exc1 = 472.01;
            var exc2 = 895.25;
            var exc3 = 2038.11;

            if (sueldo < 0)
            {
                document.calculo.sneto.value = "Datos incorrectos";
            }
            else if (sbruto < exc1)
            {
                var sneto = sbruto;
                document.calculo.salario.value = "$" + Math.round(sbruto * 100) / 100;
                document.calculo.descafp.value = "$" + afp;
                document.calculo.desciss.value = "$" + iss;
                document.calculo.descrenta.value = "No pagas renta";
                document.calculo.sneto.value = "$ " + Math.round(sneto * 100) / 100;
                document.calculo.quincenal.value = "$ " + Math.round(sneto / 2 * 100) / 100;
            }
            else if (sbruto >= exc1 && sbruto < exc2)
            {
                sbruto = sbruto;
                var renta = Math.round((sbruto - exc1) * 0.1 * 100) / 100;
                var sneto = sbruto - renta - cf1;
                document.calculo.salario.value = "$ " + Math.round(sbruto * 100) / 100;
                document.calculo.descafp.value = "$ " + afp;
                document.calculo.desciss.value = "$ " + iss;
                document.calculo.descrenta.value = "$ " + Math.round((renta + cf1) * 100) / 100;
                document.calculo.sneto.value = "$ " + Math.round(sneto * 100) / 100;
                document.calculo.quincenal.value = "$ " + Math.round(sneto / 2 * 100) / 100;
            }
            else if (sbruto >= exc2 && sbruto < exc3)
            {
                if ((sbruto + afp) >= 1000)
                {
                    iss = 30.00;
                }
                sbruto = sbruto;
                var renta = Math.round((sbruto - exc2) * 0.2 * 100) / 100;
                var sneto = sbruto - renta - cf2;
                document.calculo.salario.value = "$ " + Math.round(sbruto * 100) / 100;
                document.calculo.descafp.value = "$ " + afp;
                document.calculo.desciss.value = "$ " + iss;
                document.calculo.descrenta.value = "$ " + Math.round((renta + cf2) * 100) / 100;
                document.calculo.sneto.value = "$ " + Math.round(sneto * 100) / 100;
                document.calculo.quincenal.value = "$ " + Math.round(sneto / 2 * 100) / 100;
            }
            else if (sbruto >= exc3)
            {
                if ((sbruto + afp) >= 1000)
                {
                    iss = 30.00;
                }
                if ((sbruto + afp) >= 6377.15)
                {
                    afp = 398.57;
                }
                sbruto = sbruto;
                var renta = Math.round((sbruto - exc3) * 0.3 * 100) / 100;
                var sneto = sbruto - renta - cf3;
                document.calculo.salario.value = "$ " + Math.round(sbruto * 100) / 100;
                document.calculo.descafp.value = "$ " + afp;
                document.calculo.desciss.value = "$ " + iss;
                document.calculo.descrenta.value = "$ " + Math.round((renta + cf3) * 100) / 100;
                document.calculo.sneto.value = "$ " + Math.round(sneto * 100) / 100;
                document.calculo.quincenal.value = "$ " + Math.round(sneto / 2 * 100) / 100;
            }
            else
            {
                document.calculo.ingreso.value = "Ingresa solamente numeros";
            }
        }; function validateEnter(e)
        {
            var key = e.keyCode || e.which;
            if (key == 13)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
