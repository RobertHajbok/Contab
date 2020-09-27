﻿using System.ComponentModel;
using System.Linq;

namespace Contab.Extensions
{
    public static class EnumExtensions
    {
        public static string GetEnumDescription<TEnum>(this TEnum item) => item.GetType()
            .GetField(item.ToString())
            .GetCustomAttributes(typeof(DescriptionAttribute), false)
            .Cast<DescriptionAttribute>()
            .FirstOrDefault()?.Description;
    }
}
