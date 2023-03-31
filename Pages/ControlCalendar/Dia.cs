using System;

namespace PreubasNetCore.Pages.ControlCalendar
{
    class Dia
    {
        private DateTime Hoy;
        private string MesSeleccionado;
        private string CambioMes;
        private bool CambioAño;
        private string MesNumero;

        public class Holyday
        {
            public DateTime holiday { get; set; }
        }

        public void setDay(DateTime Dia)
        {
            this.Hoy = Dia;
        }

        public void setCambioMeso(string Mes, string Verificador)
        {
            this.MesSeleccionado = Mes;
            this.CambioMes = Verificador;
        }
        public string getYear()
        {
            return Convert.ToDateTime(this.Hoy).ToString("yyyy");
        }
        public bool getCambioAño()
        {
            return this.CambioAño;
        }

        public void setMesNumero(string mesNumero)
        {
            this.MesNumero = mesNumero;
        }

        public string getMonth()
        {
            switch (Convert.ToDateTime(this.Hoy).ToString("MM"))
            {
                case "01":
                    return "Enero";

                case "02":
                    return "Febrero";

                case "03":
                    return "Marzo";

                case "04":
                    return "Abril";

                case "05":
                    return "Mayo";

                case "06":
                    return "Junio";

                case "07":
                    return "Julio";

                case "08":
                    return "Agosto";

                case "09":
                    return "Septiembre";

                case "10":
                    return "Octubre";

                case "11":
                    return "Noviembre";

                case "12":
                    return "Diciembre";

                default:
                    return "Error";
            }
        }

        public int getMonthDayNumber()
        {
            switch (this.MesNumero)
            {
                case "Enero":
                    return 1;

                case "Febrero":
                    return 2;

                case "Marzo":
                    return 3;

                case "Abril":
                    return 4;

                case "Mayo":
                    return 5;

                case "Junio":
                    return 6;

                case "Julio":
                    return 7;

                case "Agosto":
                    return 8;

                case "Septiembre":
                    return 9;

                case "Octubre":
                    return 10;

                case "Noviembre":
                    return 11;

                case "Diciembre":
                    return 12;

                default:
                    return 0;
            }
        }

        public string getMonthName()
        {

            if (this.CambioMes == "Aumenta")
            {
                switch (this.MesSeleccionado)
                {
                    case "Enero":
                        this.CambioAño = false;
                        return "Febrero";

                    case "Febrero":
                        this.CambioAño = false;
                        return "Marzo";

                    case "Marzo":
                        this.CambioAño = false;
                        return "Abril";

                    case "Abril":
                        this.CambioAño = false;
                        return "Mayo";

                    case "Mayo":
                        this.CambioAño = false;
                        return "Junio";

                    case "Junio":
                        this.CambioAño = false;
                        return "Julio";

                    case "Julio":
                        this.CambioAño = false;
                        return "Agosto";

                    case "Agosto":
                        this.CambioAño = false;
                        return "Septiembre";

                    case "Septiembre":
                        this.CambioAño = false;
                        return "Octubre";

                    case "Octubre":
                        this.CambioAño = false;
                        return "Noviembre";

                    case "Noviembre":
                        this.CambioAño = false;
                        return "Diciembre";

                    case "Diciembre":
                        this.CambioAño = true;
                        return "Enero";

                    default:
                        this.CambioAño = false;
                        return "Error";
                }
            }
            else
            {
                switch (this.MesSeleccionado)
                {
                    case "Enero":
                        this.CambioAño = true;
                        return "Diciembre";

                    case "Febrero":
                        this.CambioAño = false;
                        return "Enero";

                    case "Marzo":
                        this.CambioAño = false;
                        return "Febrero";

                    case "Abril":
                        this.CambioAño = false;
                        return "Marzo";

                    case "Mayo":
                        this.CambioAño = false;
                        return "Abril";

                    case "Junio":
                        this.CambioAño = false;
                        return "Mayo";

                    case "Julio":
                        this.CambioAño = false;
                        return "Junio";

                    case "Agosto":
                        this.CambioAño = false;
                        return "Julio";

                    case "Septiembre":
                        this.CambioAño = false;
                        return "Agosto";

                    case "Octubre":
                        this.CambioAño = false;
                        return "Septiembre";

                    case "Noviembre":
                        this.CambioAño = false;
                        return "Octubre";

                    case "Diciembre":
                        this.CambioAño = false;
                        return "Noviembre";

                    default:
                        this.CambioAño = false;
                        return "Error";
                }
            }
        }

        public int getMonthbyMonthName(string monthName)
        {
            switch (monthName)
            {
                case "Enero":
                    return 1;

                case "Febrero":
                    return 2;

                case "Marzo":
                    return 3;

                case "Abril":
                    return 4;

                case "Mayo":
                    return 5;

                case "Junio":
                    return 6;

                case "Julio":
                    return 7;

                case "Agosto":
                    return 8;

                case "Septiembre":
                    return 9;

                case "Octubre":
                    return 10;

                case "Noviembre":
                    return 11;

                case "Diciembre":
                    return 12;

                default:
                    return 0;
            }
        }
    }
}
