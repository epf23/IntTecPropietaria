using FluentValidation;
using SistemadeCompras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemadeCompras.Validations
{
    public class ValidatorunidadMedida : AbstractValidator<UnidadMedida>
    {

        public ValidatorunidadMedida()
        {

            RuleFor(x => x.Descripcion).NotNull().WithMessage("campo Descripción no puede estar vacio");
            RuleFor(x => x.Estado).NotNull().WithMessage("campo Estado no puede estar vacio");

        }

    }
}