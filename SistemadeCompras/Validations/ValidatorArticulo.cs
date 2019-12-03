using FluentValidation;
using SistemadeCompras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemadeCompras.Validations
{
    public class ValidatorArticulo : AbstractValidator<Articulo>
    {

        public ValidatorArticulo()
        {
            RuleFor(x => x.Descripcion).NotEmpty()
                .WithMessage("Campo Descripción no puede estar vacio")
                .Must(x => x.Length > 3 && x.Length < 40)
                .WithMessage("Campo Descripción debe de tener entre 3 a 40 letras");

            RuleFor(x => x.Marca).NotEmpty()
                .WithMessage("Campo Narca no puede estar vacio");

            RuleFor(x => x.Existencia).NotNull()
                .WithMessage("Campo Existencia no puede estar vacio")
                .GreaterThan(0)
                .WithMessage("Campo Existencia debe de ser mayor que 0");


        }



    }
}