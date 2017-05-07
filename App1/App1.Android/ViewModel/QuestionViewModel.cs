using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App1.Droid.ViewModel
{
    public class QuestionViewModel
    {
        public QuestionViewModel()
        { }

        public string id { get; set; }
        public string Question { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public int CorrectAnswer { get; set; }
    }

    public class XamarinQuiz
    {
        public string id { get; set; }
        public string Question { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public int CorrectAnswer { get; set; }

        //Is loading: propiedad para carga de datos asincronico.

        //propertychange: actualiza los datos ej calculo de promedio cuando agrego una nueva nota.

        // gh/garudaslap/xamarinquiz
    }

}