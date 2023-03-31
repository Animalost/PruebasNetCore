using System;
using System.Collections.Generic;

namespace PreubasNetCore.Pages.ControlCalendar
{
    public static class Mayus
    {
        public static string Capitalize(this string s)
        {
            if (String.IsNullOrEmpty(s))
            {

            }

            return s[0].ToString().ToUpper() + s.Substring(1);
        }
    }
    class DaysControl
    {
        private List<DateTime> Holidays = new List<DateTime>();

        public void setHoliday(DateTime fecha)
        {
            Holidays.Add(fecha);
        }

        public List<DateTime> getHolidaysAll()
        {
            return Holidays;
        }

        public string getPrimerdia(DateTime fechaactual)
        {
            DateTime oPrimerDiaDelMes = new DateTime(fechaactual.Year, fechaactual.Month, 1);
            return Convert.ToDateTime(oPrimerDiaDelMes).ToString("ddd").ToUpper();
        }

        public Dictionary<string, string> getUltimoDia(DateTime fechaactual)
        {
            DateTime oPrimerDiaDelMes = new DateTime(fechaactual.Year, fechaactual.Month, 1);
            DateTime oUltimoDiaDelMes = oPrimerDiaDelMes.AddMonths(1).AddDays(-1);

            Dictionary<string, string> DIc = new Dictionary<string, string>();
            DIc.Add("Dia", Convert.ToDateTime(oUltimoDiaDelMes).ToString("ddd").ToUpper());
            DIc.Add("nDia", Convert.ToDateTime(oUltimoDiaDelMes).ToString("dd"));
            return DIc;
        }

        public Dictionary<int, int> Ciclo(int Inicio, int Final)
        {
            Dictionary<int, int> DIC = new Dictionary<int, int>();
            int comienzodic = 0;
            Final = 50;

            while (Inicio != Final)
            {
                DIC.Add(comienzodic, Inicio);
                Inicio = Inicio + 1;
                comienzodic = comienzodic + 1;
            }
            return DIC;
        }
    }
}
