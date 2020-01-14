using System;

namespace acoBoletos
{
    class Program
    {
        static void Main(string[] args)
        {
            SacadoEndereco s1 = new SacadoEndereco(
                "null",
                50,
                "Jd. das pitangas",
                "Guarulhos",
                UnidadeFederativa.SP,
                "07245-056");

            Sacado paulo = new Sacado("Paulo","3710780284466",s1);



        }
    }
}
