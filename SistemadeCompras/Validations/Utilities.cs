using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemadeCompras.Validations
{
    public class Utilities
    {

        public static bool CheckCedula(string Cedula)
        {
            int vnTotal = 0;
            string chkCedula = Cedula.Replace("-", "");
            int pLongCed = chkCedula.Trim().Length;
            int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

            if (Cedula == "00000000000") return false;

            if (pLongCed < 11 || pLongCed > 11)
                return false;

            for (int vDig = 1; vDig <= pLongCed; vDig++)
            {
                int vCalculo = int.Parse(chkCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                if (vCalculo < 10)
                    vnTotal += vCalculo;
                else
                    vnTotal += int.Parse(vCalculo.ToString().Substring(0, 1)) + int.Parse(vCalculo.ToString().Substring(1, 1));
            }

            return (vnTotal % 10) == 0;

            //if (vnTotal % 10 == 0)
            //    return true;
            //else
            //    return false;

        }

        public static bool ValidateRNC(string rnc)
        {
            int[] baseRnc = new int[8] { 7, 9, 8, 6, 5, 4, 3, 2 };
            int suma = 0;
            int resto, verificador;

            if (rnc.Trim().Length != 9)
                return false;

            var digitos = rnc.Trim().ToArray();
            var digitoVerificador = int.Parse(digitos.Last().ToString());

            for (var i = baseRnc.Length - 1; i >= 0; i -= 1)
            {
                suma += baseRnc[i] * int.Parse(digitos[i].ToString());
            }

            resto = suma % 11;

            switch (resto)
            {
                case 0:
                    verificador = 2;
                    break;
                case 1:
                    verificador = 1;
                    break;
                default:
                    verificador = 11 - resto;
                    break;
            }

            return verificador == digitoVerificador;
        }



    }
}