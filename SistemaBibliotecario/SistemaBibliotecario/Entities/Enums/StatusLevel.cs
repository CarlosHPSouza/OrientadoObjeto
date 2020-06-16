using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBibliotecario.Entities.Enums
{
    enum StatusLevel : int
    {
        Disponivel = 0,
        Emprestado = 1,
        Expirado = 2,
        Esgotado = 3
    }
}
