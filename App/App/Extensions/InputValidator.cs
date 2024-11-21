using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

public static class InputValidator
{
    /// <summary>
    /// Zkontroluje, zda je hodnota TextBoxu neprázdná.
    /// </summary>
    public static bool IsNotEmpty(TextBox textBox, string errorMessage = "Pole nesmí být prázdné.")
    {
        if (string.IsNullOrWhiteSpace(textBox.Text))
        {
            ShowErrorMessage(textBox, errorMessage);
            return false;
        }
        return true;
    }

    /// <summary>
    /// Zkontroluje, zda je hodnota TextBoxu číslo.
    /// </summary>
    public static bool IsNumber(TextBox textBox, string errorMessage = "Hodnota musí být číslo.")
    {
        if (!double.TryParse(textBox.Text, out _))
        {
            ShowErrorMessage(textBox, errorMessage);
            return false;
        }
        return true;
    }

    /// <summary>
    /// Zkontroluje, zda je hodnota TextBoxu číslo v rámci specifikovaného rozsahu.
    /// </summary>
    public static bool IsNumberInRange(TextBox textBox, double min, double max, string errorMessage = null)
    {
        if (double.TryParse(textBox.Text, out double value))
        {
            if (value < min || value > max)
            {
                ShowErrorMessage(textBox, errorMessage ?? $"Hodnota musí být mezi {min} a {max}.");
                return false;
            }
        }
        else
        {
            ShowErrorMessage(textBox, errorMessage ?? "Hodnota musí být číslo.");
            return false;
        }
        return true;
    }

    /// <summary>
    /// Zkontroluje, zda je hodnota TextBoxu validní e-mail.
    /// </summary>
    public static bool IsEmail(TextBox textBox, string errorMessage = "Neplatný formát e-mailové adresy.")
    {
        var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        if (!emailRegex.IsMatch(textBox.Text))
        {
            ShowErrorMessage(textBox, errorMessage);
            return false;
        }
        return true;
    }

    /// <summary>
    /// Zkontroluje, zda je hodnota TextBoxu validní telefonní číslo.
    /// </summary>
    public static bool IsPhoneNumber(TextBox textBox, string errorMessage = "Neplatné telefonní číslo.")
    {
        var phoneRegex = new Regex(@"^\+?\d{9,15}$");
        if (!phoneRegex.IsMatch(textBox.Text))
        {
            ShowErrorMessage(textBox, errorMessage);
            return false;
        }
        return true;
    }

    /// <summary>
    /// Zkontroluje, zda je vybraná položku v comboboxu.
    /// </summary>
    public static bool IsSelected(ComboBox comboBox, string errorMessage = "Vyberte prosím hodnotu.")
    {
        if (comboBox.SelectedIndex == -1 || comboBox.SelectedItem == null)
        {
            ShowErrorMessage(comboBox, errorMessage);
            return false;
        }
        return true;
    }
    /// <summary>
    /// Zkontroluje, zda je vybraný validní datum.
    /// </summary>
    public static bool IsDateValid(DateTimePicker dateTimePicker, DateTime? minDate = null, DateTime? maxDate = null, string errorMessage = "Zadejte platné datum.")
    {
        DateTime selectedDate = dateTimePicker.Value;

        if ((minDate.HasValue && selectedDate < minDate.Value) || (maxDate.HasValue && selectedDate > maxDate.Value))
        {
            ShowErrorMessage(dateTimePicker, errorMessage ?? $"Datum musí být mezi {minDate?.ToShortDateString()} a {maxDate?.ToShortDateString()}.");
            return false;
        }
        return true;
    }

    /// <summary>
    /// Zobrazí chybovou zprávu a nastaví fokus na nevalidní TextBox.
    /// </summary>
    private static void ShowErrorMessage(Control control, string errorMessage)
    {
        MessageBox.Show(errorMessage, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        control.Focus();
    }
}
