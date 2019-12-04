using FluentValidation;
using SistemadeCompras.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemadeCompras.Validations
{
    public class ValidatorOrdenCompra : AbstractValidator<OrdenCompra>
    {

        public ValidatorOrdenCompra()
        {
            RuleFor(x => x.Cantidad).NotNull().WithMessage("Campo Cantidad no puede estar vacio")
                .GreaterThan(0).WithMessage("Cantidad no debe ser menor que 0");
            RuleFor(x => x.CostoUnitario).NotNull().WithMessage("Campo Costo Unitario no debe de estar vacio")
                .GreaterThan(0).WithMessage("Costo unitario debe ser menor que 0");
            RuleFor(x => x.Estado).NotEmpty().WithMessage("Campo Estado no debe de estar vacio");



        }

    }
}