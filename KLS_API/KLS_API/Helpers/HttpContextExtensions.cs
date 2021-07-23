using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLS_API.Helpers
{
    public static class HttpContextExtensions
    {
        public static void InsertarParametrosPaginacionEnRespuesta<T>(this HttpContext context,
           IQueryable<T> queryable, int cantidadRegistrosAMostrar)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            double conteo = queryable.Count();
            double totalPaginas = Math.Ceiling(conteo / cantidadRegistrosAMostrar);
            context.Response.Headers.Add("totalPaginas", totalPaginas.ToString());
        }
    }
}
