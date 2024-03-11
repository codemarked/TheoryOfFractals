
namespace FractalTheory
{
    public class Cplx
    {
        public double Re, Im;

        Cplx(double Re, double Im) {
            this.Re = Re;
            this.Im = Im;
        }

        Cplx() { }

        public Cplx Copy()
        {
            return Cplx.of(this.Re, this.Im);
        }

        public static Cplx of(double Re, double Im)
        {
            return new Cplx(Re, Im);
        }

        public static Cplx of()
        {
            return new Cplx();
        }

        public override string ToString()
        {
            return (this.Re != 0 ? this.Re + " " : "") + (this.Im < 0 ? "- i" : "+ i");
        }

        public Cplx Conj()
        {
            return Cplx.of(this.Re, -this.Im);
        }

        public double Norm()
        {
            return Math.Sqrt(this.Re * this.Re + this.Im * this.Im);
        }

        public static Cplx operator +(Cplx z1, Cplx z2)
        {
            return Cplx.of(z1.Re + z2.Re, z1.Im + z2.Im);
        }

        public static Cplx operator -(Cplx z1, Cplx z2)
        {
            return Cplx.of(z1.Re - z2.Re, z1.Im - z2.Im);
        }

        public static Cplx operator *(Cplx z1, Cplx z2)
        {
            return Cplx.of(z1.Re * z2.Re - z1.Im * z2.Im, z1.Re * z2.Im + z1.Im * z2.Re);
        }

        public static Cplx operator /(Cplx z1, Cplx z2)
        {
            Cplx cZ2 = z2.Conj();
            Cplx up = z1 * cZ2;
            Cplx down = z2 * cZ2;
            return Cplx.of(up.Re / down.Re, up.Im / down.Re);
        }
    }
}
