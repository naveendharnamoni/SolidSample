using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating
{
    public class AutoPolicyRater : Rater
    {
        public AutoPolicyRater(RatingEngine ratingEngine, ConsoleLogger logger) : base(ratingEngine, logger)
        {
        }

        public override void Rate(Policy policy)
        {
            _logger.Log("Rating AUTO policy...");
            _logger.Log("Validating policy.");
            if (String.IsNullOrEmpty(policy.Make))
            {
                _logger.Log("Auto policy must specify Make");
                return;
            }
            if (policy.Make == "BMW")
            {
                if (policy.Deductible < 500)
                {
                    _ratingEngine.Rating = 1000m;
                }
                _ratingEngine.Rating = 900m;
            }
        }
    }
}
