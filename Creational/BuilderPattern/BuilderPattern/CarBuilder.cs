namespace BuilderPattern
{
    public class CarBuilder : ICarBuilder
    {
        readonly Car _car = new Car();

        public ICarBuilder SetSeats(int numSeats)
        {
            _car.NumSeats = numSeats;
            return this;
        }

        public ICarBuilder SetEngineType(CarEngineType engine)
        {
            _car.Engine = engine;
            return this;
        }

        public ICar CreateCar()
        {
            return _car;
        }
    }
}
