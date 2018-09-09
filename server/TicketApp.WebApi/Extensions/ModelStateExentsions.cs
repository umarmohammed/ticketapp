using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.Linq;
using TicketApp.Common.Extensions;
using TicketApp.WebApi.Models;

namespace TicketApp.WebApi.Extensions
{
    public static class ModelStateExentsions
    {
        public static CustomModelStateErrors ToCustomModelStateErrors(this ModelStateDictionary modelState)
        {
            var errors = new List<CustomModelStateError>();

            foreach (var key in modelState.Keys)
            {
                if (modelState.TryGetValue(key, out var value))
                {
                    errors.Add(new CustomModelStateError
                    {
                        FieldName = key.ToJsFriendlyProperty(),
                        FieldErrors = value.Errors.Select(v => v.ErrorMessage)
                    });
                }
            }

            return new CustomModelStateErrors
            {
                Errors = errors
            };
        }
    }
}
