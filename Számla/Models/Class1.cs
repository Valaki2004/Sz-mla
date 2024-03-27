using System.ComponentModel.DataAnnotations;

namespace Számla.Models
{
    public class Class1
    {
        [Key]
        public string nev { get; set; }
        public int kor { get; set; }
        public string varos { get; set; }
        public string munka { get; set; }
        public int bevetel { get; set; }

        public Class1(){ }

        public Class1(string sor)
        {
            string[] s = sor.Split(';');

            nev = s[0];
            kor = Convert.ToInt32(s[1]);
            varos = s[2];
            munka = s[3];
            bevetel = Convert.ToInt32(s[4]); 
        }
        public override string? ToString()
        {
            return $" Ügyfél neve {nev} a kora {kor} a hely ahol lakik {varos} és {munka} munkát végez valamint a bevétele pedig {bevetel} zsé";
        }
    }
}