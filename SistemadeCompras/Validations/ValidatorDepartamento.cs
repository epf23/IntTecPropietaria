using FluentValidation;
using SistemadeCompras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemadeCompras.Validations
{
    public class ValidatorDepartamento : AbstractValidator<Departamento>
    {

        public ValidatorDepartamento() {

            RuleFor(x => x.Nombre).NotEmpty()
                .WithMessage("Campo Nombre no puede estar vacio")
                .Must(x => x.Length > 3 && x.Length < 30)
                .WithMessage("Campo Nombre debe de tener entre 3 a 30 letras");

            RuleFor(x => x.Estado).NotEmpty()
                .WithMessage("Campo Estado no puede estar vacio");


        }


    }
}