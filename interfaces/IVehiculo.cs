

namespace MyFirstApp.Interfaces
{
    interface IVehiculo // solo te permiten crear firmmas, sin implemtacion 
    {
        void Acelerar(int kmh);// declarar la firma de los metodos 
        void Frenan();
        void Girar(int angulos);
        void Despegar();
        void Aterrizar();
    }
}
