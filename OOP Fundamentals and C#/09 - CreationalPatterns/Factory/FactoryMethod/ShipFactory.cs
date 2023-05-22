﻿namespace Factory.FactoryMethod
{
    public class ShipCreator : TransportCreator
    {
        public override ITransport CreateTransport(float capacity, string name)
        {
            var ship = new Ship
            {
                Capacity = capacity,
                Name = name
            };

            _counter++;

            return ship;
        }
    }
}
