using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using static PreubasNetCore.Pages.ControlCalendar.Dia;

namespace PreubasNetCore.Pages
{
    public class IndexModel : PageModel
    {
        //Clases Calendario
        private ControlCalendar.Dia control;
        private ControlCalendar.DaysControl controldays;

        private readonly ILogger<IndexModel> _logger;

        //Meses Años
        public string MesText, AñoText;
        //Dias
        public string D1, D2, D3, D4, D5, D6, D7, D8, D9, D10;
        public string D11, D12, D13, D14, D15, D16, D17, D18, D19, D20;
        public string D21, D22, D23, D24, D25, D26, D27, D28, D29, D30;
        public string D31, D32, D33, D34, D35, D36, D37, D38, D39, D40, D41, D42;
        //Festivos
        List<Holyday> Festivos = new List<Holyday>();
        public string F1, F2, F3, F4, F5, F6, F7, F8, F9, F10;
        public string F11, F12, F13, F14, F15, F16, F17, F18, F19, F20;
        public string F21, F22, F23, F24, F25, F26, F27, F28, F29, F30;
        public string F31, F32, F33, F34, F35, F36, F37, F38, F39, F40, F41, F42;
        //Dia seleccionado
        public string FSelected2;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            try
            {
                DateTime FSelected = DateTime.Now.Date;

                if (Request.Query["F"] != "")
                {
                    FSelected = Convert.ToDateTime(Request.Query["F"]);
                }

                control = new ControlCalendar.Dia();
                control.setDay(Convert.ToDateTime(FSelected));
                MesText = control.getMonth();
                AñoText = control.getYear();

                LlenadoCalendario();                

                FSelected2 = Convert.ToDateTime(FSelected).ToString("yyyy-MM-dd");
                
                CargarFestivos();
                VerificarFestivos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void LlenadoCalendario()
        {
            controldays = new ControlCalendar.DaysControl();
            control = new ControlCalendar.Dia();

            control.setMesNumero(MesText);
            var Month = control.getMonthDayNumber();

            DateTime DiaSeleccionado = new DateTime(Convert.ToInt32(AñoText), Convert.ToInt32(Month), 1, 00, 00, 00);

            var pd = controldays.getPrimerdia(DiaSeleccionado);
            var ud = controldays.getUltimoDia(DiaSeleccionado);

            if (pd == "LUN.")
            {
                D1 = "1";
                D2 = "2";
                D3 = "3";
                D4 = "4";
                D5 = "5";
                D6 = "6";
                D7 = "7";
                Asignacion(8, Convert.ToInt32(ud["nDia"]));
                return;
            }

            if (pd == "MAR.")
            {
                D1 = "";
                D2 = "1";
                D3 = "2";
                D4 = "3";
                D5 = "4";
                D6 = "5";
                D7 = "6";
                Asignacion(7, Convert.ToInt32(ud["nDia"]));
                return;
            }

            if (pd == "MIÉ.")
            {
                D1 = "";
                D2 = "";
                D3 = "1";
                D4 = "2";
                D5 = "3";
                D6 = "4";
                D7 = "5";
                Asignacion(6, Convert.ToInt32(ud["nDia"]));
                return;
            }

            if (pd == "JUE.")
            {
                D1 = "";
                D2 = "";
                D3 = "";
                D4 = "1";
                D5 = "2";
                D6 = "3";
                D7 = "4";
                Asignacion(5, Convert.ToInt32(ud["nDia"]));
                return;
            }

            if (pd == "VIE.")
            {
                D1 = "";
                D2 = "";
                D3 = "";
                D4 = "";
                D5 = "1";
                D6 = "2";
                D7 = "3";
                Asignacion(4, Convert.ToInt32(ud["nDia"]));
                return;
            }

            if (pd == "SÁB.")
            {
                D1 = "";
                D2 = "";
                D3 = "";
                D4 = "";
                D5 = "";
                D6 = "1";
                D7 = "2";
                Asignacion(3, Convert.ToInt32(ud["nDia"]));
                return;
            }

            if (pd == "DOM.")
            {
                D1 = "";
                D2 = "";
                D3 = "";
                D4 = "";
                D5 = "";
                D6 = "";
                D7 = "1";
                Asignacion(2, Convert.ToInt32(ud["nDia"]));
                return;
            }
        }

        private void Asignacion(int Inicios, int Finales)
        {
            //SEMANA 2
            D8 = "";
            D9 = "";
            D10 = "";
            D11 = "";
            D12 = "";
            D13 = "";
            D14 = "";

            //SEMANA 3
            D15 = "";
            D16 = "";
            D17 = "";
            D18 = "";
            D19 = "";
            D20 = "";
            D21 = "";

            //SEMANA 4
            D22 = "";
            D23 = "";
            D24 = "";
            D25 = "";
            D26 = "";
            D27 = "";
            D28 = "";

            //SEMANA 5
            D29 = "";
            D30 = "";
            D31 = "";
            D32 = "";
            D33 = "";
            D34 = "";
            D35 = "";

            //Lunes de la semana 2
            D8 = Inicios.ToString();
            var dia = controldays.Ciclo(Inicios, Finales);

            //martes de la semana 2
            D9 = dia[1].ToString();
            D10 = dia[2].ToString();
            D11 = dia[3].ToString();
            D12 = dia[4].ToString();
            D13 = dia[5].ToString();
            D14 = dia[6].ToString();

            // semana3
            D15 = dia[7].ToString();
            D16 = dia[8].ToString();
            D17 = dia[9].ToString();
            D18 = dia[10].ToString();
            D19 = dia[11].ToString();
            D20 = dia[12].ToString();
            D21 = dia[13].ToString();

            //semana 4
            D22 = dia[14].ToString();
            D23 = dia[15].ToString();
            D24 = dia[16].ToString();
            D25 = dia[17].ToString();
            D26 = dia[18].ToString();
            D27 = dia[19].ToString();
            D28 = dia[20].ToString();

            //lunes semana 5
            if (dia[21] > Finales)
            {
                D29 = "";
            }
            else
            {
                D29 = dia[21].ToString();
            }

            if (dia[22] > Finales)
            {
                D30 = "";
            }
            else
            {
                D30 = dia[22].ToString();
            }

            if (dia[23] > Finales)
            {
                D31 = "";
            }
            else
            {
                D31 = dia[23].ToString();
            }

            if (dia[24] > Finales)
            {
                D32 = "";
            }
            else
            {
                D32 = dia[24].ToString();
            }

            if (dia[25] > Finales)
            {
                D33 = "";
            }
            else
            {
                D33 = dia[25].ToString();
            }

            if (dia[26] > Finales)
            {
                D34 = "";
            }
            else
            {
                D34 = dia[26].ToString();
            }

            if (dia[27] > Finales)
            {
                D35 = "";
            }
            else
            {
                D35 = dia[27].ToString();
            }

            // semana 6
            if (dia[28] > Finales)
            {
                D36 = "";
            }
            else
            {
                D36 = dia[28].ToString();
            }

            if (dia[29] > Finales)
            {
                D37 = "";
            }
            else
            {
                D37 = dia[29].ToString();
            }

            if (dia[30] > Finales)
            {
                D38 = "";
            }
            else
            {
                D38 = dia[30].ToString();
            }

            if (dia[31] > Finales)
            {
                D39 = "";
            }
            else
            {
                D39 = dia[31].ToString();
            }

            if (dia[32] > Finales)
            {
                D40 = "";
            }
            else
            {
                D40 = dia[32].ToString();
            }

            if (dia[33] > Finales)
            {
                D41 = "";
            }
            else
            {
                D41 = dia[33].ToString();
            }

            if (dia[34] > Finales)
            {
                D42 = "";
            }
            else
            {
                D42 = dia[34].ToString();
            }
        }

        private void CargarFestivos()
        {
            /* Fechas de pruebas para festivos, esta lista se llena de acuerdo a su requerimiento */
            Festivos.Clear();
            
            DateTime Fecha1 = new DateTime(2023, 02, 01, 00, 00, 00);
            DateTime Fecha2 = new DateTime(2023, 02, 04, 00, 00, 00);
            DateTime Fecha3 = new DateTime(2023, 02, 10, 00, 00, 00);
            DateTime Fecha4 = new DateTime(2023, 03, 15, 00, 00, 00);
            DateTime Fecha5 = new DateTime(2023, 02, 28, 00, 00, 00);
            
            Festivos.Add(new Holyday { holiday = Fecha1 });
            Festivos.Add(new Holyday { holiday = Fecha2 });
            Festivos.Add(new Holyday { holiday = Fecha3 });
            Festivos.Add(new Holyday { holiday = Fecha4 });
            Festivos.Add(new Holyday { holiday = Fecha5 });
        }

        private void VerificarFestivos()
        {
            //traer lista completa
            var monthNumber = control.getMonthbyMonthName(MesText);

            DateTime getDays = new DateTime(Convert.ToInt32(AñoText), monthNumber, 1, 00, 00, 00);
            DateTime TotalDaysMonth = getDays.AddMonths(1).AddDays(-1);
            int TotalDays = TotalDaysMonth.Day;

            int Contador = 1;

            F1 = "";
            F2 = "";
            F3 = "";
            F4 = "";
            F5 = "";
            F6 = "";
            F7 = "";

            F8 = "";
            F9 = "";
            F10 = "";
            F11 = "";
            F12 = "";
            F13 = "";
            F14 = "";

            F15 = "";
            F16 = "";
            F17 = "";
            F18 = "";
            F19 = "";
            F20 = "";
            F21 = "";

            F22 = "";
            F23 = "";
            F24 = "";
            F25 = "";
            F26 = "";
            F27 = "";
            F28 = "";

            F29 = "";
            F30 = "";
            F31 = "";
            F32 = "";
            F33 = "";
            F34 = "";
            F35 = "";

            while (Contador <= TotalDays)
            {
                //buscar en la lista festivos
                DateTime FTemp = new DateTime(Convert.ToInt32(AñoText), monthNumber, Contador, 00, 00, 00);
                string Fest = "";

                foreach (var i in Festivos)
                {
                    if (i.holiday == FTemp)
                    {
                        switch (Contador)
                        {
                            case 1:
                                //SEMANA 1
                                Fest = (D1 == "1") ? F1 = "F" : "";
                                Fest = (D2 == "1") ? F2 = "F" : "";
                                Fest = (D3 == "1") ? F3 = "F" : "";
                                Fest = (D4 == "1") ? F4 = "F" : "";
                                Fest = (D5 == "1") ? F5 = "F" : "";
                                Fest = (D6 == "1") ? F6 = "F" : "";
                                Fest = (D7 == "1") ? F7 = "F" : "";
                                break;
                            case 2:
                                //SEMANA 1
                                Fest = (D1 == "2") ? F1 = "F" : "";
                                Fest = (D2 == "2") ? F2 = "F" : "";
                                Fest = (D3 == "2") ? F3 = "F" : "";
                                Fest = (D4 == "2") ? F4 = "F" : "";
                                Fest = (D5 == "2") ? F5 = "F" : "";
                                Fest = (D6 == "2") ? F6 = "F" : "";
                                Fest = (D7 == "2") ? F7 = "F" : "";
                                //SEMANA 2
                                Fest = (D8 == "2") ? F8 = "F" : "";
                                break;
                            case 3:
                                //SEMANA 1
                                Fest = (D1 == "3") ? F1 = "F" : "";
                                Fest = (D2 == "3") ? F2 = "F" : "";
                                Fest = (D3 == "3") ? F3 = "F" : "";
                                Fest = (D4 == "3") ? F4 = "F" : "";
                                Fest = (D5 == "3") ? F5 = "F" : "";
                                Fest = (D6 == "3") ? F6 = "F" : "";
                                Fest = (D7 == "3") ? F7 = "F" : "";
                                //SEMANA 2
                                Fest = (D8 == "3") ? F8 = "F" : "";
                                Fest = (D9 == "3") ? F9 = "F" : "";
                                break;
                            case 4:
                                //SEMANA 1
                                Fest = (D1 == "4") ? F1 = "F" : "";
                                Fest = (D2 == "4") ? F2 = "F" : "";
                                Fest = (D3 == "4") ? F3 = "F" : "";
                                Fest = (D4 == "4") ? F4 = "F" : "";
                                Fest = (D5 == "4") ? F5 = "F" : "";
                                Fest = (D6 == "4") ? F6 = "F" : "";
                                Fest = (D7 == "4") ? F7 = "F" : "";
                                //SEMANA 2
                                Fest = (D8 == "4") ? F8 = "F" : "";
                                Fest = (D9 == "4") ? F9 = "F" : "";
                                Fest = (D10 == "4") ? F10 = "F" : "";
                                break;
                            case 5:
                                //SEMANA 1
                                Fest = (D1 == "5") ? F1 = "F" : "";
                                Fest = (D2 == "5") ? F2 = "F" : "";
                                Fest = (D3 == "5") ? F3 = "F" : "";
                                Fest = (D4 == "5") ? F4 = "F" : "";
                                Fest = (D5 == "5") ? F5 = "F" : "";
                                Fest = (D6 == "5") ? F6 = "F" : "";
                                Fest = (D7 == "5") ? F7 = "F" : "";
                                //SEMANA 2
                                Fest = (D8 == "5") ? F8 = "F" : "";
                                Fest = (D9 == "5") ? F9 = "F" : "";
                                Fest = (D10 == "5") ? F10 = "F" : "";
                                Fest = (D11 == "5") ? F11 = "F" : "";
                                break;
                            case 6:
                                //SEMANA 1
                                Fest = (D1 == "6") ? F1 = "F" : "";
                                Fest = (D2 == "6") ? F2 = "F" : "";
                                Fest = (D3 == "6") ? F3 = "F" : "";
                                Fest = (D4 == "6") ? F4 = "F" : "";
                                Fest = (D5 == "6") ? F5 = "F" : "";
                                Fest = (D6 == "6") ? F6 = "F" : "";
                                Fest = (D7 == "6") ? F7 = "F" : "";
                                //SEMANA 2
                                Fest = (D8 == "6") ? F8 = "F" : "";
                                Fest = (D9 == "6") ? F9 = "F" : "";
                                Fest = (D10 == "6") ? F10 = "F" : "";
                                Fest = (D11 == "6") ? F11 = "F" : "";
                                Fest = (D12 == "6") ? F12 = "F" : "";
                                break;
                            case 7:
                                //SEMANA 1
                                Fest = (D1 == "7") ? F1 = "F" : "";
                                Fest = (D2 == "7") ? F2 = "F" : "";
                                Fest = (D3 == "7") ? F3 = "F" : "";
                                Fest = (D4 == "7") ? F4 = "F" : "";
                                Fest = (D5 == "7") ? F5 = "F" : "";
                                Fest = (D6 == "7") ? F6 = "F" : "";
                                Fest = (D7 == "7") ? F7 = "F" : "";
                                //SEMANA 2
                                Fest = (D8 == "7") ? F8 = "F" : "";
                                Fest = (D9 == "7") ? F9 = "F" : "";
                                Fest = (D10 == "7") ? F10 = "F" : "";
                                Fest = (D11 == "7") ? F11 = "F" : "";
                                Fest = (D12 == "7") ? F12 = "F" : "";
                                Fest = (D13 == "7") ? F13 = "F" : "";
                                break;

                            case 8:
                                //SEMANA 2
                                Fest = (D8 == "8") ? F8 = "F" : "";
                                Fest = (D9 == "8") ? F9 = "F" : "";
                                Fest = (D10 == "8") ? F10 = "F" : "";
                                Fest = (D11 == "8") ? F11 = "F" : "";
                                Fest = (D12 == "8") ? F12 = "F" : "";
                                Fest = (D13 == "8") ? F13 = "F" : "";
                                Fest = (D14 == "8") ? F14 = "F" : "";
                                break;
                            case 9:
                                //SEMANA 2
                                Fest = (D9 == "9") ? F9 = "F" : "";
                                Fest = (D10 == "9") ? F10 = "F" : "";
                                Fest = (D11 == "9") ? F11 = "F" : "";
                                Fest = (D12 == "9") ? F12 = "F" : "";
                                Fest = (D13 == "9") ? F13 = "F" : "";
                                Fest = (D14 == "9") ? F14 = "F" : "";
                                //SEMANA 3
                                Fest = (D15 == "9") ? F15 = "F" : "";
                                break;
                            case 10:
                                //SEMANA 2
                                Fest = (D10 == "10") ? F10 = "F" : "";
                                Fest = (D11 == "10") ? F11 = "F" : "";
                                Fest = (D12 == "10") ? F12 = "F" : "";
                                Fest = (D13 == "10") ? F13 = "F" : "";
                                Fest = (D14 == "10") ? F14 = "F" : "";
                                //SEMANA 3
                                Fest = (D15 == "10") ? F15 = "F" : "";
                                Fest = (D16 == "10") ? F16 = "F" : "";
                                break;
                            case 11:
                                //SEMANA 2
                                Fest = (D11 == "11") ? F11 = "F" : "";
                                Fest = (D12 == "11") ? F12 = "F" : "";
                                Fest = (D13 == "11") ? F13 = "F" : "";
                                Fest = (D14 == "11") ? F14 = "F" : "";
                                //SEMANA 3
                                Fest = (D15 == "11") ? F15 = "F" : "";
                                Fest = (D16 == "11") ? F16 = "F" : "";
                                Fest = (D17 == "11") ? F17 = "F" : "";
                                break;
                            case 12:
                                //SEMANA 2
                                Fest = (D12 == "12") ? F12 = "F" : "";
                                Fest = (D13 == "12") ? F13 = "F" : "";
                                Fest = (D14 == "12") ? F14 = "F" : "";
                                //SEMANA 3
                                Fest = (D15 == "12") ? F15 = "F" : "";
                                Fest = (D16 == "12") ? F16 = "F" : "";
                                Fest = (D17 == "12") ? F17 = "F" : "";
                                Fest = (D18 == "12") ? F18 = "F" : "";
                                break;
                            case 13:
                                //SEMANA 2
                                Fest = (D13 == "13") ? F13 = "F" : "";
                                Fest = (D14 == "13") ? F14 = "F" : "";
                                //SEMANA 3
                                Fest = (D15 == "13") ? F15 = "F" : "";
                                Fest = (D16 == "13") ? F16 = "F" : "";
                                Fest = (D17 == "13") ? F17 = "F" : "";
                                Fest = (D18 == "13") ? F18 = "F" : "";
                                Fest = (D19 == "13") ? F19 = "F" : "";
                                break;
                            case 14:
                                //SEMANA 2
                                Fest = (D14 == "14") ? F14 = "F" : "";
                                //SEMANA 3
                                Fest = (D15 == "14") ? F15 = "F" : "";
                                Fest = (D16 == "14") ? F16 = "F" : "";
                                Fest = (D17 == "14") ? F17 = "F" : "";
                                Fest = (D18 == "14") ? F18 = "F" : "";
                                Fest = (D19 == "14") ? F19 = "F" : "";
                                Fest = (D20 == "14") ? F20 = "F" : "";
                                break;

                            case 15:
                                //SEMANA 3
                                Fest = (D15 == "15") ? F15 = "F" : "";
                                Fest = (D16 == "15") ? F16 = "F" : "";
                                Fest = (D17 == "15") ? F17 = "F" : "";
                                Fest = (D18 == "15") ? F18 = "F" : "";
                                Fest = (D19 == "15") ? F19 = "F" : "";
                                Fest = (D20 == "15") ? F20 = "F" : "";
                                Fest = (D21 == "15") ? F21 = "F" : "";
                                break;
                            case 16:
                                //SEMANA 3
                                Fest = (D16 == "16") ? F16 = "F" : "";
                                Fest = (D17 == "16") ? F17 = "F" : "";
                                Fest = (D18 == "16") ? F18 = "F" : "";
                                Fest = (D19 == "16") ? F19 = "F" : "";
                                Fest = (D20 == "16") ? F20 = "F" : "";
                                Fest = (D21 == "16") ? F21 = "F" : "";
                                //SEMANA 4
                                Fest = (D22 == "16") ? F22 = "F" : "";
                                break;
                            case 17:
                                //SEMANA 3
                                Fest = (D17 == "17") ? F17 = "F" : "";
                                Fest = (D18 == "17") ? F18 = "F" : "";
                                Fest = (D19 == "17") ? F19 = "F" : "";
                                Fest = (D20 == "17") ? F20 = "F" : "";
                                Fest = (D21 == "17") ? F21 = "F" : "";
                                //SEMANA 4
                                Fest = (D22 == "17") ? F22 = "F" : "";
                                Fest = (D23 == "17") ? F23 = "F" : "";
                                break;
                            case 18:
                                //SEMANA 3
                                Fest = (D18 == "18") ? F18 = "F" : "";
                                Fest = (D19 == "18") ? F19 = "F" : "";
                                Fest = (D20 == "18") ? F20 = "F" : "";
                                Fest = (D21 == "18") ? F21 = "F" : "";
                                //SEMANA 4
                                Fest = (D22 == "18") ? F22 = "F" : "";
                                Fest = (D23 == "18") ? F23 = "F" : "";
                                Fest = (D24 == "18") ? F24 = "F" : "";
                                break;
                            case 19:
                                //SEMANA 3
                                Fest = (D19 == "19") ? F19 = "F" : "";
                                Fest = (D20 == "19") ? F20 = "F" : "";
                                Fest = (D21 == "19") ? F21 = "F" : "";
                                //SEMANA 4
                                Fest = (D22 == "19") ? F22 = "F" : "";
                                Fest = (D23 == "19") ? F23 = "F" : "";
                                Fest = (D24 == "19") ? F24 = "F" : "";
                                Fest = (D25 == "19") ? F25 = "F" : "";
                                break;
                            case 20:
                                //SEMANA 3
                                Fest = (D20 == "20") ? F20 = "F" : "";
                                Fest = (D21 == "20") ? F21 = "F" : "";
                                //SEMANA 4
                                Fest = (D22 == "20") ? F22 = "F" : "";
                                Fest = (D23 == "20") ? F23 = "F" : "";
                                Fest = (D24 == "20") ? F24 = "F" : "";
                                Fest = (D25 == "20") ? F25 = "F" : "";
                                Fest = (D26 == "20") ? F26 = "F" : "";
                                break;
                            case 21:
                                //SEMANA 3
                                Fest = (D21 == "21") ? F21 = "F" : "";
                                //SEMANA 4
                                Fest = (D22 == "21") ? F22 = "F" : "";
                                Fest = (D23 == "21") ? F23 = "F" : "";
                                Fest = (D24 == "21") ? F24 = "F" : "";
                                Fest = (D25 == "21") ? F25 = "F" : "";
                                Fest = (D26 == "21") ? F26 = "F" : "";
                                Fest = (D27 == "21") ? F27 = "F" : "";
                                break;

                            case 22:
                                //SEMANA 4
                                Fest = (D22 == "22") ? F22 = "F" : "";
                                Fest = (D23 == "22") ? F23 = "F" : "";
                                Fest = (D24 == "22") ? F24 = "F" : "";
                                Fest = (D25 == "22") ? F25 = "F" : "";
                                Fest = (D26 == "22") ? F26 = "F" : "";
                                Fest = (D27 == "22") ? F27 = "F" : "";
                                Fest = (D28 == "22") ? F28 = "F" : "";
                                break;
                            case 23:
                                //SEMANA 4
                                Fest = (D23 == "23") ? F23 = "F" : "";
                                Fest = (D24 == "23") ? F24 = "F" : "";
                                Fest = (D25 == "23") ? F25 = "F" : "";
                                Fest = (D26 == "23") ? F26 = "F" : "";
                                Fest = (D27 == "23") ? F27 = "F" : "";
                                Fest = (D28 == "23") ? F28 = "F" : "";
                                //SEMANA 5
                                Fest = (D29 == "23") ? F29 = "F" : "";
                                break;
                            case 24:
                                //SEMANA 4
                                Fest = (D24 == "24") ? F24 = "F" : "";
                                Fest = (D25 == "24") ? F25 = "F" : "";
                                Fest = (D26 == "24") ? F26 = "F" : "";
                                Fest = (D27 == "24") ? F27 = "F" : "";
                                Fest = (D28 == "24") ? F28 = "F" : "";
                                //SEMANA 5
                                Fest = (D29 == "24") ? F29 = "F" : "";
                                Fest = (D30 == "24") ? F30 = "F" : "";
                                break;
                            case 25:
                                //SEMANA 4
                                Fest = (D25 == "25") ? F25 = "F" : "";
                                Fest = (D26 == "25") ? F26 = "F" : "";
                                Fest = (D27 == "25") ? F27 = "F" : "";
                                Fest = (D28 == "25") ? F28 = "F" : "";
                                //SEMANA 5
                                Fest = (D29 == "25") ? F29 = "F" : "";
                                Fest = (D30 == "25") ? F30 = "F" : "";
                                Fest = (D31 == "25") ? F31 = "F" : "";
                                break;
                            case 26:
                                //SEMANA 4
                                Fest = (D26 == "26") ? F26 = "F" : "";
                                Fest = (D27 == "26") ? F27 = "F" : "";
                                Fest = (D28 == "26") ? F28 = "F" : "";
                                //SEMANA 5
                                Fest = (D29 == "26") ? F29 = "F" : "";
                                Fest = (D30 == "26") ? F30 = "F" : "";
                                Fest = (D31 == "26") ? F31 = "F" : "";
                                Fest = (D32 == "26") ? F32 = "F" : "";
                                break;
                            case 27:
                                //SEMANA 4
                                Fest = (D27 == "27") ? F27 = "F" : "";
                                Fest = (D28 == "27") ? F28 = "F" : "";
                                //SEMANA 5
                                Fest = (D29 == "27") ? F29 = "F" : "";
                                Fest = (D30 == "27") ? F30 = "F" : "";
                                Fest = (D31 == "27") ? F31 = "F" : "";
                                Fest = (D32 == "27") ? F32 = "F" : "";
                                Fest = (D33 == "27") ? F33 = "F" : "";
                                break;
                            case 28:
                                //SEMANA 4
                                Fest = (D28 == "28") ? F28 = "F" : "";
                                //SEMANA 5
                                Fest = (D29 == "28") ? F29 = "F" : "";
                                Fest = (D30 == "28") ? F30 = "F" : "";
                                Fest = (D31 == "28") ? F31 = "F" : "";
                                Fest = (D32 == "28") ? F32 = "F" : "";
                                Fest = (D33 == "28") ? F33 = "F" : "";
                                Fest = (D33 == "28") ? F33 = "F" : "";
                                Fest = (D34 == "28") ? F34 = "F" : "";
                                break;

                            case 29:
                                //SEMANA 5
                                Fest = (D29 == "29") ? F29 = "F" : "";
                                Fest = (D30 == "29") ? F30 = "F" : "";
                                Fest = (D31 == "29") ? F31 = "F" : "";
                                Fest = (D32 == "29") ? F32 = "F" : "";
                                Fest = (D33 == "29") ? F33 = "F" : "";
                                Fest = (D33 == "29") ? F33 = "F" : "";
                                Fest = (D34 == "29") ? F34 = "F" : "";
                                //SEMANA 6
                                Fest = (D35 == "29") ? F35 = "F" : "";
                                break;
                            case 30:
                                //SEMANA 5
                                Fest = (D30 == "30") ? F30 = "F" : "";
                                Fest = (D31 == "30") ? F31 = "F" : "";
                                Fest = (D32 == "30") ? F32 = "F" : "";
                                Fest = (D33 == "30") ? F33 = "F" : "";
                                Fest = (D33 == "30") ? F33 = "F" : "";
                                Fest = (D34 == "30") ? F34 = "F" : "";
                                //SEMANA 6
                                Fest = (D35 == "30") ? F35 = "F" : "";
                                Fest = (D36 == "30") ? F36 = "F" : "";
                                break;
                            case 31:
                                //SEMANA 5
                                Fest = (D31 == "31") ? F31 = "F" : "";
                                Fest = (D32 == "31") ? F32 = "F" : "";
                                Fest = (D33 == "31") ? F33 = "F" : "";
                                Fest = (D33 == "31") ? F33 = "F" : "";
                                Fest = (D34 == "31") ? F34 = "F" : "";
                                //SEMANA 6
                                Fest = (D35 == "31") ? F35 = "F" : "";
                                Fest = (D36 == "31") ? F36 = "F" : "";
                                Fest = (D37 == "31") ? F37 = "F" : "";
                                break;                            
                        }
                    }
                }

                //int indice = Festivos.FindIndex(x => x.holiday == FTemp);               

                Contador = Contador + 1;
            }            
        }
    }
}
