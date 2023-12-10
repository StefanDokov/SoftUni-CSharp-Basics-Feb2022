namespace Railway.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Tests
    {
        private RailwayStation station;
        string name = "South";
        string train = "JOJO";
        [SetUp]
        public void Setup()
        {
            station = new RailwayStation(name);
        }

        [Test]
        public void Test_IsNameWorking_Correctly()
        {
            Assert.AreEqual(name, station.Name);
            Assert.AreEqual(0, station.DepartureTrains.Count());
            Assert.AreEqual(0, station.ArrivalTrains.Count());
        }

        [Test]
        public void Test_IsNameWorking_NotCorrectly()
        {
            Assert.Throws<ArgumentException>(() => new RailwayStation(""));
            Assert.Throws<ArgumentException>(() => new RailwayStation(" "));
            Assert.Throws<ArgumentException>(() => new RailwayStation(null));
        }

        [Test]
        public void Test_NewTrain_Correctly()
        {
            station.NewArrivalOnBoard(train);

            Assert.AreEqual(1, station.ArrivalTrains.Count);
            Assert.AreEqual(train, station.ArrivalTrains.Peek());

            station.NewArrivalOnBoard(train); 
            station.NewArrivalOnBoard(train);

            Assert.AreEqual(3, station.ArrivalTrains.Count);


        }

        [Test]
        public void Test_TrainArrive_Correctly()
        {
            station.NewArrivalOnBoard("Six");
            station.NewArrivalOnBoard("Seven");
            station.NewArrivalOnBoard("two");
            station.NewArrivalOnBoard(train);

            string result = station.TrainHasArrived(train);

            Assert.AreEqual($"There are other trains to arrive before {train}.", result);

            station.TrainHasArrived("Six");
            station.TrainHasArrived("Seven");
            station.TrainHasArrived("two");
            Assert.AreEqual(train, station.ArrivalTrains.Peek()); 
        }

        [Test]
        public void Test_TrainArrive_InCorrectly()
        {
            station.NewArrivalOnBoard(train);;
            string result = station.TrainHasArrived(train);

            Assert.AreEqual(1, station.DepartureTrains.Count());
            Assert.AreEqual($"{train} is on the platform and will leave in 5 minutes.", result);
            Assert.AreEqual(0, station.ArrivalTrains.Count());
            Assert.AreEqual(train, station.DepartureTrains.Peek());


        }

        [Test]
        public void Test_TrainHasLeft_Correctly()
        {
            station.NewArrivalOnBoard(train); ;
            station.TrainHasArrived(train);
            bool result = station.TrainHasLeft(train);

            Assert.AreEqual(true, result);
            Assert.IsEmpty(station.DepartureTrains);

        }

        [Test]
        public void Test_TrainHasLeft_InCorrectly()
        {
            station.NewArrivalOnBoard("Six");
            station.NewArrivalOnBoard("Seven");
            station.NewArrivalOnBoard("two");
            station.TrainHasArrived("Six");
            station.TrainHasArrived("Seven");
            bool result = station.TrainHasLeft(train);

            Assert.AreEqual(false, result);


        }
    }
}