using System;

class Program
{
    public static void Main(string[] args)
    {
        CovidConfig covidConfig = new CovidConfig();
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Berapa suhu badan anda saat ini? Dalam nilai " + covidConfig.config.satuan_suhu);
            double inputSuhu = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam?");
            int inputHariDemam = Convert.ToInt32(Console.ReadLine());

            if (covidConfig.config.satuan_suhu == "celcius")
            {
                if (36.5 <= inputSuhu && inputSuhu <= 37.5 && inputHariDemam < covidConfig.config.batas_hari_demam)
                {
                    Console.WriteLine(covidConfig.config.pesan_diterima);
                }
                else
                {
                    Console.WriteLine(covidConfig.config.pesan_ditolak);
                }
            }
            else if (covidConfig.config.satuan_suhu == "fahrenheit")
            {
                if (97.7 <= inputSuhu && inputSuhu <= 99.5 && inputHariDemam < covidConfig.config.batas_hari_demam)
                {
                    Console.WriteLine(covidConfig.config.pesan_diterima);
                }
                else
                {
                    Console.WriteLine(covidConfig.config.pesan_ditolak);
                }
            }

            Console.WriteLine();
            covidConfig.UbahSatuan();
        }
    }
}