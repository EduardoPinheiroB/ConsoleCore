using GameTop.Interface;

namespace GameTOP.lib
{ 
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "maradona estas pateando \n";
        }

        public string Corre()
        {
            return "maradona estas corriendo \n";
        }

        public string Passe()
        {
            return "maradona estas pasando \n";
        }
    }
}