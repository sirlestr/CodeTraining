﻿using static System.Net.Mime.MediaTypeNames;

namespace OnlineApp
{
     class Zaznam
    {
        public DateTime DatumCas { get; set; }
        public string Text { get; set; }
        public Zaznam(DateTime datumCas, string text)
        {
            DatumCas = datumCas;
            Text = text;

        }


        public override string ToString()
        {
            return DatumCas + " " + Text;
        }
    }

  
}
