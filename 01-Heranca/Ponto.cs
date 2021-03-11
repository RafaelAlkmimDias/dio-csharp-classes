namespace Classes.Heranca
{
    public class Ponto
    {
        public int x, y;

        private int distancia;

        public Ponto(int x, int y){
            this.x = x;
            this.y = y;
        }

        protected void CalcularDistancia()
        {
            // chamado internamente e por herança
            //Faz alguma coisa
        }

        private void CalcularDistancia2()
        {
            //chamado apenas internamente
            //Faz alguma coisa
        }

        public virtual void CalcularDistancia3()
        {
            // chamado externamente
            // o virtual permite que essa função seja subescrita usando o override
            //Faz alguma coisa
        }
    }
}