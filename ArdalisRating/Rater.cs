using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating
{
    public abstract class Rater
    {
        protected readonly RatingEngine _ratingEngine;
        protected readonly ConsoleLogger _logger;

        public Rater(RatingEngine engine, ConsoleLogger logger)
        {
            _ratingEngine = engine;
            _logger = logger;
        }

        public abstract void Rate(Policy policy);
    }
}
