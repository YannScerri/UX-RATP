using Interface_RATP.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_RATP.Models
{
    public class RatpModel
    {
        public RatpController Controller { get; set; }

        private const int ADULTPRICE = 5;
        private const int REDUCEDPRICE = 2;

        private const int DISNEYADULTPRICE = 20;
        private const int DISNEYREDUCEDPRICE = 10;

        private const int PARIS1ADULTPRICE = 15;
        private const int PARIS1REDUCEDPRICE = 30;
        private const int PARIS3ADULTPRICE = 30;
        private const int PARIS3REDUCEDPRICE = 25;
        private const int PARIS5ADULTPRICE = 60;
        private const int PARIS5REDUCEDPRICE = 55;

        private const int AIRPORTADULTPRICE = 10;
        private const int AIRPORTREDUCEDPRICE = 5;

        public int AdultPrice
        {
            get { return ADULTPRICE; }
        }

        public int ReducedPrice
        {
            get { return REDUCEDPRICE; }
        }

        public int DisneyAdultPrice
        {
            get { return DISNEYADULTPRICE; }
        }

        public int DisneyReducedPrice
        {
            get { return DISNEYREDUCEDPRICE; }
        }

        public int Paris1AdultPrice
        {
            get { return PARIS1ADULTPRICE; }
        }

        public int Paris1ReducedPrice
        {
            get { return PARIS1REDUCEDPRICE; }
        }

        public int Paris3AdultPrice
        {
            get { return PARIS3ADULTPRICE; }
        }

        public int Paris3Reducedprice
        {
            get { return PARIS3REDUCEDPRICE;}
        }

        public int Paris5Adult
        {
            get { return PARIS5ADULTPRICE;}
        }

        public int Paris5ReducedPrice
        {
            get { return PARIS5REDUCEDPRICE;}
        }

        public int AirportAdultPrice
        {
            get { return AIRPORTADULTPRICE; }
        }

        public int AirportReducedPrice
        {
            get { return AIRPORTREDUCEDPRICE;}
            
        }
    }
}
