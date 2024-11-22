using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public class OrderStatusEnum
{
    public enum StatusEnum
    {
        Vyřízeno = 1,
        Zpracovává_se = 0
    }
    public static List<KeyValuePair<int, string>> GetStatusList()
    {
        return Enum.GetValues(typeof(StatusEnum))
                   .Cast<StatusEnum>()
                   .Select(e => new KeyValuePair<int, string>(
                       (int)e,
                       FormatEnumName(e.ToString())))
                   .ToList();
    }

    private static string FormatEnumName(string enumName)
    {
        return enumName.Replace("_", " ");
    }
}
