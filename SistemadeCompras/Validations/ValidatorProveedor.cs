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
               .WithMessage("Campo Nombre Comercial no puede estar vacio")
               .Must(x => x.Length > 2 && x.Length < 25).WithMessage("Campo nombre debe de tener entre 3 a 25 letras");

            RuleFor(x => x.Cedula_RNC)
               .NotEmpty()
               .WithMessage("Campo Cédula/RNC no puede estar vacio")
               .Matches("^[0-9]*$").WithMessage("Campo Cédula/RNC solo acepta números")
               .Must((x, list, context) =>
               {
                   if (null != x.Cedula_RNC)
                   {
                       context.MessageFormatter.AppendArgument("RNC_Cedula", x.Cedula_RNC);
                       return Utilities.ValidateRNC(x.Cedula_RNC);

                   }
                   return true;

               }).WithMessage("RNC no es valido").When(x => x.Cedula_RNC.Length <= 9);

            RuleFor(x => x.Estado)
               .NotEmpty()
               .WithMessage("Campo Estado no puede estar vacio");

        }

       

    }
}