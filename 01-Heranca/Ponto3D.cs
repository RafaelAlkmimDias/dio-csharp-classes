namespace Classes.Heranca
{
    public class Ponto3D : Ponto
    {
        public int z;

        public Ponto3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
            CalcularDistancia();
        }

        public static void Calcular()
        {
            //faz alguma coisa
        }

        public override void CalcularDistancia3()
        {
            //faz outra coisa
            base.CalcularDistancia3();
            // forma de chamar função da classe pai
        }
    }
}