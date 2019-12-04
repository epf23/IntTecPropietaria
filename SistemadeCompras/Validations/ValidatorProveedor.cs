using FluentValidation;
using SistemadeCompras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemadeCompras.Validations
{
    public class ValidatorProveedor : AbstractValidator<Proveedor>
    {
        public ValidatorProveedor() {


            RuleFor(x => x.Nombre_Comercial)
               .NotEmpty()
               .WithMessage("Campo Nombre Comercial no puede estar vacio");

            RuleFor(x => x.Estado)
               .NotEmpty()
               .WithMessage("Campo Estado no puede estar vacio");

            RuleFor(x => x.Cedula_RNC)
               .NotEmpty()
               .WithMessage("Campo Cédula/RNC no puede estar vacio")
               .Matches("^[0-9]*$").WithMessage("Campo Cédula/RNC solo acepta números")
               .Must((x, list, context) =>
               {
                   if (null != x.Cedula_RNC)
                   {
                       context.MessageFormatter.AppendArgument("RNC_Cedula", x.Cedula_RNC);
                       return Utilities.CheckCedula(x.Cedula_RNC);

                   }
                   return true;

               }).WithMessage("Cédula/RNC no es valido");/*.When(x => x.Cedula_RNC.Length <= 9);*/

            //RuleFor(x => x.Cedula_RNC)
            //    .NotEmpty()
            //    .WithMessage("Campo Cédula/RNC no puede estar vacio")
            //    .Matches("^[0-9]*$").WithMessage("Campo Cédula/RNC solo acepta números")
            //    .Must((x, list, context) =>
            //    {
            //        if (null != x.Cedula_RNC)
            //        {
            //            context.MessageFormatter.AppendArgument("RNC_Cedula", x.Cedula_RNC);
            //            return Utilities.ValidateRNC(x.Cedula_RNC);

            //        }
            //        return true;

            //    }).WithMessage("RNC no es valido").When(x => x.Cedula_RNC.Length <= 9);



        }

       

    }
}